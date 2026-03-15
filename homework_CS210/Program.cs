using System;
using homework_CS210;
class Program
{
    static void Main()
    {
        Console.WriteLine("Enter expression:");

        string input = Console.ReadLine();

        ArrayList tokens = Tokenizer.Tokenize(input);

        ArrayList rpn = Shunting_Yard.Convert(tokens);

        int result = RpnCalculator.Calculate(rpn);

        Console.WriteLine("Result: " + result);
    }
}