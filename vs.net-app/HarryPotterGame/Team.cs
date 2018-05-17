using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HarryPotterGame
{
    class Team
    {

        private int score;

        private List<String> members;

        public Team()
        {
            score = 0;
        }

        public int Score
        {
            get
            {
                return score;
            }
        }
        
        public void ResetScore()
        {
            score = 0;
        }

        public void IncrementScore()
        {
            score++;
        }

        public List<string> Members
        {
            get
            {
                return members;
            }

            set
            {
                members = value;
            }
        }

    }
}
