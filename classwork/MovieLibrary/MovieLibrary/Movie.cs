namespace MovieLibrary
{
     //Represents a movie
     /// <summary>
     /// Represents a movie
     /// </summary>
    public class Movie
    {
      private string _title = "";
        public string GetTitle ()
        {
            return _title;
        }
     
        public void SetTitle ( string title )
        {
            //this.title = title;
            title=title;
        }
        public  string _description = "";
      public  int _runLength = 0; //In minutes
      public  int _releaseYear = 1900;
      public  string _rating = "";
      public  bool _isClassic = false;
        /// <summary>
        /// Clones the existing movie
        /// </summary>
        /// <returns>Copy of the movie</returns>
        public Movie Clone ()
        {
            var movie = new Movie ();   
            CopyTo (movie);
            return movie;
        }
        /// <summary>
        /// Copy the movie to another instance
        /// </summary>
        /// <param name="movie"> Movie to copy into</param>
        public void CopyTo (Movie movie )
        {
            var areEqual = _title == this._title;
            movie._title = _title;
            movie._description = _description;
            movie._runLength = _runLength;
            movie._releaseYear = _releaseYear;
            movie._rating = _rating;
            movie._isClassic = _isClassic;
        }
        
    }
}