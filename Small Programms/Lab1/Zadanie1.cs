using System;

class User
{
    public string userName { get; set; }
    public int userAge { get; set; }

    public User() //Конструктор без параметров.
    {
    }

    public User(string name, int age) //Контструктор с параметрами.
    {
        userName = name;
        userAge = age;
    }

    public void DisplayUserName() //Метод 1. Показывает полное имя User.
    {
        Console.WriteLine($"User full name: {userName}.");
    }

    public void DisplayUserAge() //Метод 2 на выбор. Показывает возраст User.
    {
        Console.WriteLine($"User age: {userAge}.");
    }
}

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter user full name: "); //Сохраняем ввод User Name в переменную string userName.
        string userName = Console.ReadLine();

        Console.Write("Enter user age: "); //Сохраняем ввод User Age в переменную int userAge + конвентируем из строки в int переменную для записи.
        int userAge = Convert.ToInt32(Console.ReadLine());

        User user1 = new User(userName, userAge); //Создаем экземляр класса с переменными, которые мы получили при вводе.
        user1.DisplayUserName(); //Вызов метода из класса User, который показывает userName
        user1.DisplayUserAge(); //Вызов метода из класса User, который показывает userAge

        User user2 = new User("Full User Name", 24); //Создаем экземляр класса с инициализацией в программе.
        user2.DisplayUserName(); //Вызов метода из класса User, который показывает userName
        user2.DisplayUserAge(); //Вызов метода из класса User, который показывает userAge
    }
}