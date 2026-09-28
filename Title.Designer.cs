namespace BJ
{
    partial class Title
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
            Title_Logo = new PictureBox();
            Setting_button = new Button();
            New_button = new Button();
            tableLayoutPanel1 = new TableLayoutPanel();
            Continue_button = new Button();
            ((System.ComponentModel.ISupportInitialize)Title_Logo).BeginInit();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // Title_Logo
            // 
            Title_Logo.Cursor = Cursors.Hand;
            Title_Logo.Image = assets.logo;
            Title_Logo.ImageLocation = "";
            Title_Logo.Location = new Point(115, 38);
            Title_Logo.Margin = new Padding(0);
            Title_Logo.Name = "Title_Logo";
            Title_Logo.Size = new Size(563, 199);
            Title_Logo.SizeMode = PictureBoxSizeMode.Zoom;
            Title_Logo.TabIndex = 0;
            Title_Logo.TabStop = false;
            Title_Logo.Click += Logo_click;
            // 
            // Setting_button
            // 
            Setting_button.Dock = DockStyle.Fill;
            Setting_button.Location = new Point(152, 0);
            Setting_button.Margin = new Padding(10, 0, 10, 0);
            Setting_button.Name = "Setting_button";
            Setting_button.Size = new Size(122, 36);
            Setting_button.TabIndex = 2;
            Setting_button.Text = "設定";
            Setting_button.UseVisualStyleBackColor = true;
            // 
            // New_button
            // 
            New_button.Dock = DockStyle.Fill;
            New_button.Location = new Point(10, 0);
            New_button.Margin = new Padding(10, 0, 10, 0);
            New_button.Name = "New_button";
            New_button.Size = new Size(122, 36);
            New_button.TabIndex = 1;
            New_button.Text = "はじめから";
            New_button.UseVisualStyleBackColor = true;
            New_button.Click += New_button_click;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 3;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.Controls.Add(Continue_button, 2, 0);
            tableLayoutPanel1.Controls.Add(New_button, 0, 0);
            tableLayoutPanel1.Controls.Add(Setting_button, 1, 0);
            tableLayoutPanel1.Location = new Point(195, 335);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new Size(427, 36);
            tableLayoutPanel1.TabIndex = 3;
            // 
            // Continue_button
            // 
            Continue_button.Dock = DockStyle.Fill;
            Continue_button.Location = new Point(294, 0);
            Continue_button.Margin = new Padding(10, 0, 10, 0);
            Continue_button.Name = "Continue_button";
            Continue_button.Size = new Size(123, 36);
            Continue_button.TabIndex = 3;
            Continue_button.Text = "つづきから";
            Continue_button.UseVisualStyleBackColor = true;
            // 
            // Title
            // 
            AutoScaleDimensions = new SizeF(7F, 18F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLight;
            ClientSize = new Size(792, 469);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(Title_Logo);
            ImeMode = ImeMode.Off;
            MaximizeBox = false;
            MaximumSize = new Size(800, 500);
            MinimumSize = new Size(800, 500);
            Name = "Title";
            SizeGripStyle = SizeGripStyle.Hide;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ブラックジャックポーカー Ver.0.0";
            ((System.ComponentModel.ISupportInitialize)Title_Logo).EndInit();
            tableLayoutPanel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private PictureBox Title_Logo;
        private Button Setting_button;
        private Button New_button;
        private TableLayoutPanel tableLayoutPanel1;
        private Button Continue_button;
    }
}
