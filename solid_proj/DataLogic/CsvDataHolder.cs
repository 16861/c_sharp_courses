using System;
using System.IO;
using System.Collections.Generic;


namespace solid_proj {
    public class CsvDataHolder {
        public DateTime Date;
        public string OperationName;
        public double OperationSum;

        public CsvDataHolder(string date, string operationName, string sum)
        {
            this.Date = DateTime.ParseExact(date.Replace("\"", ""), "M/d/y H:mm",
                                       System.Globalization.CultureInfo.InvariantCulture);;
            this.OperationName = operationName;
            this.OperationSum = double.Parse(sum);
        }

        public override string ToString() {
            return $"{this.Date.ToString("dd.MM.yyyy HH:mm")},{this.OperationName},{this.OperationSum}";
        }
    }

    public class CsvReader {
        private List<CsvDataHolder> _datas = new List<CsvDataHolder>();
        private ILogger _logger;

        internal CsvReader(ILogger logger)
        {
            _logger = logger;
        }

        public void ReadCsvFile(string path) {
            _logger.WriteLine($"Begin to read file: {path}");
            if (!File.Exists(path)) {
                _logger.WriteLine($"Can't find file with path: {path}");
                return;
            }
            using (var reader = new StreamReader(path)) {
                //read csv header
                reader.ReadLine();
                while (!reader.EndOfStream)
                {
                    var line = reader.ReadLine().Split(',');
                    _datas.Add(new CsvDataHolder(line[0], line[1], line[2]));
                }
            }
            _logger.WriteLine("Read file successfully!");
        }

        public void GetDataForPeriod(DateTime begin, DateTime end) {
            foreach(var record in _datas) {
                if (record.Date > begin && record.Date < end)
                    Console.WriteLine(record);
            }
        }

        public void PrintAll() {
            foreach(var record in _datas)
                    Console.WriteLine(record);
        }

        public void AddNewRecord(string date, string operationName, string sum) {
            _datas.Add(new CsvDataHolder(date, operationName, sum));
        }
    }
}