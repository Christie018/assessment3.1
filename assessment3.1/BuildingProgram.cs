using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using assessment3._1;

namespace assessment3._1
{
    public class BuildingProgram
    {
        public static Pyramid BuildGreatPyramid()
        {
            return new Pyramid(756, 481, 756);
        }

        public static string DescribeBuilding(Building building)
        {
            double volume = building.GetVolume();
            double firstFloorArea = building.GetFirstFloorArea();
            return $"Volume: {volume}, First Floor Area: {firstFloorArea}";
        }
    }
}
