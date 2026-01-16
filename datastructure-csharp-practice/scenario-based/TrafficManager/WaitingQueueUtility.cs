using System;
using System.Collections.Generic;

class WaitingQueueUtility
{
    private Queue<int> queue;
    private int capacity;

    public WaitingQueueUtility(int capacity)
    {
        this.capacity = capacity;
        queue = new Queue<int>();
    }

    // Check if queue is empty
    public bool IsEmpty()
    {
        return queue.Count == 0;
    }

    // Check if queue is full
    public bool IsFull()
    {
        return queue.Count == capacity;
    }

    // Add vehicle to waiting queue
    public void Enqueue(int data)
    {
        if (IsFull())
        {
            Console.WriteLine("Waiting queue full");
            return;
        }

        queue.Enqueue(data); // In-built enqueue
        Console.WriteLine($"Vehicle {data} added to waiting queue");
    }

    // Remove vehicle from waiting queue
    public int Dequeue()
    {
        if (IsEmpty())
        {
            Console.WriteLine("Waiting queue empty");
            return -1;
        }

        int vehicle = queue.Dequeue(); // In-built dequeue
        Console.WriteLine($"Vehicle {vehicle} removed from waiting queue");
        return vehicle;
    }

    // Display waiting queue
    public void Display()
    {
        if (IsEmpty())
        {
            Console.WriteLine("No waiting vehicles");
            return;
        }

        Console.Write("Waiting Queue: ");
        foreach (int vehicle in queue)
        {
            Console.Write(vehicle + " ");
        }
        Console.WriteLine();
    }
}
