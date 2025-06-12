namespace ConsoleApp19;

public static class StringExtensions
{
    public static string ToUpperCase(this string str)
    {
        return str?.Trim().ToUpper() ?? string.Empty;
    }
    
    public static string ToLowerCase(this string str)
    {
        return str?.Trim().ToLower() ?? string.Empty;
    }
    
    public static string TrimCustom(this string str)
    {
        return str?.Trim() ?? string.Empty;
    }
    
    public static bool IsNullOrEmptyWhiteSpace(this string str)
    {
        return string.IsNullOrWhiteSpace(str);
    }
}

class Program
{
    static void Main()
    {
        Console.Write("Введите предложение: ");
        string input = Console.ReadLine();

        if (input.IsNullOrEmptyWhiteSpace())
        {
            Console.WriteLine("Ошибка: введено пустое или состоящее из пробелов предложение.");
            return;
        }

        Console.WriteLine("""
                              Выберите действие:
                              1. Привести в верхний регистр
                              2. Привести в нижний регистр
                          """);

        string choice = Console.ReadLine();
        string result = choice == "1" ? input.ToUpperCase() : choice == "2" ? input.ToLowerCase() : "Неверный выбор";

        Console.WriteLine($"Результат: {result}");
    }
}