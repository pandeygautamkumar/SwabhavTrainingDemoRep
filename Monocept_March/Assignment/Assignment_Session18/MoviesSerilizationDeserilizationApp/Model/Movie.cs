using System;

namespace MoviesSerilizationDeserilizationApp.Model
{
    [Serializable]
    internal class Movie
    {
        private string _movieName;
        private int _releasedYear;
        public Movie(string movieName, int releasedYear)
        {
            _movieName = movieName;
            _releasedYear = releasedYear;
        }
        public string MovieName
        {
            get { return _movieName; }
        }
        public int ReleasedYear
        {
            get { return _releasedYear; }
        }
    }
}
