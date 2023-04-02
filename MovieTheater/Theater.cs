namespace MovieTheater
{
    public class Theater
    {
        public List<Screening> Screenings { get; set; }
        
        // a feladat "helper"
        public int biggestCount()
        {
            Screening screening = Screenings.OrderByDescending(s => s.ViewCount).FirstOrDefault();
            return screening.ViewCount;
        }
        
        
    }
}
