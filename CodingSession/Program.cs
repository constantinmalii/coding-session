using System;
using ClassLibrarySample;
using CodingSession.Services;


namespace CodingSession
{
    class Program1
    {
        private string name = "John";

        static void Main(string[] args)
        {
            var customer = new Customer();

            var file = new File("testFileName");
            var fileService = new FileReader(file);
            var result  = fileService.Read();

            PrintToConsole(result);

            Console.ReadKey();
        }

        private static void PrintToConsole(string fileName)
        {
            var printContent = $"Hello, {fileName}!";

            Console.WriteLine(printContent);
        }

    }
}
