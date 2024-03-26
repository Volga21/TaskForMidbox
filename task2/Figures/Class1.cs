using System.Collections;

namespace Figures
{
    public class Circle:Figure
    {
        public Circle(double radius)
        {
            this.radius = radius;
        }
        public double square()
        {
            return Math.PI*Math.Pow(radius,2);
        }
        double radius;
    }
    public class Triangle: Figure
    {
        public Triangle(double a, double b, double c)
        {
            this.a = a;
            this.b = b;
            this.c = c;
        }
        public bool squarenessCheck()
        {
            List <double> sides=new List<double>(){a,b,c};
            sides.Sort();
            if (Math.Pow(sides[0],2)+ Math.Pow(sides[1], 2)== Math.Pow(sides[2], 2))
            {
                return true;
            }
            return false;
        }
        public double square()
        {
            double perimetr = (a + b + c)/2;
            return Math.Sqrt(perimetr * (perimetr - a) * (perimetr - b) * (perimetr - c));
        }
        double a,b,c;
    }
    interface Figure
    {
        public double square();
    }
}


