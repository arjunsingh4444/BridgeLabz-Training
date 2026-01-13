namespace BridgeLabzTraining.oops_csharp_practice.scenario_based.cinema_time
{
    // Interface defines allowed cinema operations
    public interface ICinemaService
    {
        void AddMovie(string title, string time); // Add a new movie to the schedule
        void SearchMovie(string keyword); //     Search for a movie by title or keyword 
        void DisplayAllMovies(); // Display all movies in the schedule
        void PrintReport(); // Print a report of all movies in the schedule
    }
}
