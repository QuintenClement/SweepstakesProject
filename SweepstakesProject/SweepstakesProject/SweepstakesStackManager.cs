using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SweepstakesProject
{
    class SweepstakesStackManager : ISweepstakesManager
    {
        Stack<Sweepstakes> sweepstakes;
        public SweepstakesStackManager() 
        {
            sweepstakes = new Stack<Sweepstakes>();
        }
        public void InsertSweepstakes()
        {
        }
        public void GetSweepstakes(ISweepstakesManager sweepstakes)
        {

        }

    }
}
