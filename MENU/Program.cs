using System;

class Program
{
    //Ham đếm số lần xuất hiện
    public static void DemSoLanXuatHienTrongMang()
    {
        Console.Write("Nhập số phần tử của mảng: ");
        int n = int.Parse(Console.ReadLine());

        int[] arr = new int[n];
        for (int i = 0; i < n; i++)
        {
            Console.Write($"Nhập phần tử thứ {i + 1}: ");
            arr[i] = int.Parse(Console.ReadLine());
        }

        Dictionary<int, int> countDict = new Dictionary<int, int>();

        foreach (int num in arr)
        {
            if (countDict.ContainsKey(num))
            {
                countDict[num]++;
            }
            else
            {
                countDict[num] = 1;
            }
        }

        Console.WriteLine("Số lần xuất hiện của các phần tử trong mảng:");
        foreach (var kvp in countDict)
        {
            Console.WriteLine($"{kvp.Key} - {kvp.Value} ");
        }
    }
    // ham chia mang theo dieu kien
    public static void ChiaMangTheoDieuKien()
    {
        Console.Write("Nhập số phần tử của mảng: ");
        int n = int.Parse(Console.ReadLine());

        int[] arr = new int[n];
        for (int i = 0; i < n; i++)
        {
            Console.Write($"Nhập phần tử thứ {i + 1}: ");
            arr[i] = int.Parse(Console.ReadLine());
        }

        List<int> mangDau = new List<int>();
        List<int> mangCuoi = new List<int>();

        for (int i = 0; i < n; i++)
        {
            if (arr[i] % 3 == 2)
            {
                mangDau.Add(arr[i]);
            }
            else
            {
                mangCuoi.Add(arr[i]);
            }
        }

        Console.WriteLine("Mảng gồm các phần tử khi chia cho 3 thì dư 2:");
        foreach (int num in mangDau)
        {
            Console.Write(num + " ");
        }
        Console.WriteLine();

        Console.WriteLine("Mảng gồm các phần tử còn lại:");
        foreach (int num in mangCuoi)
        {
            Console.Write(num + " ");
        }
        Console.WriteLine();
    }
// Tinh định thức ma trận
    public static double TinhDinhThucMaTran()
    {
        Console.WriteLine("Nhập ma trận 3x3:");
        int[,] matrix = new int[3, 3];

        for (int row = 0; row < 3; row++)
        {
            for (int col = 0; col < 3; col++)
            {
                Console.Write($"Nhập phần tử [{row},{col}]: ");
                matrix[row, col] = int.Parse(Console.ReadLine());
            }
        }

        int a = matrix[0, 0];
        int b = matrix[0, 1];
        int c = matrix[0, 2];
        int d = matrix[1, 0];
        int e = matrix[1, 1];
        int f = matrix[1, 2];
        int g = matrix[2, 0];
        int h = matrix[2, 1];
        int i = matrix[2, 2];

        double determinant = a * e * i + b * f * g + c * d * h - c * e * g - b * d * i - a * f * h;

        return determinant;
    }
    // Sap xep noi bot
    public class BubbleSortExample
    {
        public static void SapXepNoiBot(int[] arr)
        {
            int n = arr.Length;
            bool swapped;

            for (int i = 0; i < n - 1; i++)
            {
                swapped = false;

                for (int j = 0; j < n - i - 1; j++)
                {
                    if (arr[j] > arr[j + 1])
                    {
                        // Hoán đổi giá trị của arr[j] và arr[j + 1]
                        int temp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = temp;

                        swapped = true;
                    }
                }

                // Nếu không có phần tử nào được hoán đổi trong vòng lặp nội, mảng đã được sắp xếp
                if (!swapped)
                {
                    break;
                }
            }
        }

        public static void NhapMangTuBanPhim(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write($"Nhập phần tử thứ {i + 1}: ");
                arr[i] = int.Parse(Console.ReadLine());
            }
        }

