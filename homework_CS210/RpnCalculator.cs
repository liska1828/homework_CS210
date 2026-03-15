namespace homework_CS210;

public class RpnCalculator
{
    public static int Calculate(ArrayList tokens)
    {
        Stack stack = new Stack();

        for (int i = 0; i < tokens.Size(); i++)
        {

            string token = tokens.Get(i);

            if (char.IsDigit(token[0]))
            {
                stack.Push(token);
                
            }

            else
            {
                int b = int.Parse(stack.Pop());
                int a = int.Parse(stack.Pop());

                int result = 0;

                if (token == "+") result = a + b;
                if (token == "-") result = a - b;
                if (token == "*") result = a * b;
                if (token == "/") result = a / b;

                stack.Push(result.ToString());

            }

        }

        return int.Parse(stack.Pop());

    }

}