using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabzTraining.oops_csharp_practice.scenario_based.fitness_tracker
{
    public abstract class Workout : ITrackable //abstract class
    {
        protected int durationMinutes; //protected field

        public int DurationMinutes 
        {
            get { return durationMinutes; }
            set { durationMinutes = value; }
        }

        public abstract void TrackWorkout(); //abstract method to be implemented by child classes
        public abstract int CalculateCalories(); //abstract method to be implemented by child classes
    }
}
