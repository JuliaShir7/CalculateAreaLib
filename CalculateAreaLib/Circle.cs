namespace CalculateAreaLib
{
    public class Circle: IAreaCalculatable
    {
        public double Radius { get; set; }
        public Circle(double radius)
        {
            Radius = radius;
        }

        public double CountArea()
        {
            return Math.PI * (Math.Pow(Radius, 2));
        }
    }
}
