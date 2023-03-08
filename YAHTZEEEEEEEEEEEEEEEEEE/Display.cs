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


    }
}
