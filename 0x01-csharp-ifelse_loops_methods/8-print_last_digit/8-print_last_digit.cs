using System;

class Number
{
    public static int PrintLastDigit(int number)
    {
        int last = number % 10;
        if (last < 0)
            last *= -1;
        Console.Write(last);
        return last;
    }
}
