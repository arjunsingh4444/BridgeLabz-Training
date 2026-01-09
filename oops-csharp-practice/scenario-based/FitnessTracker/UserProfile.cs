using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabzTraining.oops_csharp_practice.scenario_based.fitness_tracker
{
    public class UserProfile //Class
    {
        private string userName; //Instance variable

        public UserProfile(string name) //Constructor
        {
            userName = name;
        }

        public void PerformWorkout(Workout workout) //Method to perform workout 
        {
            workout.TrackWorkout(); //Calling method to track workout

            Console.WriteLine("User: " + userName); //Printing user name and workout details
            Console.WriteLine("Duration: " + workout.DurationMinutes + " minutes");
            Console.WriteLine("Calories Burned: " + workout.CalculateCalories());
        }
    }
}
