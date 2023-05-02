namespace AbstractClasses

{
    public abstract class Shape
    {
        public int Width { get; set; }
        public int Height { get; set; }


        public abstract void Draw();
        
            // cannot define this if using Abstract class
            // derived class will take control eg. Rectangle : Shape


        public void Copy()
        {
            // this will be the main class
            // we don need the derived class to take control
            Console.WriteLine("Copy shape into clipboard");
        }
    }

}