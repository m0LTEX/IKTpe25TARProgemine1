namespace LINQ
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            //tuleb teha class nimega PeopleList
            //seal on kuus rida andmeid 
            //kindlasti peab olema Kaks Mari nimega isikut
            //aga erinevate vanustega

            Console.WriteLine("Tee valik numbriga");

            int choise = int.Parse(Console.ReadLine());

            switch (choise) 
            {
                case 1:
                    ThenByLINQ();
                    break;

                    case 2:
                    ThenByDescendingLINQ();
                        break;

                default:
                    Console.WriteLine("vale valik");
                    break;

            }
        }

        //kutsuda meetod switchis esile
        public static void ThenByLINQ()
        {
            //thenby sorteerib numbrilises järjestuses
            var thenByResult = PeopleList.peoples
                .OrderBy(x => x.Name)
                .ThenBy(x => x.Age);

            Console.WriteLine("ThenBy järgi sorteerimine");
            foreach (var people in thenByResult) 
            {
                Console.WriteLine(people.Name);
                Console.WriteLine(people.Age);

            }
        }

        //samasugune nagu eelmine, aga kasutage
        //thenByDescending
        public static void ThenByDescendingLINQ()
        {
            //thenby sorteerib numbrilises järjestuses
            var ThenByDescending = PeopleList.peoples
                .OrderByDescending(x => x.Name)
                .ThenByDescending(x => x.Age);

            Console.WriteLine("ThenBy järgi sorteerimine");
            foreach (var people in ThenByDescending)
            {
                Console.WriteLine(people.Name);
                Console.WriteLine(people.Age);

            }
        }
    }
}
