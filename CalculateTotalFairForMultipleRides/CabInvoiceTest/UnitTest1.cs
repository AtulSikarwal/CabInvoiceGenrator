
using InvoiceGenerator;

namespace CabInvoiceTest
{
    public class Tests
    {
        InvoiceGenertor invoiceGenertor;

        [SetUp]
        public void Setup()
        {
            invoiceGenertor= new InvoiceGenertor(RideType.NORMAL);
        }

        [Test]
        public void GivenDistanceAndTimeReturnTotalFair()
        {
            //assert
            int distance = 2;
            int time = 5;
            double expected = 25;
            InvoiceGenertor generator = new InvoiceGenertor(RideType.NORMAL);
            //act

            double actual = generator.CalculateTotalFair(distance, time);
        }

        [Test]
        public void GivenDistanceAndTimeReturnTotalFairForPrimiumRides()
        {
            //assert
            int distance = 2;
            int time = 5;
            double expected = 40;
            InvoiceGenertor generator = new InvoiceGenertor(RideType.PREMIUM);
            //act

            double actual = generator.CalculateTotalFair(distance, time);
            //assert
            Assert.AreEqual(expected, actual);
        }
        [Test]
        public void GivenMultipleRidesreturnTotalFair()
        {
            //assert

            double expected = 97;
            Ride[] rides = new Ride[]
            {
                new Ride(2,5),//40
                new Ride(3,6)//3*15+6*2=57//57+40=97
            };
            InvoiceGenertor generator = new InvoiceGenertor(RideType.PREMIUM);
            //act

            double actual = generator.CalculateTotalFair(rides);
            //assert
            Assert.AreEqual(expected, actual);
        }

    }
}