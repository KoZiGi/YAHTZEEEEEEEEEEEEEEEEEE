using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace YAHTZEEEEEEEEEEEEEEEEEE
{
    class Display
    {
        public static void DisplayRoll(Label[] dices, List<int> roll)
        {
            for (int i = 0; i < dices.Length; i++)
            {
                dices[i].Text = roll[i].ToString();
            }
        }
        public static void diceClick(Label diceLbl)
        {
            if (diceLbl.BackColor == Color.PowderBlue)
            {
                diceLbl.BackColor = Color.HotPink;
            }
            else
            {
                diceLbl.BackColor = Color.PowderBlue;
            }
        }
        public static void ShowPublicScore(List<int> rolls)
        {
            ShowSingles(rolls);
            ShowPairs(rolls);

        }
        private static void ShowSingles(List<int> rolls)
        {
            rolls
                .Distinct()
                .ToList()
                .ForEach(e => {
                    MessageBox.Show(Score_Calculator.Single_Scores(e, rolls).ToString()); 
                });
        }
        private static void ShowPairs(List<int> rolls)
        {

        }
    }
}
