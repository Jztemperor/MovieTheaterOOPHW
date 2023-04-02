namespace MovieTheater
{
    public class VIPTheater : Theater
    {
        public VIPTheater()
        {
            Screenings = new List<Screening>();
        }

        public override string ToString()
        {
            return "VIP Terem";
        }
    }
}
