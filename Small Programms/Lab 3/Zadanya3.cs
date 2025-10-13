//Создаем интерфейс IBusiness и метод DoBusiness
interface IBusiness
{
    void DoBusiness();
}
//Создаем интерфейс ITech и метод WriteCode
interface ITech
{
    void WriteCode();
}
//Создали класс SoftwareDeveloper, который наследует 2 интерфейса IBusiness & ITech
public class SoftwareDeveloper : IBusiness, ITech
{
    //Реализовали метод из интерфейса IBusiness
    public void DoBusiness()
    {
        Console.WriteLine("Doing business");
    }
    //Реализовали метод из интерфейса ITech
    public void WriteCode()
    {
        Console.WriteLine("Writing code");
    }
}
//Основное тело программы
class Program
{
    static void Main(string[] args)
    {
        //Создали экземляр класса SoftwareDeveloper и вызвали его методы
        SoftwareDeveloper softwareDeveloper = new SoftwareDeveloper();
        softwareDeveloper.DoBusiness();
        softwareDeveloper.WriteCode();
    }
}
