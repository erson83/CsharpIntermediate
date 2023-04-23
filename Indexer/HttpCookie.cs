namespace Index


{
    public class HttpCookie
    {
        //1 . declare variables
        private readonly Dictionary<string, string> _dictionary;
        // can improve the code - this can set the expiry date of the dictionary

        // more efficient to use indexer 
        public DateTime Expiry { get; set; }


        //2. intialize variables
        public HttpCookie()
        {

            _dictionary = new Dictionary<string, string>();
                        
        }


        //3. get set method
        // indexer does not have a name, we use this keyword
        public string this[string key]
        {
            get { return _dictionary[key]; }
            set { _dictionary[key] = value; }

        }



    }




}

