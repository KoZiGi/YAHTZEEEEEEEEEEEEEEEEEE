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
        public static void ShowPlayerScores(ListBox leaderboard)
        {
            Globals.Players.ForEach(e =>
            {
                leaderboard.Items[Globals.CurrentPlayerIndex] = $"{e.Name} - {e.playerScore.TotalScore()}";
            });
        }

        public static void ShowPublicScore(List<int> rolls, ListBox scorebox)
        {
            scorebox.Items.Clear();
            ShowSingles(rolls, scorebox);
            ShowPairs(rolls, scorebox);
            ShowKinds(rolls, scorebox);
            ShowHouse(rolls, scorebox);
        }
        private static void ShowSingles(List<int> rolls, ListBox scorebox)
        {
            for (int i = 1; i < 7; i++)
            {
                scorebox.Items.Add($"{i}:{SinglesGivePoints(i, rolls)}{GiveSingleCheckMark(i)}");
            }
        }
        private static void ShowPairs(List<int> rolls, ListBox scorebox)
        {
            scorebox.Items.Add($"Pár:{PairsGivePoints(0, rolls)}{GivePairCheckMark(0)}");
            scorebox.Items.Add($"Két pár:{PairsGivePoints(1, rolls)}{GivePairCheckMark(1)}");
        }
        private static void ShowKinds(List<int> rolls, ListBox scorebox)
        {
            scorebox.Items.Add($"Drill:{Score_Calculator.kindCheck(rolls, 3)}");
            scorebox.Items.Add($"Póker:{Score_Calculator.kindCheck(rolls, 4)}");
            scorebox.Items.Add($"Yahtzee:{Score_Calculator.kindCheck(rolls, 5)}");
        }
        private static void ShowHouse(List<int> rolls, ListBox scorebox)
            => scorebox.Items.Add($"Full:{Score_Calculator.Fullhouse_check(rolls)}");

        private static int SinglesGivePoints(int index, List<int> rolls)
            => Globals.Players[Globals.CurrentPlayerIndex].playerScore.Singles[index-1] == -1 ?
                Score_Calculator.Single_Scores(index, rolls)
              : Globals.Players[Globals.CurrentPlayerIndex].playerScore.Singles[index - 1];
        private static string GiveSingleCheckMark(int index)
            => Globals.Players[Globals.CurrentPlayerIndex].playerScore.Singles[index - 1] == -1 ?
                "" : "✔";
        private static int PairsGivePoints(int index, List<int> rolls)
            => Globals.Players[Globals.CurrentPlayerIndex].playerScore.Pairs[index] == -1 ?
                Score_Calculator.Peirs_Scores(index == 0, rolls) :
                Globals.Players[Globals.CurrentPlayerIndex].playerScore.Pairs[index];
        private static string GivePairCheckMark(int index)
             => Globals.Players[Globals.CurrentPlayerIndex].playerScore.Pairs[index] == -1 ?
                "" : "✔";
        
    }
}
