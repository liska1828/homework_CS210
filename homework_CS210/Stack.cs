namespace homework_CS210;

public class Stack
{
    private string[] data;
    private int top;

    public Stack()
    {
        data = new string[100];
        top = -1;
    }

    public void Push(string value)
    {
        top++;
        data[top] = value;
    }

    public string Pop()
    {
        string value = data[top];
        top--;
        return value;
    }

    public string Peek()
    {
        return data[top];
    }

    public bool IsEmpty()
    {
        return top == -1;
    }
    
}