        public static void InMang(int[] arr)
        {
            foreach (int element in arr)
            {
                Console.Write(element + " ");
            }
            Console.WriteLine();
        }
    }
    //tim vi tri cua mot chuoi
    public static int TimViTriChuoiCon(string chuoiGoc, string chuoiCon)
    {
        int viTri = chuoiGoc.IndexOf(chuoiCon);

        return viTri;
    }
    //Dem so lan xuat hien
    public static int DemSoLanXuatHien(string chuoiGoc, string chuoiCon)
    {
        int soLan = 0;
        int index = chuoiGoc.IndexOf(chuoiCon);

        while (index != -1)
        {
            soLan++;
            index = chuoiGoc.IndexOf(chuoiCon, index + 1);
        }

        return soLan;
    }
    // Fibb
    public static long TinhFibonacci(int n)
    {
        if (n <= 0)
        {
            return 0;
        }
        else if (n == 1)
        {
            return 1;
        }
        else
        {
            return TinhFibonacci(n - 1) + TinhFibonacci(n - 2);
        }
    }
    //tinh giai thua
    public static long TinhGiaiThua(int n)
    {
        if (n == 0)
        {
            return 1;
        }
        return n * TinhGiaiThua(n - 1);
    }
    //Quản lý sách
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



    static void Main(string[] args)
    {
        while (true)
        {
            Console.WriteLine("Menu:");
            Console.WriteLine("1. Đếm số lần xuất hiện của các phần tử trong mảng một chiều");
            Console.WriteLine("2. Chia mảng thành hai mảng con theo điều kiện");
            Console.WriteLine("3. Cộng, trừ, nhân, chia hai ma trận");
            Console.WriteLine("4. Tính định thức ma trận");
            Console.WriteLine("5. Sắp xếp nổi bọt (Bubble Sort)");
            Console.WriteLine("6. Tìm vị trí của chuỗi con trong chuỗi");
            Console.WriteLine("7. Đếm số lần xuất hiện của chuỗi con trong chuỗi");
            Console.WriteLine("8. Tính số Fibonacci thứ n");
            Console.WriteLine("9. Tính giai thừa của một số");
            Console.WriteLine("10. Quản lý sách cho thư viện");
            Console.WriteLine("11. Quản lý học sinh");
            Console.WriteLine("0. Thoát");

            Console.Write("Chọn chức năng (0-11): ");
            int choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    DemSoLanXuatHienTrongMang();
                    break;
                case 2:
                    ChiaMangTheoDieuKien();
                    break;
                case 3:
                    CongHaiMaTran(matrixA, matrixB);
                    TruHaiMaTran(matrixA, matrixB);
                    NhanHaiMaTran(matrixA, matrixB);
                    break;
                case 4:
                    TinhDinhThucMaTran();
                    break;
                case 5:
                    Console.Write("Nhập số lượng phần tử trong mảng: ");
                    int n = int.Parse(Console.ReadLine());

                    int[] arr = new int[n];

                    BubbleSortExample.NhapMangTuBanPhim(arr);

                    Console.WriteLine("Mảng ban đầu:");
                    BubbleSortExample.InMang(arr);

                    BubbleSortExample.SapXepNoiBot(arr);

                    Console.WriteLine("Mảng sau khi sắp xếp:");
                    BubbleSortExample.InMang(arr);
                    break;
                case 6:
                    Console.Write("Nhập chuỗi: ");
                    string chuoiGoc = Console.ReadLine();

                    Console.Write("Nhập chuỗi con cần tìm: ");
                    string chuoiCon = Console.ReadLine();

                    int viTri = TimViTriChuoiCon(chuoiGoc, chuoiCon);

                    if (viTri != -1)
                    {
                        Console.WriteLine($"Chuỗi con \"{chuoiCon}\" được tìm thấy tại vị trí {viTri} trong chuỗi gốc.");
                    }
                    else
                    {
                        Console.WriteLine($"Chuỗi con \"{chuoiCon}\" không được tìm thấy trong chuỗi gốc.");
                    }
            
                    break;
                case 7:
                    Console.Write("Nhập chuỗi: ");
                    string chuoiGoc = Console.ReadLine();

                    Console.Write("Nhập chuỗi con cần đếm: ");
                    string chuoiCon = Console.ReadLine();

                    int soLanXuatHien = DemSoLanXuatHien(chuoiGoc, chuoiCon);

                    Console.WriteLine($"Chuỗi con \"{chuoiCon}\" xuất hiện {soLanXuatHien} lần trong chuỗi gốc.");
                    break;
                case 8:
                    Console.Write("Nhập n: ");
                    int n = int.Parse(Console.ReadLine());

                    long ketQua = TinhFibonacci(n);

                    Console.WriteLine($"Phần tử thứ {n} trong dãy Fibonacci là: {ketQua}");
                    break;
                case 9:
                    static void Main()
                    {
                        Console.Write("Nhập một số nguyên dương n: ");
                        int n = int.Parse(Console.ReadLine());

                        long giaiThua = TinhGiaiThua(n);

                        Console.WriteLine($"{n}! = {giaiThua}");
                    }
                    break;
                case 10:
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
                    break;
                case 11:
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
                    break;
                case 0:
                    Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("Lựa chọn không hợp lệ. Vui lòng chọn lại.");
                    break;
            }
        }
    }



    public static int[,] CongHaiMaTran(int[,] matrixA, int[,] matrixB)
    {
        int rows = matrixA.GetLength(0);
        int cols = matrixA.GetLength(1);

        int[,] resultMatrix = new int[rows, cols];

        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                resultMatrix[i, j] = matrixA[i, j] + matrixB[i, j];
            }
        }

        return resultMatrix;
    }

    public static int[,] TruHaiMaTran(int[,] matrixA, int[,] matrixB)
    {
        int rows = matrixA.GetLength(0);
        int cols = matrixA.GetLength(1);

        int[,] resultMatrix = new int[rows, cols];

        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                resultMatrix[i, j] = matrixA[i, j] - matrixB[i, j];
            }
        }

        return resultMatrix;
    }

    public static int[,] NhanHaiMaTran(int[,] matrixA, int[,] matrixB)
    {
        int rowsA = matrixA.GetLength(0);
        int colsA = matrixA.GetLength(1);
        int colsB = matrixB.GetLength(1);

        int[,] resultMatrix = new int[rowsA, colsB];

        for (int i = 0; i < rowsA; i++)
        {
            for (int j = 0; j < colsB; j++)
            {
                int sum = 0;
                for (int k = 0; k < colsA; k++)
                {
                    sum += matrixA[i, k] * matrixB[k, j];
                }
                resultMatrix[i, j] = sum;
            }
        }

        return resultMatrix;
    }
}
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