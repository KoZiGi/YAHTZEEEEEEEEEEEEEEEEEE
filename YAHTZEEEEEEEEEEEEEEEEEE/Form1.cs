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
        private int currentPlayerIndex = 0;
        public Form1(List<string> players)
        {
            InitializeComponent();
            setUpDisplayFunctions(players);
            LeaderboardLbx.SelectedIndexChanged += delegate { handlePlayerinput(); };
        }
        private void setUpDisplayFunctions(List<string> players)
        {
            Dice1.Click += delegate { Display.diceClick(Dice1); };
            Dice2.Click += delegate { Display.diceClick(Dice2); };
            Dice3.Click += delegate { Display.diceClick(Dice3); };
            Dice4.Click += delegate { Display.diceClick(Dice4); };
            Dice5.Click += delegate { Display.diceClick(Dice5); };
            setUpLeaderBoard(players);
        }
        private void handlePlayerinput()
        {
            LeaderboardLbx.SelectedIndex = currentPlayerIndex;
        }
        private void setUpLeaderBoard(List<string> players)
        {
            if (players.ToArray().Length > 0)
            {
                LeaderboardLbx.Items.AddRange(players.ToArray());
            }
            else
            {
                LeaderboardLbx.Items.Add("Játékos 1");
            }
            LeaderboardLbx.SelectedIndex = currentPlayerIndex;
        }
        private void ThrowBtn_Click(object sender, EventArgs e)
        {
            Display.DisplayRoll(new Label[] { Dice1, Dice2, Dice3, Dice4, Dice5 }, GameFuctions.Rolls(5));
        }
    }
}
