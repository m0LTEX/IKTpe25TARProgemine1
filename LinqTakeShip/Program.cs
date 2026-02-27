namespace LinqTakeShip
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Kutsume esile LINQ meetodid");
            Console.WriteLine("1. Skip");
            Console.WriteLine("2. SkipWhile");
            Console.WriteLine("3. TakeWhile");
            Console.WriteLine("4. FirstOrDefault");
            Console.WriteLine("5. Average");
            Console.WriteLine("6. CountLINQ");
            Console.WriteLine("7. Sum");
            Console.WriteLine("8. Max");
            Console.WriteLine("9. Min");
            //siin kasutada switchi ja peab saama Skip meetodit esile kutsuda

            int choise = int.Parse(Console.ReadLine());

            switch (choise) 
            {
            case 1:
               Skip();
               break;
                    
                case 2:
                    SkipWhile();
                    break;

                case 3:
                    TakeWhile();
                    break;

                case 4:
                    FirstOrDefault();
                    break;

                case 5:
                    Average();
                    break;

                case 6:
                    CountLINQ();
                    break;

                case 7:
                    Sum();
                    break;

                case 8:
                    Max();
                    break;

                case 9:
                    Min();
                    break;

                default:
                    Console.WriteLine("Vale valik");
                    break;
        }
    }

        public static void Skip()
            {
            Console.WriteLine("----------Skip-----------");
            //kasuta skip ja jäta kolm tükki vahele


            var Skip = PeopleList.peoples.Skip(3);
                foreach (var people in Skip)
            {
                Console.WriteLine(people.Name);
            }
        }

        //teete uue meetodi aga kasutate SkipWhile ja vanemad, kui 18 peab olema tingimus

        public static void SkipWhile()
        {
            Console.WriteLine("--------SkipWhile--------");
            //mis tähendab => . See tähendab lamba märki ja selle
            // abil saab kasutada pikema classo nimetuse asemel lühendit
            //koos sees oleva muutujaga, mis antud juhul on x.
            var SkipWhile = PeopleList.peoples.SkipWhile(x => x.Age > 18);

            foreach (var item in SkipWhile)
            {
                Console.WriteLine(item.Id + " " + item.Name + " " + item.Age); 
            }
            //SkipWhile jätab loendis nii kaua vahele ridu kuni vastab tingimustele
            //e antud juhul jätab read vahele kuni leiab 18 a isiku ja 
            //peale seda hakkab info jälle kuvama olenemata vanuse tingimusest
        }

        //jasutada TakeWhileja kasutada see esile switchis
        //tingimus on Age > 18

        //vooskeem teha TakeWhile meetodist
        public static void TakeWhile()
        {
            Console.WriteLine("--------TakeWhile--------");
            var TakeWhile = PeopleList.peoples.TakeWhile(x => x.Age > 18);

            foreach (var item in TakeWhile)
            {
                Console.WriteLine(item.Id + " " + item.Name + " " + item.Age);
            }
            //TakeWhile näitab isikuid kuni vastab tingimustele
            //e antud juhul jnäitab andmeid kuni leiab 18 a isiku ja 
            //peale seda hakkab enam ei näita andmeid
        }

        public static void FirstOrDefault()
        {
            //kuvab esimese elemdi, mis on järjestuses
            //vastab tingimustele
            Console.WriteLine("-------FirstOrDefault--------");
            //peate kasutama Name ja Leght-i. Nimi peab olema vähemalt 5
            //tähemärki pikk
            string FirstLongName = PeopleList.peoples
                .FirstOrDefault(x => x.Name.Length == 5).Name;
            Console.WriteLine("The first long name is '{0}'.", FirstLongName);
        }

        //kasutame Avarage Linq

        public static void Average()
        {
            Console.WriteLine("-------Average--------");
            var Average = PeopleList.peoples.Average(x => x.Age);
            Console.WriteLine(Average);
        }

        public static void CountLINQ() 
        {
            var totalPersons = PeopleList.peoples.Count();

            Console.WriteLine("Inimesi on kokku: " + totalPersons);
            Console.WriteLine("--------------------------------");

            var adultPerson = PeopleList.peoples.Count(x => x.Age >= 18);
            Console.WriteLine("Täiskasvanuid on kokku: " + adultPerson);
        }

        public static void Sum()
        {
            Console.WriteLine("-------Sum--------");
            var Sum = PeopleList.peoples.Sum(x => x.Age);
            Console.WriteLine("Kõikide vanus kokku on " + Sum);

            Console.WriteLine("-----------------------------");
            Console.WriteLine("Täisealiste isikute koondarv");
            var sumAdults = 0;
            var numAdults = PeopleList.peoples.Sum(x =>
            {
                if(x.Age >= 18) 
                {
                    return 1;
                }
                else
                {
                    return 0;
                }
            });

            Console.WriteLine("Täiskasvanud isikute koondarv " + numAdults);
        }

        //kasutada Max

        public static void Max()
        {
             Console.WriteLine("-------Max--------");
            var Max = PeopleList.peoples.Max(x => x.Age);

            Console.WriteLine("kõige vanem inimene on " + Max + " aastat vana");

        }

        public static void Min()
        {
            Console.WriteLine("-------Min--------");
            var Min = PeopleList.peoples.Min(x => x.Age);

            Console.WriteLine("kõige noorem inimene on " + Min + " aastat vana");

        }
    }
}
