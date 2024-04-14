using CsvHelper;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2.CSV
{
    internal class CSVRead
    {
        public List<T> ReadCsv<T>(string path)
        {
            using (CsvReader csv = new CsvReader(new StreamReader($"{path}.csv"), CultureInfo.InvariantCulture))
            {
                List<T> Result = new List<T>();
                
                    while (csv.Read())
                    {
                        Result.Add(csv.GetRecord<T>());
                    }
                return Result;
            };
        }
    }
}
