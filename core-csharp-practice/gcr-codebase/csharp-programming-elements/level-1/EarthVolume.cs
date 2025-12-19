using System;

class EarthVolume
{
    static void Main()
    {
        double radiusKm = 6378;   //radius 
        double pi = Math.PI;   //pi value 

        double volumeKm = (4.0 / 3.0) * pi * Math.Pow(radiusKm, 3);  //volume formula in cubic km
        double volumeMiles = volumeKm / Math.Pow(1.609, 3);     //converting volume from km cubes to miles cube

        Console.WriteLine($"The volume of earth in cubic kilometers is {volumeKm} and cubic miles is {volumeMiles}");
    }
}
