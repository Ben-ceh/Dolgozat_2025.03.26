using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _Egysegteszt_KomócziBence
{
    internal class Rectangle
    {

        public double CalculateArea(double width, double height)
        {

            
            if(width == 0)
            {
                throw new ArgumentException("Az oldal 0!");
            }    
            
            if (height == 0)
            {
                throw new ArgumentException("Az oldal 0!");
            }
            if(width < 0)
            {
                throw new ArgumentException("Az oldal negatív!");
            }
            if (height < 0)
            {
                throw new ArgumentException("Az oldal negatív!");
            }



            return width * height;
        }
        static void Main(string[] args)
        {
            var szamol = new Rectangle();
            Console.Write("A téglalap egyik oldala: ");

            double width = double.Parse(Console.ReadLine());
            Console.WriteLine();

            Console.Write("A téglalap másik oldala: ");
            double height = double.Parse(Console.ReadLine());
            Console.WriteLine();
            Console.Write("A téglalap területe: ");
            Console.WriteLine(CalculateArea(width,height));



           
        }
    }
}
