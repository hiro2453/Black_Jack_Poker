using BJ.Src;
using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace BJ
{
    public partial class Game : Form
    {
        Deck d = new Deck();
        bool Start_AA = false;
        bool Start_A = false;
        public Game(int chip)
        {
            InitializeComponent();
            Start(chip);
        }

        public void Start(int vs_chip)
        {
            bool double_Down_Check = Properties.Settings.Default.double_Down;

            int Chip_check = vs_chip;
            battle_Chip_Count.Text = Chip_check.ToString();
            int chip = Properties.Settings.Default.Chip - vs_chip;
            Chip_Count.Text = chip.ToString();

            d.Crad_Shuffle();

            //ユーザーの手札2枚配布
            for (int i = 0; i < 2; i++)
            {
                Label L = new Label();
                L.Text = d.Please_Card();
                L.AutoSize = true;
                User_Card.Controls.Add(L);

                //合計値計算
                string check = d.Mark_remove(L.Text);
                int Count = 0;
                if (check == "A" || check == "J" || check == "Q" || check == "K")
                {
                    Count = d.Start_BlackJackValue(check);
                }
                else
                {
                    Count = int.Parse(check);
                }
                int Total = int.Parse(User_Total_Count.Text);
                Total = Total + Count;
                User_Total_Count.Text = Total.ToString();
            }

            //Dealerの手札2枚配布
            for (int i = 0; i < 2; i++)
            {
                Label L = new Label();
                L.Text = d.Please_Card();
                L.AutoSize = true;
                Dealer_Card.Controls.Add(L);

                //合計値計算
                string check = d.Mark_remove(L.Text);
                int Count = 0;
                if (check == "A" || check == "J" || check == "Q" || check == "K")
                {
                    Count = d.Start_BlackJackValue(check);
                }
                else
                {
                    Count = int.Parse(check);
                }
                int Total = int.Parse(Dealer_Total_Count.Text);
                Total = Total + Count;
                Dealer_Total_Count.Text = Total.ToString();
            }

            string item_0 = d.Mark_remove(User_Card.Controls[0].Text);
            string item_1 = d.Mark_remove(User_Card.Controls[1].Text);
            if (item_0 == "A" && item_1 == "A")
            {
                Start_AA = true;
                Console.WriteLine("どちらもAです");
            }
            if (item_0 == "A" || item_1 == "A")
            {
                Start_A = true;
                Console.WriteLine("片方Aです");
            }
        }

        private void hit_Button_Click(object sender, EventArgs e)
        {
            Label L = new Label();
            L.Text = d.Please_Card();
            L.AutoSize = true;
            User_Card.Controls.Add(L);
            doubleDown_Button.Enabled = false;
            Action_anime(hit_Button.Text);

            //合計値計算
            string check = d.Mark_remove(L.Text);
            int Count = 0;
            int Total = int.Parse(User_Total_Count.Text);

            if (Start_AA == true)
            {
                Total -= 20;
                Dealer_Total_Count.Text = Total.ToString();
                Start_AA = false;
            }

            //最初にAを持っていたとしても、21を超えるまではAを11とカウントする
            if (Start_A == true && Total < 21)
            {
                Total -= 10;
                Dealer_Total_Count.Text = Total.ToString();
                Start_A = false;
            }

            if (check == "A" || check == "J" || check == "Q" || check == "K")
            {
                Count = d.BlackJackValue(check);
            }
            else
            {
                Count = int.Parse(check);
            }

            Total = Total + Count;
            User_Total_Count.Text = Total.ToString();
            if (Total > 21)
            {
                MessageBox.Show("バーストした為、今回の勝負は負けです。");
                Title title = new Title();

                title.Show();

                this.Hide();
            }
        }

        private void stand_Button_Click(object sender, EventArgs e)
        {

        }

        private void doubleDown_Button_Click(object sender, EventArgs e)
        {

        }

        private void battle_Chip_Count_Click(object sender, EventArgs e)
        {

        }

        private async void Action_anime(string text)
        {
            OutlinedLabel test = new OutlinedLabel();
            test.Font = new System.Drawing.Font("A P-SK 石井ゴシック StdN B", 32F, FontStyle.Bold);
            int x = 800;
            int size = 100;
            test.Text = text;
            test.StrokeWidth = 5;
            test.AutoSize = true;
            this.Controls.Add(test);
            while (x >= 320)
            {
                test.Location = new Point(x, 180);
                x -= 40;
                await Task.Delay(10);
            }

            await Task.Delay(1000);

            while (x >= -200)
            {
                test.Location = new Point(x, 180);
                x -= 40;
                await Task.Delay(10);
            }
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            Action_anime(button1.Text);
        }
    }
}
