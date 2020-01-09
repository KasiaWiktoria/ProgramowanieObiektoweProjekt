using NUnit.Framework;
using TechTalk.SpecFlow;

namespace Library.Tests
{
    [Binding]
    public class ReaderSteps
    {
        Reader reader = new Reader("Katarzyna", "Stankiewicz");
        Book book;
        [Given(@"I choose libitem")]
        public void GivenIChooseLibitem()
        {
            book = new Book("451° Fahrenheita", "Ray Bradbury", 2008, 219, 1);
        }

        [When(@"I check out libitem")]
        public void WhenICheckOutLibitem()
        {
            reader.CheckOut(book);
        }

        [Then(@"the result should be libitem on my CheckOutList")]
        public void ThenTheResultShouldBeLibitemOnMyCheckOutList()
        {
            Assert.IsTrue(reader.CheckOutList.Contains(book));
        }
    }
}
