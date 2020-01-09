using System;

namespace Library
{
    public class Movie : Multimedia
    {
        public string Director { get; }

        public Movie(string title, string director, int yearOfPublication, int duration)
            :base(title, yearOfPublication, duration){
            this.Director = director;
        }

        public override string ToString()
        {
            return String.Format("Movie: [ title: {0}, director: {1}, yearOfPublication: {2}, duration in minutes: {3}]",Title, Director, YearOfPublication, DurationInMinutes);
        }
    }
}
