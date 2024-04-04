interface IBusiness
{
    void DoBusiness();
}

interface ITech
{
    void WriteCode();
}

public class SoftwareDeveloper : IBusiness, ITech
{
    public void DoBusiness()
    {
        Console.WriteLine("Doing business");
    }

    public void WriteCode()
    {
        Console.WriteLine("Writing code");
    }
}
class Program
{
    static void Main(string[] args)
    {
        SoftwareDeveloper softwareDeveloper = new SoftwareDeveloper();
        softwareDeveloper.DoBusiness();
        softwareDeveloper.WriteCode();
    }
}
