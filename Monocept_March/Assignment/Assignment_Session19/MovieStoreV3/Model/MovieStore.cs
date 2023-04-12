using System;
using System.Runtime.Serialization.Formatters.Binary;

namespace MovieStoreV3.Model
{
    [Serializable]
    internal class MovieStore
    {
        private int _noOfMovies;
        private List<Movie> movies = new List<Movie>();
        public MovieStore()
        {
            movies = Load();            // this is Deserialize Method
            _noOfMovies = 0;
        }
        public void AddMovie(Movie movie)
        {
            movies.Add(movie);
            Console.WriteLine("Movie are Added Successfully");
            Save();                    // This is Serialize Method
        }

        private void Save()
        {
            FileStream fs = new FileStream("movie.dump", FileMode.Create, FileAccess.Write);
            BinaryFormatter binaryFormatter = new BinaryFormatter();
            binaryFormatter.Serialize(fs, movies);
            fs.Close();
            Console.WriteLine("Serialization Completed");
        }

        public List<Movie> GetMovies()
        {
            return movies;
        }
        public int NoOfMovies { get { return _noOfMovies; } }
        private List<Movie> Load()
        {
            string path = "C:\\SwbhavLiveSessions\\MonoceptMarch\\Assignment\\Assignment_Session19\\MovieStoreV3\\bin\\Debug\\net6.0\\movie.dump";
            FileStream fs = new FileStream(path, FileMode.Open, FileAccess.Read);
            BinaryFormatter binaryFormatter = new BinaryFormatter();
            List<Movie> allMovies = (List<Movie>)binaryFormatter.Deserialize(fs);
            fs.Close();
            return allMovies;
        }
    }
}
