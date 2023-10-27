using System;
using System.Collections.Generic;

class LAB2
{
    static void Main()
    {
        Console.Write("Nhập số lượng phần tử của mảng: ");
        int n = int.Parse(Console.ReadLine());

        int[] arr = new int[n];

        Console.WriteLine("Nhập mảng:");
        for (int i = 0; i < n; i++)
        {
            arr[i] = int.Parse(Console.ReadLine());
        }

        Dictionary<int, int> elementCount = CountElementOccurrences(arr);

        Console.WriteLine("Các phần tử có số lần xuất hiện lớn hơn 1:");
        foreach (var kvp in elementCount)
        {
            if (kvp.Value > 1)
            {
                Console.WriteLine($"{kvp.Key} - {kvp.Value}");
            }
        }
    }

    static Dictionary<int, int> CountElementOccurrences(int[] arr)
    {
        Dictionary<int, int> elementCount = new Dictionary<int, int>();
        foreach (int element in arr)
        {
            if (elementCount.ContainsKey(element))
            {
                elementCount[element]++;
            }
            else
            {
                elementCount[element] = 1;
            }
        }
        return elementCount;
    }
}
