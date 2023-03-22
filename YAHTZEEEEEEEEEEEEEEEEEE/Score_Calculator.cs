using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YAHTZEEEEEEEEEEEEEEEEEE
{
    class Score_Calculator
    {
        //returns single score for a specific number (1-6)
        public static int Single_Scores(int number, List<int> rolls)
        {       
            int score = 0;
            for (int i = 0; i < rolls.Count; i++)
            {
                if (rolls[i] == number) score += number;
            }
            return score;
        }

        public static int Peirs_Scores(bool isSinglePair, List<int>rolls)
            => isSinglePair ? SinglePair(rolls) : TwoPair(rolls);
        /*
         * if there is four of one number, then return that * 4,
         * otherwise if the pairs array has a 0, then there are no two pairs,
         * otherwise return the sum of the array
         */
        private static int TwoPair(List<int> rolls)
        {
            int[] pairs = new int[2] { 0, 0 };
            int i = 0;
            foreach (int value in rolls.Distinct().ToList())
            {
                if (rolls.Count(e => e == value) >= 4) return value * 4;
                else if (rolls.Count(g => g == value) >= 2)
                {
                    pairs[i] = value * 2;
                    i++;
                }
            }
            return pairs.Contains(0) ? 0 : pairs.Sum();
        }
        //Return the maximum score of a pair, if there are more, if there are no pairs at all return 0
        private static int SinglePair(List<int> rolls)
        {
            List<int> scores = new List<int>();
            for (int i = 1; i < 7; i++)
            {
                scores.Add(rolls.Count(e => e == i) >= 2 ? i * 2 : 0);
            }
            return scores.Max();
        }
        public static int Straight_Check(bool isSmallStraight, List<int> rolls)
        {   
            bool midle_numbers = rolls.Contains(2) && rolls.Contains(3) && rolls.Contains(4) && rolls.Contains(5);
            if (midle_numbers)
            {
                if (rolls.Contains(1) && isSmallStraight) return 30;
                if (rolls.Contains(6) && !isSmallStraight) return 40;
            }
            return 0;
        }

        public static int Chance_Check(List<int> rolls)
            => rolls.Sum();

        public static int kindCheck(List<int> rolls, int count)
        {
            for (int i = 1; i < 7; i++)
            {
                if (rolls.Count(e => e == i) >= count) return count == 5 ? 50 : i * count;
            }
            return 0;
        }
        /*
         * if there are 5 of the same kind, return that * 5,
         * otherwise return the two of the same * 2 and three of the same * 3
         */
        public static int houseCheck(List<int> rolls)
        {
            if (rolls.Distinct().ToList().Count == 2)
            {
                if ((rolls.Count(e => rolls.Distinct().ToList()[0] == e) == 2 &&
                    rolls.Count(e => rolls.Distinct().ToList()[1] == e) == 3))
                {
                    return rolls.Distinct().ToList()[0] * 2 + rolls.Distinct().ToList()[1] * 3;
                }
                else if ((rolls.Count(e => rolls.Distinct().ToList()[0] == e) == 3 &&
                    rolls.Count(e => rolls.Distinct().ToList()[1] == e) == 2))
                {
                    return rolls.Distinct().ToList()[1] * 2 + rolls.Distinct().ToList()[0] * 3;
                }
            }
            if (rolls.Distinct().ToList().Count == 1)
            {
                return rolls.Distinct().ToList()[0]*5;
            }
            return 0;
        }
    }
}
