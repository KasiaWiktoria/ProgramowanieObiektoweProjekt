namespace Library
{
    public abstract class Multimedia :LibItem
    {
        public double DurationInMinutes;

        public Multimedia(string title, int yearOfPublication, double duration)
            :base(title, yearOfPublication)
        {
            this.DurationInMinutes = duration;
        }
    }
}
