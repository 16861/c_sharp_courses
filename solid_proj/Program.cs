using System;
using System.IO;

namespace solid_proj
{
    class Program
    {
        static readonly string ResourcesPath = "Resources";
        static readonly string CsvFilename = "SalesJan2009.csv";

        static readonly string PathToCsvFile =  Path.Combine(ResourcesPath, CsvFilename);


        static void Main(string[] args)
        {
            ILogger _logger = new ConsoleLogger();

            CsvReader csvReader = new CsvReader(_logger);
            csvReader.ReadCsvFile(PathToCsvFile);

            csvReader.AddNewRecord("2/10/20 21:06", "New custom operation", "1000.00");
            csvReader.GetDataForPeriod(new DateTime(2020, 02, 10) , new DateTime(2020, 02, 15));
            csvReader.PrintAll();
            

            Console.WriteLine("Hello World!");
        }
    }
}
