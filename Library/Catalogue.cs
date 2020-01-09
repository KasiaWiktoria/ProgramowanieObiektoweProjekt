using System;
using System.Collections.Generic;

namespace Library
{
    public class Catalogue
    {
        public List<Book> Books = new List<Book>();
        public List<Article> Articles = new List<Article>();
        public List<Movie> Movies = new List<Movie>();
        public List<NewsPaper> NewsPapers = new List<NewsPaper>();
        public List<Journal> Journals = new List<Journal>();


        public void Add(LibItem libItem)
        {
            if (libItem == null) {
                throw new System.ArgumentException("LibItem cannot be null.");
            }

            if (libItem.GetType() == typeof(Book))
            {
                Books.Add((Book)libItem);
            }
            else if (libItem.GetType() == typeof(Article))
            {
                Articles.Add((Article)libItem);
            }
            else if (libItem.GetType() == typeof(Movie))
            {
                Movies.Add((Movie)libItem);
            }
            else if (libItem.GetType() == typeof(NewsPaper))
            {
                NewsPapers.Add((NewsPaper)libItem);
            }
            else if (libItem.GetType() == typeof(Journal))
            {
                Journals.Add((Journal)libItem);
            }
            else
            {
                throw new System.ArgumentException("Unknown type of library item");
            }
        }

        public Article FindArticleByAuthorAndTitle(String author, String title)
        {
            throw new NotImplementedException();
        }

        public Book FindBookByAuthorAndTitle(String author, String title)
        {
            throw new NotImplementedException();
        }

        public Journal FindJournalByTitleAndNo( String title, int no)
        {
            throw new NotImplementedException();

        }

        public Movie FindMovieByDirectorAndTitle(String director, String title)
        {
            throw new NotImplementedException();

        }

        public NewsPaper FindNewsPaperByTitleAndNo(String title, int no)
        {
            throw new NotImplementedException();

        }


        private void PrintItems<T>(List<T> list)
        {
            Console.WriteLine("\nAll {0}s:", typeof(T).Name);
            foreach( T libItem in list)
            {
                Console.WriteLine(libItem);
            }
        }

        public void PrintBooks()
        {
            Books.Sort( (book1, book2) => book1.Title.CompareTo(book2.Title) );
            PrintItems<Book>(Books);
        }

        public void PrintNewsPapers()
        {
            NewsPapers.Sort((newsPaper1, newsPaper2) => newsPaper1.Title.CompareTo(newsPaper2.Title));
            PrintItems<NewsPaper>(NewsPapers);
        }

        public void PrintMovies()
        {
            Movies.Sort((movie1, movie2) => movie1.Title.CompareTo(movie2.Title) );
            PrintItems<Movie>(Movies);
        }

        public void PrintArticles()
        {
            Articles.Sort((article1, article2) => article1.Title.CompareTo(article2.Title));
            PrintItems<Article>(Articles);
        }

        public void PrintJournals()
        {
            Journals.Sort((journal1, journal2) => journal1.Title.CompareTo(journal2.Title));
            PrintItems<Journal>(Journals);
        }

        public void PrintAll()
        {
            List<LibItem> libItemsList = new List<LibItem>();
            libItemsList.AddRange(Books);
            libItemsList.AddRange(NewsPapers);
            libItemsList.AddRange(Articles);
            libItemsList.AddRange(Movies);
            libItemsList.AddRange(Journals);


            libItemsList.Sort((libI1, libI2) => libI1.Title.CompareTo(libI2.Title));
            PrintItems<LibItem>(libItemsList);
        }
    }
}
