namespace BJ.Src
{
    partial class Setting
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
            statusStrip1 = new StatusStrip();
            toolStripStatusLabel1 = new ToolStripStatusLabel();
            BestFive_radio = new RadioButton();
            LookFive_radio = new RadioButton();
            Rule_Group = new GroupBox();
            label1 = new Label();
            FiveTarget_radio = new RadioButton();
            Setting_Enter = new Button();
            checkBox1 = new CheckBox();
            groupBox1 = new GroupBox();
            groupBox2 = new GroupBox();
            battle_count = new ComboBox();
            checkBox2 = new CheckBox();
            statusStrip1.SuspendLayout();
            Rule_Group.SuspendLayout();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // statusStrip1
            // 
            statusStrip1.BackColor = SystemColors.ControlLight;
            statusStrip1.Items.AddRange(new ToolStripItem[] { toolStripStatusLabel1 });
            statusStrip1.Location = new Point(0, 303);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(384, 23);
            statusStrip1.TabIndex = 0;
            statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            toolStripStatusLabel1.Size = new Size(308, 18);
            toolStripStatusLabel1.Text = "選択項目にマウスをかざすとここに説明が表示されます";
            // 
            // BestFive_radio
            // 
            BestFive_radio.AutoSize = true;
            BestFive_radio.Location = new Point(6, 24);
            BestFive_radio.Name = "BestFive_radio";
            BestFive_radio.Padding = new Padding(0, 0, 0, 5);
            BestFive_radio.Size = new Size(110, 27);
            BestFive_radio.TabIndex = 1;
            BestFive_radio.Text = "プラスマイナス";
            BestFive_radio.UseVisualStyleBackColor = true;
            BestFive_radio.MouseEnter += BestFive_Desc;
            // 
            // LookFive_radio
            // 
            LookFive_radio.AutoSize = true;
            LookFive_radio.Location = new Point(6, 52);
            LookFive_radio.Name = "LookFive_radio";
            LookFive_radio.Padding = new Padding(0, 0, 0, 5);
            LookFive_radio.Size = new Size(110, 27);
            LookFive_radio.TabIndex = 2;
            LookFive_radio.Text = "ロックファイブ";
            LookFive_radio.UseVisualStyleBackColor = true;
            LookFive_radio.MouseEnter += LookFive_Desc;
            // 
            // Rule_Group
            // 
            Rule_Group.Controls.Add(label1);
            Rule_Group.Controls.Add(FiveTarget_radio);
            Rule_Group.Controls.Add(BestFive_radio);
            Rule_Group.Controls.Add(LookFive_radio);
            Rule_Group.Location = new Point(12, 12);
            Rule_Group.Name = "Rule_Group";
            Rule_Group.Size = new Size(160, 150);
            Rule_Group.TabIndex = 3;
            Rule_Group.TabStop = false;
            Rule_Group.Text = "モード設定";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("メイリオ", 9F, FontStyle.Bold, GraphicsUnit.Point, 128);
            label1.ForeColor = Color.Red;
            label1.Location = new Point(0, 105);
            label1.Name = "label1";
            label1.Size = new Size(158, 36);
            label1.TabIndex = 4;
            label1.Text = "※変更した場合、\r\n所持金30%を徴収します。";
            // 
            // FiveTarget_radio
            // 
            FiveTarget_radio.AutoSize = true;
            FiveTarget_radio.Location = new Point(6, 80);
            FiveTarget_radio.Name = "FiveTarget_radio";
            FiveTarget_radio.Padding = new Padding(0, 0, 0, 5);
            FiveTarget_radio.Size = new Size(134, 27);
            FiveTarget_radio.TabIndex = 3;
            FiveTarget_radio.Text = "ファイブターゲット";
            FiveTarget_radio.UseVisualStyleBackColor = true;
            FiveTarget_radio.MouseEnter += FiveTarget_Desc;
            // 
            // Setting_Enter
            // 
            Setting_Enter.AutoSize = true;
            Setting_Enter.Font = new Font("メイリオ", 12F);
            Setting_Enter.Location = new Point(283, 197);
            Setting_Enter.Name = "Setting_Enter";
            Setting_Enter.Size = new Size(84, 34);
            Setting_Enter.TabIndex = 4;
            Setting_Enter.Text = "保存する";
            Setting_Enter.UseVisualStyleBackColor = true;
            Setting_Enter.Click += Setting_OK;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(6, 24);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(87, 22);
            checkBox1.TabIndex = 5;
            checkBox1.Text = "ジョーカー";
            checkBox1.UseVisualStyleBackColor = true;
            checkBox1.MouseEnter += Joker_desc;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(groupBox2);
            groupBox1.Controls.Add(checkBox2);
            groupBox1.Controls.Add(checkBox1);
            groupBox1.Location = new Point(178, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(189, 150);
            groupBox1.TabIndex = 6;
            groupBox1.TabStop = false;
            groupBox1.Text = "ルール";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(battle_count);
            groupBox2.Location = new Point(6, 52);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(177, 55);
            groupBox2.TabIndex = 7;
            groupBox2.TabStop = false;
            groupBox2.Text = "試合回数";
            // 
            // battle_count
            // 
            battle_count.FormatString = "N0";
            battle_count.FormattingEnabled = true;
            battle_count.Items.AddRange(new object[] { "1", "3", "5", "10", "15", "20" });
            battle_count.Location = new Point(29, 23);
            battle_count.Name = "battle_count";
            battle_count.Size = new Size(121, 26);
            battle_count.TabIndex = 8;
            battle_count.TabStop = false;
            battle_count.Text = "5";
            // 
            // checkBox2
            // 
            checkBox2.AutoSize = true;
            checkBox2.Location = new Point(105, 24);
            checkBox2.Name = "checkBox2";
            checkBox2.Size = new Size(51, 22);
            checkBox2.TabIndex = 6;
            checkBox2.Text = "借金";
            checkBox2.UseVisualStyleBackColor = true;
            // 
            // Setting
            // 
            AutoScaleDimensions = new SizeF(7F, 18F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLight;
            ClientSize = new Size(384, 326);
            Controls.Add(groupBox1);
            Controls.Add(Setting_Enter);
            Controls.Add(Rule_Group);
            Controls.Add(statusStrip1);
            MaximizeBox = false;
            Name = "Setting";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Setting";
            MouseHover += Window_Hover;
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            Rule_Group.ResumeLayout(false);
            Rule_Group.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private StatusStrip statusStrip1;
        private ToolStripStatusLabel toolStripStatusLabel1;
        private RadioButton BestFive_radio;
        private RadioButton LookFive_radio;
        private GroupBox Rule_Group;
        private Label label1;
        private RadioButton FiveTarget_radio;
        private Button Setting_Enter;
        private CheckBox checkBox1;
        private GroupBox groupBox1;
        private CheckBox checkBox2;
        private GroupBox groupBox2;
        private ComboBox battle_count;
    }
}