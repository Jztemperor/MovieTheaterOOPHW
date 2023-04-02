namespace MovieTheater
{
    public class BigTheater : Theater
    {
        public BigTheater()
        {
            Screenings = new List<Screening>();
        }

        public override string ToString()
        {
            return "Nagy Terem";
        }
    }
}
