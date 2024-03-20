/* Assessment #3.1
 * Mattalynn Darden
 * 3/19/24 
 * GC C# */

using assessment3._1;

Pyramid greatPyramid = BuildingProgram.BuildGreatPyramid();
string description = BuildingProgram.DescribeBuilding(greatPyramid);
Console.WriteLine(description);