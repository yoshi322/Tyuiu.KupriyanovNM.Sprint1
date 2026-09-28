using Tyuiu.KupriyanovNM.Sprint1.Task3.V11.Lib;
namespace Tyuiu.KupriyanovNM.Sprint1.Task2.V13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #1 | Выполнил: Куприянов Н. М. | ИБКСб-26-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #1                                                               *");
            Console.WriteLine("* Тема: Организация ввода/вывода в консольных приложениях                 *");
            Console.WriteLine("* Задание #3                                                              *");
            Console.WriteLine("* Вариант #11                                                             *");
            Console.WriteLine("* Выполнил: Куприянов Никита Максимович | ИБКСб-26-1                      *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу, которая вычисляет площадь треугольника, если        *");
            Console.WriteLine("* известны координаты его углов.                                          *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            double x1 = -2;
            double y1 = 5;
            double x2 = 1;
            double y2 = 7;
            double x3 = 5;
            double y3 = -3;
            Console.WriteLine("Координаты первого угла = " + x1 +" "+ y1);
            Console.WriteLine("Координаты второго угла = " + x2 + " "+ y2);
            Console.WriteLine("Координаты третьего угла = " + x3 + " " + y3);

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("Площадь треугольника = " + ds.TriangleArea(x1,y1,x2,y2,x3,y3));

            Console.ReadKey();
        }
    }
}
