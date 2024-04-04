//Создаем интерфейс IWorker и метод DoWork
interface IWorker
{
    void DoWork();
}

//Создаем класс Programmer, который наследует интерфейс IWorker
class Programmer : IWorker
{
    public string programmingLanguage;
    //Реализовали метод интерфейса
    public void DoWork()
    {
        Console.WriteLine("Programmer do work");
    }
}

//Создаем класс Manager, который наследует интерфейс IWorker
class Manager : IWorker
{
    public int teamSize;
    //Реализовали метод интерфейса
    public void DoWork()
    {
        Console.WriteLine("Manager do work");
    }
}

//Основное тело программы
class Program
{
    static void Main(string[] args)
    {
        //Создаем экземляр классов Programmer & Manager и вызываем их методы
        Programmer programmer = new Programmer();
        programmer.DoWork();
        Manager manager = new Manager();
        manager.DoWork();
    }
}