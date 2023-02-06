using System;
using System.Collections;

namespace Homework17_3
{

    class Translator
    {
        public static IEnumerable Words()
        {
            yield return new { Key = "сонце", Value = "sun" };
            yield return new { Key = "вітер", Value = "wind" };
            yield return new { Key = "хмара", Value = "cloud" };
            yield return new { Key = "дощ", Value = "rain" };
            yield return new { Key = "сніг", Value = "snow" };
            yield return new { Key = "блискавка", Value = "lightning" };
            yield return new { Key = "спека", Value = "Heat" };
            yield return new { Key = "холод", Value = "Cold" };
            yield return new { Key = "температура", Value = "temperature" };
            yield return new { Key = "туман", Value = "fog" };
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.Unicode;

            
            foreach (dynamic item in Translator.Words())
            {
                Console.WriteLine($"UA = {item.Key}; EN = {item.Value}");
            }
            

            Console.ReadKey();
        }
    }
}
