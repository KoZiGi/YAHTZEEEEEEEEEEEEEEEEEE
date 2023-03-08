using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace YAHTZEEEEEEEEEEEEEEEEEE
{
    class TroubleShooting       //this class is only for developers, chechking for bad input parameters
    {
        public static void Singles_check(int number)
        {       //this checks the single scores function
            if (number > 0 && number < 7) MessageBox.Show("Single_Scores, rossz bemeneti paraméter!");
        }

    }
}
