using System;
using System.Linq;

public class MathFunctions
{
    // Функція обчислення факторіалу
    public int Factorial(int n)
    {
        if (n < 0)
            throw new ArgumentException("Factorial is defined only for non-negative numbers.");

        int result = 1;
        for (int i = 2; i <= n; i++)
        {
            result *= i;
        }
        return result;
    }

    // Функція перевірки парності числа
    public bool IsEven(int number)
    {
        return number % 2 == 0;
    }

    // Функція перевірки простоти числа
    public bool IsPrime(int number)
    {
        if (number <= 1) return false;
        if (number <= 3) return true;
        if (number % 2 == 0 || number % 3 == 0) return false;

        for (int i = 5; i * i <= number; i += 6)
        {
            if (number % i == 0 || number % (i + 2) == 0)
                return false;
        }
        return true;
    }

    // Функція знаходження максимального числа у масиві
    public int Max(int[] numbers)
    {
        if (numbers == null || numbers.Length == 0)
            throw new ArgumentException("The array of numbers is empty or does not exist.");

        return numbers.Max();
    }

    // Функція знаходження середнього значення у масиві чисел
    public double Average(int[] numbers)
    {
        if (numbers == null || numbers.Length == 0)
            throw new ArgumentException("The array of numbers is empty or does not exist.");

        return numbers.Average();
    }

    // Функція перевірки належності елемента до масиву
    public bool Contains(int[] array, int value)
    {
        if (array == null)
            throw new ArgumentException("An array of numbers does not exist.");

        return array.Contains(value);
    }

    // Функція конкатенації двох рядків
    public string ConcatenateStrings(string str1, string str2)
    {
        return string.Concat(str1, str2);
    }

    // Функція перевірки паліндрома
    public bool IsPalindrome(string str)
    {
        string reversed = new string(str.Reverse().ToArray());
        return str.Equals(reversed, StringComparison.OrdinalIgnoreCase);
    }

    // Функція обчислення суми чисел у масиві
    public int Sum(int[] numbers)
    {
        if (numbers == null || numbers.Length == 0)
            throw new ArgumentException("The array of numbers is empty or does not exist.");

        return numbers.Sum();
    }

    // Функція знаходження медіани масиву чисел
    public double Median(int[] numbers)
    {
        if (numbers == null || numbers.Length == 0)
            throw new ArgumentException("The array of numbers is empty or does not exist\r\n.");

        Array.Sort(numbers);
        int n = numbers.Length;
        if (n % 2 == 0)
            return (numbers[n / 2 - 1] + numbers[n / 2]) / 2.0;
        else
            return numbers[n / 2];
    }
}

class Program
{
    static void Main(string[] args)
    {
        
        MathFunctions math = new MathFunctions();

        Console.WriteLine($"Factorial 5: {math.Factorial(5)}"); 

        Console.WriteLine($"Is 7 an even number? {math.IsEven(7)}"); 

        Console.WriteLine($"Is 11 a prime number? {math.IsPrime(11)}"); 

        int[] numbers = { 3, 6, 8, 2, 5 };
        Console.WriteLine($"Maximum number in an array: {math.Max(numbers)}"); 

        Console.WriteLine($"Array Average: {math.Average(numbers)}");

        int[] array = { 1, 2, 3, 4, 5 };
        Console.WriteLine($"Does the number 3 belong to an array? {math.Contains(array, 3)}"); 

        Console.WriteLine($"Combining the strings 'Hello' and 'World': {math.ConcatenateStrings("Hello", "World")}"); 
        Console.WriteLine($"Is 'radar' a palindrome? {math.IsPalindrome("radar")}"); 

        Console.WriteLine($"The sum of the numbers in the array: {math.Sum(numbers)}"); 

        Console.WriteLine($"The median of the array is: {math.Median(numbers)}"); 
    }
}
