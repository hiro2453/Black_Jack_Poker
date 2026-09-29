using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;
using System.Text.RegularExpressions;
using BJ.Src;

namespace BJ
{
    public partial class Game : Form
    {
        Deck d = new Deck();
        bool Start_AA = false;
        bool Start_A  = false;
        public Game(int test)
        {
            InitializeComponent();
            Start(test);
        }
        
        public void Start(int test)
        {
            int Chip_check = test;
            battle_Chip_Count.Text = Chip_check.ToString();

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
            if (Start_A == true)
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
    }
}
