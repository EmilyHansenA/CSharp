class Book
{
    //�������� ������ ��� ������.
    public string authorLastName { get; }
    public string authorFirstName { get; }
    public string authorMiddleName { get; }
    public string bookTitle { get; }
    public string bookCode { get; }
    public int bookYear { get; }

    //�������� ��� ������ � ������.
    private int bookPages { get; set; }

    //���������� ��� ����������.
    public Book()
    {
    }

    //����������� ������ Book � �����������.
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

    //��������������� ������������ ������ ToString() ��� �������� ���������� � ����� � ��������� ������.
    public override string ToString()
    {
        return $"������� ������: {authorLastName}\n" +
               $"��� ������: {authorFirstName}\n" +
               $"�������� ������: {authorMiddleName}\n" +
               $"�������� �����: {bookTitle}\n" +
               $"���: {bookCode}\n" +
               $"��� �������: {bookYear}\n" +
               $"���������� �������: {bookPages}";
    }

    //����������� ���� ���� ����������� ������������� Switch-Case ����������, ���� ������������ ��� �� �����, ��� ��� ��� �������.

    public void CompareAndPrintResult(Book otherBook)
    {
        bool exit = false;
        while (!exit)
        {
            Console.WriteLine("�������� �������� ���������:\n" +
            "1. lastname � �������� ����� �� �������� �������.\n" +
            "2. firstname � �������� ����� �� ������ �������.\n" +
            "3. middlename � �������� ����� �� �������� �������.\n" +
            "4. title � �������� ����� �� ��������.\n" +
            "5. code � �������� ����� �� ID.\n" +
            "6. year � �������� ����� �� ����� �������.\n" +
            "7. pages � �������� ����� �� ���������� �������.\n" +
            "8. exit � ����� �� �����������.\n");
            string criteria = Console.ReadLine().ToLower();


            switch (criteria)
            {
                case "lastname":
                    Console.WriteLine($"�������� ����� �� �������� �������: {this.authorLastName} � {otherBook.authorLastName}");
                    Console.WriteLine($"����� {(this.authorLastName == otherBook.authorLastName ? "����� ����������" : "����� ������")} �� �������� �������\n");
                    break;
                case "firstname":
                    Console.WriteLine($"�������� ����� �� ����� �������: {this.authorFirstName} � {otherBook.authorFirstName}");
                    Console.WriteLine($"����� {(this.authorFirstName == otherBook.authorFirstName ? "����� ����������" : "����� ������")} �� ������ �������\n");
                    break;
                case "middlename":
                    Console.WriteLine($"�������� ����� �� �������� �������: {this.authorMiddleName} � {otherBook.authorMiddleName}");
                    Console.WriteLine($"����� {(this.authorMiddleName == otherBook.authorMiddleName ? "����� ���������� " : "����� ������")} �� �������� �������\n");
                    break;
                case "title":
                    Console.WriteLine($"�������� ����� �� ��������: {this.bookTitle} � {otherBook.bookTitle}");
                    Console.WriteLine($"����� {(this.bookTitle == otherBook.bookTitle ? "����� ����������" : "����� ������")} ��������\n");
                    break;
                case "code":
                    Console.WriteLine($"�������� ����� �� id: {this.bookCode} � {otherBook.bookCode}");
                    Console.WriteLine($"����� {(this.bookCode == otherBook.bookCode ? "����� ����������" : "����� ������")} id\n");
                    break;
                case "year":
                    Console.WriteLine($"�������� ����� �� ����� �������: {this.bookYear} � {otherBook.bookYear}");
                    Console.WriteLine($"����� {(this.bookYear == otherBook.bookYear ? "����� ����������" : "����� ������")} ��� �������\n");
                    break;
                case "pages":
                    Console.WriteLine($"�������� ����� �� ���������� �������: {this.bookPages} � {otherBook.bookPages}");
                    Console.WriteLine($"����� {(this.bookPages == otherBook.bookPages ? "����� ����������" : "����� ������")} ���������� �������\n");
                    break;
                case "exit":
                    exit = true;
                    break;
                default:
                    Console.WriteLine("������������ �������� ��� ���������.\n");
                    break;

            }
        }
    }
}

class Program
{
    static void Main(string[] args)
    {
        //������� ��� ��������� ������ Book
        Book book1 = new Book("�������", "���", "����������", "����� � ���", "12345", 1869, 1225);
        Book book2 = new Book("�����������", "�����", "����������", "������������ � ���������", "12345", 1866, 331);

        // ����� ������ ��������� � ������ ����������
        book1.CompareAndPrintResult(book2);
    }
}
