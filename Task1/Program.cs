void Print(string text)
{
    Console.WriteLine(text);
}

double GetNumber()
{
    double number = Convert.ToInt32(Console.ReadLine());
    return number;
}

double ReversеNumber(double number)
{
    double res = 0;
    while(number > 0)
    {
        double digit = number % 10;
        res = res * 10 + digit;
        number = number / 10;     
    }
    return res;
}

Print("Inter number: ");
double num = GetNumber();
double result = ReversеNumber(num);
Print($"{result}");

