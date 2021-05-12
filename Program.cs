using System;

namespace RecCsharp
{
    public class Rectangle
    {
        public double length;
        public double width;


        public Rectangle(double len, double wid)
        {
            length = len;
            width = wid;
        }
        public void input_data()
        {
            Console.WriteLine(" please enter the length of a rectangle");
            length = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("please enter the width of a rectangle");
            width = Convert.ToDouble(Console.ReadLine());
        }
        public void output_result()
        {
            Console.WriteLine(" the length of a rectangle is:" + length);
            Console.WriteLine(" the width is :" + width);
            Console.WriteLine(" the area of a rectangle is :" + calc_Area());
            Console.WriteLine(" the perimeter of the rectangle is:" + calc_perimeter());

        }
        public double calc_Area()
        {
            return length * width;

        }
        public double calc_perimeter()
        {
            return 2 * (length + width);
        }




        class Program
        {



            static void Main(string[] args)
            {
                Rectangle obj = new Rectangle(8, 4);
                obj.output_result();
                Rectangle obj1 = new Rectangle(0, 0);
                obj1.input_data();
                obj1.output_result();
            }
        }
    }
}
