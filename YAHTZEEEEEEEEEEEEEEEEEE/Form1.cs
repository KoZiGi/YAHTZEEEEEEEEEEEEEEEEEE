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
        public Form1()
        {
            InitializeComponent();
            setUpDisplayFunctions();
        }
        private void setUpDisplayFunctions()
        {
            Dice1.Click += delegate { Display.diceClick(Dice1); };
            Dice2.Click += delegate { Display.diceClick(Dice2); };
            Dice3.Click += delegate { Display.diceClick(Dice3); };
            Dice4.Click += delegate { Display.diceClick(Dice4); };
            Dice5.Click += delegate { Display.diceClick(Dice5); };
        }
    }
}
