void Print(string text)
{
    Console.WriteLine(text);
}

int GetNumber()
{
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}

int ReversеNumber(int number)
{
    int res = 0;
    while(number > 0)
    {
        int digit = number % 10;
        res = res * 10 + digit;
        number = number / 10;     
    }
    return res;
}
 
bool GetPolindrome(int reversNum, int number)
{
    if(reversNum == number)
    {
        Console.WriteLine($"{number} palindrome");
        return true;
    }
    else
    {
        Console.WriteLine($"{number} not polindrome");
        return true;
    }
    
}

Print("Inter number: ");
int num = GetNumber();
int result = ReversеNumber(num);
GetPolindrome(result, num);

