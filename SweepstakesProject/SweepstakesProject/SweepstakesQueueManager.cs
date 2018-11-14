using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SweepstakesProject
{
    class SweepstakesQueueManager : ISweepstakesManager
    {
        Queue<Sweepstakes> _sweepstakes;
        public SweepstakesQueueManager()
        {
            _sweepstakes = new Queue<Sweepstakes>();
        }
        public void InsertSweepstakes(Sweepstakes sweepstakes)
        {
            _sweepstakes.Enqueue(sweepstakes);
        }
        public Sweepstakes GetSweepstakes()
        {
            return _sweepstakes.Dequeue();
        }
        
    }
}
