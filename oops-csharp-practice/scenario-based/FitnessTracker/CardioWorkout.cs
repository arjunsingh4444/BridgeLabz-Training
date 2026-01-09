using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabzTraining.oops_csharp_practice.scenario_based.fitness_tracker // namespace 
{
    public class CardioWorkout : Workout // class CardioWorkout inherits from Workout
    {
        public override void TrackWorkout() // overriding the TrackWorkout method of Workout class
        {
            Console.WriteLine("Cardio workout selected.");
        }

        public override int CalculateCalories() // overriding the CalculateCalories method of Workout class
        { 
            return durationMinutes * 8; // calories per minute
        }
    }
}
