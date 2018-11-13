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
        Dictionary<int, Contestant> dict;

        public Sweepstakes(string name)
        { 
            dict = new Dictionary<int, Contestant>();
        }

        public void MakeContestant()
        {
            Contestant _contestant = new Contestant();
        }
        public void Registercontestant(Contestant contestant)
        {
            dict.Add(entries, contestant);
            contestant.entryNum = entries;
            entries++;
        }
        public void pickWinner()
        {
            Random rnd = new Random();
            winner = rnd.Next(0, dict.Count);
            
        }

        public void PrintContestantInfo(Contestant contestant)
        {
            if (dict.ContainsKey(winner).Equals(true))
            {
                Console.Write(dict.Values);
            }
            else
            {
                pickWinner();
            }
        }
    }
}
