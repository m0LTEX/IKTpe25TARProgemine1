namespace ConsoleApp1
{
    class Bicycle : Vehicle
    {
        public override void Describe()
        {
            Console.WriteLine("This is a bicycle. Name: " + Name + ", Speed: " + Speed + "");
        }
    }

}
