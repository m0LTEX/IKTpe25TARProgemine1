namespace ClassTipe
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }

        private class Device
        {
            public string Name;
            public void Turnon()
            {
                Console.WriteLine(Name + " is on");
            }
            //Class ei pea olema private
        }


        class Phone : Device
        {
            public void Call()
            {
                Console.WriteLine(Name + " is caling");
            }
            //protected ei sobi
        }

        class SmartWatch : Device
        {
            public void ShowTime()
            {
                Console.WriteLine(Name + "shows time");
            }
            //Jah on, public string Name; nagu teises
        }


        sealed class Hepler
        {
            public void Help()
            {
                Console.WriteLine("Helping...");
            }
            //Ei, valesti
        }

        private class Logger
        {
            public void log(string message)
            {
                Console.WriteLine(message);
            }
        }

        class program
        {
            static void main()
            {
                Phone p = new Phone();
                p.Name = "iPhone";
                p.Turnon();
                p.Call();

                SmartWatch w = new SmartWatch();
                w.Name = "Garmin";
                w.Turnon();
                w.ShowTime();
            }
            //Jah töötab
        }
    }
}
