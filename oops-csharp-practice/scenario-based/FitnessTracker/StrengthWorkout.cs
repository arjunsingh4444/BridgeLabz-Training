using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabzTraining.oops_csharp_practice.scenario_based.fitness_tracker
{
    public class StrengthWorkout : Workout // Inheriting from Workout class
    {
        public override void TrackWorkout() //
        {
            Console.WriteLine("Strength workout selected.");
        }

        public override int CalculateCalories() // overriding the CalculateCalories method
        {
            return durationMinutes * 5; // calories per minute
        }
    }
}
