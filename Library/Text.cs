namespace Library
{
    public abstract class Text :LibItem
    {
        public string Author;
        public int NumberOfPages;

        public Text(string title, string author, int yearOfPublication, int numberOfPages)
            : base(title, yearOfPublication)
        {
            this.Author = author;
            this.NumberOfPages = numberOfPages;
        }

    }
}
