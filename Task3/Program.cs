void Print(string text)
{
    Console.WriteLine(text);
}

double GetNumber()
{
    double number = Convert.ToInt32(Console.ReadLine());
    return number;
}

void GetCubes(double number)
{
    for(double i=1; i<=number; i++)
    {
        double cubes = Math.Pow(i, 3);
        Console.Write($"{cubes}, ");
    }
}

Print("Enter number");
double number = GetNumber();
GetCubes(number);