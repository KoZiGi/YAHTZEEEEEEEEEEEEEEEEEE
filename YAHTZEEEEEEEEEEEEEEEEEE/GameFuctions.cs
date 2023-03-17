using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Drawing;
using System.Windows.Forms;
namespace YAHTZEEEEEEEEEEEEEEEEEE
{
    class GameFuctions
    {
        public static bool GivePoints(string text, int points)
        {
            try
            {
                return giveSingles(Convert.ToInt32(text.Split(':')[0]) - 1, Convert.ToInt32(text.Split(':')[1]));
            }
            catch (Exception)
            {
                return getSelect(text);
            }
        }
        public static void CheckEnd()
        {
            if (Globals.Players[Globals.CurrentPlayerIndex].playerScore.IsFinished())
            {
                string winner = Globals.Players.Find(e => 
                    e.playerScore.TotalScore() == Globals.Players.Max(g => g.playerScore.TotalScore())).Name;
                MessageBox.Show($"Győztes: {winner}");
                Application.Exit();
            }
        }
        private static bool giveSum(int points)
        {
            if (Globals.Players[Globals.CurrentPlayerIndex].playerScore.Sum == -1)
            {
                Globals.Players[Globals.CurrentPlayerIndex].playerScore.Sum = points;
                return true;
            }
            return false;
        }
        private static bool givePairs(int points, string type)
        {
            switch (type)
            {
                case "Pár":
                    if (Globals.Players[Globals.CurrentPlayerIndex].playerScore.Pairs[0]==-1)
                    {
                        Globals.Players[Globals.CurrentPlayerIndex].playerScore.Pairs[0] = points;
                        return true;
                    }
                    return false;
                case "Két pár":
                    if (Globals.Players[Globals.CurrentPlayerIndex].playerScore.Pairs[1]==-1)
                    {
                        Globals.Players[Globals.CurrentPlayerIndex].playerScore.Pairs[1] = points;
                        return true;
                    }
                    return false;
                default: return false;
            }
        }
        private static bool giveSingles(int index, int points)
        {
            if (Globals.Players[Globals.CurrentPlayerIndex].playerScore.Singles[index] == -1)
            {
                Globals.Players[Globals.CurrentPlayerIndex].playerScore.Singles[index] = points;
                return true;
            }
            return false;
        }
        private static bool giveKinds(int points, string type)
        {
            switch (type)
            {
                case "Drill":
                    if (Globals.Players[Globals.CurrentPlayerIndex].playerScore.ThreeOfAKind == -1)
                    {
                        Globals.Players[Globals.CurrentPlayerIndex].playerScore.ThreeOfAKind = points;
                        return true;
                    }
                    return false;
                case "Póker":
                    if (Globals.Players[Globals.CurrentPlayerIndex].playerScore.FourOfAKind==-1)
                    {
                        Globals.Players[Globals.CurrentPlayerIndex].playerScore.FourOfAKind = points;
                        return true;
                    }
                    return false;
                case "Yahtzee":
                    if (Globals.Players[Globals.CurrentPlayerIndex].playerScore.Yahtzee == -1)
                    {
                        Globals.Players[Globals.CurrentPlayerIndex].playerScore.Yahtzee = points;
                        return true;
                    }
                    return false;
                default:
                    return false;
            }
        }
        private static bool giveHouse(int points)
        {
            if (Globals.Players[Globals.CurrentPlayerIndex].playerScore.FullHouse==-1)
            {
                Globals.Players[Globals.CurrentPlayerIndex].playerScore.FullHouse = points;
                return true;
            }
            return false;
        }
        private static bool giveStraight(int points, string type)
        {
            if (type == "Kicsi")
            {
                return giveSmall(points);
            }
            else return giveBig(points);
        }
        private static bool giveSmall(int points)
        {
            if (Globals.Players[Globals.CurrentPlayerIndex].playerScore.StraightSmall == -1)
            {
                Globals.Players[Globals.CurrentPlayerIndex].playerScore.StraightSmall = points;
                return true;
            }
            return false;
        }
        private static bool giveBig(int points)
        {
            if (Globals.Players[Globals.CurrentPlayerIndex].playerScore.StraightLarge == -1)
            {
                Globals.Players[Globals.CurrentPlayerIndex].playerScore.StraightLarge = points;
                return true;
            }
            return false;
        }
        private static bool getSelect(string text) 
        {
            if (text.Contains("✔")) return false;
            switch (text.Split(':')[0])
            {
                case "Sor Kicsi":
                case "Sor Nagy":
                    return giveStraight(Convert.ToInt32(text.Split(':')[1]), text.Split(':')[0].Split(' ')[1]);
                case "Drill":
                case "Póker":
                case "Yahtzee":
                    return giveKinds(Convert.ToInt32(text.Split(':')[1]), text.Split(':')[0]);
                case "Két pár":
                case "Pár":
                    return givePairs(Convert.ToInt32(text.Split(':')[1]), text.Split(':')[0]);
                case "Full":
                    return giveHouse(Convert.ToInt32(text.Split(':')[1]));
                default:
                    return giveSum(Convert.ToInt32(text.Split(':')[1]));
            }
        }

        public static List<int> Rolls(int roll_count)
        {           //this function returns "roll_count" rolls
            List<int> rolls = new List<int>();
            for (int i = 0; i < roll_count; i++)
            {
                Thread.Sleep(10);
                rolls.Add(random_roll());
            }
            return rolls;
        }
        public static List<int> Rolls(int[] dontRollHere, List<int> previous)
        {
            for (int i = 0; i < previous.Count; i++)
            {
                if (!isFrozen(dontRollHere, i))
                {
                    previous[i] = random_roll();
                    Thread.Sleep(new Random().Next(1,11));
                }
            }
            return previous;
        }
        private static bool isFrozen(int[] indexes, int index)
        {
            return indexes.Contains(index);
        }
        private static int random_roll()
        {           //this function returns a number 1-6 this is a singe roll
            Random rnd = new Random();
            return rnd.Next(1, 7);
        }
        public static void HandleRoll(Button RollButton, Button PointButton)
        {
            Globals.Throws--;
            if (Globals.Throws == 0)
                RollButton.Enabled = false;
            else if (Globals.Throws == 3)
            {
                RollButton.Enabled = true;
                PointButton.Enabled = false;
            }
            else
                PointButton.Enabled = true;
        }
        public static void AntiCheat(List<Label> dices)
        {
            if (Globals.Throws == 3)
            {
                dices.ForEach(g =>
                {
                    g.BackColor = Color.PowderBlue;
                });
            }
        }
        public static void AddPlayers(List<string> playerNames)
        {
            Globals.Players = playerNames.Select(e => new Player(e)).ToList();
        }
        public static void SwitchIndex(ListBox lbx)
        {
            if (Globals.CurrentPlayerIndex + 1 >= Globals.Players.Count)
            {
                Globals.CurrentPlayerIndex = 0;
                lbx.SelectedIndex = Globals.CurrentPlayerIndex;
            }
            else Globals.CurrentPlayerIndex++;
        }
    }
}
