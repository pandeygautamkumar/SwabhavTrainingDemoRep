using System;

namespace MoviesSerilizationDeserilizationApp.Model
{
    [Serializable]
    internal class MovieStore
    { 
        private List<Movie> movies;
        public MovieStore()
        {
            movies = new List<Movie>();
        }
        public void AddMovie(Movie movie)
        {
            movies.Add(movie);
            Console.WriteLine("Movie are Added Successfully");
        }
        public List<Movie> GetMovies()
        {
            return movies;
        }
    }
}
