namespace BJ
{
    partial class Game
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
            User_Card_Grid = new GroupBox();
            User_Card = new FlowLayoutPanel();
            Dealer_Card_Grid = new GroupBox();
            Dealer_Card = new FlowLayoutPanel();
            User_Total_Text = new Label();
            User_Total_Count = new Label();
            tableLayoutPanel1 = new TableLayoutPanel();
            tableLayoutPanel2 = new TableLayoutPanel();
            Dealer_Total_Count = new Label();
            Dealer_Total_Text = new Label();
            hit_Button = new Button();
            tableLayoutPanel3 = new TableLayoutPanel();
            doubleDown_Button = new Button();
            stand_Button = new Button();
            battle_Chip_Count = new Label();
            label3 = new Label();
            Chip_Count = new Label();
            label2 = new Label();
            tableLayoutPanel5 = new TableLayoutPanel();
            button1 = new Button();
            User_Card_Grid.SuspendLayout();
            Dealer_Card_Grid.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            tableLayoutPanel5.SuspendLayout();
            SuspendLayout();
            // 
            // User_Card_Grid
            // 
            User_Card_Grid.Controls.Add(User_Card);
            User_Card_Grid.Location = new Point(200, 370);
            User_Card_Grid.Name = "User_Card_Grid";
            User_Card_Grid.Size = new Size(400, 100);
            User_Card_Grid.TabIndex = 0;
            User_Card_Grid.TabStop = false;
            User_Card_Grid.Text = "あなたの手札";
            // 
            // User_Card
            // 
            User_Card.AutoSize = true;
            User_Card.Dock = DockStyle.Fill;
            User_Card.Font = new Font("メイリオ", 16F);
            User_Card.Location = new Point(3, 21);
            User_Card.Name = "User_Card";
            User_Card.Size = new Size(394, 76);
            User_Card.TabIndex = 0;
            // 
            // Dealer_Card_Grid
            // 
            Dealer_Card_Grid.Controls.Add(Dealer_Card);
            Dealer_Card_Grid.Enabled = false;
            Dealer_Card_Grid.Location = new Point(200, 12);
            Dealer_Card_Grid.Name = "Dealer_Card_Grid";
            Dealer_Card_Grid.Size = new Size(400, 100);
            Dealer_Card_Grid.TabIndex = 1;
            Dealer_Card_Grid.TabStop = false;
            Dealer_Card_Grid.Text = "ディーラー";
            // 
            // Dealer_Card
            // 
            Dealer_Card.AutoSize = true;
            Dealer_Card.Dock = DockStyle.Fill;
            Dealer_Card.Font = new Font("メイリオ", 16F);
            Dealer_Card.Location = new Point(3, 21);
            Dealer_Card.Name = "Dealer_Card";
            Dealer_Card.Size = new Size(394, 76);
            Dealer_Card.TabIndex = 0;
            // 
            // User_Total_Text
            // 
            User_Total_Text.AutoSize = true;
            User_Total_Text.Dock = DockStyle.Bottom;
            User_Total_Text.Font = new Font("メイリオ", 12F);
            User_Total_Text.Location = new Point(3, 4);
            User_Total_Text.Name = "User_Total_Text";
            User_Total_Text.Size = new Size(66, 24);
            User_Total_Text.TabIndex = 2;
            User_Total_Text.Text = "合計";
            User_Total_Text.TextAlign = ContentAlignment.BottomCenter;
            // 
            // User_Total_Count
            // 
            User_Total_Count.AutoSize = true;
            User_Total_Count.Dock = DockStyle.Fill;
            User_Total_Count.Font = new Font("メイリオ", 24F);
            User_Total_Count.Location = new Point(3, 28);
            User_Total_Count.Name = "User_Total_Count";
            User_Total_Count.Size = new Size(66, 48);
            User_Total_Count.TabIndex = 3;
            User_Total_Count.Text = "0";
            User_Total_Count.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Controls.Add(User_Total_Count, 0, 1);
            tableLayoutPanel1.Controls.Add(User_Total_Text, 0, 0);
            tableLayoutPanel1.Location = new Point(636, 391);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.Size = new Size(72, 76);
            tableLayoutPanel1.TabIndex = 6;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 1;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.Controls.Add(Dealer_Total_Count, 0, 1);
            tableLayoutPanel2.Controls.Add(Dealer_Total_Text, 0, 0);
            tableLayoutPanel2.Location = new Point(636, 33);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 2;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle());
            tableLayoutPanel2.Size = new Size(72, 76);
            tableLayoutPanel2.TabIndex = 7;
            // 
            // Dealer_Total_Count
            // 
            Dealer_Total_Count.AutoSize = true;
            Dealer_Total_Count.Dock = DockStyle.Fill;
            Dealer_Total_Count.Font = new Font("メイリオ", 24F);
            Dealer_Total_Count.Location = new Point(3, 28);
            Dealer_Total_Count.Name = "Dealer_Total_Count";
            Dealer_Total_Count.Size = new Size(66, 48);
            Dealer_Total_Count.TabIndex = 3;
            Dealer_Total_Count.Text = "0";
            Dealer_Total_Count.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Dealer_Total_Text
            // 
            Dealer_Total_Text.AutoSize = true;
            Dealer_Total_Text.Dock = DockStyle.Bottom;
            Dealer_Total_Text.Font = new Font("メイリオ", 12F);
            Dealer_Total_Text.Location = new Point(3, 4);
            Dealer_Total_Text.Name = "Dealer_Total_Text";
            Dealer_Total_Text.Size = new Size(66, 24);
            Dealer_Total_Text.TabIndex = 2;
            Dealer_Total_Text.Text = "合計";
            Dealer_Total_Text.TextAlign = ContentAlignment.BottomCenter;
            // 
            // hit_Button
            // 
            hit_Button.Font = new Font("メイリオ", 12F);
            hit_Button.Location = new Point(10, 3);
            hit_Button.Margin = new Padding(10, 3, 10, 3);
            hit_Button.Name = "hit_Button";
            hit_Button.Size = new Size(75, 40);
            hit_Button.TabIndex = 1;
            hit_Button.Text = "ヒット";
            hit_Button.UseVisualStyleBackColor = true;
            hit_Button.Click += Hit_Button_Click;
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.AutoSize = true;
            tableLayoutPanel3.ColumnCount = 3;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel3.Controls.Add(doubleDown_Button, 2, 0);
            tableLayoutPanel3.Controls.Add(stand_Button, 1, 0);
            tableLayoutPanel3.Controls.Add(hit_Button, 0, 0);
            tableLayoutPanel3.Location = new Point(227, 307);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 1;
            tableLayoutPanel3.RowStyles.Add(new RowStyle());
            tableLayoutPanel3.Size = new Size(345, 46);
            tableLayoutPanel3.TabIndex = 9;
            // 
            // doubleDown_Button
            // 
            doubleDown_Button.Font = new Font("メイリオ", 12F);
            doubleDown_Button.Location = new Point(215, 3);
            doubleDown_Button.Margin = new Padding(10, 3, 10, 3);
            doubleDown_Button.Name = "doubleDown_Button";
            doubleDown_Button.Size = new Size(120, 40);
            doubleDown_Button.TabIndex = 10;
            doubleDown_Button.Text = "ダブルダウン";
            doubleDown_Button.UseVisualStyleBackColor = true;
            doubleDown_Button.Click += doubleDown_Button_Click;
            // 
            // stand_Button
            // 
            stand_Button.Font = new Font("メイリオ", 12F);
            stand_Button.Location = new Point(105, 3);
            stand_Button.Margin = new Padding(10, 3, 10, 3);
            stand_Button.Name = "stand_Button";
            stand_Button.Size = new Size(90, 40);
            stand_Button.TabIndex = 9;
            stand_Button.Text = "スタンド";
            stand_Button.UseVisualStyleBackColor = true;
            stand_Button.Click += stand_Button_Click;
            // 
            // battle_Chip_Count
            // 
            battle_Chip_Count.Dock = DockStyle.Fill;
            battle_Chip_Count.Font = new Font("HG明朝B", 28F);
            battle_Chip_Count.Location = new Point(3, 85);
            battle_Chip_Count.Name = "battle_Chip_Count";
            battle_Chip_Count.Size = new Size(176, 44);
            battle_Chip_Count.TabIndex = 5;
            battle_Chip_Count.Text = "999999";
            battle_Chip_Count.TextAlign = ContentAlignment.MiddleCenter;
            battle_Chip_Count.Click += battle_Chip_Count_Click;
            // 
            // label3
            // 
            label3.Dock = DockStyle.Bottom;
            label3.Font = new Font("メイリオ", 10F);
            label3.Location = new Point(3, 64);
            label3.Name = "label3";
            label3.Size = new Size(176, 21);
            label3.TabIndex = 4;
            label3.Text = "賭け金";
            label3.TextAlign = ContentAlignment.BottomCenter;
            // 
            // Chip_Count
            // 
            Chip_Count.Dock = DockStyle.Fill;
            Chip_Count.Font = new Font("HG明朝B", 28F);
            Chip_Count.Location = new Point(3, 21);
            Chip_Count.Name = "Chip_Count";
            Chip_Count.Size = new Size(176, 43);
            Chip_Count.TabIndex = 3;
            Chip_Count.Text = "999999";
            Chip_Count.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.Dock = DockStyle.Bottom;
            label2.Font = new Font("メイリオ", 10F);
            label2.Location = new Point(3, 0);
            label2.Name = "label2";
            label2.Size = new Size(176, 21);
            label2.TabIndex = 2;
            label2.Text = "手持ち";
            label2.TextAlign = ContentAlignment.BottomCenter;
            // 
            // tableLayoutPanel5
            // 
            tableLayoutPanel5.ColumnCount = 1;
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel5.Controls.Add(label2, 0, 0);
            tableLayoutPanel5.Controls.Add(Chip_Count, 0, 1);
            tableLayoutPanel5.Controls.Add(battle_Chip_Count, 0, 3);
            tableLayoutPanel5.Controls.Add(label3, 0, 2);
            tableLayoutPanel5.Location = new Point(12, 328);
            tableLayoutPanel5.Name = "tableLayoutPanel5";
            tableLayoutPanel5.RowCount = 4;
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Percent, 16.666666F));
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Percent, 16.666666F));
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel5.Size = new Size(182, 129);
            tableLayoutPanel5.TabIndex = 11;
            // 
            // button1
            // 
            button1.Location = new Point(645, 215);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 14;
            button1.TabStop = false;
            button1.Text = "テスト";
            button1.UseVisualStyleBackColor = true;
            button1.Click += test_Click;
            // 
            // Game
            // 
            AutoScaleDimensions = new SizeF(7F, 18F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLight;
            ClientSize = new Size(784, 461);
            Controls.Add(button1);
            Controls.Add(tableLayoutPanel5);
            Controls.Add(tableLayoutPanel3);
            Controls.Add(tableLayoutPanel2);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(Dealer_Card_Grid);
            Controls.Add(User_Card_Grid);
            DoubleBuffered = true;
            ImeMode = ImeMode.Off;
            MaximizeBox = false;
            MaximumSize = new Size(800, 500);
            MinimumSize = new Size(800, 500);
            Name = "Game";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ゲーム開始　1回目";
            User_Card_Grid.ResumeLayout(false);
            User_Card_Grid.PerformLayout();
            Dealer_Card_Grid.ResumeLayout(false);
            Dealer_Card_Grid.PerformLayout();
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            tableLayoutPanel3.ResumeLayout(false);
            tableLayoutPanel5.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox User_Card_Grid;
        private GroupBox Dealer_Card_Grid;
        private Label User_Total_Text;
        private Label User_Total_Count;
        private FlowLayoutPanel User_Card;
        private FlowLayoutPanel Dealer_Card;
        private TableLayoutPanel tableLayoutPanel1;
        private TableLayoutPanel tableLayoutPanel2;
        private Label Dealer_Total_Count;
        private Label Dealer_Total_Text;
        private Button hit_Button;
        private TableLayoutPanel tableLayoutPanel3;
        private Button doubleDown_Button;
        private Button stand_Button;
        private Label battle_Chip_Count;
        private Label label3;
        private Label Chip_Count;
        private Label label2;
        private TableLayoutPanel tableLayoutPanel5;
        private Button button1;
    }
}