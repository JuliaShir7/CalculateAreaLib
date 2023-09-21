namespace CalculateAreaLib
{
    public  static class Calculation
    {
        static IAreaCalculatable calculatable;
        public static double Calculate(params double[] parameters)
        {
            if (parameters == null) throw new ArgumentNullException("Ошибка при вычислении - отсутствуют парметры");
            if (parameters.Length == 1)
            {
                return CalculateCircle(parameters);
            }
            else
            {
                if (parameters.Length == 3)
                {
                    return CalculateTriangle(parameters);
                }
                else throw new ArgumentException("Невозможно провести вычисления");
            }
        }
        public static double CalculateTriangle(params double[] parameters)
        {
            calculatable = new Triangle();
            return calculatable.CountArea(parameters);
        }
        public static double CalculateCircle(params double[] parameters)
        {
            calculatable = new Circle();
            return calculatable.CountArea(parameters);
        }
    }
}
