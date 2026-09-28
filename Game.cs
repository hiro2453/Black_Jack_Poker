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

namespace BJ
{
    public partial class Game : Form
    {
        public Game()
        {
            InitializeComponent();
            Start();
        }

        private void Start()
        {
            Deck d = new Deck();
            d.Crad_Shuffle();

            //ユーザーの手札2枚配布
            for (int i = 0; i < 2; i++)
            {
                Label L = new Label();
                L.Text = d.please_Card();
                L.AutoSize = true;
                User_Card.Controls.Add(L);

                //合計値計算
                string check = d.Mark_remove(L.Text);
                Console.WriteLine(check);
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
                Console.WriteLine(Total);
                Total = Total + Count;
                User_Total_Count.Text = Total.ToString();
            }

            //Dealerの手札2枚配布
            for (int i = 0; i < 2; i++)
            {
                Label L = new Label();
                L.Text = d.please_Card();
                L.AutoSize = true;
                Dealer_Card.Controls.Add(L);

                //合計値計算
                string check = d.Mark_remove(L.Text);
                Console.WriteLine(check);
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
                Console.WriteLine(Total);
                Total = Total + Count;
                Dealer_Total_Count.Text = Total.ToString();
            }
        }

        private void hit_Button_Click(object sender, EventArgs e)
        {
            
        }
    }
}
