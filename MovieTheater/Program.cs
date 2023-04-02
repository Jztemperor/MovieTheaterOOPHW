namespace MovieTheater
{
    public class Program
    {
        static void Main(string[] args)
        {
            ProcessFile processFile = new ProcessFile("minta.txt");
            List<Theater> theater = processFile.ReadFile();
            
            while(true)
            {
                Console.WriteLine("--------------------------------------------------------------");
                Console.WriteLine("Válasszon az alábbi menü opciókból:");
                Console.WriteLine("1, a, feladat: Melyik filmet nézte meg a legtöbb néző?");
                Console.WriteLine("2, b, feladat: Számoljuk meg egy adott előadásra megvett, csak lefoglalt, illetve szabad helyeket!");
                Console.WriteLine("3, Vetítő termék állapotának megjelenítése.");
                Console.WriteLine("4, Jegy árak meghatározása.");
                Console.WriteLine("5, Kilépés.");
                Console.WriteLine("--------------------------------------------------------------");

                switch(Console.ReadLine())
                {
                    case "1":
                        
                        List<int> maxVals = new List<int>();
                        foreach (Theater t in theater)
                        {
                            foreach (Screening sc in t.Screenings)
                            {                                
                                sc.countViews();
                            }
                        }

                        foreach (Theater t in theater)
                        {
                            maxVals.Add(t.biggestCount());
                        }
                        int max = maxVals.Max();
                        
                        //int max2 = theater.SelectMany(t => t.Screenings).Select(sc => sc.ViewCount).Max();

                        foreach (Theater t in theater)
                        {
                            foreach (Screening sc in t.Screenings)
                            {

                                if (sc.ViewCount == max)
                                {
                                    Console.WriteLine("A legnagyobb nézettséggel rendelkező film: " + sc.Movie);
                                }
                            }
                        }                      
                        break;

                    case "2":
                        foreach(Theater t in theater)
                        {
                            foreach(Screening sc in t.Screenings)
                            {
                                sc.countViews();
                                sc.printScreeningData();
                            }
                        }
                        break;

                    case "3":
                        Console.WriteLine("A vetítőtermek foglalásainak állapota:");
                        foreach(Theater t in theater)
                        {
                            foreach(Screening sc in t.Screenings)
                            {
                                sc.displayRoom();
                            }
                        }
                        break;

                    case "4":
                        foreach(Theater t in theater)
                        {
                            foreach(Screening sc in t.Screenings)
                            {
                                sc.printTicketData();
                            }
                        }
                        break;

                    case "5":
                        Console.WriteLine("Kilépés...");
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Nincs ilyen opcio!");
                        break;
                }
            }                 
        }
    }
}