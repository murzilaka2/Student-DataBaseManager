namespace DataBaseManager
{
    partial class Main
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.HeaderPanel = new System.Windows.Forms.Panel();
            this.iconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            this.LogoLabel = new System.Windows.Forms.Label();
            this.HideButton = new FontAwesome.Sharp.IconButton();
            this.MinimizeButton = new FontAwesome.Sharp.IconButton();
            this.CloseButton = new FontAwesome.Sharp.IconButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.FooterPanel = new System.Windows.Forms.Panel();
            this.FooterLabel = new System.Windows.Forms.Label();
            this.ProgressPanel = new System.Windows.Forms.Panel();
            this.IconLoading = new FontAwesome.Sharp.IconPictureBox();
            this.ProgressLabel = new System.Windows.Forms.Label();
            this.TextBoxesPanel = new System.Windows.Forms.Panel();
            this.LogInButton = new FontAwesome.Sharp.IconButton();
            this.ServerTextBox = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.DescriptionLabel = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.TitleLabel = new System.Windows.Forms.Label();
            this.HeaderPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.FooterPanel.SuspendLayout();
            this.ProgressPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.IconLoading)).BeginInit();
            this.TextBoxesPanel.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // HeaderPanel
            // 
            this.HeaderPanel.Controls.Add(this.iconPictureBox1);
            this.HeaderPanel.Controls.Add(this.LogoLabel);
            this.HeaderPanel.Controls.Add(this.HideButton);
            this.HeaderPanel.Controls.Add(this.MinimizeButton);
            this.HeaderPanel.Controls.Add(this.CloseButton);
            this.HeaderPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.HeaderPanel.Location = new System.Drawing.Point(0, 0);
            this.HeaderPanel.Name = "HeaderPanel";
            this.HeaderPanel.Size = new System.Drawing.Size(784, 52);
            this.HeaderPanel.TabIndex = 0;
            this.HeaderPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.HeaderPanel_MouseDown);
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
            this.HideButton.Location = new System.Drawing.Point(647, 4);
            this.HideButton.Name = "HideButton";
            this.HideButton.Size = new System.Drawing.Size(40, 42);
            this.HideButton.TabIndex = 3;
            this.HideButton.UseVisualStyleBackColor = true;
            this.HideButton.Click += new System.EventHandler(this.HideButton_Click);
            // 
            // MinimizeButton
            // 
            this.MinimizeButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.MinimizeButton.FlatAppearance.BorderSize = 0;
            this.MinimizeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MinimizeButton.IconChar = FontAwesome.Sharp.IconChar.Circle;
            this.MinimizeButton.IconColor = System.Drawing.Color.Black;
            this.MinimizeButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.MinimizeButton.Location = new System.Drawing.Point(690, 4);
            this.MinimizeButton.Name = "MinimizeButton";
            this.MinimizeButton.Size = new System.Drawing.Size(40, 42);
            this.MinimizeButton.TabIndex = 2;
            this.MinimizeButton.UseVisualStyleBackColor = true;
            this.MinimizeButton.Click += new System.EventHandler(this.MinimizeButton_Click);
            // 
            // CloseButton
            // 
            this.CloseButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CloseButton.FlatAppearance.BorderSize = 0;
            this.CloseButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CloseButton.IconChar = FontAwesome.Sharp.IconChar.TimesCircle;
            this.CloseButton.IconColor = System.Drawing.Color.Black;
            this.CloseButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.CloseButton.Location = new System.Drawing.Point(732, 4);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(40, 42);
            this.CloseButton.TabIndex = 1;
            this.CloseButton.UseVisualStyleBackColor = true;
            this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.FooterPanel);
            this.panel1.Controls.Add(this.ProgressPanel);
            this.panel1.Controls.Add(this.TextBoxesPanel);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 52);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(784, 379);
            this.panel1.TabIndex = 1;
            // 
            // FooterPanel
            // 
            this.FooterPanel.Controls.Add(this.FooterLabel);
            this.FooterPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.FooterPanel.Location = new System.Drawing.Point(0, 305);
            this.FooterPanel.Name = "FooterPanel";
            this.FooterPanel.Size = new System.Drawing.Size(784, 74);
            this.FooterPanel.TabIndex = 6;
            // 
            // FooterLabel
            // 
            this.FooterLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FooterLabel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FooterLabel.Location = new System.Drawing.Point(0, 0);
            this.FooterLabel.Name = "FooterLabel";
            this.FooterLabel.Size = new System.Drawing.Size(784, 74);
            this.FooterLabel.TabIndex = 2;
            this.FooterLabel.Text = "DMS 2022 Standard is the newest version, ready for the cutting edge. \r\nProviding " +
    "licensing and server solutions to over 10,000 IT pros across the US.";
            this.FooterLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ProgressPanel
            // 
            this.ProgressPanel.Controls.Add(this.IconLoading);
            this.ProgressPanel.Controls.Add(this.ProgressLabel);
            this.ProgressPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.ProgressPanel.Location = new System.Drawing.Point(0, 257);
            this.ProgressPanel.Name = "ProgressPanel";
            this.ProgressPanel.Size = new System.Drawing.Size(784, 76);
            this.ProgressPanel.TabIndex = 5;
            // 
            // IconLoading
            // 
            this.IconLoading.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.IconLoading.BackColor = System.Drawing.SystemColors.Control;
            this.IconLoading.ForeColor = System.Drawing.SystemColors.ControlText;
            this.IconLoading.IconChar = FontAwesome.Sharp.IconChar.BatteryEmpty;
            this.IconLoading.IconColor = System.Drawing.SystemColors.ControlText;
            this.IconLoading.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.IconLoading.IconSize = 49;
            this.IconLoading.Location = new System.Drawing.Point(420, 19);
            this.IconLoading.Name = "IconLoading";
            this.IconLoading.Size = new System.Drawing.Size(49, 71);
            this.IconLoading.TabIndex = 2;
            this.IconLoading.TabStop = false;
            this.IconLoading.Visible = false;
            // 
            // ProgressLabel
            // 
            this.ProgressLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ProgressLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ProgressLabel.Location = new System.Drawing.Point(0, 0);
            this.ProgressLabel.Name = "ProgressLabel";
            this.ProgressLabel.Padding = new System.Windows.Forms.Padding(0, 0, 10, 0);
            this.ProgressLabel.Size = new System.Drawing.Size(784, 76);
            this.ProgressLabel.TabIndex = 1;
            this.ProgressLabel.Text = "Loading";
            this.ProgressLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.ProgressLabel.Visible = false;
            // 
            // TextBoxesPanel
            // 
            this.TextBoxesPanel.Controls.Add(this.LogInButton);
            this.TextBoxesPanel.Controls.Add(this.ServerTextBox);
            this.TextBoxesPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.TextBoxesPanel.Location = new System.Drawing.Point(0, 200);
            this.TextBoxesPanel.Name = "TextBoxesPanel";
            this.TextBoxesPanel.Padding = new System.Windows.Forms.Padding(150, 0, 150, 0);
            this.TextBoxesPanel.Size = new System.Drawing.Size(784, 57);
            this.TextBoxesPanel.TabIndex = 4;
            // 
            // LogInButton
            // 
            this.LogInButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.LogInButton.FlatAppearance.BorderSize = 0;
            this.LogInButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LogInButton.IconChar = FontAwesome.Sharp.IconChar.PowerOff;
            this.LogInButton.IconColor = System.Drawing.Color.Black;
            this.LogInButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.LogInButton.Location = new System.Drawing.Point(647, -1);
            this.LogInButton.Name = "LogInButton";
            this.LogInButton.Size = new System.Drawing.Size(56, 67);
            this.LogInButton.TabIndex = 0;
            this.LogInButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.LogInButton.UseVisualStyleBackColor = true;
            this.LogInButton.Click += new System.EventHandler(this.LogInButton_Click);
            // 
            // ServerTextBox
            // 
            this.ServerTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.ServerTextBox.BackColor = System.Drawing.SystemColors.Control;
            this.ServerTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ServerTextBox.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ServerTextBox.Location = new System.Drawing.Point(147, 13);
            this.ServerTextBox.Name = "ServerTextBox";
            this.ServerTextBox.PlaceholderText = "Enter server name...";
            this.ServerTextBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.ServerTextBox.Size = new System.Drawing.Size(484, 28);
            this.ServerTextBox.TabIndex = 0;
            this.ServerTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ServerTextBox.WordWrap = false;
            this.ServerTextBox.Click += new System.EventHandler(this.ServerTextBox_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.DescriptionLabel);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 100);
            this.panel3.Name = "panel3";
            this.panel3.Padding = new System.Windows.Forms.Padding(0, 0, 0, 20);
            this.panel3.Size = new System.Drawing.Size(784, 100);
            this.panel3.TabIndex = 3;
            // 
            // DescriptionLabel
            // 
            this.DescriptionLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DescriptionLabel.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.DescriptionLabel.Location = new System.Drawing.Point(0, 0);
            this.DescriptionLabel.Name = "DescriptionLabel";
            this.DescriptionLabel.Size = new System.Drawing.Size(784, 80);
            this.DescriptionLabel.TabIndex = 1;
            this.DescriptionLabel.Text = "DMS 2022 Standard is the newest version, ready for the cutting edge. \r\nProviding " +
    "licensing and server solutions to over 10,000 IT pros across the US.";
            this.DescriptionLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.TitleLabel);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(784, 100);
            this.panel2.TabIndex = 2;
            // 
            // TitleLabel
            // 
            this.TitleLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TitleLabel.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TitleLabel.Location = new System.Drawing.Point(0, 0);
            this.TitleLabel.Name = "TitleLabel";
            this.TitleLabel.Size = new System.Drawing.Size(784, 100);
            this.TitleLabel.TabIndex = 0;
            this.TitleLabel.Text = "Welcome to Database Managment System";
            this.TitleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 431);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.HeaderPanel);
            this.Name = "Main";
            this.Text = "Form1";
            this.Resize += new System.EventHandler(this.Form1_Resize);
            this.HeaderPanel.ResumeLayout(false);
            this.HeaderPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.FooterPanel.ResumeLayout(false);
            this.ProgressPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.IconLoading)).EndInit();
            this.TextBoxesPanel.ResumeLayout(false);
            this.TextBoxesPanel.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Panel HeaderPanel;
        private FontAwesome.Sharp.IconButton HideButton;
        private FontAwesome.Sharp.IconButton MinimizeButton;
        private FontAwesome.Sharp.IconButton CloseButton;
        private Label LogoLabel;
        private Panel panel1;
        private Label TitleLabel;
        private Label DescriptionLabel;
        private Panel panel3;
        private Panel panel2;
        private Panel TextBoxesPanel;
        private TextBox ServerTextBox;
        private Panel FooterPanel;
        private Panel ProgressPanel;
        private FontAwesome.Sharp.IconButton LogInButton;
        private Label FooterLabel;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox1;
        private Label ProgressLabel;
        private FontAwesome.Sharp.IconPictureBox IconLoading;
    }
}