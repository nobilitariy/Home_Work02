void Print(string text)
{
    Console.WriteLine(text);
}
/*
double GetNumber()
{
    double number = Convert.ToInt32(Console.ReadLine());
    return number;
}

bool GetPolindr(double number)
{
    if(number > 99 && number < 1000)
    {
        if(number % 10 == number / 100) return true;
        else return false;      
    } 
    else if(number > 999 && number < 10000)
    {
        if(number % 10 == number / 1000 && number / 10 % 10 == number / 100 % 10) return true;
        else return false;
    }
    return false;
}
*/

double GetPolindr(double number)
{
    double res = 0;
    while(number > 0)
    {
        number = number % 10;
        res = res * 10 + number;
        number = number / 10;       
    }  
}
//Print("Inter number: ");
double result = GetPolindr(565);
Print($"{result}");

