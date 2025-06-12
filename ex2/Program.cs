namespace ex2;

using System.Collections.Generic;

public static class ListExtensions
{
    public static List<T> BubbleSort<T>(this List<T> list) where T : IComparable<T>
    {
        List<T> sortedList = new List<T>(list);
        int count = sortedList.Count;

        for (int i = 0; i < count - 1; i++)
        {
            for (int j = 0; j < count - i - 1; j++)
            {
                if (sortedList[j].CompareTo(sortedList[j + 1]) > 0)
                {
                    T temp = sortedList[j];
                    sortedList[j] = sortedList[j + 1];
                    sortedList[j + 1] = temp;
                }
            }
        }
        return sortedList;
    }
}

class Program
{
    static void Main()
    {
        List<int> numbers = new List<int> { 5, 3, 8, 1, 2, 9, 4, 6, 7, 3, 9 };
        
        Console.WriteLine("Исходный список: " + string.Join(", ", numbers));
        
        List<int> sortedNumbers = numbers.BubbleSort();
        
        Console.WriteLine("Отсортированный список: " + string.Join(", ", sortedNumbers));
    }
}