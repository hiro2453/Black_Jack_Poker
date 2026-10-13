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
            h1_label = new Label();
            SuspendLayout();
            // 
            // h1_label
            // 
            h1_label.AutoSize = true;
            h1_label.Font = new Font("メイリオ", 24F, FontStyle.Regular, GraphicsUnit.Point, 128);
            h1_label.Location = new Point(318, 53);
            h1_label.Name = "h1_label";
            h1_label.Size = new Size(148, 48);
            h1_label.TabIndex = 0;
            h1_label.Text = "結果発表";
            h1_label.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Result
            // 
            AutoScaleDimensions = new SizeF(7F, 18F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLight;
            ClientSize = new Size(784, 461);
            Controls.Add(h1_label);
            ImeMode = ImeMode.Off;
            MaximizeBox = false;
            MaximumSize = new Size(800, 500);
            MdiChildrenMinimizedAnchorBottom = false;
            MinimizeBox = false;
            Name = "Result";
            SizeGripStyle = SizeGripStyle.Hide;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "浜田「結果発表～～～！！！！！」";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label h1_label;
    }
}