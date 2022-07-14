
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
    }
}