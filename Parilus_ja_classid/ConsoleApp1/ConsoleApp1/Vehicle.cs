namespace ConsoleApp1
{
    class Vehicle
    {
        public string BMW;
        public int v1;

        public string Trek;
        public int v2;

        public string Name { get; set; }
        public int Speed { get; set; }

        public virtual void Describe()
        {
        Console.WriteLine("This is a vehicle");
        }
    }
}
