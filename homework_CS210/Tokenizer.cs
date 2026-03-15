namespace homework_CS210;

public class Tokenizer
{
    public static ArrayList Tokenize(string input)
    {
        ArrayList tokens = new ArrayList();
        string number = "";

        for (int i = 0; i < input.Length; i++)
        {
            char currentChar = input[i];

            if (char.IsDigit(currentChar))
            {
                number = number + currentChar;

            }

            else
            {
                if (number != "")
                {
                    tokens.Add(number);
                    number = "";
                    
                }
                if (currentChar == '+')
                {
                    tokens.Add(currentChar.ToString());
                    
                }
                
                else if (currentChar == '-')
                {
                    tokens.Add(currentChar.ToString());
                    
                }
                
                else if (currentChar == '*')
                {
                    tokens.Add(currentChar.ToString());
                    
                }
                
                else if (currentChar == '/')
                {
                    tokens.Add(currentChar.ToString());
                    
                }
                
                else if (currentChar == '(')
                {
                    tokens.Add(currentChar.ToString());
                    
                }
                
                else if (currentChar == ')')
                {
                    tokens.Add(currentChar.ToString());
                    
                }
                
            }
            
        }
        
        if (number != "")
        {
            tokens.Add(number);
            
        }

        return tokens;
        
    }

}