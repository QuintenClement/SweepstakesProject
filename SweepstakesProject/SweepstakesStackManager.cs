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
        //public Sweepstakes PickWinner()
        //{
        //    Random rnd = new Random();

        //    for (int i = 0; i < _sweepstakes.Count; i++)
        //    {
        //        if (_sweepstakes.ElementAt(i).Equals(rnd.Next(0, _sweepstakes.Count)))
        //        {
        //            return _sweepstakes.ElementAt(i);
        //        }

        //    }
            

        //}

    }
}
