using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YAHTZEEEEEEEEEEEEEEEEEE
{
    public class Scores
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
        public int TotalScore() 
            => Singles.Where(e=>e!=-1).Sum() + Pairs.Where(e=>e!=-1).Sum() +
               TotalHelper(ThreeOfAKind) + TotalHelper(FourOfAKind) +
               TotalHelper(Yahtzee) + TotalHelper(StraightLarge) + TotalHelper(StraightSmall) +
               TotalHelper(FullHouse) + TotalHelper(Sum);
        private int TotalHelper(int points) => points == -1 ? 0 : points;
        public bool IsFinished()
            =>  Singles.Count(e => e == -1) == 0 && Pairs.Count(e => e == -1) == 0 &&
                ThreeOfAKind != -1 && FourOfAKind != -1 && Yahtzee != -1 &&
                StraightLarge != -1 && StraightSmall != -1 && FullHouse != -1 && Sum != -1;
    }
}
