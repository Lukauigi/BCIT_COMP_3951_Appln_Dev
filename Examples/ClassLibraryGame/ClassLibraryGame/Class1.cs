using System;

public interface IDelete
{
    void Delete();
}
public class TextBox : IDelete
{
    public void Delete()
    {
        Console.WriteLine("TextBox");
    }
}
public class Label : IDelete
{
    public void Delete() { Console.WriteLine("Label"); }
}
class Program
{
    static void Main(string[] args)
    {
        TextBox tb = new TextBox();
        IDelete iDel = tb;
        iDel.Delete();

        Label l = new Label();
        iDel = l;
        iDel.Delete();

        Console.ReadLine();

    }
}
}

