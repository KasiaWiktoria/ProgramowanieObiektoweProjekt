namespace Library
{
    public class Magazine : Text
    {
        public int No;

        public Magazine(string title, string author, int yearOfPublication, int no, int numberOfPages)
            : base(title, author, yearOfPublication, numberOfPages)
        {
            this.No = no;
        }
    }
}
