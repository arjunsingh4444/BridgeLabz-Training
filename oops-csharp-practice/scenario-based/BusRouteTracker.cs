using System;

class BusRouteTracker
{
    static void Main()
    {
        int totalDistance = 0;   // stores total distance travelled
        Console.WriteLine("Enter the distance between each stop =");
        int stopDistance = int.Parse(Console.ReadLine());    // distance between each stop (km)

        Console.WriteLine(" Bus Route Distance Tracker");

        while (true)
        {
            // Add distance for each stop
            totalDistance = totalDistance + stopDistance;
            Console.WriteLine("Bus reached next stop.");
            Console.WriteLine("Total Distance: " + totalDistance + " km");

            // Ask passenger if they want to get off
            Console.Write("Do you want to get off here? (yes/no): ");
            string choice = Console.ReadLine();

            // Exit condition
            if (choice == "yes")
            {
                Console.WriteLine("You got off the bus.");
                break; // exit loop
            }
        }

        Console.WriteLine("Journey Ended. Total Distance Travelled: " + totalDistance + " km");
    }
}
