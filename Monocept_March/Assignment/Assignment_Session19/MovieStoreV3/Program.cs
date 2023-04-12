using MovieStoreV3.Model;
using System.Runtime.Serialization.Formatters.Binary;
using System.Security.Cryptography;

namespace MovieStoreV3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MovieStore movieStore1 = new MovieStore();
            while (true)
            {
                DisplayMenu(movieStore1);
                TakeUserChoice(movieStore1);
            }
        }
        private static void DisplayMenu(MovieStore movieStore)
        {
            Console.WriteLine($"Welcome to Movie Store App. Available Movies are : {movieStore.NoOfMovies}");
            Console.WriteLine("(1).Add      (2).Display       (3).Exit");
        }
        private static void TakeUserChoice(MovieStore movieStore)
        {
            Console.Write("Enter Our Choice : ");
            int choice = int.Parse(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    string movieName;
                    int releasedYear;
                    TakeMovieDetails(out movieName, out releasedYear);
                    movieStore.AddMovie(new Movie(movieName, releasedYear));
                    break;
                case 2:
                    List<Movie> movies = movieStore.GetMovies();
                    PrintMoviesDetails(movies);
                    break;
                case 3:
                    Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("You entered Wrong Choice.");
                    break;
            }
            Console.WriteLine();
        }
        private static void PrintMoviesDetails(List<Movie> movies)
        {
            Console.WriteLine("Displaying Movies: ");
            Console.WriteLine("-------------------------------------------------------");
            foreach (Movie movie in movies)
            {
                Console.WriteLine($"Movie is : {movie.MovieName} , Released in : {movie.ReleasedYear}");
            }
        }
        private static void TakeMovieDetails(out string movieName, out int releasedYear)
        {
            Console.Write("Enter Movie Name: ");
            movieName = Console.ReadLine();
            Console.Write("Enter Released Year : ");
            releasedYear = int.Parse(Console.ReadLine());
        }
    }
}