using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using assessment3._1;

namespace assessment3._1
{
    public abstract class Building
    {
        public double Length { get; set; }
        public double Width { get; set; }
        public double Height { get; set; }

        public abstract double GetVolume();
        public abstract double GetFirstFloorArea();
    }
}