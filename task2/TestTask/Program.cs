using Figures;
namespace TestTask
{
    class Program
    {
        static void Main(string[] args)
        {
            Circle figure1 = new Circle(4);
            Console.WriteLine($"Площадь кргуа c r={4} равна {figure1.square()}");
            Console.Write("Введите радиус круга: ");
            try
            {
                double radius = Convert.ToDouble(Console.ReadLine());
                if (radius <= 0)
                {
                    Console.WriteLine("Радиус меньше или равен 0");
                }
                else
                {
                    Circle figure2 = new Circle(radius);
                    Console.WriteLine($"Площадь кргуа c r={radius} равна {figure2.square()}");
                }
            }
            catch
            {
                Console.WriteLine("Ошибка ввода");
            }
            Console.Write("Введите стороны треугольника : ");
            try
            {
                double side1 = Convert.ToDouble(Console.ReadLine());
                double side2 = Convert.ToDouble(Console.ReadLine());
                double side3 = Convert.ToDouble(Console.ReadLine());
                if (side1<=0 || side2 <= 0 || side3 <= 0)
                {
                    Console.WriteLine("Неверные входные данные");
                }
                else
                {
                    Triangle figure3 = new Triangle(side1,side2,side3);
                    Console.WriteLine($"Площадь труеугольника cо сторонами {side1},{side2},{side3} равна {figure3.square()}");
                    if (figure3.squarenessCheck())
                    {
                        Console.WriteLine($"Треугольник прямоугольный");
                    }
                    else
                    {
                        Console.WriteLine($"Треугольник непрямоугольный");
                    }
                }
            }
            catch
            {
                Console.WriteLine("Ошибка ввода");
            }
        }
    }
}