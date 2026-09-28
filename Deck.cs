using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BJ
{
    internal class Deck
    {
        //ジョーカーを除くすべてのカードを手打ち
        List<string> All_deck = new List<string> { "♠A", "♠2", "♠3", "♠4", "♠5", "♠6", "♠7", "♠8", "♠9", "♠10", "♠J", "♠Q", "♠K",
                                                   "♥A", "♥2", "♥3", "♥4", "♥5", "♥6", "♥7", "♥8", "♥9", "♥10", "♥J", "♥Q", "♥K",
                                                   "♦A", "♦2", "♦3", "♦4", "♦5", "♦6", "♦7", "♦8", "♦9", "♦10", "♦J", "♦Q", "♦K",
                                                   "♣A", "♣2", "♣3", "♣4", "♣5", "♣6", "♣7", "♣8", "♣9", "♣10", "♣J", "♣Q", "♣K",};

        private static Random rng = new Random();
        public void Crad_Shuffle()
        {

            //個数をnに保存
            int n = All_deck.Count;
            while (n > 1)
            {
                n--;
                int k = rng.Next(n + 1);
                // 要素の入れ替え
                string value = All_deck[k];
                All_deck[k] = All_deck[n];
                All_deck[n] = value;
            }
            Console.WriteLine("シャッフル終了");
        }

        int n = 52;
        public string Please_Card()
        {

            if (n > 1)
            {
                n--;
                return All_deck[n];
            }
            else
            {
                return "null";
            }
        }

        public string Mark_remove(string c)
        {
            char[] Card_string = c.ToCharArray();
            string output = "";
            switch (Card_string.Length)
            {
                case 3:
                    output += Card_string[1];
                    output += Card_string[2];
                    return output;
                default:
                    output += Card_string[1];
                    return output;
            }
        }

        public int Start_BlackJackValue(string c)
        {
            switch (c)
            {
                case "A": return 11;
                default: return 10;
            }
        }

        public int BlackJackValue(string c)
        {
            switch (c)
            {
                case "A": return 1;
                default: return 10;
            }
        }
        /*
        public bool Max_Check(int c)
        {
            if (c < 21)
            {
                
            }
        }*/
    }
}
