namespace Task1
{
    public class Car
    {
        public string Name { get; }

        public int Year { get; }

        public Car(string name, int year)
        {
            this.Name = name;
            this.Year = year;
        }

        public override bool Equals(object obj)
        {
            Car tmp = (Car)obj;

            if (!(obj is Car))
                return false;
            else
                return obj != null && tmp.Name == this.Name && tmp.Year == this.Year;
        }

        public override string ToString()
        {
            return $"{this.Name} {this.Year}";
        }
    }
}