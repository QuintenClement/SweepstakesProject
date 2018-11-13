using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SweepstakesProject
{
    class Sweepstakes
    {
        int entries = 0;
        int winner;
        Dictionary<int, Contestant> dict;

        public Sweepstakes(string title)
        {
            Contestant contestant = new Contestant();
            dict = new Dictionary<int, Contestant>();
        }

        public void Registercontestant(Contestant contestant)
        {
            dict.Add(entries, contestant);
            entries++;
        }
        public void pickWinner()
        {
            Random rnd = new Random();
            winner = rnd.Next(0, dict.Count);
        }

        public void PrintContestantInfo(Contestant contestant)
        {

        }
    }
}
