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
            bool midle_numbers = rolls.Contains(2) && rolls.Contains(3) && rolls.Contains(4) && rolls.Contains(5);
            if (midle_numbers)
            {
                if (rolls.Contains(1) && isSmallStraight) return 30;
                if (rolls.Contains(6) && !isSmallStraight) return 40;
            }
            return 0;
        }

        public static int Chance_Check(List<int> rolls)
        {
            return rolls.Sum();
        }

        public static int Drill_Poker_Yahtzee_check(List<int> rolls, int times)
        {   
            TroubleShooting.Drill_Poker_Yahtzee_check(times);
            Dictionary<int, int> result = rolls_to_dict(rolls);
            if (times == 5 && result.Values.Contains(5)) return 50;
            if (result.Values.Contains(times)) return times * multiple_values(result, times);
            return 0;
        }
        public static int kindCheck(List<int> rolls, int count)
        {
            for (int i = 1; i < 7; i++)
            {
                if (rolls.Count(e => e == i) >= count) return count == 5 ? 50 : i * count;
            }
            return 0;
        }
        public static int houseCheck(List<int> rolls)
        {


            return 0;
        }
        private static int multiple_values(Dictionary<int, int> dict, int times)
        {
            foreach (KeyValuePair<int,int> item in dict)
            {
                if (item.Value == times) return item.Key;
            }
            return 0;
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

        public static int Fullhouse_check(List<int> rolls)
        {
            Dictionary<int, int> unit_per_num = rolls_to_dict(rolls);
            if (unit_per_num.Count == 2
                && unit_per_num.Values.Contains(2)
                && unit_per_num.Values.Contains(3)) return fullhouse_score_calc(unit_per_num); 
            return 0;
        }

        private static int fullhouse_score_calc(Dictionary<int, int> unit_per_num)
        {
            int result = 0;
            foreach (KeyValuePair<int,int> item in unit_per_num)
            {
                result += item.Key * item.Value;
            }
            return result;
        }

        private static Dictionary<int,int> rolls_to_dict(List<int> rolls)
        {
            Dictionary<int, int> result = new Dictionary<int, int>();
            foreach(var item in rolls)
            {
                if (!result.Keys.Contains(item)) result.Keys.Append(item);
                else result[item]++;
            }    
            return result;
        }
    }
}
