using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SweepstakesProject
{
    public class Sweepstakes
    {
        int entries = 0;
        int winner;
        Dictionary<int, Contestant> contestants;

        public Sweepstakes(string name)
        { 
            contestants = new Dictionary<int, Contestant>();
        }

        public void MakeContestant()
        {
            Contestant _contestant = new Contestant();
        }
        public void Registercontestant(Contestant contestant)
        {
            contestants.Add(entries, contestant);
            contestant.entryNum = entries;
            entries++;
        }
        public int PickWinner()
        {
            Random rnd = new Random();
            int winner = rnd.Next(0, contestants.Count);
            PrintContestantInfo(winner);
            return winner;
        }

        public void PrintContestantInfo(int winner)
        {
            if (contestants.ContainsKey(winner).Equals(true))
            {
                Console.WriteLine(contestants.Values);
            }
            else
            {
                PickWinner();
            }
        }
    }
}
