using System;

namespace Library
{
    public abstract class LibItem
    {
        public string Title { get; }
        public int YearOfPublication { get; }
        public Nullable<DateTime> CheckOutDate;
        public bool Available;

        public LibItem(string title, int yearOfPublication)
        {
            this.Title = title;
            this.YearOfPublication = yearOfPublication;
            this.Available = true;
        }
       
        public void CheckOut() {
            
        }

        public void Return()
        {
            
        }
       
    }
}
