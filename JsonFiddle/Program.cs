
namespace JsonFiddle
{
    using System.Text.Json;
    using System;
    using System.IO;
    using System.Net.Mime;

    class Program
    {
        static void Main(string[] args)
        {

            string jsonString = File.ReadAllText(@".\loxapp3.json");
            Structure structure = JsonSerializer.Deserialize<Structure>(jsonString);

            Console.WriteLine("Press any key");
            Console.ReadKey();
        }
    }
}
