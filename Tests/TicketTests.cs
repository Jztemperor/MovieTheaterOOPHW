using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Tests
{
    [TestClass]
    public class TicketTests
    {
        [TestMethod]
        public void TestCalculateDiscountPriceKidSmallTheater()
        {
            Theater theater = new SmallTheater();
            Ticket ticket = new Ticket(theater, "gyerek");

            ticket.calculateDiscountPrice();

            Assert.AreEqual(600, ticket.CalculatedPrice);
        }


        [TestMethod]
        public void TestCalculateDiscountPriceKidBigTheater()
        {
            Theater theater = new BigTheater();
            Ticket ticket = new Ticket(theater, "gyerek");

            ticket.calculateDiscountPrice();

            Assert.AreEqual(1200, ticket.CalculatedPrice);
        }

        [TestMethod]
        public void TestCalculateDiscountPriceKidVipTheater()
        {
            Theater theater = new VIPTheater();
            Ticket ticket = new Ticket(theater, "gyerek");

            ticket.calculateDiscountPrice();

            Assert.AreEqual(5000, ticket.CalculatedPrice);
        }

        [TestMethod]
        public void TestCalculateDiscountPriceDiakSmallTheater()
        {
            Theater theater = new SmallTheater();
            Ticket ticket = new Ticket(theater, "diak");

            ticket.calculateDiscountPrice();

            Assert.AreEqual(700, ticket.CalculatedPrice);
        }

        [TestMethod]
        public void TestCalculateDiscountPriceDiakBigTheater()
        {
            Theater theater = new BigTheater();
            Ticket ticket = new Ticket(theater, "diak");

            ticket.calculateDiscountPrice();

            Assert.AreEqual(1600, ticket.CalculatedPrice);
        }

        [TestMethod]
        public void TestCalculateDiscountPriceDiakVIPTheater()
        {
            Theater theater = new VIPTheater();
            Ticket ticket = new Ticket(theater, "diak");

            ticket.calculateDiscountPrice();

            Assert.AreEqual(5000, ticket.CalculatedPrice);
        }

        [TestMethod]
        public void TestCalculateDiscountPriceFelnottSmallTheater()
        {
            Theater theater = new SmallTheater();
            Ticket ticket = new Ticket(theater, "felnott");

            ticket.calculateDiscountPrice();

            Assert.AreEqual(900, ticket.CalculatedPrice);
        }

        [TestMethod]
        public void TestCalculateDiscountPriceFelnottBigTheater()
        {
            Theater theater = new BigTheater();
            Ticket ticket = new Ticket(theater, "felnott");

            ticket.calculateDiscountPrice();

            Assert.AreEqual(2000, ticket.CalculatedPrice);
        }

        [TestMethod]
        public void TestCalculateDiscountPriceFelnottVipTheater()
        {
            Theater theater = new VIPTheater();
            Ticket ticket = new Ticket(theater, "felnott");

            ticket.calculateDiscountPrice();

            Assert.AreEqual(5000, ticket.CalculatedPrice);
        }

        [TestMethod]
        public void TestCalculateDiscountPriceNyugdijasSmallTheater()
        {
            Theater theater = new SmallTheater();
            Ticket ticket = new Ticket(theater, "nyugdijas");

            ticket.calculateDiscountPrice();

            Assert.AreEqual(700, ticket.CalculatedPrice);
        }

        [TestMethod]
        public void TestCalculateDiscountPriceNyugdijasBigTheater()
        {
            Theater theater = new BigTheater();
            Ticket ticket = new Ticket(theater, "nyugdijas");

            ticket.calculateDiscountPrice();

            Assert.AreEqual(1600, ticket.CalculatedPrice);
        }

        [TestMethod]
        public void TestCalculateDiscountPriceNyugdijasVipTheater()
        {
            Theater theater = new VIPTheater();
            Ticket ticket = new Ticket(theater, "nyugdijas");

            ticket.calculateDiscountPrice();

            Assert.AreEqual(5000, ticket.CalculatedPrice);
        }

        [TestMethod]
        public void TestCalculateDiscountPriceTorzstagSmallTheater()
        {
            Theater theater = new SmallTheater();
            Ticket ticket = new Ticket(theater, "torzstag");

            ticket.calculateDiscountPrice();

            Assert.AreEqual(700, ticket.CalculatedPrice);
        }

        [TestMethod]
        public void TestCalculateDiscountPriceTorzstagBigTheater()
        {
            Theater theater = new BigTheater();
            Ticket ticket = new Ticket(theater, "torzstag");

            ticket.calculateDiscountPrice();

            Assert.AreEqual(1400, ticket.CalculatedPrice);
        }

        [TestMethod]
        public void TestCalculateDiscountPriceTorzstagVipTheater()
        {
            Theater theater = new VIPTheater();
            Ticket ticket = new Ticket(theater, "torzstag");

            ticket.calculateDiscountPrice();

            Assert.AreEqual(5000, ticket.CalculatedPrice);
        }
    }
}
