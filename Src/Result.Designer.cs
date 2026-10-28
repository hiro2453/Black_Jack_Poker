namespace BJ.Src
{
    partial class Result
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
            components = new System.ComponentModel.Container();
            MainGroupPanel = new TableLayoutPanel();
            BJ_panel = new TableLayoutPanel();
            goukei_Text = new PictureBox();
            Num_panel = new FlowLayoutPanel();
            pictureBox4 = new PictureBox();
            pictureBox5 = new PictureBox();
            BJ_text = new PictureBox();
            Shoji_text = new PictureBox();
            Shoji_panel = new TableLayoutPanel();
            After_panel = new FlowLayoutPanel();
            pictureBox15 = new PictureBox();
            pictureBox16 = new PictureBox();
            pictureBox18 = new PictureBox();
            pictureBox6 = new PictureBox();
            pictureBox7 = new PictureBox();
            pictureBox8 = new PictureBox();
            Change_Text_label = new Label();
            Before_panel = new FlowLayoutPanel();
            pictureBox11 = new PictureBox();
            pictureBox12 = new PictureBox();
            pictureBox13 = new PictureBox();
            pictureBox14 = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            Layout_main = new TableLayoutPanel();
            Kekka_Text = new PictureBox();
            Message_label = new Label();
            timer1 = new System.Windows.Forms.Timer(components);
            MainGroupPanel.SuspendLayout();
            BJ_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)goukei_Text).BeginInit();
            Num_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)BJ_text).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Shoji_text).BeginInit();
            Shoji_panel.SuspendLayout();
            After_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox15).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox16).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox18).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox8).BeginInit();
            Before_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox11).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox12).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox13).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox14).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            Layout_main.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)Kekka_Text).BeginInit();
            SuspendLayout();
            // 
            // MainGroupPanel
            // 
            MainGroupPanel.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            MainGroupPanel.AutoSize = true;
            MainGroupPanel.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            MainGroupPanel.ColumnCount = 1;
            MainGroupPanel.ColumnStyles.Add(new ColumnStyle());
            MainGroupPanel.Controls.Add(BJ_panel, 0, 1);
            MainGroupPanel.Controls.Add(BJ_text, 0, 0);
            MainGroupPanel.Controls.Add(Shoji_text, 0, 3);
            MainGroupPanel.Controls.Add(Shoji_panel, 0, 4);
            MainGroupPanel.Location = new Point(3, 146);
            MainGroupPanel.Margin = new Padding(3, 10, 3, 3);
            MainGroupPanel.Name = "MainGroupPanel";
            MainGroupPanel.RowCount = 5;
            MainGroupPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
            MainGroupPanel.RowStyles.Add(new RowStyle());
            MainGroupPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 32F));
            MainGroupPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
            MainGroupPanel.RowStyles.Add(new RowStyle());
            MainGroupPanel.Size = new Size(778, 262);
            MainGroupPanel.TabIndex = 2;
            // 
            // BJ_panel
            // 
            BJ_panel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            BJ_panel.AutoSize = true;
            BJ_panel.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BJ_panel.ColumnCount = 2;
            BJ_panel.ColumnStyles.Add(new ColumnStyle());
            BJ_panel.ColumnStyles.Add(new ColumnStyle());
            BJ_panel.Controls.Add(goukei_Text, 0, 0);
            BJ_panel.Controls.Add(Num_panel, 1, 0);
            BJ_panel.Location = new Point(290, 33);
            BJ_panel.Name = "BJ_panel";
            BJ_panel.RowCount = 1;
            BJ_panel.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            BJ_panel.Size = new Size(198, 74);
            BJ_panel.TabIndex = 3;
            // 
            // goukei_Text
            // 
            goukei_Text.Dock = DockStyle.Bottom;
            goukei_Text.Image = Properties.Resources.Total_value;
            goukei_Text.Location = new Point(3, 47);
            goukei_Text.Name = "goukei_Text";
            goukei_Text.Size = new Size(84, 24);
            goukei_Text.SizeMode = PictureBoxSizeMode.Zoom;
            goukei_Text.TabIndex = 3;
            goukei_Text.TabStop = false;
            // 
            // Num_panel
            // 
            Num_panel.AutoSize = true;
            Num_panel.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            Num_panel.Controls.Add(pictureBox4);
            Num_panel.Controls.Add(pictureBox5);
            Num_panel.Location = new Point(93, 3);
            Num_panel.Name = "Num_panel";
            Num_panel.Size = new Size(102, 68);
            Num_panel.TabIndex = 4;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = Properties.Resources._02;
            pictureBox4.Location = new Point(3, 3);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(45, 62);
            pictureBox4.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox4.TabIndex = 0;
            pictureBox4.TabStop = false;
            // 
            // pictureBox5
            // 
            pictureBox5.Image = Properties.Resources._02;
            pictureBox5.Location = new Point(54, 3);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(45, 62);
            pictureBox5.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox5.TabIndex = 1;
            pictureBox5.TabStop = false;
            // 
            // BJ_text
            // 
            BJ_text.BackColor = SystemColors.ActiveCaption;
            BJ_text.Dock = DockStyle.Fill;
            BJ_text.Image = Properties.Resources.BJ;
            BJ_text.Location = new Point(3, 3);
            BJ_text.Name = "BJ_text";
            BJ_text.Size = new Size(772, 24);
            BJ_text.SizeMode = PictureBoxSizeMode.Zoom;
            BJ_text.TabIndex = 2;
            BJ_text.TabStop = false;
            // 
            // Shoji_text
            // 
            Shoji_text.BackColor = SystemColors.Info;
            Shoji_text.Image = Properties.Resources.shoji;
            Shoji_text.Location = new Point(3, 145);
            Shoji_text.Name = "Shoji_text";
            Shoji_text.Size = new Size(772, 24);
            Shoji_text.SizeMode = PictureBoxSizeMode.Zoom;
            Shoji_text.TabIndex = 6;
            Shoji_text.TabStop = false;
            // 
            // Shoji_panel
            // 
            Shoji_panel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            Shoji_panel.AutoSize = true;
            Shoji_panel.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            Shoji_panel.ColumnCount = 3;
            Shoji_panel.ColumnStyles.Add(new ColumnStyle());
            Shoji_panel.ColumnStyles.Add(new ColumnStyle());
            Shoji_panel.ColumnStyles.Add(new ColumnStyle());
            Shoji_panel.Controls.Add(After_panel, 2, 0);
            Shoji_panel.Controls.Add(Change_Text_label, 1, 0);
            Shoji_panel.Controls.Add(Before_panel, 0, 0);
            Shoji_panel.Location = new Point(37, 175);
            Shoji_panel.Name = "Shoji_panel";
            Shoji_panel.RowCount = 1;
            Shoji_panel.RowStyles.Add(new RowStyle());
            Shoji_panel.Size = new Size(704, 84);
            Shoji_panel.TabIndex = 7;
            // 
            // After_panel
            // 
            After_panel.AutoSize = true;
            After_panel.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            After_panel.Controls.Add(pictureBox15);
            After_panel.Controls.Add(pictureBox16);
            After_panel.Controls.Add(pictureBox18);
            After_panel.Controls.Add(pictureBox6);
            After_panel.Controls.Add(pictureBox7);
            After_panel.Controls.Add(pictureBox8);
            After_panel.Location = new Point(358, 3);
            After_panel.Name = "After_panel";
            After_panel.Size = new Size(343, 78);
            After_panel.TabIndex = 6;
            // 
            // pictureBox15
            // 
            pictureBox15.Image = Properties.Resources.hen;
            pictureBox15.Location = new Point(3, 3);
            pictureBox15.Name = "pictureBox15";
            pictureBox15.Size = new Size(58, 72);
            pictureBox15.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox15.TabIndex = 1;
            pictureBox15.TabStop = false;
            // 
            // pictureBox16
            // 
            pictureBox16.Image = Properties.Resources.kou;
            pictureBox16.Location = new Point(67, 5);
            pictureBox16.Margin = new Padding(3, 5, 3, 3);
            pictureBox16.Name = "pictureBox16";
            pictureBox16.Size = new Size(58, 69);
            pictureBox16.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox16.TabIndex = 2;
            pictureBox16.TabStop = false;
            // 
            // pictureBox18
            // 
            pictureBox18.Image = Properties.Resources.na;
            pictureBox18.Location = new Point(131, 7);
            pictureBox18.Margin = new Padding(3, 7, 3, 3);
            pictureBox18.Name = "pictureBox18";
            pictureBox18.Size = new Size(55, 66);
            pictureBox18.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox18.TabIndex = 4;
            pictureBox18.TabStop = false;
            // 
            // pictureBox6
            // 
            pictureBox6.Image = Properties.Resources.shi;
            pictureBox6.Location = new Point(192, 7);
            pictureBox6.Margin = new Padding(3, 7, 3, 3);
            pictureBox6.Name = "pictureBox6";
            pictureBox6.Size = new Size(46, 65);
            pictureBox6.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox6.TabIndex = 5;
            pictureBox6.TabStop = false;
            // 
            // pictureBox7
            // 
            pictureBox7.Image = Properties.Resources._02;
            pictureBox7.Location = new Point(244, 3);
            pictureBox7.Name = "pictureBox7";
            pictureBox7.Size = new Size(45, 62);
            pictureBox7.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox7.TabIndex = 6;
            pictureBox7.TabStop = false;
            // 
            // pictureBox8
            // 
            pictureBox8.Image = Properties.Resources._02;
            pictureBox8.Location = new Point(295, 3);
            pictureBox8.Name = "pictureBox8";
            pictureBox8.Size = new Size(45, 62);
            pictureBox8.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox8.TabIndex = 7;
            pictureBox8.TabStop = false;
            // 
            // Change_Text_label
            // 
            Change_Text_label.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            Change_Text_label.AutoSize = true;
            Change_Text_label.Font = new Font("メイリオ", 16F, FontStyle.Regular, GraphicsUnit.Point, 128);
            Change_Text_label.Location = new Point(315, 0);
            Change_Text_label.Name = "Change_Text_label";
            Change_Text_label.Size = new Size(37, 84);
            Change_Text_label.TabIndex = 4;
            Change_Text_label.Text = "→";
            Change_Text_label.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Before_panel
            // 
            Before_panel.AutoSize = true;
            Before_panel.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            Before_panel.Controls.Add(pictureBox11);
            Before_panel.Controls.Add(pictureBox12);
            Before_panel.Controls.Add(pictureBox13);
            Before_panel.Controls.Add(pictureBox14);
            Before_panel.Controls.Add(pictureBox2);
            Before_panel.Controls.Add(pictureBox3);
            Before_panel.Location = new Point(3, 3);
            Before_panel.Name = "Before_panel";
            Before_panel.Size = new Size(306, 68);
            Before_panel.TabIndex = 5;
            // 
            // pictureBox11
            // 
            pictureBox11.Image = Properties.Resources._02;
            pictureBox11.Location = new Point(3, 3);
            pictureBox11.Name = "pictureBox11";
            pictureBox11.Size = new Size(45, 62);
            pictureBox11.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox11.TabIndex = 1;
            pictureBox11.TabStop = false;
            // 
            // pictureBox12
            // 
            pictureBox12.Image = Properties.Resources._02;
            pictureBox12.Location = new Point(54, 3);
            pictureBox12.Name = "pictureBox12";
            pictureBox12.Size = new Size(45, 62);
            pictureBox12.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox12.TabIndex = 2;
            pictureBox12.TabStop = false;
            // 
            // pictureBox13
            // 
            pictureBox13.Image = Properties.Resources._02;
            pictureBox13.Location = new Point(105, 3);
            pictureBox13.Name = "pictureBox13";
            pictureBox13.Size = new Size(45, 62);
            pictureBox13.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox13.TabIndex = 3;
            pictureBox13.TabStop = false;
            // 
            // pictureBox14
            // 
            pictureBox14.Image = Properties.Resources._02;
            pictureBox14.Location = new Point(156, 3);
            pictureBox14.Name = "pictureBox14";
            pictureBox14.Size = new Size(45, 62);
            pictureBox14.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox14.TabIndex = 4;
            pictureBox14.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources._02;
            pictureBox2.Location = new Point(207, 3);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(45, 62);
            pictureBox2.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox2.TabIndex = 5;
            pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Resources._02;
            pictureBox3.Location = new Point(258, 3);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(45, 62);
            pictureBox3.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox3.TabIndex = 6;
            pictureBox3.TabStop = false;
            // 
            // Layout_main
            // 
            Layout_main.AutoSize = true;
            Layout_main.ColumnCount = 1;
            Layout_main.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            Layout_main.Controls.Add(Kekka_Text, 0, 0);
            Layout_main.Controls.Add(MainGroupPanel, 0, 1);
            Layout_main.Dock = DockStyle.Fill;
            Layout_main.Location = new Point(0, 0);
            Layout_main.Name = "Layout_main";
            Layout_main.RowCount = 2;
            Layout_main.RowStyles.Add(new RowStyle());
            Layout_main.RowStyles.Add(new RowStyle());
            Layout_main.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            Layout_main.Size = new Size(784, 461);
            Layout_main.TabIndex = 3;
            // 
            // Kekka_Text
            // 
            Kekka_Text.Dock = DockStyle.Fill;
            Kekka_Text.Image = Properties.Resources.kekka_text;
            Kekka_Text.Location = new Point(3, 20);
            Kekka_Text.Margin = new Padding(3, 20, 3, 10);
            Kekka_Text.Name = "Kekka_Text";
            Kekka_Text.Size = new Size(778, 57);
            Kekka_Text.SizeMode = PictureBoxSizeMode.Zoom;
            Kekka_Text.TabIndex = 1;
            Kekka_Text.TabStop = false;
            // 
            // Message_label
            // 
            Message_label.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            Message_label.AutoSize = true;
            Message_label.Font = new Font("游ゴシック", 16F, FontStyle.Bold, GraphicsUnit.Point, 128);
            Message_label.ForeColor = Color.ForestGreen;
            Message_label.Location = new Point(165, 100);
            Message_label.Name = "Message_label";
            Message_label.Size = new Size(452, 29);
            Message_label.TabIndex = 4;
            Message_label.Text = "ウィンドウを閉じると次の試合を開始します";
            // 
            // timer1
            // 
            timer1.Enabled = true;
            timer1.Interval = 1000;
            timer1.Tick += Text_tenmetu;
            // 
            // Result
            // 
            AutoScaleDimensions = new SizeF(7F, 18F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLight;
            ClientSize = new Size(784, 461);
            Controls.Add(Message_label);
            Controls.Add(Layout_main);
            ImeMode = ImeMode.Off;
            MaximizeBox = false;
            MaximumSize = new Size(800, 500);
            MdiChildrenMinimizedAnchorBottom = false;
            MinimizeBox = false;
            Name = "Result";
            SizeGripStyle = SizeGripStyle.Hide;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "浜田「結果発表～～～！！！！！」";
            MainGroupPanel.ResumeLayout(false);
            MainGroupPanel.PerformLayout();
            BJ_panel.ResumeLayout(false);
            BJ_panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)goukei_Text).EndInit();
            Num_panel.ResumeLayout(false);
            Num_panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ((System.ComponentModel.ISupportInitialize)BJ_text).EndInit();
            ((System.ComponentModel.ISupportInitialize)Shoji_text).EndInit();
            Shoji_panel.ResumeLayout(false);
            Shoji_panel.PerformLayout();
            After_panel.ResumeLayout(false);
            After_panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox15).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox16).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox18).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox8).EndInit();
            Before_panel.ResumeLayout(false);
            Before_panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox11).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox12).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox13).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox14).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            Layout_main.ResumeLayout(false);
            Layout_main.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)Kekka_Text).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TableLayoutPanel MainGroupPanel;
        private PictureBox BJ_text;
        private TableLayoutPanel BJ_panel;
        private PictureBox goukei_Text;
        private FlowLayoutPanel Num_panel;
        private PictureBox pictureBox4;
        private PictureBox pictureBox5;
        private TableLayoutPanel Layout_main;
        private TableLayoutPanel Shoji_panel;
        private Label Change_Text_label;
        private PictureBox Shoji_text;
        private FlowLayoutPanel After_panel;
        private PictureBox pictureBox15;
        private PictureBox pictureBox16;
        private PictureBox pictureBox18;
        private FlowLayoutPanel Before_panel;
        private PictureBox pictureBox11;
        private PictureBox pictureBox12;
        private PictureBox pictureBox13;
        private PictureBox pictureBox14;
        private PictureBox pictureBox6;
        private PictureBox pictureBox7;
        private PictureBox pictureBox8;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private PictureBox Kekka_Text;
        private Label Message_label;
        private System.Windows.Forms.Timer timer1;
    }
}