using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SweepstakesProject
{
    public class UI
    {
        
        public void EnterSweep()
        {
            Console.WriteLine("What Sweepstakes would you like to join?");
            Console.ReadLine();
        }
        public void GetInfo(Contestant contestant)
        {
            
            string lastName;
            string email;
            
            Console.WriteLine("Please enter your first name:");
            contestant.firstName = Console.ReadLine();
            Console.WriteLine("Thank you! Now please enter your last name:");
            lastName = Console.ReadLine();
            Console.WriteLine("Perfect! Almost done, can you please enter your email address:");
            email = Console.ReadLine();
        }
    }
}
