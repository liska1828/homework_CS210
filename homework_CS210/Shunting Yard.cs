namespace homework_CS210;

public class Shunting_Yard
{
    public static ArrayList Convert(ArrayList tokens)
    {
        ArrayList output = new ArrayList();
        Stack stack = new Stack();

        for (int i = 0; i < tokens.Size(); i++)
        {
            string token = tokens.Get(i);

            if (char.IsDigit(token[0]))
            {
                output.Add(token);
                
            }
            
            else if (Helpers.IsOperator(token))
            {
                while (!stack.IsEmpty() && Helpers.IsOperator(stack.Peek()) &&
                       Helpers.Priority(stack.Peek()) >= Helpers.Priority(token))
                {
                    output.Add(stack.Pop());
                    
                }
                
                stack.Push(token);
                
            }
            
            else if (token == "(")
            {
                stack.Push(token);
                
            }
            
            else if (token == ")")
            {
                while (stack.Peek() != "(")
                {
                    output.Add(stack.Pop());

                }

                stack.Pop();
                
            }
            
        }

        while (!stack.IsEmpty())
        {
            output.Add(stack.Pop());
        }

        return output;

    }

}