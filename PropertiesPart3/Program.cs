namespace PropertiesSet3
{


    public class Movie
    {
        // declare variables in camel case
        public string title;
        public string director;
        private string _rating;

        // intialize
        public Movie(string atitle, string adirector, string arating)
        {
            title = atitle;
            director = adirector;
            _rating = arating;

        }

        // here is where we must use Pascal case
        public string Rating
        {
            get { return _rating; }
            set
            {
                if (value == "PG-13" || value == "RA")
                {
                    _rating = value;
                }
                else
                {
                    _rating = "ERROR!";
                    Console.WriteLine("the rating is nonsense!");
                }

            }

        }


    }

        class Program

        {

            static void Main(string[] args)
            {

            var avengers = new Movie("The Avengers", "Joss Whedon", "PG-13");
            Console.WriteLine(avengers.Rating);

            var shrek = new Movie("Shrek", "Adam Adamson", "DOG");
            Console.WriteLine(shrek.Rating);

        }


        }
    }






