using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

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

        private static int random_roll()
        {           //this function returns a number 1-6 this is a singe roll
            Random rnd = new Random();
            return rnd.Next(1, 7);
        }
    }
}
