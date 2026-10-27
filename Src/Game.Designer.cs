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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Game));
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
            Select_Action_Panel = new TableLayoutPanel();
            doubleDown_Button = new Button();
            stand_Button = new Button();
            battle_Chip_Count = new Label();
            label3 = new Label();
            Chip_Count = new Label();
            label2 = new Label();
            tableLayoutPanel5 = new TableLayoutPanel();
            button1 = new Button();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            Num_Panel = new FlowLayoutPanel();
            Num_10 = new PictureBox();
            Num_01 = new PictureBox();
            Table = new TableLayoutPanel();
            Table2 = new TableLayoutPanel();
            pictureBox3 = new PictureBox();
            Chip_count2 = new Label();
            VS_text = new BJ.Src.RotatableLabel();
            Play_Count = new Label();
            tableLayoutPanel3 = new TableLayoutPanel();
            label6 = new Label();
            Play_Count_Max = new Label();
            label4 = new Label();
            User_Card_Grid.SuspendLayout();
            Dealer_Card_Grid.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            Select_Action_Panel.SuspendLayout();
            tableLayoutPanel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            Num_Panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)Num_10).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Num_01).BeginInit();
            Table.SuspendLayout();
            Table2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            tableLayoutPanel3.SuspendLayout();
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
            Dealer_Card.ControlAdded += Dealer_Total_Calc;
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
            User_Total_Count.TextChanged += Total_Change;
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
            hit_Button.Click += Button_Action;
            // 
            // Select_Action_Panel
            // 
            Select_Action_Panel.AutoSize = true;
            Select_Action_Panel.ColumnCount = 3;
            Select_Action_Panel.ColumnStyles.Add(new ColumnStyle());
            Select_Action_Panel.ColumnStyles.Add(new ColumnStyle());
            Select_Action_Panel.ColumnStyles.Add(new ColumnStyle());
            Select_Action_Panel.Controls.Add(doubleDown_Button, 2, 0);
            Select_Action_Panel.Controls.Add(stand_Button, 1, 0);
            Select_Action_Panel.Controls.Add(hit_Button, 0, 0);
            Select_Action_Panel.Location = new Point(227, 307);
            Select_Action_Panel.Name = "Select_Action_Panel";
            Select_Action_Panel.RowCount = 1;
            Select_Action_Panel.RowStyles.Add(new RowStyle());
            Select_Action_Panel.Size = new Size(345, 46);
            Select_Action_Panel.TabIndex = 9;
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
            doubleDown_Button.Click += Button_Action;
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
            stand_Button.Click += Button_Action;
            // 
            // battle_Chip_Count
            // 
            battle_Chip_Count.BackColor = SystemColors.ControlLight;
            battle_Chip_Count.Cursor = Cursors.Help;
            battle_Chip_Count.Dock = DockStyle.Fill;
            battle_Chip_Count.Font = new Font("HG明朝B", 28F);
            battle_Chip_Count.Location = new Point(0, 85);
            battle_Chip_Count.Margin = new Padding(0);
            battle_Chip_Count.Name = "battle_Chip_Count";
            battle_Chip_Count.Size = new Size(182, 44);
            battle_Chip_Count.TabIndex = 5;
            battle_Chip_Count.Text = "999999";
            battle_Chip_Count.TextAlign = ContentAlignment.MiddleCenter;
            battle_Chip_Count.Click += Battle_Chip_Count_Click;
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
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.DoubleDown_text;
            pictureBox1.Location = new Point(-400, 190);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(395, 50);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 15;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Dock = DockStyle.Bottom;
            pictureBox2.Image = Properties.Resources.Total_value;
            pictureBox2.Location = new Point(0, 36);
            pictureBox2.Margin = new Padding(0);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(110, 28);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 16;
            pictureBox2.TabStop = false;
            // 
            // Num_Panel
            // 
            Num_Panel.Controls.Add(Num_10);
            Num_Panel.Controls.Add(Num_01);
            Num_Panel.Dock = DockStyle.Top;
            Num_Panel.Location = new Point(110, 0);
            Num_Panel.Margin = new Padding(0);
            Num_Panel.Name = "Num_Panel";
            Num_Panel.Size = new Size(115, 64);
            Num_Panel.TabIndex = 17;
            // 
            // Num_10
            // 
            Num_10.Dock = DockStyle.Left;
            Num_10.Image = Properties.Resources._02;
            Num_10.Location = new Point(0, 0);
            Num_10.Margin = new Padding(0);
            Num_10.Name = "Num_10";
            Num_10.Size = new Size(45, 63);
            Num_10.SizeMode = PictureBoxSizeMode.AutoSize;
            Num_10.TabIndex = 17;
            Num_10.TabStop = false;
            // 
            // Num_01
            // 
            Num_01.BackColor = SystemColors.ControlLight;
            Num_01.Dock = DockStyle.Left;
            Num_01.Image = Properties.Resources._08;
            Num_01.Location = new Point(48, 0);
            Num_01.Margin = new Padding(3, 0, 0, 0);
            Num_01.Name = "Num_01";
            Num_01.Size = new Size(44, 63);
            Num_01.SizeMode = PictureBoxSizeMode.AutoSize;
            Num_01.TabIndex = 18;
            Num_01.TabStop = false;
            // 
            // Table
            // 
            Table.AutoSize = true;
            Table.ColumnCount = 2;
            Table.ColumnStyles.Add(new ColumnStyle());
            Table.ColumnStyles.Add(new ColumnStyle());
            Table.Controls.Add(pictureBox2, 0, 0);
            Table.Controls.Add(Num_Panel, 1, 0);
            Table.Location = new Point(290, 200);
            Table.Margin = new Padding(0);
            Table.Name = "Table";
            Table.RowCount = 1;
            Table.RowStyles.Add(new RowStyle());
            Table.Size = new Size(225, 64);
            Table.TabIndex = 18;
            Table.Visible = false;
            // 
            // Table2
            // 
            Table2.AutoSize = true;
            Table2.ColumnCount = 1;
            Table2.ColumnStyles.Add(new ColumnStyle());
            Table2.Controls.Add(pictureBox3, 0, 0);
            Table2.Controls.Add(Chip_count2, 0, 1);
            Table2.Location = new Point(200, 170);
            Table2.Margin = new Padding(0);
            Table2.Name = "Table2";
            Table2.RowCount = 2;
            Table2.RowStyles.Add(new RowStyle());
            Table2.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
            Table2.Size = new Size(397, 94);
            Table2.TabIndex = 19;
            Table2.Visible = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Dock = DockStyle.Fill;
            pictureBox3.Image = Properties.Resources.battle_Chip_text;
            pictureBox3.Location = new Point(3, 3);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(391, 28);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 16;
            pictureBox3.TabStop = false;
            // 
            // Chip_count2
            // 
            Chip_count2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            Chip_count2.AutoSize = true;
            Chip_count2.Font = new Font("HG明朝E", 40F, FontStyle.Regular, GraphicsUnit.Point, 128);
            Chip_count2.Location = new Point(146, 34);
            Chip_count2.Name = "Chip_count2";
            Chip_count2.Size = new Size(104, 60);
            Chip_count2.TabIndex = 17;
            Chip_count2.Text = "123";
            Chip_count2.TextAlign = ContentAlignment.TopCenter;
            // 
            // VS_text
            // 
            VS_text.Angle = -360F;
            VS_text.BackColor = Color.Transparent;
            VS_text.Font = new Font("游ゴシック", 24F, FontStyle.Bold, GraphicsUnit.Point, 128);
            VS_text.Location = new Point(636, 271);
            VS_text.Margin = new Padding(0);
            VS_text.Name = "VS_text";
            VS_text.Scale = 400;
            VS_text.Size = new Size(400, 124);
            VS_text.TabIndex = 20;
            VS_text.TabStop = false;
            VS_text.Text = "勝負!";
            VS_text.Visible = false;
            // 
            // Play_Count
            // 
            Play_Count.AutoSize = true;
            Play_Count.Dock = DockStyle.Fill;
            Play_Count.Location = new Point(3, 0);
            Play_Count.Name = "Play_Count";
            Play_Count.Size = new Size(15, 18);
            Play_Count.TabIndex = 21;
            Play_Count.Text = "1";
            Play_Count.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.AutoSize = true;
            tableLayoutPanel3.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            tableLayoutPanel3.ColumnCount = 4;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel3.Controls.Add(label6, 3, 0);
            tableLayoutPanel3.Controls.Add(Play_Count_Max, 2, 0);
            tableLayoutPanel3.Controls.Add(label4, 1, 0);
            tableLayoutPanel3.Controls.Add(Play_Count, 0, 0);
            tableLayoutPanel3.Location = new Point(15, 12);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 1;
            tableLayoutPanel3.RowStyles.Add(new RowStyle());
            tableLayoutPanel3.Size = new Size(125, 18);
            tableLayoutPanel3.TabIndex = 22;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Dock = DockStyle.Fill;
            label6.Location = new Point(78, 0);
            label6.Name = "label6";
            label6.Size = new Size(44, 18);
            label6.TabIndex = 24;
            label6.Text = "かいめ";
            // 
            // Play_Count_Max
            // 
            Play_Count_Max.AutoSize = true;
            Play_Count_Max.Dock = DockStyle.Fill;
            Play_Count_Max.Location = new Point(43, 0);
            Play_Count_Max.Name = "Play_Count_Max";
            Play_Count_Max.Size = new Size(29, 18);
            Play_Count_Max.TabIndex = 23;
            Play_Count_Max.Text = "999";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Dock = DockStyle.Fill;
            label4.Location = new Point(24, 0);
            label4.Name = "label4";
            label4.Size = new Size(13, 18);
            label4.TabIndex = 22;
            label4.Text = "/";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Game
            // 
            AutoScaleDimensions = new SizeF(7F, 18F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLight;
            BackgroundImageLayout = ImageLayout.None;
            ClientSize = new Size(792, 469);
            Controls.Add(tableLayoutPanel3);
            Controls.Add(VS_text);
            Controls.Add(Table2);
            Controls.Add(Table);
            Controls.Add(pictureBox1);
            Controls.Add(button1);
            Controls.Add(tableLayoutPanel5);
            Controls.Add(Select_Action_Panel);
            Controls.Add(tableLayoutPanel2);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(Dealer_Card_Grid);
            Controls.Add(User_Card_Grid);
            Icon = (Icon)resources.GetObject("$this.Icon");
            ImeMode = ImeMode.Off;
            MaximizeBox = false;
            MaximumSize = new Size(800, 500);
            MinimumSize = new Size(800, 500);
            Name = "Game";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ゲーム開始";
            FormClosing += Exit_Check;
            User_Card_Grid.ResumeLayout(false);
            User_Card_Grid.PerformLayout();
            Dealer_Card_Grid.ResumeLayout(false);
            Dealer_Card_Grid.PerformLayout();
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            Select_Action_Panel.ResumeLayout(false);
            tableLayoutPanel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            Num_Panel.ResumeLayout(false);
            Num_Panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)Num_10).EndInit();
            ((System.ComponentModel.ISupportInitialize)Num_01).EndInit();
            Table.ResumeLayout(false);
            Table2.ResumeLayout(false);
            Table2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            tableLayoutPanel3.ResumeLayout(false);
            tableLayoutPanel3.PerformLayout();
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
        private TableLayoutPanel Select_Action_Panel;
        private Button doubleDown_Button;
        private Button stand_Button;
        private Label battle_Chip_Count;
        private Label label3;
        private Label Chip_Count;
        private Label label2;
        private TableLayoutPanel tableLayoutPanel5;
        private Button button1;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private FlowLayoutPanel Num_Panel;
        private PictureBox Num_10;
        private PictureBox Num_01;
        private TableLayoutPanel Table;
        private TableLayoutPanel Table2;
        private PictureBox pictureBox3;
        private Label Chip_count2;
        private Src.RotatableLabel VS_text;
        private Label Play_Count;
        private TableLayoutPanel tableLayoutPanel3;
        private Label label4;
        private Label label6;
        private Label Play_Count_Max;
    }
}