using System;
class Answer
{
    static void CheckNumber(int number)
    {
        string result;
        if (number == 0) result = "ноль";
        else if (number > 0) result = "положительное";
        else result = "отрицательное";
        Console.WriteLine(result);
    }
    static public void Main(string[] args)
    {
        int number;
        if (args.Length >= 1)
        {
            number = int.Parse(args[0]);
        }
        else
        {
            number = 7;
        }
        CheckNumber(number);
    }
}
