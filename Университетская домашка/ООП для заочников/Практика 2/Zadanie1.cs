//Базовый абстрактный класс (шаблон для других) "Мультимедийный Материал"
abstract class MultimediaMaterial
{
    //Общие свойства
    public string Title { get; set; }
    public string Author { get; set; }
    public int Duration { get; set; }

    public virtual void View()
    {
        Console.WriteLine($"Название: {Title}.");
        Console.WriteLine($"Автор: {Author}.");
        Console.WriteLine($"Длительность: {Duration} мин.");
    }
}
//Подкласс книга
class Book : MultimediaMaterial
{
    //Доп поле для книги
    public string Genre { get; set; }

    //Переопределим метод View у родителя
    public override void View()
    {
        base.View();
        Console.WriteLine($"Жанр книги: {Genre}.");
    }

}
class AudioBook : MultimediaMaterial
{
    //Доп поле для аудиокниги
    public string AudioQuality { get; set; }

    //Переопределим метод View у родителя
    public override void View()
    {
        base.View();
        Console.WriteLine($"Качество аудио: {AudioQuality}.");
    }

}
class VideoFilm : MultimediaMaterial
{
    //Доп поле для видеофильма
    public string Director { get; set; }

    //Переопределим метод View у родителя
    public override void View()
    {
        base.View();
        Console.WriteLine($"Режиссер: {Director}.");
    }

}

class Program
{
    static void Main(string[] args)
    {
        // Создание объектов
        Book book = new Book
        {
            Title = "Три товарища",
            Author = "Эрих Мария Ремарк",
            Duration = 350,
            Genre = "Роман"
        };

        AudioBook audiobook = new AudioBook
        {
            Title = "1984",
            Author = "Джордж Оруэлл",
            Duration = 480,
            AudioQuality = "Высокое"
        };

        VideoFilm videoFilm = new VideoFilm
        {
            Title = "Зеленая миля",
            Author = "Стивен Кинг",
            Duration = 189,
            Director = "Фрэнк Дарабонт"
        };

        // Вызов метода View для каждого объекта
        Console.WriteLine("Информация о книге:");
        book.View();

        Console.WriteLine("\nИнформация об аудиокниге:");
        audiobook.View();

        Console.WriteLine("\nИнформация о видеофильме:");
        videoFilm.View();
    }
}