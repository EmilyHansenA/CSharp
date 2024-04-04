interface Iworker
{
    public void DoWork();
}

class Programmer : Iworker
{
    public string programmingLanguage;

    public void DoWork()
    {
        throw new NotImplementedException();
    }
}

class Manager : Iworker
{
    public int TeamSize;
    public void DoWork()
    {
        throw new NotImplementedException();
    }
}