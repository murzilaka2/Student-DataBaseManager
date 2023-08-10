using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataBaseManager
{
    public partial class DataBaseManager : Form
    {
        private DataBase DataBaseGlobal { get; set; }
        int borderSize = 2;
        internal DataBaseManager(DataBase DataBaseGlobal)
        {
            InitializeComponent();
            Presets();
            this.DataBaseGlobal = DataBaseGlobal;
        }
        private void DataBaseManager_Load(object sender, EventArgs e)
        {
            LoadDatabases();
            ReloadTableData.Enabled = false;
            EditTableData.Enabled = false;
        }
        void Presets()
        {
            this.MinimumSize = new Size(800, 470);
            Components.Fonts fonts = new Components.Fonts();
            HeaderPanel.BackColor = Color.FromArgb(51, 153, 204);
            FooterPanel.BackColor = Color.FromArgb(51, 153, 204);
            FooterPanel.Font = new Font(fonts.OverpassReg, 9);
            LogoLabel.Font = new Font(fonts.OverpassReg, 24);
        }
        void LoadDatabases()
        {
            Task task = Task.Run(() =>
            {
                List<string> names = DataBaseGlobal.GetDatabaseNames();
                this.Invoke(new EventHandler(delegate
                {
                    DatabasesComboBox.DataSource = names;
                }));
            });
        }
        private void DataBaseManager_Resize(object sender, EventArgs e)
        {
            AdjustForm();
        }
        private void AdjustForm()
        {
            switch (this.WindowState)
            {
                case FormWindowState.Maximized: //Maximized form (After)
                    this.Padding = new Padding(8, 8, 8, 0);
                    break;
                case FormWindowState.Normal: //Restored form (After)
                    if (this.Padding.Top != borderSize)
                        this.Padding = new Padding(borderSize);
                    break;
            }
        }
        private void MinimizeButtonManager_Click(object sender, EventArgs e)
        {
            this.WindowState = WindowState == FormWindowState.Normal ? FormWindowState.Maximized : FormWindowState.Normal;
            //if (this.WindowState == FormWindowState.Normal)
            //{
            //    this.Size = new Size(687, 607);
            //    this.StartPosition = FormStartPosition.CenterScreen;
            //}
        }
        private void CloseButtonManager_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void HideButtonManager_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        private void HeaderPanel_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
        //Премещение формы
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        private void TitlePanel_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
        //Убираем рамку формы && Позволяет изменять размеры формы вручную
        protected override void WndProc(ref Message m)
        {
            const int WM_NCCALCSIZE = 0x0083;//Standar Title Bar - Snap Window
            const int WM_SYSCOMMAND = 0x0112;
            const int SC_MINIMIZE = 0xF020; //Minimize form (Before)
            const int SC_RESTORE = 0xF120; //Restore form (Before)
            const int WM_NCHITTEST = 0x0084;//Win32, Mouse Input Notification: Determine what part of the window corresponds to a point, allows to resize the form.
            const int resizeAreaSize = 10;
            #region Form Resize
            // Resize/WM_NCHITTEST values
            const int HTCLIENT = 1; //Represents the client area of the window
            const int HTLEFT = 10;  //Left border of a window, allows resize horizontally to the left
            const int HTRIGHT = 11; //Right border of a window, allows resize horizontally to the right
            const int HTTOP = 12;   //Upper-horizontal border of a window, allows resize vertically up
            const int HTTOPLEFT = 13;//Upper-left corner of a window border, allows resize diagonally to the left
            const int HTTOPRIGHT = 14;//Upper-right corner of a window border, allows resize diagonally to the right
            const int HTBOTTOM = 15; //Lower-horizontal border of a window, allows resize vertically down
            const int HTBOTTOMLEFT = 16;//Lower-left corner of a window border, allows resize diagonally to the left
            const int HTBOTTOMRIGHT = 17;//Lower-right corner of a window border, allows resize diagonally to the right
            ///<Doc> More Information: https://docs.microsoft.com/en-us/windows/win32/inputdev/wm-nchittest </Doc>
            if (m.Msg == WM_NCHITTEST)
            { //If the windows m is WM_NCHITTEST
                base.WndProc(ref m);
                if (this.WindowState == FormWindowState.Normal)//Resize the form if it is in normal state
                {
                    if ((int)m.Result == HTCLIENT)//If the result of the m (mouse pointer) is in the client area of the window
                    {
                        Point screenPoint = new Point(m.LParam.ToInt32()); //Gets screen point coordinates(X and Y coordinate of the pointer)                           
                        Point clientPoint = this.PointToClient(screenPoint); //Computes the location of the screen point into client coordinates                          
                        if (clientPoint.Y <= resizeAreaSize)//If the pointer is at the top of the form (within the resize area- X coordinate)
                        {
                            if (clientPoint.X <= resizeAreaSize) //If the pointer is at the coordinate X=0 or less than the resizing area(X=10) in 
                                m.Result = (IntPtr)HTTOPLEFT; //Resize diagonally to the left
                            else if (clientPoint.X < (this.Size.Width - resizeAreaSize))//If the pointer is at the coordinate X=11 or less than the width of the form(X=Form.Width-resizeArea)
                                m.Result = (IntPtr)HTTOP; //Resize vertically up
                            else //Resize diagonally to the right
                                m.Result = (IntPtr)HTTOPRIGHT;
                        }
                        else if (clientPoint.Y <= (this.Size.Height - resizeAreaSize)) //If the pointer is inside the form at the Y coordinate(discounting the resize area size)
                        {
                            if (clientPoint.X <= resizeAreaSize)//Resize horizontally to the left
                                m.Result = (IntPtr)HTLEFT;
                            else if (clientPoint.X > (this.Width - resizeAreaSize))//Resize horizontally to the right
                                m.Result = (IntPtr)HTRIGHT;
                        }
                        else
                        {
                            if (clientPoint.X <= resizeAreaSize)//Resize diagonally to the left
                                m.Result = (IntPtr)HTBOTTOMLEFT;
                            else if (clientPoint.X < (this.Size.Width - resizeAreaSize)) //Resize vertically down
                                m.Result = (IntPtr)HTBOTTOM;
                            else //Resize diagonally to the right
                                m.Result = (IntPtr)HTBOTTOMRIGHT;
                        }
                    }
                }
                return;
            }
            #endregion
            //Remove border and keep snap window
            if (m.Msg == WM_NCCALCSIZE && m.WParam.ToInt32() == 1)
            {
                return;
            }
            base.WndProc(ref m);
        }

        //DATABASE WORKS AREA
        string dataBaseName, tableName;
        private void GetDataBaseButton_Click(object sender, EventArgs e)
        {
            if (DatabasesComboBox.SelectedItem is not null)
            {
                dataBaseName = DatabasesComboBox.SelectedItem.ToString()!;
                Task task = Task.Run(() =>
                {
                    List<string> tableName = DataBaseGlobal.GetTableNames(dataBaseName!);
                    if (tableName is not null)
                    {
                        this.Invoke(new EventHandler(delegate
                        {
                            TabelsComboBox.DataSource = tableName;
                        }));
                    }
                });
            }
            CurrentDbLabel.Text = $"Selected DataBase: [{dataBaseName}]";
            ReloadTableData.Enabled = true;
        }
        private void ReloadTableData_Click(object sender, EventArgs e)
        {
            PostloadsSets();
            Task task = Task.Run(() =>
            {
                DataBaseGlobal.GetTableContent(dataBaseName!, tableName!);
                if (DataBaseGlobal.sTable is not null)
                {
                    this.Invoke(new EventHandler(delegate
                    {
                        TableGridView.DataSource = DataBaseGlobal.sDs.Tables[$"[{tableName}]"];
                    }));
                }
            });
        }
        private void EditTableData_Click(object sender, EventArgs e)
        {
            PreloadsSets();
        }
        void PreloadsSets()
        {
            TableGridView.ReadOnly = false;
            EditTableData.Enabled = false;
            SaveTableData.Enabled = true;
        }
        void PostloadsSets()
        {
            TableGridView.ReadOnly = true;
            EditTableData.Enabled = true;
            SaveTableData.Enabled = false;
        }
        private void SaveTableData_Click(object sender, EventArgs e)
        {
            PostloadsSets();
            try
            {
                Task task = Task.Run(() =>
                {
                    DataBaseGlobal.sAdapter.Update(DataBaseGlobal.sTable);
                });
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void WriteSqlCommand_Click(object sender, EventArgs e)
        {
            SqlCommandPanel.Visible = !SqlCommandPanel.Visible;
        }
        private void CloseSqlPanelButton_Click(object sender, EventArgs e)
        {
            SqlCommandPanel.Visible = false;
        }
        const int minSqlTableSize = 128, maxSqlTableSize = 278;
        private void MakeBiggerSqlPanelButton_Click(object sender, EventArgs e)
        {
            if (SqlCommandPanel.Height + 50 <= maxSqlTableSize)
            {
                SqlCommandPanel.Height += 50;
                SqlTextBox.Height += 50;
            }
        }
        private void ExcecuteSqlButton_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(SqlTextBox.Text))
            {
                string sql = SqlTextBox.Text;
                try
                {
                    DataBaseGlobal.ExecuteSqlQuery(sql, out int countRowAffected);
                    MessageBox.Show($"({countRowAffected} row affected)");

                    Task task = Task.Run(() =>
                    {
                        DataBaseGlobal.GetTableContent(dataBaseName!, tableName!);
                        if (DataBaseGlobal.sTable is not null)
                        {
                            this.Invoke(new EventHandler(delegate
                            {
                                TableGridView.DataSource = DataBaseGlobal.sDs.Tables[$"[{tableName}]"];
                            }));
                        }
                    });
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (DataBaseGlobal.sTable is not null)
            {
                if (MessageBox.Show("Do you want to delete this row ?", "Delete (Selected all Row to delete!)", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    try
                    {
                        foreach (DataGridViewRow row in TableGridView.SelectedRows)
                        {
                            TableGridView.Rows.RemoveAt(row.Index);
                        }
                        DataBaseGlobal.sAdapter.Update(DataBaseGlobal.sTable);
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                }
            }
        }
        private void MakeSmallerSqlPanelButton_Click(object sender, EventArgs e)
        {
            if (SqlCommandPanel.Height - 50 >= minSqlTableSize)
            {
                SqlCommandPanel.Height -= 50;
                SqlTextBox.Height -= 50;
            }
        }

        private void TabelsComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            PostloadsSets();
            if (TabelsComboBox.SelectedItem is not null)
            {
                tableName = TabelsComboBox.SelectedItem.ToString()!;
                Task task = Task.Run(() =>
                {
                    DataBaseGlobal.GetTableContent(dataBaseName!, tableName!);
                    if (DataBaseGlobal.sTable is not null)
                    {
                        this.Invoke(new EventHandler(delegate
                        {
                            TableGridView.DataSource = DataBaseGlobal.sDs.Tables[$"[{tableName}]"];
                        }));
                    }
                });
            }
        }
    }
}
