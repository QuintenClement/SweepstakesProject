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
        public Sweepstakes GetSweepstakes(Sweepstakes sweepstakes)
        {
            return _sweepstakes.GetSweepstakes(sweepstakes);
        }

        public void RunProgram()
        {
            UI.Menu();
            
            
        }
        public static void MakeNewSweepstakes()
        {
            UI.SelectDataStorageType();
        }
        public static void NewQueueDataType()
        {

        }

        public static void NewStackDataType()
        {
            UI.NameNewSweepstakes();
            
            MarketingFirm.
        }

        public static void PickWinner()
        {

        }

        public static void PreviousSweepstakes()
        {

        }

        public static void RegisterNewContestant()
        {

        }

        





    }
}
