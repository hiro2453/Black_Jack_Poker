using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BJ
{
    public partial class Chip : Form
    {
        public Chip()
        {
            InitializeComponent();
            Check();
        }

        private void Check()
        {
            Chip_before.Text = Properties.Settings.Default.Chip.ToString();
            Chip_After.Text = Properties.Settings.Default.Chip.ToString();
            Debt_label.Text = Properties.Settings.Default.Debt ? "※借金可能" : "※借金できません";

        }

        private void Clear_Button_Click(object sender, EventArgs e)
        {
            Chip_Count.Text = "0";
            Enter_Button.Enabled = false;
        }

        private void Max_Button_Click(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.Chip > 1000000)
            {
                Chip_Count.Text = "999999";
                Enter_Button.Enabled = true;
            }
        }
        
        private void Num_Button_Click(object sender, EventArgs e)
        {
            Enter_Button.Enabled = true;

            if (int.Parse(Chip_Count.Text) <= int.Parse(Chip_before.Text))
            {
                Button btn = sender as Button;
                if (Chip_Count.Text == "0")
                {
                    Chip_Count.Text = btn.Text;
                }
                else
                {
                    Chip_Count.Text = Chip_Count.Text + btn.Text;
                }

                if (Chip_Count.Text.Length < Chip_Count.Text.Length)
                {
                    
                }
            }

            if (int.Parse(Chip_Count.Text) > int.Parse(Chip_before.Text))
            {
                if (Properties.Settings.Default.Debt == true)
                {
                    Chip_Count.Text = "999999";
                }
                else
                {
                    Chip_Count.Text = Properties.Settings.Default.Chip.ToString();
                }
            }

        }

        private void Enter_Button_Click(object sender, EventArgs e)
        {
            int battle_chip = int.Parse(Chip_Count.Text);
            Properties.Settings.Default.Save();

            using (var gameform = new Game(battle_chip))
            {
                this.Hide();
                gameform.ShowDialog();
                // ← ゲーム画面が閉じられる（Closeされる）まで、処理はここで待機
                this.Close();
            }
        }

        private void Chip_Change(object sender, EventArgs e)
        {
            int num = Properties.Settings.Default.Chip - int.Parse(Chip_Count.Text);
            Chip_After.Text = num.ToString();
        }
    }
}
