using System;

struct Student
{
    public int StudentCode;
    public string Name;
    public double LiteratureScore;
    public double EnglishScore;
    public double AptitudeScore;

    public void DisplayStudentInfo()
    {
        Console.WriteLine("Thông tin học sinh:");
        Console.WriteLine($"Mã số học sinh: {StudentCode}");
        Console.WriteLine($"Tên học sinh: {Name}");
        Console.WriteLine($"Điểm Văn: {LiteratureScore}");
        Console.WriteLine($"Điểm Anh Văn: {EnglishScore}");
        Console.WriteLine($"Điểm Năng khiếu: {AptitudeScore}");
    }

    public double CalculateAverageScore()
    {
        return (AptitudeScore * 2 + LiteratureScore + EnglishScore) / 4;
    }
}

class Program
{
    static void Main()
    {
        Console.WriteLine("Nhập thông tin học sinh:");

        Console.Write("Mã số học sinh: ");
        int studentCode = int.Parse(Console.ReadLine());

        Console.Write("Tên học sinh: ");
        string name = Console.ReadLine();

        Console.Write("Điểm Văn: ");
        double literatureScore = double.Parse(Console.ReadLine());

        Console.Write("Điểm Anh Văn: ");
        double englishScore = double.Parse(Console.ReadLine());

        Console.Write("Điểm Năng khiếu: ");
        double aptitudeScore = double.Parse(Console.ReadLine());

        Student student;
        student.StudentCode = studentCode;
        student.Name = name;
        student.LiteratureScore = literatureScore;
        student.EnglishScore = englishScore;
        student.AptitudeScore = aptitudeScore;

        Console.Clear(); // Xóa màn hình để hiển thị thông tin học sinh
        student.DisplayStudentInfo();

        double averageScore = student.CalculateAverageScore();
        Console.WriteLine($"Điểm trung bình: {averageScore:F2}");
    }
}