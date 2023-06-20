void Print(string text)
{
    Console.WriteLine(text);
}

double GetNumber()
{
    double num = Convert.ToInt32(Console.ReadLine());
    return num;
}

double CalculDistans(double x1, double y1, double z1,
                     double x2, double y2, double z2)
{
    double DistanceFirst = Math.Sqrt((x2-x1)*(x2-x1)+(z2-z1)*(z2-z1));
    double DistanceFinal = Math.Sqrt(DistanceFirst*DistanceFirst+(y2-y1)*(y2-y1));
    return DistanceFinal;

}

Print("Еnter coordinates of 2 points in 3D space");
double x1 = GetNumber();
double y1 = GetNumber();
double z1 = GetNumber();
double x2 = GetNumber();
double y2 = GetNumber();
double z2 = GetNumber();
double result = CalculDistans(x1, y1, z1, x2, y2, z2);
Print($"Distance between two points in 3D space = {result}");