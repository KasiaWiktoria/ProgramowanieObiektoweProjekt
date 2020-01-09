using System;

namespace Library
{
    public class NewsPaper : Magazine
    {
        public string MainTopic;
        public NewsPaper(string title, string author, int yearOfPublication,int no, int numberOfPages, string mainTopic)
            :base(title, author, yearOfPublication, no, numberOfPages)
        {
            this.MainTopic = mainTopic;
        }

        public override string ToString()
        {
            return String.Format("Magazine: [ title: {0}, author: {1}, yearOfPublication: {2}, no: {3}]", Title, Author, YearOfPublication, No);
        }
    }
}
