namespace MovieTheater
{
    public class SmallTheater : Theater
    {
        public SmallTheater()
        {
            Screenings = new List<Screening>();
        }

        public override string ToString()
        {
            return "Kis terem";
        }
    }
}
