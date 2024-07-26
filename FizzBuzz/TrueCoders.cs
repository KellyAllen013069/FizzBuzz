namespace FizzBuzz;

public class TrueCoders
{
    public void FizzBuzz(int num)
    {
        var expression = "";
        if (num % 3 == 0) expression += "fizz";
        if (num % 5 == 0) expression += "buzz";
        if (expression == "") expression = "nothing";
        Console.WriteLine($"FizzBuzz result for {num} is {expression}");
    }
}