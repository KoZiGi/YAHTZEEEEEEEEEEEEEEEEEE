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
        static List<int> rolls = GameFuctions.Rolls(6);

        public Form1()
        {
            InitializeComponent();
            MessageBox.Show($"{rolls[0]}, {rolls[1]}, {rolls[2]}, {rolls[3]}, {rolls[4]}, {rolls[5]}");
        }
    }
}
