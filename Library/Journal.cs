using System;

namespace Library
{

    public class Journal : Magazine
    {

        public string CoverTitle { get; }

        public Journal(string title, string author, int yearOfPublication, int no, int pages, string coverTitle)
        : base(title, author, yearOfPublication, no, pages)
        {
            this.CoverTitle = coverTitle;
        }

        public override string ToString()
        {
            return String.Format("Journal: [title: {0}, author: {1}, yearOfPublication: {2}, no: {3}, pages: {4}, coverTitle: {5}]", Title, Author, YearOfPublication, No, NumberOfPages, CoverTitle);
        }

    }
}