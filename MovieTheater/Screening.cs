using MovieTheater.enums;

namespace MovieTheater
{
    public class Screening
    {      
        public SeatState[,] Seats { get; set; }
        public string Movie { get; set; }
        public string Interval { get; set; }
        
        public List<Ticket> Tickets { get; set; }

        public int ViewCount { get; set; }
        public int PayedCount { get; set; }
        public int ReservedCount { get; set; }
        public int FreeCount { get; set; }

        public Screening(Theater theater, string movie, string interval)
        {
            if(theater is SmallTheater)
            {
                Seats = new SeatState[3, 6];
            }else if(theater is BigTheater)
            {
                Seats = new SeatState[4, 8];
            }else if(theater is VIPTheater)
            {
                Seats = new SeatState[6, 10];
            }

            Movie = movie;
            Interval = interval;
            Tickets = new List<Ticket>();

        
        }

        private int rowToInt(char letter)
        {            
            return letter - 'A' + 1;           
        }

        public void displayRoom()
        {
            Console.WriteLine(Movie);
            for (int i = 0; i < Seats.GetLength(0); i++)
            {
                Console.WriteLine();
                for (int j = 0; j < Seats.GetLength(1); j++)
                {
                    Console.Write(Seats[i, j] + " ");
                }
            }
            Console.WriteLine();
        }

        public void reserveSeat(char rowLetter, int col, string actionType, Theater theater, string customerType)
        {
            int row = rowToInt(rowLetter);

            if(actionType == "foglalas")
            {
                if (Seats[row-1,col-1] == SeatState.szabad)
                {
                    Seats[row - 1, col - 1] = SeatState.foglalt;
                }
            }
            else
            {
                if (Seats[row - 1, col - 1] == SeatState.szabad)
                {
                    Seats[row - 1, col - 1] = SeatState.eladott;
                }
            }
            Ticket ticket = new Ticket(theater, customerType);
            ticket.calculateDiscountPrice();
            Tickets.Add(ticket);
        }

        // a feladat helper method + b feladat
        public void countViews()
        {
            int sold = 0;
            int reserved = 0;
            int free = 0;
            for (int i = 0; i < Seats.GetLength(0); i++)
            {              
                for (int j = 0; j < Seats.GetLength(1); j++)
                {
                    if (Seats[i,j] == SeatState.eladott)
                    {
                        sold++;
                    }

                    if (Seats[i,j] == SeatState.foglalt)
                    {
                        reserved++;
                    }

                    if (Seats[i,j] == SeatState.szabad)
                    {
                        free++;
                    }
                }
            }
            ViewCount = sold;
            PayedCount = sold;
            ReservedCount = reserved;
            FreeCount = free;
        } 

        public void printScreeningData()
        {
            Console.WriteLine();
            Console.WriteLine("Előadás: "+Movie);
            Console.WriteLine("Időpont: "+Interval);
            Console.WriteLine("Szabad helyek: "+FreeCount);
            Console.WriteLine("Foglalt helyek: "+ReservedCount);
            Console.WriteLine("Eladott helyek: "+PayedCount);
        }

        public void printTicketData()
        {
            Console.WriteLine();
            Console.WriteLine("Előadás:" +Movie);
            Console.WriteLine("Időpont: " + Interval);
            foreach(Ticket ticket in Tickets)
            {
                Console.WriteLine("Terem: "+ticket.theater.ToString()+" Vásárló: "+ticket.customer+" Ár: "+ticket.CalculatedPrice+" Ft");
                
            }
        }
        
    }
}
