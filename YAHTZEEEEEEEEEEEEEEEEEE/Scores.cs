using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YAHTZEEEEEEEEEEEEEEEEEE
{
    class Scores
    {
        public int[] Singles;
        public int[] Pairs;
        public int ThreeOfAKind;
        public int FourOfAKind;
        public int Yahtzee;
        public int StraightSmall;
        public int StraightLarge;
        public int FullHouse;
        public int Sum;

        public Scores()
        {
            Singles = new int[6] { -1, -1, -1, -1, -1, -1 };
            Pairs = new int[2] { -1, -1 };
            ThreeOfAKind = -1;
            FourOfAKind = -1;
            Yahtzee = -1;
            StraightSmall = -1;
            StraightLarge = -1;
            FullHouse = -1;
            Sum = -1;
        }

    }
}
