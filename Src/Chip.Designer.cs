namespace BJ
{
    partial class Chip
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
            Enter_Button = new Button();
            tableLayoutPanel1 = new TableLayoutPanel();
            tableLayoutPanel2 = new TableLayoutPanel();
            tableLayoutPanel4 = new TableLayoutPanel();
            Max_Button = new Button();
            Num0_Button = new Button();
            Clear_Button = new Button();
            Num9_Button = new Button();
            Num8_Button = new Button();
            Num7_Button = new Button();
            Num6_Button = new Button();
            Num5_Button = new Button();
            Num4_Button = new Button();
            Num3_Button = new Button();
            Num2_Button = new Button();
            Num1_Button = new Button();
            tableLayoutPanel3 = new TableLayoutPanel();
            Chip_Count = new Label();
            Chip_Text = new Label();
            tableLayoutPanel6 = new TableLayoutPanel();
            tableLayoutPanel8 = new TableLayoutPanel();
            Chip_before = new Label();
            label4 = new Label();
            tableLayoutPanel7 = new TableLayoutPanel();
            label2 = new Label();
            Chip_After = new Label();
            label5 = new Label();
            label1 = new Label();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            tableLayoutPanel4.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            tableLayoutPanel6.SuspendLayout();
            tableLayoutPanel8.SuspendLayout();
            tableLayoutPanel7.SuspendLayout();
            SuspendLayout();
            // 
            // Enter_Button
            // 
            Enter_Button.Anchor = AnchorStyles.Bottom;
            Enter_Button.Cursor = Cursors.Hand;
            Enter_Button.Enabled = false;
            Enter_Button.Location = new Point(58, 197);
            Enter_Button.Name = "Enter_Button";
            Enter_Button.Size = new Size(94, 30);
            Enter_Button.TabIndex = 0;
            Enter_Button.Text = "確定";
            Enter_Button.UseVisualStyleBackColor = true;
            Enter_Button.Click += Enter_Button_Click;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(tableLayoutPanel2, 0, 1);
            tableLayoutPanel1.Controls.Add(label1, 0, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(4, 4);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new Size(439, 271);
            tableLayoutPanel1.TabIndex = 1;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 2;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPanel2.Controls.Add(tableLayoutPanel4, 0, 0);
            tableLayoutPanel2.Controls.Add(tableLayoutPanel3, 1, 0);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(3, 32);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new RowStyle());
            tableLayoutPanel2.Size = new Size(433, 236);
            tableLayoutPanel2.TabIndex = 2;
            // 
            // tableLayoutPanel4
            // 
            tableLayoutPanel4.ColumnCount = 3;
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel4.Controls.Add(Max_Button, 2, 3);
            tableLayoutPanel4.Controls.Add(Num0_Button, 1, 3);
            tableLayoutPanel4.Controls.Add(Clear_Button, 0, 3);
            tableLayoutPanel4.Controls.Add(Num9_Button, 2, 2);
            tableLayoutPanel4.Controls.Add(Num8_Button, 1, 2);
            tableLayoutPanel4.Controls.Add(Num7_Button, 0, 2);
            tableLayoutPanel4.Controls.Add(Num6_Button, 2, 1);
            tableLayoutPanel4.Controls.Add(Num5_Button, 1, 1);
            tableLayoutPanel4.Controls.Add(Num4_Button, 0, 1);
            tableLayoutPanel4.Controls.Add(Num3_Button, 2, 0);
            tableLayoutPanel4.Controls.Add(Num2_Button, 1, 0);
            tableLayoutPanel4.Controls.Add(Num1_Button, 0, 0);
            tableLayoutPanel4.Dock = DockStyle.Fill;
            tableLayoutPanel4.Location = new Point(25, 3);
            tableLayoutPanel4.Margin = new Padding(25, 3, 25, 3);
            tableLayoutPanel4.Name = "tableLayoutPanel4";
            tableLayoutPanel4.RowCount = 4;
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel4.Size = new Size(166, 230);
            tableLayoutPanel4.TabIndex = 2;
            // 
            // Max_Button
            // 
            Max_Button.Cursor = Cursors.Hand;
            Max_Button.Dock = DockStyle.Fill;
            Max_Button.Font = new Font("メイリオ", 9F);
            Max_Button.Location = new Point(110, 181);
            Max_Button.Margin = new Padding(0, 10, 0, 10);
            Max_Button.Name = "Max_Button";
            Max_Button.Size = new Size(56, 39);
            Max_Button.TabIndex = 11;
            Max_Button.TabStop = false;
            Max_Button.Text = "MAX";
            Max_Button.UseVisualStyleBackColor = true;
            Max_Button.Click += Max_Button_Click;
            // 
            // Num0_Button
            // 
            Num0_Button.Cursor = Cursors.Hand;
            Num0_Button.Dock = DockStyle.Fill;
            Num0_Button.Font = new Font("メイリオ", 10F);
            Num0_Button.Location = new Point(63, 179);
            Num0_Button.Margin = new Padding(8);
            Num0_Button.Name = "Num0_Button";
            Num0_Button.Size = new Size(39, 43);
            Num0_Button.TabIndex = 10;
            Num0_Button.TabStop = false;
            Num0_Button.Text = "0";
            Num0_Button.UseVisualStyleBackColor = true;
            Num0_Button.Click += Num0_Button_Click;
            // 
            // Clear_Button
            // 
            Clear_Button.Cursor = Cursors.Hand;
            Clear_Button.Dock = DockStyle.Fill;
            Clear_Button.Font = new Font("メイリオ", 9F);
            Clear_Button.Location = new Point(0, 181);
            Clear_Button.Margin = new Padding(0, 10, 0, 10);
            Clear_Button.Name = "Clear_Button";
            Clear_Button.Size = new Size(55, 39);
            Clear_Button.TabIndex = 9;
            Clear_Button.TabStop = false;
            Clear_Button.Text = "クリア";
            Clear_Button.UseVisualStyleBackColor = true;
            Clear_Button.Click += Clear_Button_Click;
            // 
            // Num9_Button
            // 
            Num9_Button.Cursor = Cursors.Hand;
            Num9_Button.Dock = DockStyle.Fill;
            Num9_Button.Font = new Font("メイリオ", 10F);
            Num9_Button.Location = new Point(118, 122);
            Num9_Button.Margin = new Padding(8);
            Num9_Button.Name = "Num9_Button";
            Num9_Button.Size = new Size(40, 41);
            Num9_Button.TabIndex = 8;
            Num9_Button.TabStop = false;
            Num9_Button.Text = "9";
            Num9_Button.UseVisualStyleBackColor = true;
            Num9_Button.Click += Num9_Button_Click;
            // 
            // Num8_Button
            // 
            Num8_Button.Cursor = Cursors.Hand;
            Num8_Button.Dock = DockStyle.Fill;
            Num8_Button.Font = new Font("メイリオ", 10F);
            Num8_Button.Location = new Point(63, 122);
            Num8_Button.Margin = new Padding(8);
            Num8_Button.Name = "Num8_Button";
            Num8_Button.Size = new Size(39, 41);
            Num8_Button.TabIndex = 7;
            Num8_Button.TabStop = false;
            Num8_Button.Text = "8";
            Num8_Button.UseVisualStyleBackColor = true;
            Num8_Button.Click += Num8_Button_Click;
            // 
            // Num7_Button
            // 
            Num7_Button.Cursor = Cursors.Hand;
            Num7_Button.Dock = DockStyle.Fill;
            Num7_Button.Font = new Font("メイリオ", 10F);
            Num7_Button.Location = new Point(8, 122);
            Num7_Button.Margin = new Padding(8);
            Num7_Button.Name = "Num7_Button";
            Num7_Button.Size = new Size(39, 41);
            Num7_Button.TabIndex = 6;
            Num7_Button.TabStop = false;
            Num7_Button.Text = "7";
            Num7_Button.UseVisualStyleBackColor = true;
            Num7_Button.Click += Num7_Button_Click;
            // 
            // Num6_Button
            // 
            Num6_Button.Cursor = Cursors.Hand;
            Num6_Button.Dock = DockStyle.Fill;
            Num6_Button.Font = new Font("メイリオ", 10F);
            Num6_Button.Location = new Point(118, 65);
            Num6_Button.Margin = new Padding(8);
            Num6_Button.Name = "Num6_Button";
            Num6_Button.Size = new Size(40, 41);
            Num6_Button.TabIndex = 5;
            Num6_Button.TabStop = false;
            Num6_Button.Text = "6";
            Num6_Button.UseVisualStyleBackColor = true;
            Num6_Button.Click += Num6_Button_Click;
            // 
            // Num5_Button
            // 
            Num5_Button.Cursor = Cursors.Hand;
            Num5_Button.Dock = DockStyle.Fill;
            Num5_Button.Font = new Font("メイリオ", 10F);
            Num5_Button.Location = new Point(63, 65);
            Num5_Button.Margin = new Padding(8);
            Num5_Button.Name = "Num5_Button";
            Num5_Button.Size = new Size(39, 41);
            Num5_Button.TabIndex = 4;
            Num5_Button.TabStop = false;
            Num5_Button.Text = "5";
            Num5_Button.UseVisualStyleBackColor = true;
            Num5_Button.Click += Num5_Button_Click;
            // 
            // Num4_Button
            // 
            Num4_Button.Cursor = Cursors.Hand;
            Num4_Button.Dock = DockStyle.Fill;
            Num4_Button.Font = new Font("メイリオ", 10F);
            Num4_Button.Location = new Point(8, 65);
            Num4_Button.Margin = new Padding(8);
            Num4_Button.Name = "Num4_Button";
            Num4_Button.Size = new Size(39, 41);
            Num4_Button.TabIndex = 3;
            Num4_Button.TabStop = false;
            Num4_Button.Text = "4";
            Num4_Button.UseVisualStyleBackColor = true;
            Num4_Button.Click += Num4_Button_Click;
            // 
            // Num3_Button
            // 
            Num3_Button.Cursor = Cursors.Hand;
            Num3_Button.Dock = DockStyle.Fill;
            Num3_Button.Font = new Font("メイリオ", 10F);
            Num3_Button.Location = new Point(118, 8);
            Num3_Button.Margin = new Padding(8);
            Num3_Button.Name = "Num3_Button";
            Num3_Button.Size = new Size(40, 41);
            Num3_Button.TabIndex = 2;
            Num3_Button.TabStop = false;
            Num3_Button.Text = "3";
            Num3_Button.UseVisualStyleBackColor = true;
            Num3_Button.Click += Num3_Button_Click;
            // 
            // Num2_Button
            // 
            Num2_Button.Cursor = Cursors.Hand;
            Num2_Button.Dock = DockStyle.Fill;
            Num2_Button.Font = new Font("メイリオ", 10F);
            Num2_Button.Location = new Point(63, 8);
            Num2_Button.Margin = new Padding(8);
            Num2_Button.Name = "Num2_Button";
            Num2_Button.Size = new Size(39, 41);
            Num2_Button.TabIndex = 1;
            Num2_Button.TabStop = false;
            Num2_Button.Text = "2";
            Num2_Button.UseVisualStyleBackColor = true;
            Num2_Button.Click += Num2_Button_Click;
            // 
            // Num1_Button
            // 
            Num1_Button.Cursor = Cursors.Hand;
            Num1_Button.Dock = DockStyle.Fill;
            Num1_Button.Font = new Font("メイリオ", 10F);
            Num1_Button.Location = new Point(8, 8);
            Num1_Button.Margin = new Padding(8);
            Num1_Button.Name = "Num1_Button";
            Num1_Button.Size = new Size(39, 41);
            Num1_Button.TabIndex = 0;
            Num1_Button.TabStop = false;
            Num1_Button.Text = "1";
            Num1_Button.UseVisualStyleBackColor = true;
            Num1_Button.Click += Num1_Button_Click;
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.ColumnCount = 1;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel3.Controls.Add(Chip_Count, 0, 1);
            tableLayoutPanel3.Controls.Add(Chip_Text, 0, 2);
            tableLayoutPanel3.Controls.Add(Enter_Button, 0, 3);
            tableLayoutPanel3.Controls.Add(tableLayoutPanel6, 0, 0);
            tableLayoutPanel3.Dock = DockStyle.Fill;
            tableLayoutPanel3.Location = new Point(219, 3);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 4;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Absolute, 101F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 51.9379845F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 16.27907F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 31.0077515F));
            tableLayoutPanel3.Size = new Size(211, 230);
            tableLayoutPanel3.TabIndex = 2;
            // 
            // Chip_Count
            // 
            Chip_Count.AutoSize = true;
            Chip_Count.Dock = DockStyle.Bottom;
            Chip_Count.Font = new Font("HG明朝B", 32F);
            Chip_Count.Location = new Point(3, 125);
            Chip_Count.Name = "Chip_Count";
            Chip_Count.Size = new Size(205, 43);
            Chip_Count.TabIndex = 1;
            Chip_Count.Text = "0";
            Chip_Count.TextAlign = ContentAlignment.BottomCenter;
            Chip_Count.TextChanged += Chip_Change;
            // 
            // Chip_Text
            // 
            Chip_Text.AutoSize = true;
            Chip_Text.Dock = DockStyle.Bottom;
            Chip_Text.Location = new Point(3, 171);
            Chip_Text.Name = "Chip_Text";
            Chip_Text.Size = new Size(205, 18);
            Chip_Text.TabIndex = 2;
            Chip_Text.Text = "チップ";
            Chip_Text.TextAlign = ContentAlignment.BottomCenter;
            // 
            // tableLayoutPanel6
            // 
            tableLayoutPanel6.ColumnCount = 1;
            tableLayoutPanel6.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel6.Controls.Add(tableLayoutPanel8, 0, 0);
            tableLayoutPanel6.Controls.Add(tableLayoutPanel7, 0, 1);
            tableLayoutPanel6.Location = new Point(3, 3);
            tableLayoutPanel6.Name = "tableLayoutPanel6";
            tableLayoutPanel6.RowCount = 2;
            tableLayoutPanel6.RowStyles.Add(new RowStyle());
            tableLayoutPanel6.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel6.Size = new Size(200, 95);
            tableLayoutPanel6.TabIndex = 2;
            // 
            // tableLayoutPanel8
            // 
            tableLayoutPanel8.ColumnCount = 2;
            tableLayoutPanel8.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 145F));
            tableLayoutPanel8.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel8.Controls.Add(Chip_before, 0, 0);
            tableLayoutPanel8.Controls.Add(label4, 1, 0);
            tableLayoutPanel8.Dock = DockStyle.Fill;
            tableLayoutPanel8.Location = new Point(3, 3);
            tableLayoutPanel8.Name = "tableLayoutPanel8";
            tableLayoutPanel8.RowCount = 1;
            tableLayoutPanel8.RowStyles.Add(new RowStyle(SizeType.Absolute, 45F));
            tableLayoutPanel8.Size = new Size(194, 41);
            tableLayoutPanel8.TabIndex = 4;
            // 
            // Chip_before
            // 
            Chip_before.Dock = DockStyle.Fill;
            Chip_before.Font = new Font("HG明朝B", 30F);
            Chip_before.Location = new Point(0, 0);
            Chip_before.Margin = new Padding(0);
            Chip_before.Name = "Chip_before";
            Chip_before.Size = new Size(145, 45);
            Chip_before.TabIndex = 2;
            Chip_before.Text = "999";
            Chip_before.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            label4.Dock = DockStyle.Bottom;
            label4.Location = new Point(148, 27);
            label4.Name = "label4";
            label4.Size = new Size(77, 18);
            label4.TabIndex = 4;
            label4.Text = "チップ";
            label4.TextAlign = ContentAlignment.BottomLeft;
            // 
            // tableLayoutPanel7
            // 
            tableLayoutPanel7.ColumnCount = 3;
            tableLayoutPanel7.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 35F));
            tableLayoutPanel7.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 110F));
            tableLayoutPanel7.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPanel7.Controls.Add(label2, 0, 0);
            tableLayoutPanel7.Controls.Add(Chip_After, 1, 0);
            tableLayoutPanel7.Controls.Add(label5, 2, 0);
            tableLayoutPanel7.Dock = DockStyle.Fill;
            tableLayoutPanel7.Location = new Point(3, 50);
            tableLayoutPanel7.Name = "tableLayoutPanel7";
            tableLayoutPanel7.RowCount = 1;
            tableLayoutPanel7.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
            tableLayoutPanel7.Size = new Size(194, 42);
            tableLayoutPanel7.TabIndex = 4;
            // 
            // label2
            // 
            label2.Dock = DockStyle.Top;
            label2.Font = new Font("メイリオ", 24F);
            label2.Location = new Point(10, 0);
            label2.Margin = new Padding(10, 0, 0, 0);
            label2.Name = "label2";
            label2.Size = new Size(25, 42);
            label2.TabIndex = 5;
            label2.Text = "↳";
            label2.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // Chip_After
            // 
            Chip_After.Dock = DockStyle.Fill;
            Chip_After.Font = new Font("HG明朝B", 30F);
            Chip_After.Location = new Point(35, 0);
            Chip_After.Margin = new Padding(0);
            Chip_After.Name = "Chip_After";
            Chip_After.Size = new Size(110, 42);
            Chip_After.TabIndex = 3;
            Chip_After.Text = "999";
            Chip_After.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label5
            // 
            label5.Dock = DockStyle.Bottom;
            label5.Location = new Point(145, 18);
            label5.Margin = new Padding(0);
            label5.Name = "label5";
            label5.Size = new Size(49, 24);
            label5.TabIndex = 5;
            label5.Text = "チップ";
            label5.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Dock = DockStyle.Fill;
            label1.Font = new Font("ヒラギノ角ゴ Pr6N W6", 16F);
            label1.Location = new Point(3, 0);
            label1.Name = "label1";
            label1.Size = new Size(433, 29);
            label1.TabIndex = 2;
            label1.Text = "賭けるチップの枚数を決めてください";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Chip
            // 
            AutoScaleDimensions = new SizeF(7F, 18F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            ClientSize = new Size(447, 279);
            Controls.Add(tableLayoutPanel1);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Chip";
            Padding = new Padding(4);
            ShowIcon = false;
            SizeGripStyle = SizeGripStyle.Hide;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "チップ確定";
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel4.ResumeLayout(false);
            tableLayoutPanel3.ResumeLayout(false);
            tableLayoutPanel3.PerformLayout();
            tableLayoutPanel6.ResumeLayout(false);
            tableLayoutPanel8.ResumeLayout(false);
            tableLayoutPanel7.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Button Enter_Button;
        private TableLayoutPanel tableLayoutPanel1;
        private Label label1;
        private TableLayoutPanel tableLayoutPanel2;
        private TableLayoutPanel tableLayoutPanel3;
        private TableLayoutPanel tableLayoutPanel4;
        private Button Num1_Button;
        private Label Chip_Count;
        private Label Chip_Text;
        private Button Num2_Button;
        private Button Num5_Button;
        private Button Num4_Button;
        private Button Num3_Button;
        private Button Num9_Button;
        private Button Num8_Button;
        private Button Num7_Button;
        private Button Num6_Button;
        private Button Clear_Button;
        private Button Max_Button;
        private Button Num0_Button;
        private Label label5;
        private Label label4;
        private Label Chip_After;
        private Label Chip_before;
        private TableLayoutPanel tableLayoutPanel6;
        private TableLayoutPanel tableLayoutPanel7;
        private Label label2;
        private TableLayoutPanel tableLayoutPanel8;
    }
}