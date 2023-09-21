namespace CalculateAreaLib
{
    public class Triangle:IAreaCalculatable
    {
        double[] FindPossibleLegs(params double[] parameters)
        {
            return parameters.Where(p => p != parameters.Max()).ToArray();
        }
        bool IsRectangular(params double[] parameters)
        {
            double[] probableLegs = FindPossibleLegs(parameters);
            if (Math.Pow(parameters.Max(), 2) == (Math.Pow(probableLegs[0], 2) + Math.Pow(probableLegs[1], 2)))
                return true;
            else
                return false;
        }
        public double CountArea(params double[] parameters)
        {
            if (IsRectangular(parameters))
            {
                var legs = FindPossibleLegs(parameters);
                return (legs[0] * legs[1]) / 2;
            }
            else
            {
                double p = (parameters[0] + parameters[1] + parameters[2]) / 2;
                return Math.Sqrt(p * (p - parameters[0]) * (p - parameters[1]) * (p - parameters[2]));
            }
        }
    }
}