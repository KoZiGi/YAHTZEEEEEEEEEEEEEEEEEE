using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YAHTZEEEEEEEEEEEEEEEEEE
{
    class Score_Calculator
    {
        public static int Single_Scores(int number, List<int> rolls)
        {       //returns single score for a specific number (1-6)
            TroubleShooting.Singles_check(number);
            int score = 0;
            for (int i = 0; i < rolls.Count; i++)
            {
                if (rolls[i] == number) score += number;
            }
            return score;
        }

        public static int Peirs_Scores(bool isSinglePair, List<int>rolls)
        {       //returns the peirs scores
            if (isSinglePair && check_for_pairs(rolls).Count==2)
            {
                return check_for_pairs(rolls)[0]*2;
            }
            else if(!isSinglePair && check_for_pairs(rolls).Count==4)
            {
                return (check_for_pairs(rolls)[0] * 2) + (check_for_pairs(rolls)[2] * 2);
            }
            return 0;
        }

        public static int Straight_Check(bool isSmallStraight, List<int> rolls)
        {
            if(isSmallStraight)
        }

        private static List<int> check_for_pairs(List<int> rolls)
        {       //returns a list of numbers that has at least 2 copy in the rolls list
            List<int> multiple_result = new List<int>();
            for (int i = 0; i < rolls.Count; i++)
            {
                int counter = 0;
                for (int j = 0; j < rolls.Count; j++) if (rolls[i] == rolls[j]) counter++;
                if (counter > 1) multiple_result.Add(rolls[i]);
            }
            return multiple_result.OrderByDescending(x=>x).ToList();
        }

        private static int chechk_for_straights(List<int> rolls)
        {
            bool midle_numbers = rolls.Contains(2) && rolls.Contains(3) && rolls.Contains(4) && rolls.Contains(5);
            if (midle_numbers)
            {
                if (rolls.Contains(1)) return 30;
                if (rolls.Contains(6)) return 40;
            } 
            return 0;
        }
    }
}
