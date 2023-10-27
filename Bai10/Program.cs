using System;

class Book
{
    public int BookCode { get; set; }
    public string Publisher { get; set; }
    public int PublicationYear { get; set; }
    public double Price { get; set; }

    public Book(int bookCode, string publisher, int publicationYear, double price)
    {
        BookCode = bookCode;
        Publisher = publisher;
        PublicationYear = publicationYear;
        Price = price;
    }

    public void DisplayBookInfo()
    {
        Console.WriteLine("Thông tin cuốn sách:");
        Console.WriteLine($"Mã số sách: {BookCode}");
        Console.WriteLine($"Nhà xuất bản: {Publisher}");
        Console.WriteLine($"Năm xuất bản: {PublicationYear}");
        Console.WriteLine($"Giá tiền: {Price:C}");
    }
}

class Program
{
    static void Main()
    {
        Console.WriteLine("Nhập thông tin cuốn sách:");

        Console.Write("Mã số sách: ");
        int bookCode = int.Parse(Console.ReadLine());

        Console.Write("Nhà xuất bản: ");
        string publisher = Console.ReadLine();

        Console.Write("Năm xuất bản: ");
        int publicationYear = int.Parse(Console.ReadLine());

        Console.Write("Giá tiền: ");
        double price = double.Parse(Console.ReadLine());

        Book book = new Book(bookCode, publisher, publicationYear, price);

        Console.Clear(); // Xóa màn hình để hiển thị thông tin sách
        book.DisplayBookInfo();
    }
}
