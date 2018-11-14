using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SweepstakesProject
{
    class MarketingFirm
    {
        private ISweepstakesManager sweepstakesManager;
        public MarketingFirm(ISweepstakesManager sweepstakes)
        {
            sweepstakesManager = sweepstakes;
        }
        public void InsertSweepstakes(Sweepstakes sweepstakes)
        {
            sweepstakesManager.InsertSweepstakes(sweepstakes);
        }
        public Sweepstakes GetSweepstakes()
        {
            return sweepstakesManager.GetSweepstakes();
        }
        public void RunProgram()
        {
            while ()
            {
                int num  = UI.Menu();
                switch (num)
                {
                    case 1:
                        MakeNewSweepstakes();
                        break;
                    case 2:
                        RegisterNewContestant();
                        break;
                    case 3:
                        UI.PickWinner();
                        PickWinner();
                        break;
                    case 4:
                        UI.PreviousSweepstakes();
                        break;
                    default:
                        Console.WriteLine("Please enter a valid response.(1,2,3,4)");
                        UI.Menu();
                        break;
                }
            }
        }
        public void MakeNewSweepstakes()
        {
            UI.NameNewSweepstakes();
            string sweepstakesName = Console.ReadLine();
            Sweepstakes NewSweepstakes = new Sweepstakes(sweepstakesName);
            InsertSweepstakes(NewSweepstakes);
            Console.WriteLine("Your new Sweepstake " + sweepstakesName + "has just been made.");
            UI.Menu();
        }
     

        public static void NewStackDataType()
        {
            UI.NameNewSweepstakes();
     
        }

        public void PickWinner(Sweepstakes sweepstakes)
        {
            sweepstakes.PickWinner();

        }

        public Sweepstakes PreviousSweepstakes()
        {
            return GetSweepstakes();
        }

        public static void RegisterNewContestant(Sweepstakes sweepstake)
        {
            UI.RegisterNewContestant();
            string name = Console.ReadLine();
            Contestant contestant = new Contestant();
            UI.GetInfo(contestant);
            sweepstake.Registercontestant(contestant);
            Console.WriteLine("Awesome! Your registered! You will be notified if you have won!");
            UI.Menu();
        }

        





    }
}
