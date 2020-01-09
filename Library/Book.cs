using System;

namespace Library
{
    public class Book : Text
    {

        int Edition;

        public Book(string title, string author, int yearOfPublication, int numberOfPages, int edition)
            : base(title, author, yearOfPublication, numberOfPages)
        {
            this.Edition = edition;
            
        }

        public override string ToString()
        {
            return String.Format( "Book: [ title: {0}, author: {1}, yearOfPublication: {2}, edition: {3}]", Title, Author, YearOfPublication, Edition);
        }
    }
}
