void Print(string text);
{
    Console.WriteLine(text);
}

int GetNumber()
{
    int number = Convert.ToInt32(ReadLine());
    return number;
}

bool GetPolindr(int number);
{
    if(numberr>100 && number<1000)
    {
        if(number%10 == numberr/100)
        return true;
        else 
        return false;
    }
    if(number>1000 && number<10000)
    {
        if(number%10 == number/1000 && number/10%10 == number/100%10)
        return true;
        else
        return false;
    }
}
Print("Inter number: ");
GetNumber();
GetPolindr(GetNumber);
