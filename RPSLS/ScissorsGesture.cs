using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{
    public class ScissorsGesture : Gesture
    {
        public ScissorsGesture()
        {
            gestureName = "Scissors";
            winsAgainst[0] = "paper";
            winsAgainst[1] = "lizard";
        }
    }
}
