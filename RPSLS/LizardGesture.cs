using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{
    public class LizardGesture : Gesture
    {
        public LizardGesture()
        {
            gestureName = "Lizard";
            winsAgainst[0] = "spock";
            winsAgainst[1] = "paper";
        }
    }
}
