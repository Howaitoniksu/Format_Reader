using System.Globalization;
using CsvHelper;
using System.Text;


namespace ConsoleApp2.CSV
{
    internal class CSVWrite
    {
        public void WriteCSV<T>(List<T> list, string path)
        {
            try
            {
                using CsvWriter csv = new CsvWriter(new StreamWriter($"{path}.csv"), CultureInfo.InvariantCulture, false/*, Encoding.UTF8*/);
                csv.WriteRecords(list);
                ;
            }
            catch (Exception exp)
            {
                Console.WriteLine($"{exp.Message}");
            }
        }
    }
}
