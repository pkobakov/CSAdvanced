namespace RawData
{
    public class Tire
    {
        private double pressure;
        private int year;
        public Tire(double pressure, int year) 
        {
           this.Pressure = pressure;
            this.Year = year;
        }

        public double Pressure { get { return pressure; } set { pressure = value; } }
        public int Year { get { return year;  } set { year = value; } }
    }
}