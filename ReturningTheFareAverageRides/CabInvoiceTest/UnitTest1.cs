
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
                new Ride(2,5),
                new Ride(3,6)
            };
            InvoiceGenertor generator = new InvoiceGenertor(RideType.PREMIUM);
            //act

            InvoiceSummery actual = generator.CalculateTotalFair(rides);
            //assert
            Assert.AreEqual(expected, actual.totalFair);
        }
        [Test]
        public void GivenMultipleRidesreturnTotalFairNumberOfRidesAvreage()
        {
            //assert


            Ride[] rides = new Ride[]
            {
                new Ride(2,5),
                new Ride(3,6)
            };
            double totalFair = 97;
            double average = totalFair / rides.Length;
            InvoiceSummery expected1 = new InvoiceSummery(rides.Length, totalFair);
            
            InvoiceGenertor generator = new InvoiceGenertor(RideType.PREMIUM);
            //act

            var actual = generator.CalculateTotalFair(rides);
            //assert
            
            expected1.Equals(actual);
        }

    }
}