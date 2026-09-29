using tyuiu.cources.programming.interfaces.Sprint1;
namespace Tyuiu.KupriyanovNM.Sprint1.Task7.V17.Lib
{
    public class DataService : ISprint1Task7V17
    {
        public double Calculate(double x, double y)
        {
            double first = 1 + Math.Sin(Math.Sqrt(Math.Pow(x, 2) + 1));
            double second = Math.Cos(12 * y - 4);
            double res = first / second;
            res = Math.Round(res, 3);
            return res;
        }
    }
}
