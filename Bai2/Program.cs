using System;

class Program
{
    static void Main()
    {
        Console.Write("Nhập số lượng phần tử của mảng: ");
        int n = int.Parse(Console.ReadLine());

        int[] arr = new int[n];
        int[] remainder2Array; // Mảng gồm các phần tử khi chia cho 3 thì dư 2
        int[] otherArray;      // Mảng gồm các phần tử còn lại

        Console.WriteLine("Nhập mảng:");
        for (int i = 0; i < n; i++)
        {
            arr[i] = int.Parse(Console.ReadLine());
        }

        SplitArrayByRemainder(arr, out remainder2Array, out otherArray);

        Console.WriteLine("Mảng các phần tử khi chia cho 3 thì dư 2:");
        PrintArray(remainder2Array);

        Console.WriteLine("Mảng các phần tử còn lại:");
        PrintArray(otherArray);
    }

    static void SplitArrayByRemainder(int[] arr, out int[] remainder2Array, out int[] otherArray)
    {
        int remainder2Count = 0;
        int otherCount = 0;

        // Đếm số lượng phần tử thỏa mãn điều kiện
        for (int i = 0; i < arr.Length; i++)
        {
            if (arr[i] % 3 == 2)
            {
                remainder2Count++;
            }
            else
            {
                otherCount++;
            }
        }

        // Khởi tạo mảng con
        remainder2Array = new int[remainder2Count];
        otherArray = new int[otherCount];

        int remainder2Index = 0;
        int otherIndex = 0;

        // Chia phần tử vào mảng con tương ứng
        for (int i = 0; i < arr.Length; i++)
        {
            if (arr[i] % 3 == 2)
            {
                remainder2Array[remainder2Index] = arr[i];
                remainder2Index++;
            }
            else
            {
                otherArray[otherIndex] = arr[i];
                otherIndex++;
            }
        }
    }

    static void PrintArray(int[] arr)
    {
        for (int i = 0; i < arr.Length; i++)
        {
            Console.Write(arr[i] + " ");
        }
        Console.WriteLine();
    }
}
