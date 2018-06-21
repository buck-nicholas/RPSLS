using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{
    public class SpockGesture : Gesture
    {
        public SpockGesture()
        {
            gestureName = "Spock";
            winsAgainst[0] = "rock";
            winsAgainst[1] = "scissors";
        }
    }
}
