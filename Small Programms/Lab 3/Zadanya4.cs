interface IVehicle
{
    void Move();
}
interface IDrive
{
    void Control();
}
interface IEngine
{
    void StartEngine();
}
interface ILoadable
{
    void LoadCargo();
}

class Car : IVehicle, IDrive
{
    public void Move()
    {
        Console.WriteLine("Машина едет");
    }
    public void Control()
    {
        Console.WriteLine("Водитель контролирует машину");
    }

}
class Truck : IVehicle, IDrive, IEngine, ILoadable
{
    public void LoadCargo()
    {
        Console.WriteLine("Груз был загружен в грузовик");
    }
    public void StartEngine()
    {
        Console.WriteLine("Двигатель грузовика запустился");
    }
    public void Move()
    {
        Console.WriteLine("Грузовик едет");
    }
    public void Control()
    {
        Console.WriteLine("Водитель контролирует грузовик");
    }
}

class TruckDriver : IDrive
{
    private Car car;
    private Truck truck;

    public TruckDriver()
    {
        car = new Car();
        truck = new Truck();
    }

    public void Control()
    {
        car.Move();
        car.Control();

        truck.LoadCargo();
        truck.StartEngine();
        truck.Move();
        truck.Control();
    }

}

class Program
{
    static void Main(string[] args)
    {
        TruckDriver truckDriver = new TruckDriver();
        truckDriver.Control();
    }
}