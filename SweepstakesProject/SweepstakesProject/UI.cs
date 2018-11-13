using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SweepstakesProject
{
    public class UI
    {
        Sweepstakes sweepstakes;
        public void EnterSweep()
        {
            Console.WriteLine("What Sweepstakes would you like to join?");
            Console.ReadLine();
        }
        public void GetInfo(Contestant contestant)
        {           
            Console.WriteLine("Please enter your first name:");
            contestant.firstName = Console.ReadLine();
            Console.WriteLine("Thank you! Now please enter your last name:");
            contestant.lastName = Console.ReadLine();
            Console.WriteLine("Perfect! Almost done, can you please enter your email address:");
            contestant.email = Console.ReadLine();
        }

        public void SelectDataStorageType()
        {
            Console.WriteLine("Hello! Welcome to your Sweepstakes Manager Tool.");
            Console.WriteLine("Please select the type of data structure you would like to use.");
            Console.WriteLine("")
            
        }

        public void Menu()
        {
            
            Console.WriteLine("Menu:");
            Console.WriteLine("1: Make new Sweepstakes");
            Console.WriteLine("2: Register a new contestant");
            Console.WriteLine("3: See previous Sweepstakes");
            Console.WriteLine("4: Pick winner of Sweepstakes");
            int num = Int32.Parse(Console.ReadLine());
            switch (num)
            {
                case 1:
                    MakeNewSweepstakes();
                    break;
                case 2:
                    RegisterNewContestant();
                    break;
                case 3:
                    PickWinner();
                    break;
                case 4:
                    PreviousSweepstakes();
                    break;
                default:
                    Console.WriteLine("Please enter a valid response.(1,2,3,4)");
                    Menu();
                    break;
            }
        }
        public void MakeNewSweepstakes()
        {
            string name = Console.ReadLine();
            Sweepstakes sweepstakes = new Sweepstakes(name);
            Menu();
        }
        public void RegisterNewContestant()
        {
            Contestant contestant = new Contestant();
            GetInfo(contestant);
            Console.WriteLine("Awesome! Your registered! You will be notified if you have won!");
            Menu();
        }
        public void PreviousSweepstakes()
        {

        }
        public void PickWinner()
        {
           
        }
    }
}
