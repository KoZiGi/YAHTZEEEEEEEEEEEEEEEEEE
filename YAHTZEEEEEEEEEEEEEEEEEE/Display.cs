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
        public static void diceClick(Label diceLbl) =>
            diceLbl.BackColor =
                diceLbl.BackColor == Color.PowderBlue ? Color.HotPink : Color.PowderBlue;
        public static void ShowPlayerScores(ListBox leaderboard)
        {
            leaderboard.Items.Clear();
            Globals.Players.ForEach(e =>
            {
                leaderboard.Items.Add($"{e.Name} - {e.playerScore.TotalScore()}");
            });
        }

        public static void ShowPublicScore(List<int> rolls, ListBox scorebox)
        {
            scorebox.Items.Clear();
            ShowSingles(rolls, scorebox);
            ShowStraights(rolls, scorebox);
            ShowPairs(rolls, scorebox);
            ShowKinds(rolls, scorebox);
            ShowHouse(rolls, scorebox);
            ShowSum(rolls, scorebox);
        }
        private static void ShowStraights(List<int> rolls, ListBox scorebox)
        {
            scorebox.Items.Add($"Sor Kicsi:{GiveStraights("Kicsi", rolls)}{checkmark(Globals.Players[Globals.CurrentPlayerIndex].playerScore.StraightSmall==-1)}");
            scorebox.Items.Add($"Sor Nagy:{GiveStraights("Nagy", rolls)}{checkmark(Globals.Players[Globals.CurrentPlayerIndex].playerScore.StraightLarge == -1)}");
        }
        private static void ShowSum(List<int> rolls, ListBox scorebox)
        {
            scorebox.Items.Add($"Chance:{SumPoints(rolls)}{SumCheck()}");
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
            scorebox.Items.Add($"Drill:{KindsGivePoints(3, rolls)}{KindsCheckMark(3, rolls)}");
            scorebox.Items.Add($"Póker:{KindsGivePoints(4, rolls)}{KindsCheckMark(4, rolls)}");
            scorebox.Items.Add($"Yahtzee:{KindsGivePoints(5, rolls)}{KindsCheckMark(5, rolls)}");
        }
        private static void ShowHouse(List<int> rolls, ListBox scorebox)
            => scorebox.Items.Add($"Full:{HouseGivePoints(rolls)}{FullCheckMark()}");

        /*
         * GivePoints Functions:
         * if the player's score for the specific type is -1, aka. not choosen,
         * then show the calculated score for that type, otherwise show the points for that type 
         */
        private static int HouseGivePoints(List<int> rolls)
               => Globals.Players[Globals.CurrentPlayerIndex].playerScore.FullHouse == -1 ?
                    Score_Calculator.houseCheck(rolls) :
                    Globals.Players[Globals.CurrentPlayerIndex].playerScore.FullHouse;
        private static int SumPoints(List<int> rolls) =>
            Globals.Players[Globals.CurrentPlayerIndex].playerScore.Sum == -1 ?
                Score_Calculator.Chance_Check(rolls) :
                Globals.Players[Globals.CurrentPlayerIndex].playerScore.Sum;
        private static string SumCheck() => 
            checkmark(Globals.Players[Globals.CurrentPlayerIndex].playerScore.Sum == -1);
        private static int SinglesGivePoints(int index, List<int> rolls)
            => Globals.Players[Globals.CurrentPlayerIndex].playerScore.Singles[index-1] == -1 ?
                Score_Calculator.Single_Scores(index, rolls)
              : Globals.Players[Globals.CurrentPlayerIndex].playerScore.Singles[index - 1];
        private static string GiveSingleCheckMark(int index)
            => checkmark(Globals.Players[Globals.CurrentPlayerIndex].playerScore.Singles[index - 1] == -1);
        private static int PairsGivePoints(int index, List<int> rolls)
            => Globals.Players[Globals.CurrentPlayerIndex].playerScore.Pairs[index] == -1 ?
                Score_Calculator.Peirs_Scores(index == 0, rolls) :
                Globals.Players[Globals.CurrentPlayerIndex].playerScore.Pairs[index];
        private static string GivePairCheckMark(int index)
             => checkmark(Globals.Players[Globals.CurrentPlayerIndex].playerScore.Pairs[index] == -1);
        private static int KindsGivePoints(int type, List<int> rolls) =>
            type == 3 ?
                Globals.Players[Globals.CurrentPlayerIndex].playerScore.ThreeOfAKind == -1 ?
                    Score_Calculator.kindCheck(rolls, 3) :
                    Globals.Players[Globals.CurrentPlayerIndex].playerScore.ThreeOfAKind :
            type == 4 ?
                Globals.Players[Globals.CurrentPlayerIndex].playerScore.FourOfAKind == -1 ?
                    Score_Calculator.kindCheck(rolls, 4) :
                    Globals.Players[Globals.CurrentPlayerIndex].playerScore.FourOfAKind :
                Globals.Players[Globals.CurrentPlayerIndex].playerScore.Yahtzee == -1 ?
                    Score_Calculator.kindCheck(rolls, 5) :
                    Globals.Players[Globals.CurrentPlayerIndex].playerScore.Yahtzee;
        private static string KindsCheckMark(int type, List<int> rolls) =>
            type == 3 ?
            checkmark(Globals.Players[Globals.CurrentPlayerIndex].playerScore.ThreeOfAKind == -1) :
            type == 4 ?
            checkmark(Globals.Players[Globals.CurrentPlayerIndex].playerScore.FourOfAKind == -1) :
            checkmark(Globals.Players[Globals.CurrentPlayerIndex].playerScore.Yahtzee== -1);
        private static string FullCheckMark() =>
            checkmark(Globals.Players[Globals.CurrentPlayerIndex].playerScore.FullHouse == -1);
        private static int GiveStraights(string type, List<int> rolls) => 
            type == "Kicsi" ? 
                Globals.Players[Globals.CurrentPlayerIndex].playerScore.StraightSmall == -1 ?    
                    Score_Calculator.Straight_Check(true, rolls) :
                    Globals.Players[Globals.CurrentPlayerIndex].playerScore.StraightSmall :
                Globals.Players[Globals.CurrentPlayerIndex].playerScore.StraightLarge == -1 ?
                    Score_Calculator.Straight_Check(false, rolls) :
                    Globals.Players[Globals.CurrentPlayerIndex].playerScore.StraightLarge;
        private static string checkmark(bool condition) => condition ? "" : "✔";
    }
}
