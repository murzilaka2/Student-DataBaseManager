namespace DataBaseManager
{
    partial class DataBaseManager
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.iconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            this.LogoLabel = new System.Windows.Forms.Label();
            this.HideButton = new FontAwesome.Sharp.IconButton();
            this.MinimizeButton = new FontAwesome.Sharp.IconButton();
            this.CloseButton = new FontAwesome.Sharp.IconButton();
            this.HeaderPanel = new System.Windows.Forms.Panel();
            this.HideButtonManager = new FontAwesome.Sharp.IconButton();
            this.MinimizeButtonManager = new FontAwesome.Sharp.IconButton();
            this.CloseButtonManager = new FontAwesome.Sharp.IconButton();
            this.FooterLabel = new System.Windows.Forms.Label();
            this.ToolsPanel = new System.Windows.Forms.Panel();
            this.WriteSqlCommand = new FontAwesome.Sharp.IconButton();
            this.ReloadTableData = new FontAwesome.Sharp.IconButton();
            this.SaveTableData = new FontAwesome.Sharp.IconButton();
            this.EditTableData = new FontAwesome.Sharp.IconButton();
            this.TabelsComboBox = new System.Windows.Forms.ComboBox();
            this.GetDataBaseButton = new FontAwesome.Sharp.IconButton();
            this.DatabasesComboBox = new System.Windows.Forms.ComboBox();
            this.FooterPanel = new System.Windows.Forms.Panel();
            this.DesktopPanel = new System.Windows.Forms.Panel();
            this.SqlCommandPanel = new System.Windows.Forms.Panel();
            this.CurrentDbLabel = new System.Windows.Forms.Label();
            this.MakeSmallerSqlPanelButton = new System.Windows.Forms.Button();
            this.MakeBiggerSqlPanelButton = new System.Windows.Forms.Button();
            this.ExcecuteSqlButton = new FontAwesome.Sharp.IconButton();
            this.CloseSqlPanelButton = new System.Windows.Forms.Button();
            this.SqlTextBox = new System.Windows.Forms.TextBox();
            this.TableGridView = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).BeginInit();
            this.HeaderPanel.SuspendLayout();
            this.ToolsPanel.SuspendLayout();
            this.FooterPanel.SuspendLayout();
            this.DesktopPanel.SuspendLayout();
            this.SqlCommandPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TableGridView)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // iconPictureBox1
            // 
            this.iconPictureBox1.BackColor = System.Drawing.SystemColors.Control;
            this.iconPictureBox1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.iconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.PiedPiperHat;
            this.iconPictureBox1.IconColor = System.Drawing.SystemColors.ControlText;
            this.iconPictureBox1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPictureBox1.IconSize = 49;
            this.iconPictureBox1.Location = new System.Drawing.Point(83, 3);
            this.iconPictureBox1.Name = "iconPictureBox1";
            this.iconPictureBox1.Size = new System.Drawing.Size(49, 49);
            this.iconPictureBox1.TabIndex = 5;
            this.iconPictureBox1.TabStop = false;
            // 
            // LogoLabel
            // 
            this.LogoLabel.AutoSize = true;
            this.LogoLabel.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LogoLabel.Location = new System.Drawing.Point(4, 6);
            this.LogoLabel.Name = "LogoLabel";
            this.LogoLabel.Size = new System.Drawing.Size(77, 40);
            this.LogoLabel.TabIndex = 4;
            this.LogoLabel.Text = "DmS";
            // 
            // HideButton
            // 
            this.HideButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.HideButton.FlatAppearance.BorderSize = 0;
            this.HideButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.HideButton.IconChar = FontAwesome.Sharp.IconChar.MinusCircle;
            this.HideButton.IconColor = System.Drawing.Color.Black;
            this.HideButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.HideButton.Location = new System.Drawing.Point(1231, 4);
            this.HideButton.Name = "HideButton";
            this.HideButton.Size = new System.Drawing.Size(40, 42);
            this.HideButton.TabIndex = 3;
            this.HideButton.UseVisualStyleBackColor = true;
            // 
            // MinimizeButton
            // 
            this.MinimizeButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.MinimizeButton.FlatAppearance.BorderSize = 0;
            this.MinimizeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MinimizeButton.IconChar = FontAwesome.Sharp.IconChar.Circle;
            this.MinimizeButton.IconColor = System.Drawing.Color.Black;
            this.MinimizeButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.MinimizeButton.Location = new System.Drawing.Point(1274, 4);
            this.MinimizeButton.Name = "MinimizeButton";
            this.MinimizeButton.Size = new System.Drawing.Size(40, 42);
            this.MinimizeButton.TabIndex = 2;
            this.MinimizeButton.UseVisualStyleBackColor = true;
            // 
            // CloseButton
            // 
            this.CloseButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CloseButton.FlatAppearance.BorderSize = 0;
            this.CloseButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CloseButton.IconChar = FontAwesome.Sharp.IconChar.TimesCircle;
            this.CloseButton.IconColor = System.Drawing.Color.Black;
            this.CloseButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.CloseButton.Location = new System.Drawing.Point(1316, 4);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(40, 42);
            this.CloseButton.TabIndex = 1;
            this.CloseButton.UseVisualStyleBackColor = true;
            // 
            // HeaderPanel
            // 
            this.HeaderPanel.Controls.Add(this.HideButtonManager);
            this.HeaderPanel.Controls.Add(this.iconPictureBox1);
            this.HeaderPanel.Controls.Add(this.MinimizeButtonManager);
            this.HeaderPanel.Controls.Add(this.CloseButtonManager);
            this.HeaderPanel.Controls.Add(this.LogoLabel);
            this.HeaderPanel.Controls.Add(this.HideButton);
            this.HeaderPanel.Controls.Add(this.MinimizeButton);
            this.HeaderPanel.Controls.Add(this.CloseButton);
            this.HeaderPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.HeaderPanel.Location = new System.Drawing.Point(0, 0);
            this.HeaderPanel.Name = "HeaderPanel";
            this.HeaderPanel.Size = new System.Drawing.Size(784, 52);
            this.HeaderPanel.TabIndex = 2;
            this.HeaderPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.HeaderPanel_MouseDown);
            // 
            // HideButtonManager
            // 
            this.HideButtonManager.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.HideButtonManager.FlatAppearance.BorderSize = 0;
            this.HideButtonManager.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.HideButtonManager.IconChar = FontAwesome.Sharp.IconChar.MinusCircle;
            this.HideButtonManager.IconColor = System.Drawing.Color.Black;
            this.HideButtonManager.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.HideButtonManager.Location = new System.Drawing.Point(647, 4);
            this.HideButtonManager.Name = "HideButtonManager";
            this.HideButtonManager.Size = new System.Drawing.Size(40, 42);
            this.HideButtonManager.TabIndex = 9;
            this.HideButtonManager.UseVisualStyleBackColor = true;
            this.HideButtonManager.Click += new System.EventHandler(this.HideButtonManager_Click);
            // 
            // MinimizeButtonManager
            // 
            this.MinimizeButtonManager.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.MinimizeButtonManager.FlatAppearance.BorderSize = 0;
            this.MinimizeButtonManager.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MinimizeButtonManager.IconChar = FontAwesome.Sharp.IconChar.Circle;
            this.MinimizeButtonManager.IconColor = System.Drawing.Color.Black;
            this.MinimizeButtonManager.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.MinimizeButtonManager.Location = new System.Drawing.Point(690, 4);
            this.MinimizeButtonManager.Name = "MinimizeButtonManager";
            this.MinimizeButtonManager.Size = new System.Drawing.Size(40, 42);
            this.MinimizeButtonManager.TabIndex = 8;
            this.MinimizeButtonManager.UseVisualStyleBackColor = true;
            this.MinimizeButtonManager.Click += new System.EventHandler(this.MinimizeButtonManager_Click);
            // 
            // CloseButtonManager
            // 
            this.CloseButtonManager.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CloseButtonManager.FlatAppearance.BorderSize = 0;
            this.CloseButtonManager.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CloseButtonManager.IconChar = FontAwesome.Sharp.IconChar.TimesCircle;
            this.CloseButtonManager.IconColor = System.Drawing.Color.Black;
            this.CloseButtonManager.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.CloseButtonManager.Location = new System.Drawing.Point(732, 4);
            this.CloseButtonManager.Name = "CloseButtonManager";
            this.CloseButtonManager.Size = new System.Drawing.Size(40, 42);
            this.CloseButtonManager.TabIndex = 7;
            this.CloseButtonManager.UseVisualStyleBackColor = true;
            this.CloseButtonManager.Click += new System.EventHandler(this.CloseButtonManager_Click);
            // 
            // FooterLabel
            // 
            this.FooterLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FooterLabel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FooterLabel.Location = new System.Drawing.Point(0, 0);
            this.FooterLabel.Name = "FooterLabel";
            this.FooterLabel.Size = new System.Drawing.Size(784, 74);
            this.FooterLabel.TabIndex = 3;
            this.FooterLabel.Text = "DMS 2022 Standard is the newest version, ready for the cutting edge. \r\nProviding " +
    "licensing and server solutions to over 10,000 IT pros across the US.";
            this.FooterLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ToolsPanel
            // 
            this.ToolsPanel.Controls.Add(this.WriteSqlCommand);
            this.ToolsPanel.Controls.Add(this.ReloadTableData);
            this.ToolsPanel.Controls.Add(this.SaveTableData);
            this.ToolsPanel.Controls.Add(this.EditTableData);
            this.ToolsPanel.Controls.Add(this.TabelsComboBox);
            this.ToolsPanel.Controls.Add(this.GetDataBaseButton);
            this.ToolsPanel.Controls.Add(this.DatabasesComboBox);
            this.ToolsPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.ToolsPanel.Location = new System.Drawing.Point(0, 52);
            this.ToolsPanel.Name = "ToolsPanel";
            this.ToolsPanel.Size = new System.Drawing.Size(784, 53);
            this.ToolsPanel.TabIndex = 4;
            // 
            // WriteSqlCommand
            // 
            this.WriteSqlCommand.FlatAppearance.BorderSize = 0;
            this.WriteSqlCommand.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.WriteSqlCommand.IconChar = FontAwesome.Sharp.IconChar.Terminal;
            this.WriteSqlCommand.IconColor = System.Drawing.Color.Black;
            this.WriteSqlCommand.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.WriteSqlCommand.Location = new System.Drawing.Point(4, 4);
            this.WriteSqlCommand.Name = "WriteSqlCommand";
            this.WriteSqlCommand.Size = new System.Drawing.Size(48, 44);
            this.WriteSqlCommand.TabIndex = 6;
            this.WriteSqlCommand.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.WriteSqlCommand.UseVisualStyleBackColor = true;
            this.WriteSqlCommand.Click += new System.EventHandler(this.WriteSqlCommand_Click);
            // 
            // ReloadTableData
            // 
            this.ReloadTableData.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ReloadTableData.FlatAppearance.BorderSize = 0;
            this.ReloadTableData.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ReloadTableData.IconChar = FontAwesome.Sharp.IconChar.SyncAlt;
            this.ReloadTableData.IconColor = System.Drawing.Color.Black;
            this.ReloadTableData.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ReloadTableData.IconSize = 42;
            this.ReloadTableData.Location = new System.Drawing.Point(150, 5);
            this.ReloadTableData.Name = "ReloadTableData";
            this.ReloadTableData.Size = new System.Drawing.Size(48, 44);
            this.ReloadTableData.TabIndex = 5;
            this.ReloadTableData.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ReloadTableData.UseVisualStyleBackColor = true;
            this.ReloadTableData.Click += new System.EventHandler(this.ReloadTableData_Click);
            // 
            // SaveTableData
            // 
            this.SaveTableData.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.SaveTableData.Enabled = false;
            this.SaveTableData.FlatAppearance.BorderSize = 0;
            this.SaveTableData.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SaveTableData.IconChar = FontAwesome.Sharp.IconChar.Save;
            this.SaveTableData.IconColor = System.Drawing.Color.Black;
            this.SaveTableData.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.SaveTableData.IconSize = 44;
            this.SaveTableData.Location = new System.Drawing.Point(194, 6);
            this.SaveTableData.Name = "SaveTableData";
            this.SaveTableData.Size = new System.Drawing.Size(48, 44);
            this.SaveTableData.TabIndex = 4;
            this.SaveTableData.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.SaveTableData.UseVisualStyleBackColor = true;
            this.SaveTableData.Click += new System.EventHandler(this.SaveTableData_Click);
            // 
            // EditTableData
            // 
            this.EditTableData.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.EditTableData.FlatAppearance.BorderSize = 0;
            this.EditTableData.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EditTableData.IconChar = FontAwesome.Sharp.IconChar.Edit;
            this.EditTableData.IconColor = System.Drawing.Color.Black;
            this.EditTableData.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.EditTableData.Location = new System.Drawing.Point(240, 4);
            this.EditTableData.Name = "EditTableData";
            this.EditTableData.Size = new System.Drawing.Size(48, 44);
            this.EditTableData.TabIndex = 3;
            this.EditTableData.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.EditTableData.UseVisualStyleBackColor = true;
            this.EditTableData.Click += new System.EventHandler(this.EditTableData_Click);
            // 
            // TabelsComboBox
            // 
            this.TabelsComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.TabelsComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.TabelsComboBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TabelsComboBox.FormattingEnabled = true;
            this.TabelsComboBox.Location = new System.Drawing.Point(294, 11);
            this.TabelsComboBox.Name = "TabelsComboBox";
            this.TabelsComboBox.Size = new System.Drawing.Size(162, 29);
            this.TabelsComboBox.TabIndex = 2;
            this.TabelsComboBox.SelectedIndexChanged += new System.EventHandler(this.TabelsComboBox_SelectedIndexChanged);
            // 
            // GetDataBaseButton
            // 
            this.GetDataBaseButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.GetDataBaseButton.FlatAppearance.BorderSize = 0;
            this.GetDataBaseButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.GetDataBaseButton.IconChar = FontAwesome.Sharp.IconChar.PlayCircle;
            this.GetDataBaseButton.IconColor = System.Drawing.Color.Black;
            this.GetDataBaseButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.GetDataBaseButton.Location = new System.Drawing.Point(730, 6);
            this.GetDataBaseButton.Name = "GetDataBaseButton";
            this.GetDataBaseButton.Size = new System.Drawing.Size(48, 44);
            this.GetDataBaseButton.TabIndex = 1;
            this.GetDataBaseButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.GetDataBaseButton.UseVisualStyleBackColor = true;
            this.GetDataBaseButton.Click += new System.EventHandler(this.GetDataBaseButton_Click);
            // 
            // DatabasesComboBox
            // 
            this.DatabasesComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.DatabasesComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DatabasesComboBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.DatabasesComboBox.FormattingEnabled = true;
            this.DatabasesComboBox.Location = new System.Drawing.Point(462, 11);
            this.DatabasesComboBox.Name = "DatabasesComboBox";
            this.DatabasesComboBox.Size = new System.Drawing.Size(265, 29);
            this.DatabasesComboBox.TabIndex = 0;
            // 
            // FooterPanel
            // 
            this.FooterPanel.Controls.Add(this.FooterLabel);
            this.FooterPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.FooterPanel.Location = new System.Drawing.Point(0, 357);
            this.FooterPanel.Name = "FooterPanel";
            this.FooterPanel.Size = new System.Drawing.Size(784, 74);
            this.FooterPanel.TabIndex = 6;
            // 
            // DesktopPanel
            // 
            this.DesktopPanel.Controls.Add(this.SqlCommandPanel);
            this.DesktopPanel.Controls.Add(this.TableGridView);
            this.DesktopPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DesktopPanel.Location = new System.Drawing.Point(0, 105);
            this.DesktopPanel.Name = "DesktopPanel";
            this.DesktopPanel.Size = new System.Drawing.Size(784, 252);
            this.DesktopPanel.TabIndex = 7;
            // 
            // SqlCommandPanel
            // 
            this.SqlCommandPanel.BackColor = System.Drawing.Color.Gainsboro;
            this.SqlCommandPanel.Controls.Add(this.CurrentDbLabel);
            this.SqlCommandPanel.Controls.Add(this.MakeSmallerSqlPanelButton);
            this.SqlCommandPanel.Controls.Add(this.MakeBiggerSqlPanelButton);
            this.SqlCommandPanel.Controls.Add(this.ExcecuteSqlButton);
            this.SqlCommandPanel.Controls.Add(this.CloseSqlPanelButton);
            this.SqlCommandPanel.Controls.Add(this.SqlTextBox);
            this.SqlCommandPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.SqlCommandPanel.Location = new System.Drawing.Point(0, 124);
            this.SqlCommandPanel.Name = "SqlCommandPanel";
            this.SqlCommandPanel.Padding = new System.Windows.Forms.Padding(0, 28, 0, 0);
            this.SqlCommandPanel.Size = new System.Drawing.Size(784, 128);
            this.SqlCommandPanel.TabIndex = 10;
            this.SqlCommandPanel.Visible = false;
            // 
            // CurrentDbLabel
            // 
            this.CurrentDbLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.CurrentDbLabel.AutoSize = true;
            this.CurrentDbLabel.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CurrentDbLabel.Location = new System.Drawing.Point(265, 5);
            this.CurrentDbLabel.Name = "CurrentDbLabel";
            this.CurrentDbLabel.Size = new System.Drawing.Size(188, 18);
            this.CurrentDbLabel.TabIndex = 5;
            this.CurrentDbLabel.Text = "Selected DataBase: [...]";
            // 
            // MakeSmallerSqlPanelButton
            // 
            this.MakeSmallerSqlPanelButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.MakeSmallerSqlPanelButton.BackColor = System.Drawing.Color.Transparent;
            this.MakeSmallerSqlPanelButton.FlatAppearance.BorderSize = 0;
            this.MakeSmallerSqlPanelButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MakeSmallerSqlPanelButton.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.MakeSmallerSqlPanelButton.Location = new System.Drawing.Point(707, 0);
            this.MakeSmallerSqlPanelButton.Name = "MakeSmallerSqlPanelButton";
            this.MakeSmallerSqlPanelButton.Size = new System.Drawing.Size(24, 21);
            this.MakeSmallerSqlPanelButton.TabIndex = 4;
            this.MakeSmallerSqlPanelButton.Text = "▼";
            this.MakeSmallerSqlPanelButton.UseVisualStyleBackColor = false;
            this.MakeSmallerSqlPanelButton.Click += new System.EventHandler(this.MakeSmallerSqlPanelButton_Click);
            // 
            // MakeBiggerSqlPanelButton
            // 
            this.MakeBiggerSqlPanelButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.MakeBiggerSqlPanelButton.BackColor = System.Drawing.Color.Transparent;
            this.MakeBiggerSqlPanelButton.FlatAppearance.BorderSize = 0;
            this.MakeBiggerSqlPanelButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MakeBiggerSqlPanelButton.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.MakeBiggerSqlPanelButton.Location = new System.Drawing.Point(733, 0);
            this.MakeBiggerSqlPanelButton.Name = "MakeBiggerSqlPanelButton";
            this.MakeBiggerSqlPanelButton.Size = new System.Drawing.Size(24, 21);
            this.MakeBiggerSqlPanelButton.TabIndex = 3;
            this.MakeBiggerSqlPanelButton.Text = "▲";
            this.MakeBiggerSqlPanelButton.UseVisualStyleBackColor = false;
            this.MakeBiggerSqlPanelButton.Click += new System.EventHandler(this.MakeBiggerSqlPanelButton_Click);
            // 
            // ExcecuteSqlButton
            // 
            this.ExcecuteSqlButton.FlatAppearance.BorderSize = 0;
            this.ExcecuteSqlButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ExcecuteSqlButton.IconChar = FontAwesome.Sharp.IconChar.PlaneDeparture;
            this.ExcecuteSqlButton.IconColor = System.Drawing.Color.Black;
            this.ExcecuteSqlButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ExcecuteSqlButton.IconSize = 32;
            this.ExcecuteSqlButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ExcecuteSqlButton.Location = new System.Drawing.Point(-5, 3);
            this.ExcecuteSqlButton.Name = "ExcecuteSqlButton";
            this.ExcecuteSqlButton.Size = new System.Drawing.Size(98, 23);
            this.ExcecuteSqlButton.TabIndex = 2;
            this.ExcecuteSqlButton.Text = "           Execute";
            this.ExcecuteSqlButton.UseVisualStyleBackColor = true;
            this.ExcecuteSqlButton.Click += new System.EventHandler(this.ExcecuteSqlButton_Click);
            // 
            // CloseSqlPanelButton
            // 
            this.CloseSqlPanelButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CloseSqlPanelButton.BackColor = System.Drawing.Color.Transparent;
            this.CloseSqlPanelButton.FlatAppearance.BorderSize = 0;
            this.CloseSqlPanelButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CloseSqlPanelButton.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.CloseSqlPanelButton.Location = new System.Drawing.Point(760, 0);
            this.CloseSqlPanelButton.Name = "CloseSqlPanelButton";
            this.CloseSqlPanelButton.Size = new System.Drawing.Size(24, 21);
            this.CloseSqlPanelButton.TabIndex = 0;
            this.CloseSqlPanelButton.Text = "X";
            this.CloseSqlPanelButton.UseVisualStyleBackColor = false;
            this.CloseSqlPanelButton.Click += new System.EventHandler(this.CloseSqlPanelButton_Click);
            // 
            // SqlTextBox
            // 
            this.SqlTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.SqlTextBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.SqlTextBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.SqlTextBox.Location = new System.Drawing.Point(0, 28);
            this.SqlTextBox.Multiline = true;
            this.SqlTextBox.Name = "SqlTextBox";
            this.SqlTextBox.PlaceholderText = "Type some sql query...";
            this.SqlTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.SqlTextBox.Size = new System.Drawing.Size(784, 100);
            this.SqlTextBox.TabIndex = 1;
            // 
            // TableGridView
            // 
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.TableGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.TableGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.TableGridView.BackgroundColor = System.Drawing.SystemColors.Control;
            this.TableGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.SkyBlue;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.TableGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.TableGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TableGridView.ContextMenuStrip = this.contextMenuStrip1;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.TableGridView.DefaultCellStyle = dataGridViewCellStyle3;
            this.TableGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TableGridView.EnableHeadersVisualStyles = false;
            this.TableGridView.GridColor = System.Drawing.SystemColors.Control;
            this.TableGridView.Location = new System.Drawing.Point(0, 0);
            this.TableGridView.Name = "TableGridView";
            this.TableGridView.ReadOnly = true;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.TableGridView.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.TableGridView.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TableGridView.RowTemplate.Height = 25;
            this.TableGridView.Size = new System.Drawing.Size(784, 252);
            this.TableGridView.TabIndex = 0;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.deleteToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(108, 26);
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.deleteToolStripMenuItem.Text = "Delete";
            this.deleteToolStripMenuItem.Click += new System.EventHandler(this.deleteToolStripMenuItem_Click);
            // 
            // DataBaseManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 431);
            this.Controls.Add(this.DesktopPanel);
            this.Controls.Add(this.FooterPanel);
            this.Controls.Add(this.ToolsPanel);
            this.Controls.Add(this.HeaderPanel);
            this.Name = "DataBaseManager";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "DataBaseManager";
            this.Load += new System.EventHandler(this.DataBaseManager_Load);
            this.Resize += new System.EventHandler(this.DataBaseManager_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).EndInit();
            this.HeaderPanel.ResumeLayout(false);
            this.HeaderPanel.PerformLayout();
            this.ToolsPanel.ResumeLayout(false);
            this.FooterPanel.ResumeLayout(false);
            this.DesktopPanel.ResumeLayout(false);
            this.SqlCommandPanel.ResumeLayout(false);
            this.SqlCommandPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TableGridView)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private FontAwesome.Sharp.IconPictureBox iconPictureBox1;
        private Label LogoLabel;
        private FontAwesome.Sharp.IconButton HideButton;
        private FontAwesome.Sharp.IconButton MinimizeButton;
        private FontAwesome.Sharp.IconButton CloseButton;
        private Panel HeaderPanel;
        private FontAwesome.Sharp.IconButton HideButtonManager;
        private FontAwesome.Sharp.IconButton MinimizeButtonManager;
        private FontAwesome.Sharp.IconButton CloseButtonManager;
        private Label FooterLabel;
        private Panel ToolsPanel;
        private ComboBox DatabasesComboBox;
        private FontAwesome.Sharp.IconButton GetDataBaseButton;
        private Panel FooterPanel;
        private Panel DesktopPanel;
        private DataGridView TableGridView;
        private ComboBox TabelsComboBox;
        private FontAwesome.Sharp.IconButton EditTableData;
        private FontAwesome.Sharp.IconButton SaveTableData;
        private FontAwesome.Sharp.IconButton ReloadTableData;
        private FontAwesome.Sharp.IconButton WriteSqlCommand;
        private Panel SqlCommandPanel;
        private Button CloseSqlPanelButton;
        private TextBox SqlTextBox;
        private FontAwesome.Sharp.IconButton ExcecuteSqlButton;
        private Button MakeBiggerSqlPanelButton;
        private Button MakeSmallerSqlPanelButton;
        private Label CurrentDbLabel;
        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem deleteToolStripMenuItem;
    }
}