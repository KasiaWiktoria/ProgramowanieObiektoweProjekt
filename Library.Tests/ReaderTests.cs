using NUnit.Framework;

namespace Library.Tests
{
    [TestFixture]
    public class ReaderTests
    {
        [Test]
        public void CheckOutTest()
        {
            Reader reader = new Reader("Katarzyna", "Stankiewicz");
            Book book = new Book("451° Fahrenheita", "Ray Bradbury", 2008, 219, 1);

            reader.CheckOut(book);
            Assert.IsTrue(reader.CheckOutList.Contains(book));
        }

        [Test]
        public void ReturnTest()
        {
            Reader reader = new Reader("Katarzyna", "Stankiewicz");
            Book book = new Book("451° Fahrenheita", "Ray Bradbury", 2008, 219, 1);

            reader.CheckOut(book);
            Assert.IsTrue(reader.CheckOutList.Contains(book));
            reader.Return(book);
            Assert.IsTrue(!reader.CheckOutList.Contains(book));
        }
    }
}
