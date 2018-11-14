using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SweepstakesProject
{
    public static class UI
    {
        
        public static void EnterSweep()
        {
            Console.WriteLine("What Sweepstakes would you like to join?");
            Console.ReadLine();
        }
        public static void GetInfo(Contestant contestant)
        {           
            Console.WriteLine("Please enter your first name:");
            contestant.firstName = Console.ReadLine();
            Console.WriteLine("Thank you! Now please enter your last name:");
            contestant.lastName = Console.ReadLine();
            Console.WriteLine("Perfect! Almost done, can you please enter your email address:");
            contestant.email = Console.ReadLine();
        }
        public static void NameNewSweepstakes()
        {
            Console.WriteLine("What would you like to name your new Sweepstakes?");

        }

        public static void SelectDataStorageType()
        {
            Console.WriteLine("Please select the type of data structure you would like to use. (Stack or Queue)");
        }

        public static int Menu()
        {
          
            Console.WriteLine("Hello! Welcome to your sweepstakes manager tool!");
            Console.WriteLine("Menu:");
            Console.WriteLine("1: Make new Sweepstakes");
            Console.WriteLine("2: Register a new contestant");
            Console.WriteLine("3: See previous Sweepstakes");
            Console.WriteLine("4: Pick winner of Sweepstakes");
            int num = Int32.Parse(Console.ReadLine());
            return num;
        }
        
        public static void RegisterNewContestant()
        {
            Contestant contestant = new Contestant();
            GetInfo(contestant);
            Console.WriteLine("Awesome! Your registered! You will be notified if you have won!");
            Menu();
        }
        public static void PreviousSweepstakes()
        {
            Console.WriteLine("Here is a previous sweepstakes");

        }
        public static void PickWinner()
        {
            Console.WriteLine("The winner of the sweepstakes is: ");
            
        }
    }
}
