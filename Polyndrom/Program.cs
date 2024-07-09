using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Polyndrom
{
    public static bool IsInputPolyndrom(string input)
    {
        bool result = true;
        input = input.ToLower();
        input = input.Replace(".", "");
        input = input.Replace("?", "");
        input = input.Replace(" ", "");
        input = input.Replace("-", "");
        input = input.Replace("!", "");
        input = input.Replace(",", "");
        char[] ArrayOfInput = input.ToCharArray();
        for (int i = 0; i < input.Length; i++) 
        {
            ArrayOfInput[i] = input[i];
        }
        for (int i = 0; i < input.Length/2; i++)
        {
            if (ArrayOfInput[i] != input[input.Length - i - 1])
            {
                result = false;
            }
        }
        return result;
    }
}
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Введите текст:");
        string text = Console.ReadLine();
        Polyndrom.IsInputPolyndrom(text);
        if (Polyndrom.IsInputPolyndrom(text) == true)
        {
            Console.WriteLine("Это полиндром");
        }
        else
        {
            Console.WriteLine("Это не полиндром");
        }
    }
}