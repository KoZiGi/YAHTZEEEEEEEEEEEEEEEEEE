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
                    Thread.Sleep(10);
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
        public static void SwitchIndex()
        {
            if (Globals.CurrentPlayerIndex + 1 >= Globals.Players.Count)
                Globals.CurrentPlayerIndex = 0;
            else Globals.CurrentPlayerIndex++;
        }
    }
}
