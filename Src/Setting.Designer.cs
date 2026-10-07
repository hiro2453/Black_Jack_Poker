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
            groupBox1 = new GroupBox();
            label1 = new Label();
            FiveTarget_radio = new RadioButton();
            Setting_Enter = new Button();
            statusStrip1.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // statusStrip1
            // 
            statusStrip1.Items.AddRange(new ToolStripItem[] { toolStripStatusLabel1 });
            statusStrip1.Location = new Point(0, 438);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(784, 23);
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
            BestFive_radio.Size = new Size(110, 22);
            BestFive_radio.TabIndex = 1;
            BestFive_radio.Text = "ベストファイブ";
            BestFive_radio.UseVisualStyleBackColor = true;
            BestFive_radio.MouseEnter += BestFive_Description;
            BestFive_radio.MouseLeave += Default_Description;
            // 
            // LookFive_radio
            // 
            LookFive_radio.AutoSize = true;
            LookFive_radio.Location = new Point(6, 52);
            LookFive_radio.Name = "LookFive_radio";
            LookFive_radio.Size = new Size(110, 22);
            LookFive_radio.TabIndex = 2;
            LookFive_radio.Text = "ロックファイブ";
            LookFive_radio.UseVisualStyleBackColor = true;
            LookFive_radio.MouseEnter += LookFive_Description;
            LookFive_radio.MouseLeave += Default_Description;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(FiveTarget_radio);
            groupBox1.Controls.Add(BestFive_radio);
            groupBox1.Controls.Add(LookFive_radio);
            groupBox1.Location = new Point(612, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(160, 150);
            groupBox1.TabIndex = 3;
            groupBox1.TabStop = false;
            groupBox1.Text = "ルール設定";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("メイリオ", 9F, FontStyle.Bold, GraphicsUnit.Point, 128);
            label1.ForeColor = Color.Red;
            label1.Location = new Point(6, 105);
            label1.Name = "label1";
            label1.Size = new Size(158, 36);
            label1.TabIndex = 4;
            label1.Text = "※変更した場合、\r\n持ち金30%を徴収します。";
            // 
            // FiveTarget_radio
            // 
            FiveTarget_radio.AutoSize = true;
            FiveTarget_radio.Location = new Point(6, 80);
            FiveTarget_radio.Name = "FiveTarget_radio";
            FiveTarget_radio.Size = new Size(134, 22);
            FiveTarget_radio.TabIndex = 3;
            FiveTarget_radio.Text = "ファイブターゲット";
            FiveTarget_radio.UseVisualStyleBackColor = true;
            FiveTarget_radio.MouseEnter += FiveTarget_Description;
            FiveTarget_radio.MouseLeave += Default_Description;
            // 
            // Setting_Enter
            // 
            Setting_Enter.AutoSize = true;
            Setting_Enter.Font = new Font("メイリオ", 12F);
            Setting_Enter.Location = new Point(688, 401);
            Setting_Enter.Name = "Setting_Enter";
            Setting_Enter.Size = new Size(84, 34);
            Setting_Enter.TabIndex = 4;
            Setting_Enter.Text = "保存する";
            Setting_Enter.UseVisualStyleBackColor = true;
            Setting_Enter.Click += Setting_OK;
            // 
            // Setting
            // 
            AutoScaleDimensions = new SizeF(7F, 18F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLight;
            ClientSize = new Size(784, 461);
            Controls.Add(Setting_Enter);
            Controls.Add(groupBox1);
            Controls.Add(statusStrip1);
            MaximizeBox = false;
            MaximumSize = new Size(800, 500);
            MinimumSize = new Size(800, 500);
            Name = "Setting";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Setting";
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private StatusStrip statusStrip1;
        private ToolStripStatusLabel toolStripStatusLabel1;
        private RadioButton BestFive_radio;
        private RadioButton LookFive_radio;
        private GroupBox groupBox1;
        private Label label1;
        private RadioButton FiveTarget_radio;
        private Button Setting_Enter;
    }
}