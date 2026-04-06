namespace ConsoleApp1
{
    class Car : Vehicle
    {
        public override void Describe()
        {
            Console.WriteLine("This is a car. Name: " + Name + ", Speed: " + Speed + "");
        }
    }
}
