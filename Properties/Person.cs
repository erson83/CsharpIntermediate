namespace PropertiesSet

{
    public class Person
    {
        public DateTime Birthdate { get; set; }
        
        public int Age
        { 
            get
            {
                var timespan = DateTime.Today - Birthdate;
                var years = timespan.Days / 365;

                return years;
            }

            }

        }

    }       

