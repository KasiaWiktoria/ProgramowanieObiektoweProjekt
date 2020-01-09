using System;

namespace Library
{
    public class Article : Text
    {
        public Article(string title, string author, int yearOfPublication, int numberOfPages)
            : base(title, author, yearOfPublication, numberOfPages)
        {
        }

        public override string ToString()
        {
            return String.Format("Article: [ title: {0}, author: {1}, yearOfPublication: {2}]", Title, Author, YearOfPublication);
        }
    }
}
