using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SweepstakesProject
{
    class SweepstakesQueueManager : ISweepstakesManager
    {
        Queue<Sweepstakes> sweepstakes;
        public SweepstakesQueueManager()
        {
            sweepstakes = new Queue<Sweepstakes>();
        }
        public void InsertSweepstakes()
        {
        }
        public Sweepstakes GetSweepstakes()
        {

        }
        
    }
}
