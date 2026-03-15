namespace homework_CS210;

public class Helpers
{
    public static bool IsOperator(string s)
    {
        if (s == "+")
            return true;
        if (s == "-")
            return true;
        if (s == "*")
            return true;
        if (s == "/")
            return true;

        return false;
        
    }

    public static int Priority(string op)
    {
        if (op == "+" || op == "-")
            return 1;
        if (op == "*" || op == "/")
            return 2;

        return 0;
        
    }
    
}