using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YAHTZEEEEEEEEEEEEEEEEEE
{
    class Globals
    {
        public static List<int> Previous_Roll = new List<int>() { 1, 1, 1, 1, 1 };
        public static int Throws = 3;
        public static int CurrentPlayerIndex = 0;
        public static List<Player> Players = new List<Player>();
    }
}
