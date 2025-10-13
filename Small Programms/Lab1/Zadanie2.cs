class Book
{
    //Свойства только для чтения.
    public string authorLastName { get; }
    public string authorFirstName { get; }
    public string authorMiddleName { get; }
    public string bookTitle { get; }
    public string bookCode { get; }
    public int bookYear { get; }

    //Свойство для чтения и записи.
    private int bookPages { get; set; }

    //Коструктор без параметров.
    public Book()
    {
    }

    //Конструктор класса Book с параметрами.
    public Book(string authorLastName, string authorFirstName, string authorMiddleName, string bookTitle, string bookCode, int bookYear, int bookPages)
    {
        this.authorLastName = authorLastName;
        this.authorFirstName = authorFirstName;
        this.authorMiddleName = authorMiddleName;
        this.bookTitle = bookTitle;
        this.bookCode = bookCode;
        this.bookYear = bookYear;
        this.bookPages = bookPages;
    }

    //Переопределение стандартного метода ToString() для перевода информации о книге в строковый формат.
    public override string ToString()
    {
        return $"Фамилия автора: {authorLastName}\n" +
               $"Имя автора: {authorFirstName}\n" +
               $"Отчество автора: {authorMiddleName}\n" +
               $"Название книги: {bookTitle}\n" +
               $"Код: {bookCode}\n" +
               $"Год издания: {bookYear}\n" +
               $"Количество страниц: {bookPages}";
    }

    //Сравнивание двух книг посредством использования Switch-Case бесконечно, пока пользователь сам не решит, что ему это надоело.

    public void CompareAndPrintResult(Book otherBook)
    {
        bool exit = false;
        while (!exit)
        {
            Console.WriteLine("Выберите критерий сравнения:\n" +
            "1. lastname — Сравнить книги по фамилиям авторов.\n" +
            "2. firstname — Сравнить книги по именам авторов.\n" +
            "3. middlename — Сравнить книги по отчеству авторов.\n" +
            "4. title — Сравнить книги по названию.\n" +
            "5. code — Сравнить книги по ID.\n" +
            "6. year — Сравнить книги по годам издания.\n" +
            "7. pages — Сравнить книги по количеству страниц.\n" +
            "8. exit — Выход из сравнивания.\n");
            string criteria = Console.ReadLine().ToLower();


            switch (criteria)
            {
                case "lastname":
                    Console.WriteLine($"Сравнить книги по фамилиям авторов: {this.authorLastName} и {otherBook.authorLastName}");
                    Console.WriteLine($"Книги {(this.authorLastName == otherBook.authorLastName ? "имеют одинаковых" : "имеют разных")} по фамилиям авторов\n");
                    break;
                case "firstname":
                    Console.WriteLine($"Сравнить книги по имени авторов: {this.authorFirstName} и {otherBook.authorFirstName}");
                    Console.WriteLine($"Книги {(this.authorFirstName == otherBook.authorFirstName ? "имеют одинаковых" : "имеют разных")} по именам авторов\n");
                    break;
                case "middlename":
                    Console.WriteLine($"Сравнить книги по отчеству авторов: {this.authorMiddleName} и {otherBook.authorMiddleName}");
                    Console.WriteLine($"Книги {(this.authorMiddleName == otherBook.authorMiddleName ? "имеют одинаковых " : "имеют разных")} по отчеству авторов\n");
                    break;
                case "title":
                    Console.WriteLine($"Сравнить книги по названию: {this.bookTitle} и {otherBook.bookTitle}");
                    Console.WriteLine($"Книги {(this.bookTitle == otherBook.bookTitle ? "имеют одинаковые" : "имеют разные")} названия\n");
                    break;
                case "code":
                    Console.WriteLine($"Сравнить книги по id: {this.bookCode} и {otherBook.bookCode}");
                    Console.WriteLine($"Книги {(this.bookCode == otherBook.bookCode ? "имеют одинаковые" : "имеют разные")} id\n");
                    break;
                case "year":
                    Console.WriteLine($"Сравнить книги по годам издания: {this.bookYear} и {otherBook.bookYear}");
                    Console.WriteLine($"Книги {(this.bookYear == otherBook.bookYear ? "имеют одинаковый" : "имеют разный")} год издания\n");
                    break;
                case "pages":
                    Console.WriteLine($"Сравнить книги по количеству страниц: {this.bookPages} и {otherBook.bookPages}");
                    Console.WriteLine($"Книги {(this.bookPages == otherBook.bookPages ? "имеют одинаковое" : "имеют разное")} количество страниц\n");
                    break;
                case "exit":
                    exit = true;
                    break;
                default:
                    Console.WriteLine("Неккоректный параметр для сравнения.\n");
                    break;

            }
        }
    }
}

class Program
{
    static void Main(string[] args)
    {
        //Создаем два экземляра класса Book
        Book book1 = new Book("Толстой", "Лев", "Николаевич", "Война и мир", "12345", 1869, 1225);
        Book book2 = new Book("Достоевский", "Федор", "Михайлович", "Преступление и наказание", "12345", 1866, 331);

        // Вызов метода сравнения и вывода результата
        book1.CompareAndPrintResult(book2);
    }
}
