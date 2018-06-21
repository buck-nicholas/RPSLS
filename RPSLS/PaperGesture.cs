using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{
    public class PaperGesture : Gesture
    {
        public PaperGesture()
        {
            gestureName = "Paper";
            winsAgainst[0] = "rock";
            winsAgainst[1] = "spock";
        }
    }
}
