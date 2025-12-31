using System;

class HotelBooking
{
    private string guestName;
    private string roomType;
    private int nights;

    // Default constructor
    public HotelBooking()
    {
        guestName = "Guest";
        roomType = "Standard";
        nights = 1;
    }

    // Parameterized constructor
    public HotelBooking(string guestName, string roomType, int nights)
    {
        this.guestName = guestName;
        this.roomType = roomType;
        this.nights = nights;
    }

    // Copy constructor
    public HotelBooking(HotelBooking other)
    {
        this.guestName = other.guestName;
        this.roomType = other.roomType;
        this.nights = other.nights;
    }

    public void Display()
    {
        Console.WriteLine($"{guestName} booked {roomType} room for {nights} nights");
    }
}

class hotel
{
    static void Main()
    {
        HotelBooking h1 = new HotelBooking();
        HotelBooking h2 = new HotelBooking("Raj", "Deluxe", 3);
        HotelBooking h3 = new HotelBooking(h2);

        h1.Display();
        h2.Display();
        h3.Display();
    }
}
