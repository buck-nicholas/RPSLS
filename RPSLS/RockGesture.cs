using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{
    public class RockGesture : Gesture
    {
        public RockGesture()
        {
            gestureName = "Rock";
            winsAgainst[0] = "scissors";
            winsAgainst[1] = "lizard";
        }
    }
}
