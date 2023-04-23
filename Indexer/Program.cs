namespace Index


{
    // Indexer is a special kind of property that allows accessing elements of a list by an
    // index.
    // If a class has the semantics of a list, or collection, we can define an indexer property
    // for it.This way it’s easier to get or set items in the collection
    class Program

    {

        static void Main(string[] args)
        {

            var cookie = new HttpCookie();
            cookie["name"] = "Mosh";
            Console.WriteLine(cookie["name"]);
            cookie["salutation"] = "Dr";
            Console.WriteLine(cookie["salutation"]);
        }


    }




}

