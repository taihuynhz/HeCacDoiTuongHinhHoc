using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeCacDoiTuongHinhHoc
{
    class Program
    {
        static void Main(string[] args)
        {
            // Shape Test
            Shape shape = new Shape();
            Console.WriteLine(shape);

            shape = new Shape("red", false);
            Console.WriteLine(shape);

            // Circle Test
            Circle circle = new Circle();
            Console.WriteLine(circle);

            circle = new Circle(3.5);
            Console.WriteLine(circle);

            circle = new Circle(3.5, "indigo", false);
            Console.WriteLine(circle);

            // Rectangle Test
            Rectangle rectangle = new Rectangle();

            Console.WriteLine(rectangle);

            rectangle = new Rectangle(2.3, 5.8);

            Console.WriteLine(rectangle);

            rectangle = new Rectangle(2.5, 3.8, "orange", true);

            Console.WriteLine(rectangle);

            // Square Test
            Square square = new Square();
            Console.WriteLine(square);

            square = new Square(2.3);
            Console.WriteLine(square);

            square = new Square(5.8, "yellow", true);
            Console.WriteLine(square);
        }
    }
}
