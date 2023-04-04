using MovieTheater.enums;

namespace Tests
{
    [TestClass]
    public class ScreeningTests
    {
        [TestMethod]
        public void TestSmallScreeningSize()
        {
            
            Theater theater = new SmallTheater();
            int rows = 3;
            int cols = 6;

            Screening sc = new Screening(theater, "Film", "18:00 19:00");
            Assert.AreEqual(rows, sc.Seats.GetLength(0));
            Assert.AreEqual(cols, sc.Seats.GetLength(1));        
        }

        [TestMethod]
        public void TestBigScreeningSize()
        {
            Theater theater = new BigTheater();
            int rows = 4;
            int cols = 8;

            Screening sc = new Screening(theater, "Film", "18:00 19:00");
            Assert.AreEqual(rows, sc.Seats.GetLength(0));
            Assert.AreEqual(cols, sc.Seats.GetLength(1));
        }

        [TestMethod]
        public void TestVIPScreeningSize()
        {
            Theater theater = new VIPTheater();
            int rows = 6;
            int cols = 10;

            Screening sc = new Screening(theater, "Film", "18:00 19:00");
            Assert.AreEqual(rows, sc.Seats.GetLength(0));
            Assert.AreEqual(cols, sc.Seats.GetLength(1));
        }


        [TestMethod]
        public void TestReserveSeat()
        {
            Theater t = new SmallTheater();
            Screening sc = new Screening(t, "Test movie", "18:00 19:00");
            char row = 'B';
            int col = 2;
            string type = "foglalas";
            string expectedState = "foglalt";
            string customer = "gyerek";

            sc.reserveSeat(row, col, type, t, customer);

            Assert.AreEqual(expectedState, sc.Seats[1, 1].ToString());         
        }

        [TestMethod]
        public void TestCountViews()
        {
            // Kifizetett (megvett) jegyet tekintem megnézettnek
            Theater t = new SmallTheater();
            Screening sc = new Screening(t, "Film", "20:00 22:00");
            sc.reserveSeat('B', 2, "kifizetes", t, "diak");
            

            sc.countViews();

            Assert.AreEqual(1, sc.ViewCount);
        }
    }
}