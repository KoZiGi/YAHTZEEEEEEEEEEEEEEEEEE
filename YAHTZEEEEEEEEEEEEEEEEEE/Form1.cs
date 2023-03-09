using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace YAHTZEEEEEEEEEEEEEEEEEE
{
    public partial class Form1 : Form
    {
        private Label[] dices = new Label[] { };
        public Form1()
        {
            InitializeComponent();
            setUpDisplayFunctions();
            dices = new Label[] { Dice1, Dice2, Dice3, Dice4, Dice5 };
            LeaderboardLbx.SelectedIndexChanged += delegate { handlePlayerinput(); };

        }
        private void setUpDisplayFunctions()
        {
            Dice1.Click += delegate { Display.diceClick(Dice1); };
            Dice2.Click += delegate { Display.diceClick(Dice2); };
            Dice3.Click += delegate { Display.diceClick(Dice3); };
            Dice4.Click += delegate { Display.diceClick(Dice4); };
            Dice5.Click += delegate { Display.diceClick(Dice5); };
            setUpLeaderBoard();
        }
        private void handlePlayerinput()
        {
            LeaderboardLbx.SelectedIndex = Globals.CurrentPlayerIndex;
        }
        private void setUpLeaderBoard()
        {
            if (Globals.Players.Count<1)
            {
                Globals.Players.Add(new Player("Játékos 1"));
            }
            LeaderboardLbx.Items.AddRange(Globals.Players.Select(e=>e.Name).ToArray());
            LeaderboardLbx.SelectedIndex = Globals.CurrentPlayerIndex;
        }
        private void ThrowBtn_Click(object sender, EventArgs e)
        {
            GameFuctions.AntiCheat(dices.ToList());
            List<int> Rolls;
            if (GetFreeze().Count > 0)
            {
                Rolls = GameFuctions.Rolls(GetFreeze().ToArray(), Globals.Previous_Roll);
                Display.DisplayRoll(dices, Rolls);
            }
            else
            {
                Rolls = GameFuctions.Rolls(5);
                Display.DisplayRoll(dices, Rolls);
            }
            GameFuctions.HandleRoll(ThrowBtn, PointBtn);
            Display.ShowPublicScore(Rolls);
        }
        
        /*
         * 
         * Gets all of the Dice Labels (e.g.: Dice1, Dice2)
         * If the background color is 'HotPink', then return all of the labels names last characters, then
         * subtracts one from it.
         * ( example: Dice1 is HotPink -> (Dice) 1 - 1 = 0 )
         */
        private List<int> GetFreeze()
        {
            return dices
                    .ToList()
                    .Where(z => z.BackColor == Color.HotPink)
                    .Select(e => Convert.ToInt32(e.Name[e.Name.Length - 1].ToString()) - 1)
                    .ToList();
        }

        private void PointBtn_Click(object sender, EventArgs e)
        {
            Globals.Throws = 4;
            GameFuctions.SwitchIndex();
            GameFuctions.HandleRoll(ThrowBtn, PointBtn);
        }
    }
}
