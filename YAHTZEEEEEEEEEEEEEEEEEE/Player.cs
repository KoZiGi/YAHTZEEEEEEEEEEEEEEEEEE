using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YAHTZEEEEEEEEEEEEEEEEEE
{
    public class Player
    {
        public string Name;
        private Scores playerScore = new Scores();
        public Player(string name)
        {
            Name = name;
        }
    }
}
