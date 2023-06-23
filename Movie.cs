namespace FirstTutorial
{
    public class Movie
    {
        public string title;
        public string director;
        private string rating;

        public Movie(string aTtitle, string aDirector, string aRating) {
            title = aTtitle;
            director = aDirector;
            Rating = aRating;
        }

        public string Rating {
            get {
                return rating;
            }
            set {
                if(value == "G" || value == "PG" || value == "PG-13" || value == "R" || value == "NR") {
                    rating = value;
                }
                else {
                    rating = "NR";
                }
            }
        }
    }
}