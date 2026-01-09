using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabzTraining.oops_csharp_practice.scenario_based.fitness_tracker
{
   

    class FitTrack
    {
        static void Main()
        {
            Console.Write("Enter User Name: "); //asking user to enter name
            string name = Console.ReadLine();

            UserProfile user = new UserProfile(name); //creating user profile object

            int choice;
            do
            {
                Console.WriteLine("\n---- FitTrack Menu ----"); //displaying menu
                Console.WriteLine("1. Cardio Workout");
                Console.WriteLine("2. Strength Workout");
                Console.WriteLine("3. Exit");
                Console.Write("Enter choice: ");
                choice = int.Parse(Console.ReadLine());

                switch (choice)
                { 
                    case 1: //cardio workout
                        CardioWorkout cardio = new CardioWorkout();
                        Console.Write("Enter duration in minutes: ");
                        cardio.DurationMinutes = int.Parse(Console.ReadLine());
                        user.PerformWorkout(cardio);
                        break;

                    case 2: //strength workout
                        StrengthWorkout strength = new StrengthWorkout();
                        Console.Write("Enter duration in minutes: ");
                        strength.DurationMinutes = int.Parse(Console.ReadLine());
                        user.PerformWorkout(strength);
                        break;

                    case 3: 
                        Console.WriteLine("Exiting FitTrack--.");
                        break;

                    default:
                        Console.WriteLine("Invalid choice ");
                        break;
                }
            }
            while (choice != 3); //exiting loop when user chooses to exit

            Console.WriteLine("Thank you for using FitTrack.");
        }
    }

}
