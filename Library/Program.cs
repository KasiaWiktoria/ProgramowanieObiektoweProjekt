using System;

namespace Library
{

    public class Program
    {
        static void Main(string[] args)
        {
            Library library = new Library();
            PrepareCatalogue(library);
            PrepareReaders(library);
            
            Book book = new Book("451° Fahrenheita", "Ray Bradbury", 2008, 219, 1);
            

            library.PrintReadersByNumberOfCheckOuts();

        }

        static void PrepareReaders(Library library)
        {
            Reader reader1 = new Reader("Jerzy","Nowak");
            Reader reader2 = new Reader("Anna", "Niewińska");
            Reader reader3 = new Reader("Ewa", "Kacprowicz");
            Reader reader4 = new Reader("Gabriel", "Ilczuk");
            Reader reader5 = new Reader("Maciej", "Koc");
            Reader reader6 = new Reader("Przemysław", "Niedzielski");
            Reader reader7 = new Reader("Irena", "Poniedziałek");

            library.AddReader(reader1);
            library.AddReader(reader2);
            library.AddReader(reader3);
            library.AddReader(reader4);
            library.AddReader(reader5);
            library.AddReader(reader6);
            library.AddReader(reader7);
        }

        static void PrepareCatalogue(Library library)
        {
            PrepareBooks(library.Catalogue);
            PrepareJournals(library.Catalogue);
            PrepareNewsPapers(library.Catalogue);
            PrepareArticles(library.Catalogue);
            /*
            library.Catalogue.PrintBooks();
            library.Catalogue.PrintJournals();
            library.Catalogue.PrintNewsPapers();
            library.Catalogue.PrintArticles();

            library.Catalogue.PrintAll();
            */
        }

        static void PrepareBooks(Catalogue catalog)
        {
            Book book1 = new Book("Zły", "Leopold Tyrmand", 1955, 321, 1);
            Book book2 = new Book("Wilk stepowy", "Herman Hesse", 1927, 165, 2);
            Book book3 = new Book("Trucicielka i inne historie o namiętnościach", "Eric-Emmanuel Schmitt", 2010, 311, 1);
            Book book4 = new Book("Bóg nie jest automatem do kawy.", "Marketa Zahradnikova", 2018, 247, 1);
            Book book5 = new Book("451° Fahrenheita", "Ray Bradbury", 2008, 219, 1);
            Book book6 = new Book("Tajemna Historia", "Donna Tartt", 2015, 608, 1);


            catalog.Add(book1);
            catalog.Add(book2);
            catalog.Add(book3);
            catalog.Add(book4);
            catalog.Add(book5);
            catalog.Add(book6);

        }

        static void PrepareMovies(Catalogue catalog)
        {
            Movie movie1 = new Movie("Dwunastu gniewnych ludzi", "	Sidney Lumet", 1957, 96);

            catalog.Add(movie1);
        }

        static void PrepareJournals(Catalogue catalog)
        {
            Journal journal1 = new Journal("Wnętrza Inspiracje", "Czasopisma krajowe", 2019, 3, 40, "Kuchnia w salonie");
            Journal journal2 = new Journal("M jak Mieszkanie", "Czasopisma krajowe", 2019, 11, 49, "Urządzamy ze smakiem");
            Journal journal3 = new Journal("Mój ogród", "Czasopisma krajowe", 2019, 10, 39, "Gołębie w ogrodzie");

            catalog.Add(journal1);
            catalog.Add(journal2);
            catalog.Add(journal3);
        }

        static void PrepareNewsPapers(Catalogue catalog)
        {
            NewsPaper newsPaper1 = new NewsPaper("Gazeta Wyborcza", "Agora", 2019, 41, 28, "Dokąd idziemy?");
            NewsPaper newsPaper2 = new NewsPaper("Do Rzeczy", "Orle Pióro Sp. z o.o.", 2019, 41, 45, "Twierdza senat");

            catalog.Add(newsPaper1);
            catalog.Add(newsPaper2);
        }

        static void PrepareArticles(Catalogue catalog)
        {
            Article article1 = new Article("Einstein vs Weinstein", "Znany Profesor", 2019, 35);
            Article article2 = new Article("Percepcja światów możliwych w jednokomórkowcach -- ruchu dziewicze: analiza obserwacji", "Nienznay doktor", 2018, 24);
            Article article3 = new Article("Regeneracja DNA u zwierząt", "Początkujący Naukowiec", 2018, 19);

            catalog.Add(article1);
            catalog.Add(article2);
            catalog.Add(article3);

        }
    }
}
