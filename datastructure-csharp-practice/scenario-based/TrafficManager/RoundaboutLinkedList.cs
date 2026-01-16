using System;
using System.Collections.Generic;

namespace TrafficManager
{
    public class RoundaboutLinkedList
    {
        private LinkedList<int> vehicles;
        private int capacity;

        public RoundaboutLinkedList(int capacity)
        {
            this.capacity = capacity;
            vehicles = new LinkedList<int>();
        }

        // Check if roundabout is full
        public bool IsFull()
        {
            return vehicles.Count == capacity;
        }

        // Check if roundabout is empty
        public bool IsEmpty()
        {
            return vehicles.Count == 0;
        }

        // Add vehicle to roundabout
        public void AddVehicle(int data)
        {
            if (IsFull())
            {
                Console.WriteLine("Roundabout is FULL");
                return;
            }

            vehicles.AddLast(data); // In-built LinkedList method
            Console.WriteLine($"Vehicle {data} entered the roundabout");
        }

        // Remove vehicle from roundabout
        public void RemoveVehicle()
        {
            if (IsEmpty())
            {
                Console.WriteLine("Roundabout is EMPTY");
                return;
            }

            Console.WriteLine($"Vehicle {vehicles.First.Value} exited the roundabout");
            vehicles.RemoveFirst(); // In-built removal
        }

        // Display circular movement
        public void Display()
        {
            if (IsEmpty())
            {
                Console.WriteLine("No vehicles in roundabout");
                return;
            }

            Console.Write("Roundabout Vehicles: ");

            foreach (int vehicle in vehicles)
            {
                Console.Write(vehicle + " -> ");
            }

            // Circular indication
            Console.WriteLine(vehicles.First.Value + " (CIRCULAR)");
        }
    }
}
