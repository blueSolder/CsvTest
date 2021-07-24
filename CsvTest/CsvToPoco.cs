using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using CsvHelper;
using CsvHelper.Configuration;

namespace CsvTest
{
    public class CsvToPoco
    {
        public static IEnumerable<TCsv> Parse<TCsv, TMap>(string path) where TMap : ClassMap
        {
            List<TCsv> records1;

            using (var reader = new StreamReader(path))
            using (var csv = new CsvReader(reader, CultureInfo.InvariantCulture))
            {
                csv.Context.RegisterClassMap<TMap>();
                var records = csv.GetRecords<TCsv>().ToList();
                records1 = records;
            }

            return records1;
        }
    }
}
