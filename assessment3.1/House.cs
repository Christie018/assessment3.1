using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using assessment3._1;

namespace assessment3._1
{
    public class House : Building
    {
        public House(double length, double width, double height)
        {
            Length = length;
            Width = width;
            Height = height;
        }

        public override double GetVolume()
        {
            return Length * Width * Height;
        }

        public override double GetFirstFloorArea()
        {
            return Length * Width;
        }
    }
}
