namespace homework_CS210;

public class ArrayList
{
    private string[] data;
    private int size;

    public ArrayList()
    {
        data = new string[100];
        size = 0;
        
    }

    public void Add(string value)
    {
        data[size] = value;
        size++;
        
    }

    public string Get(int index)
    {
        return data[index];

    }

    public int Size()
    {
        return size;
        
    }
    
}
