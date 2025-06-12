namespace ex3;

public static class ListExtensions
{
    public static List<int> Method1(this List<int> lst)
    {
        return lst.Where(x => x < 0 && x % 2 == 0).ToList();
    }
    
    public static int Method2(this List<int> lst)
    {
        return lst.Where(x => x > 0).DefaultIfEmpty(0).Min();
    }
    
    public static List<string> Method3(this List<int> lst)
    {
        return lst.Where(x => x > 0 && x % 2 != 0)
                  .Select(x => x.ToString())
                  .OrderBy(x => x)
                  .ToList();
    }
    
    public static List<int> Method4(this List<int> lst, int digit)
    {
        return lst.Where(x => x > 0 && x % 10 == digit)
                  .Distinct()
                  .ToList();
    }
    
    public static List<string> Method5(this List<string> lst, int idx)
    {
        return lst.Take(idx)
                  .Where(s => s.Length % 2 != 0 && char.IsUpper(s[0]) && s[0] >= 'A' && s[0] <= 'Z')
                  .Reverse()
                  .ToList();
    }
}

class Program
{
    static void Main()
    {
        List<int> numbers = new List<int> { -4, -3, -2, 1, 5, 7, 10, 15, -6, 6, 21 };
        List<string> words = new List<string> { "Apple", "banana", "Cherry", "Dog", "elephant", "Fox", "Giraffe" };

        Console.WriteLine("Method1 (четные отрицательные числа): " + string.Join(", ", numbers.Method1()));
        Console.WriteLine("Method2 (мин. положительное число): " + numbers.Method2());
        Console.WriteLine("Method3 (строковые представления нечетных чисел): " + string.Join(", ", numbers.Method3()));
        Console.WriteLine("Method4 (уникальные числа оканчивающиеся на 5): " + string.Join(", ", numbers.Method4(5)));
        Console.WriteLine("Method5 (строки перед IDX4 с нечетной длиной и заглавной буквой): " + string.Join(", ", words.Method5(4)));
    }
}