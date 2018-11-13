using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SweepstakesProject
{
    class MarketingFirm
    {
        private ISweepstakesManager _sweepstakes;
        public MarketingFirm(ISweepstakesManager sweepstakes)
        {
            _sweepstakes = sweepstakes;
        }
        public void InsertSweepstakes(Sweepstakes sweepstakes)
        {
            _sweepstakes.InsertSweepstakes(sweepstakes);
        }
        public void GetSweepstakes()
        {

        }
    }
}
