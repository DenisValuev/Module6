using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module6.Unit2.Models
{
    internal class Rectangle
    {
        int a;
        int b;
        public int Square()
        {
            return a * b;
        }
        public Rectangle()
        {
            a = 6; 
            b = 4;
        }
        public Rectangle(int side)
        {
            a = b =side;
        }
        public Rectangle(int first, int second)
        {
            a = first;
            b = second;
        }
    }
}
