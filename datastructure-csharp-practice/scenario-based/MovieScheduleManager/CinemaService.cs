using System;

namespace BridgeLabzTraining.oops_csharp_practice.scenario_based.cinema_time 
{
    // Concrete(have body)class implementing cinema operations using arrays
    public class CinemaService : ICinemaService
    {
        private string[] movieTitles = new string[50]; // max 50 movies
        private string[] movieTimes = new string[50]; //
        private int count = 0; // current number of movies

        // Add a movie
        public void AddMovie(string title, string time) 
        {
            if (count >= movieTitles.Length) // check if array is full
            {
                Console.WriteLine("Movie list is full.");
                return;
            }

            movieTitles[count] = title; // add movie title to array
            movieTimes[count] = time; // add movie time to array
            count++;
        }

        // Search movies by keyword
        public void SearchMovie(string keyword)
        {
            bool found = false; 
            for (int i = 0; i < count; i++) // loop through all movies
            {
                if (movieTitles[i].ToLower().Contains(keyword.ToLower())) // check if movie title contains keyword
                {
                    Console.WriteLine($"{movieTitles[i]} at {movieTimes[i]}"); // print movie details
                    found = true;
                }
            }

            if (!found)
                Console.WriteLine("No movie found.");
        }

        // Display all movies
        public void DisplayAllMovies()
        {
            if (count == 0)
            {
                Console.WriteLine("No movies available.");
                return;
            }

            for (int i = 0; i < count; i++)
            {
                Console.WriteLine($"{i + 1}. {movieTitles[i]} at {movieTimes[i]}");
            }
        }

        // Print movie report
        public void PrintReport()
        {
            if (count == 0)
            {
                Console.WriteLine("No movies to display in report.");
                return;
            }

            string[] titlesArray = new string[count]; // create new arrays to store movie titles and times
            string[] timesArray = new string[count]; //
            Array.Copy(movieTitles, titlesArray, count); // copy movie titles to new array
            Array.Copy(movieTimes, timesArray, count); // copy movie times to new array

            Console.WriteLine("\nMovie Report:");
            for (int i = 0; i < count; i++) // loop through all movies and print report
            {
                Console.WriteLine($"{titlesArray[i]} - {timesArray[i]}"); // print movie details
            }
        }
    }
}
