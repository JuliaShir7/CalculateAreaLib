namespace CalculateAreaLib
{
    internal class Circle: IAreaCalculatable
    {
        public double CountArea(params double[] parameters)
        {
            return Math.PI * (Math.Pow(parameters[0], 2));
        }
    }
}
