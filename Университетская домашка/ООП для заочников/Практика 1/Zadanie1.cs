using System;

class User
{
    public string userName { get; set; }
    public int userAge { get; set; }

    public User() //����������� ��� ����������.
    {
    }

    public User(string name, int age) //������������ � �����������.
    {
        userName = name;
        userAge = age;
    }

    public void DisplayUserName() //����� 1. ���������� ������ ��� User.
    {
        Console.WriteLine($"User full name: {userName}.");
    }

    public void DisplayUserAge() //����� 2 �� �����. ���������� ������� User.
    {
        Console.WriteLine($"User age: {userAge}.");
    }
}

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter user full name: "); //��������� ���� User Name � ���������� string userName.
        string userName = Console.ReadLine();

        Console.Write("Enter user age: "); //��������� ���� User Age � ���������� int userAge + ������������ �� ������ � int ���������� ��� ������.
        int userAge = Convert.ToInt32(Console.ReadLine());

        User user1 = new User(userName, userAge); //������� �������� ������ � �����������, ������� �� �������� ��� �����.
        user1.DisplayUserName(); //����� ������ �� ������ User, ������� ���������� userName
        user1.DisplayUserAge(); //����� ������ �� ������ User, ������� ���������� userAge

        User user2 = new User("Full User Name", 24); //������� �������� ������ � �������������� � ���������.
        user2.DisplayUserName(); //����� ������ �� ������ User, ������� ���������� userName
        user2.DisplayUserAge(); //����� ������ �� ������ User, ������� ���������� userAge
    }
}