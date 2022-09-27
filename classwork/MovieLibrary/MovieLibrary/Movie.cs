namespace MovieLibrary
{
    //Represents a movie
    /// <summary>
    /// Represents a movie
    /// </summary>
    public class Movie
    {
        public int Id { get; private set; } = 1900;
        /// <summary>
        /// gets or sets the title.
        /// </summary>
        public string Title
        {
            //atring get_Title()
            get
            {
                return String.IsNullOrEmpty(_title) ? "" : _title;

            }
            set { _title =  String.IsNullOrEmpty(value) ? "" : value.Trim(); }
        }
        private string _title ;
        //public string GetTitle ()
        //{
        //    return _title;
        //}

        //public void SetTitle ( string title )
        //{
        //    //this.title = title;
        //    _title=title;
        //}

        public string Description
        {
            get { return String.IsNullOrEmpty(_description) ? "" : _description; }
            set { _description = String.IsNullOrEmpty(value) ? "" : value.Trim(); }
        }
        private string _description ;
        /// <summary>
        /// Gets or Sets the run length in minutes.
        /// </summary>
        //public int RunLength
        //{
        //    get { return _runLength; }
        //    set { _runLength = value; }
        //}
        public int RunLength{ get;  set; }
       // private int _runLength = 0; //In minutes
        public int ReleaseYear
        {get; set; }
        //private int _releaseYear = 1900;

        public string Rating
        {
            get { return String.IsNullOrEmpty(_rating) ? "" : _rating; }
            set { _rating =  String.IsNullOrEmpty(value) ? "" : value.Trim(); }
        }
        private string _rating;
        public bool IsClassic { get; set; }
        
        

        public bool IsBlackAndWhite 
        {
            get { return ReleaseYear < 1939; }
          //  set { }
        }
        /// <summary>
        /// Clones the existing movie
        /// </summary>
        /// <returns>Copy of the movie</returns>
        public Movie Clone ()
        {
            var movie = new Movie();
            CopyTo(movie);
            return movie;
        }
        /// <summary>
        /// Copy the movie to another instance
        /// </summary>
        /// <param name="movie"> Movie to copy into</param>
        public void CopyTo ( Movie movie )
        {
            //var areEqual = _title == this._title;
            movie.Title = Title;
            movie.Description = Description;
            movie.RunLength = RunLength;
            movie.ReleaseYear = ReleaseYear;
            movie.Rating = Rating;
            movie.IsClassic = IsClassic;
        }

    }
}