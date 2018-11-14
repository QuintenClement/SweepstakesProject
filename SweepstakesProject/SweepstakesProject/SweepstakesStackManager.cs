using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SweepstakesProject
{
    class SweepstakesStackManager : ISweepstakesManager
    {
        Stack<Sweepstakes> _sweepstakes;
        public SweepstakesStackManager() 
        {
            _sweepstakes = new Stack<Sweepstakes>();
        }
        public void InsertSweepstakes(Sweepstakes sweepstakes)
        {
            _sweepstakes.Push(sweepstakes);
        }
        public Sweepstakes GetSweepstakes()
        {
            return _sweepstakes.Pop();

        }

    }
}
