using System;

namespace MovieBusinessLayerLib.Model
{
    public class MovieStore
    {
        private int _noOfMovie;
        private Movie[] movies;
        public MovieStore()
        {
            _noOfMovie = 0;
            movies = new Movie[1];
        }
        public void AddMovie(Movie movie)
        {
            if (_noOfMovie == movies.Length)
            {
                IncreaseCapacity();
            }
            movies[_noOfMovie++] = movie;
            Console.WriteLine("Movie are Added Successfully");
        }
        public void GetMovies()
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
        public int NoOfMovies
        {
            get { return _noOfMovie; }
        }
        private void IncreaseCapacity()
        {
            int prevCapacity = movies.Length;
            Movie[] temporaryCapacity = movies;
            movies = new Movie[2 * prevCapacity];
            for (int j = 0; j < prevCapacity; j++)
            {
                movies[j] = temporaryCapacity[j];
            }
        }
    }
}
