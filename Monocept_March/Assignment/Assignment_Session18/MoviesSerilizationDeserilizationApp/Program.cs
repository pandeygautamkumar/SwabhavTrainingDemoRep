using MoviesSerilizationDeserilizationApp.Model;
using System.Runtime.Serialization.Formatters.Binary;
using System.Security.Cryptography;

namespace MoviesSerilizationDeserilizationApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CaseStudy1Serilization();
            CaseStudy2Deserilization();
        }

        private static void CaseStudy2Deserilization()
        {
            MovieStore movieStore;
            string path = "C:\\SwbhavLiveSessions\\MonoceptMarch\\Assignment\\Assignment_Session18\\MoviesSerilizationDeserilizationApp\\bin\\Debug\\net6.0\\movie.dump";
            FileStream fs = new FileStream(path, FileMode.Open, FileAccess.Read);
            BinaryFormatter binaryFormatter = new BinaryFormatter();
            movieStore = (MovieStore)binaryFormatter.Deserialize(fs);

            Console.WriteLine("After Deserlization");
            Console.WriteLine();

            List<Movie> movies = movieStore.GetMovies();
            PrintMoviesDetails(movies);
            fs.Close();
        }

        private static void PrintMoviesDetails(List<Movie> movies)
        {
            Console.WriteLine("Displaying Movies: ");
            Console.WriteLine("-------------------------------------------------------");
            foreach (Movie movie in movies)
            {
                if (movie == null)
                    break;
                Console.WriteLine($"Movie is : {movie.MovieName} , Released in : {movie.ReleasedYear}");
            }
        }

        private static void CaseStudy1Serilization()
        {
            MovieStore movieStore = new MovieStore();
            for (int i = 0; i < 3; i++)
            {
                TakeMovieDetails(movieStore);
            }

            FileStream fs = new FileStream("movie.dump", FileMode.Create, FileAccess.Write);
            BinaryFormatter binaryFormatter = new BinaryFormatter();
            binaryFormatter.Serialize(fs, movieStore);
            fs.Close();
            Console.WriteLine("Serialization Completed");
        }

        private static void TakeMovieDetails(MovieStore movieStore)
        {
            string movieName;
            int releasedYear;
            Console.Write("Enter Movie Name: ");
            movieName = Console.ReadLine();
            Console.Write("Enter Released Year : ");
            releasedYear = int.Parse(Console.ReadLine());
            movieStore.AddMovie(new Movie(movieName, releasedYear));
        }
    }
}