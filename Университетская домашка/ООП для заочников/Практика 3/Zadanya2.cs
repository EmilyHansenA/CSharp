//Создаем интерфейс IWorker
interface IWorker
{
    void DoWork();
}

//Создаем класс Programmer, который наследует интерфейс IWorker
class Programmer : IWorker
{
    public string programmingLanguage;

    public void DoWork()
    {
        throw new NotImplementedException();
    }
}
//Создаем класс Manager, который наследует интерфейс IWorker
class Manager : IWorker
{
    public int teamSize;
    public void DoWork()
    {
        throw new NotImplementedException();
    }
}