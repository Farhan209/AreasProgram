using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AreasProgram
{
    class Triangle
    {
        public double Area(double Base, double Height)
        {
            return (Base * Height) / 2;
        }

        public double Perimeter(double SizeA, double SizeB, double SizeC)
        {
            return SizeA + SizeB + SizeC;
        }
    }
}
