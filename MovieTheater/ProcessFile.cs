namespace MovieTheater
{
    public class ProcessFile
    {
        private readonly StreamReader streamReader;

        public ProcessFile(string fileName)
        {
            streamReader = new StreamReader(fileName);
        }

        public List<Theater> ReadFile()
        {
            List<Theater> theaters = new List<Theater>();
            SmallTheater smallTheater = new SmallTheater();
            BigTheater bigTheater = new BigTheater();
            VIPTheater vipTheater = new VIPTheater();

            string line;
            while((line = streamReader.ReadLine()) != null)
            {
                string[] fields = line.Split(',');
                string size = fields[0];
                string movie = fields[1];
                string interval = fields[2];
                char row = char.Parse(fields[3]);
                int col = int.Parse(fields[4]);
                string actionType = fields[5];
                string customer = fields[6];

                Screening screening;
               
                if(size == "kis")
                {
                    
                    screening = new Screening(smallTheater, movie, interval);
                    bool screeningInList = smallTheater.Screenings.Any(sc =>  sc.Interval == interval);
                    if(!screeningInList)
                    {
                        smallTheater.Screenings.Add(screening);
                        screening.reserveSeat(row, col, actionType, smallTheater, customer);
                    }
                    else
                    {
                        Screening existing = smallTheater.Screenings.FirstOrDefault(sc =>  sc.Interval == interval);
                        existing.reserveSeat(row, col, actionType, smallTheater, customer);
                    }
                   

                }else if(size == "nagy")
                {
                   
                    screening = new Screening(bigTheater, movie, interval);
                    bool screeningInList = bigTheater.Screenings.Any(sc =>  sc.Interval == interval);
                    if (!screeningInList)
                    {
                        bigTheater.Screenings.Add(screening);
                        screening.reserveSeat(row, col, actionType, bigTheater, customer);
                    }
                    else
                    {
                        Screening existing = bigTheater.Screenings.FirstOrDefault(sc =>  sc.Interval == interval);
                        existing.reserveSeat(row, col, actionType, bigTheater, customer);
                    }
                   
                }
                else
                {
                   
                    screening = new Screening(vipTheater, movie, interval);
                    bool screeningInList = vipTheater.Screenings.Any(sc =>  sc.Interval == interval);
                    if (!screeningInList)
                    {
                        vipTheater.Screenings.Add(screening);
                        screening.reserveSeat(row, col, actionType, vipTheater, customer);
                    }
                    else
                    {
                        Screening existing = vipTheater.Screenings.FirstOrDefault(sc =>  sc.Interval == interval);
                        existing.reserveSeat(row, col, actionType, vipTheater, customer);
                    }
                   
                }

               
            }
            theaters.Add(smallTheater);
            theaters.Add(bigTheater);
            theaters.Add(vipTheater);
            streamReader.Close();
            return theaters;
        }
    }
}
