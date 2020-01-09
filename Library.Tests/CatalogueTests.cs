using NUnit.Framework;

namespace Library.Tests
{
    [TestFixture]
    class CatalogueTests
    {
        [Test]
        public void AddArticleTest()
        {
            Catalogue catalogue = new Catalogue();
            Article article = new Article("Einstein vs Weinstein", "Znany Profesor", 2019, 35);

            catalogue.Add(article);
            Assert.IsTrue(catalogue.Articles.Contains(article));
        }

        [Test]
        public void AddBookTest()
        {
            Catalogue catalogue = new Catalogue();
            Book book = new Book("Tajemna Historia", "Donna Tartt", 2015, 608, 1);

            catalogue.Add(book);
            Assert.IsTrue(catalogue.Books.Contains(book));
        }

        [Test]
        public void AddJournalTest()
        {
            Catalogue catalogue = new Catalogue();
            Journal journal = new Journal("Wnętrza Inspiracje", "Czasopisma krajowe", 2019, 3, 40, "Kuchnia w salonie");

            catalogue.Add(journal);
            Assert.IsTrue(catalogue.Journals.Contains(journal));
        }

        [Test]
        public void AddNewPaperTest()
        {
            Catalogue catalogue = new Catalogue();
            NewsPaper newsPaper = new NewsPaper("Gazeta Wyborcza", "Agora", 2019, 41, 28, "Dokąd idziemy?");

            catalogue.Add(newsPaper);
            Assert.IsTrue(catalogue.NewsPapers.Contains(newsPaper));
        }

        [Test]
        public void AddMovieTest()
        {
            Catalogue catalogue = new Catalogue();
            Movie movie = new Movie("Dwunastu gniewnych ludzi", "Sidney Lumet", 1957, 96);

            catalogue.Add(movie);
            Assert.IsTrue(catalogue.Movies.Contains(movie));
        }

        [Test]
        public void AddNullLibitemTest()
        {
            Catalogue catalogue = new Catalogue();
            Book book = null;

            Assert.Throws<System.ArgumentException>(() => catalogue.Add(book));
        }

        [Test]
        public void AddUnknownLibitemTest()
        {
            Catalogue catalogue = new Catalogue();
            UnknownLibitem unknown = new UnknownLibitem("unknown", 1999);

            Assert.Throws<System.ArgumentException>(() => catalogue.Add(unknown));
        }

        [Test]
        public void FindArticleByAuthorAndTitleTest()
        {
            Catalogue catalogue = new Catalogue();
            Article article = new Article("Einstein vs Weinstein", "Znany Profesor", 2019, 35);

            catalogue.Add(article);

            Article findArticle = catalogue.FindArticleByAuthorAndTitle("Znany Profesor", "Einstein vs Weinstein");
            Assert.AreSame(article, findArticle);
        }

        [Test]
        public void FindBookByAuthorAndTitleTest()
        {
            Catalogue catalogue = new Catalogue();
            Book book = new Book("Tajemna Historia", "Donna Tartt", 2015, 608, 1);

            catalogue.Add(book);

            Book findBook = catalogue.FindBookByAuthorAndTitle("Donna Tartt","Tajemna Historia");
            Assert.AreSame(book, findBook);
        }

        [Test]
        public void FindJournalByTitleAndNoTest()
        {
            Catalogue catalogue = new Catalogue();
            Journal journal = new Journal("Wnętrza Inspiracje", "Czasopisma krajowe", 2019, 3, 40, "Kuchnia w salonie");

            catalogue.Add(journal);

            Journal findJournal = catalogue.FindJournalByTitleAndNo("Wnętrza Inspiracje", 3);
            Assert.AreSame(journal, findJournal);
        }

        [Test]
        public void FindMovieByDirectorAndTitleTest()
        {
            Catalogue catalogue = new Catalogue();
            Movie movie = new Movie("Dwunastu gniewnych ludzi", "Sidney Lumet", 1957, 96);

            catalogue.Add(movie);

            Movie findMovie = catalogue.FindMovieByDirectorAndTitle("Sidney Lumet", "Dwunastu gniewnych ludzi");
            Assert.AreSame(movie, findMovie);
        }

        [Test]
        public void FindNewsPaperByTitleAndNoTest()
        {
            Catalogue catalogue = new Catalogue();
            NewsPaper newsPaper = new NewsPaper("Gazeta Wyborcza", "Agora", 2019, 41, 28, "Dokąd idziemy?");

            catalogue.Add(newsPaper);

            NewsPaper findNewsPaper = catalogue.FindNewsPaperByTitleAndNo("Gazeta Wyborcza", 41);
            Assert.AreSame(newsPaper, findNewsPaper);
        }

        [Test]
        public void Test()
        {
            Catalogue catalogue = new Catalogue();
        }
    }
}
