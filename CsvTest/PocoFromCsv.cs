using System;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using CsvHelper;

namespace CsvTest
{
    public class PocoFromCsv
    {
        public static string DoIt(string path, string[] csvMem = null)
        {
            var csv = new string[0];
            var name = Path.GetFileNameWithoutExtension(path).Replace(" ", "");
            if (path != null) csv = csvMem ?? File.ReadAllLines(path);

            var headers = csv[0];
            //var headerRowIndex = FindHeader(csv);


            var colHeaders = headers.Split(',');
            colHeaders = CleanColHeaders(colHeaders);
            var map = CreateMap(colHeaders, name);
            var poco = CreatePoco(colHeaders, name);

            poco = "using CsvHelper.Configuration;\n\n" +
                   "namespace TW_CsvGrabber\n{" +
                   poco + "\n";

            poco += map;
            poco += "\n}";

            return poco;
        }

        private static string CreatePoco(string[] colHeaders, string name)
        {
            var poco = "\n\tpublic class " + name + "Csv\n\t{";
            poco = colHeaders.Aggregate(poco, (current, colHeader) => current + "\n\t\tpublic string " + UppercaseFirst(colHeader).Replace(" ", "") + " { get; set; }");

            poco += "\n\t}";

            return poco;
        }

        private static string CreateMap(string[] colHeaders, string name)
        {
            var poco = "\n\tpublic sealed class " + name + "CsvMap : ClassMap<" + name+ "Csv>\n{\n\t\tpublic " + name + "CsvMap()\n\t\t{\n";

            poco = colHeaders.Aggregate(poco, (current, colHeader) => current + "\t\t\t" + "Map(m => m." + UppercaseFirst(colHeader).Replace(" ", "") + ").Name(\"" + colHeader + "\");\n");

            poco += "\n\t\t}\n\t}";

            return poco;
        }

        private static string[] CleanColHeaders(string[] colHeaders)
        {
            for (var i = 0; i < colHeaders.Length; i++)
            {
                colHeaders[i] = colHeaders[i].Replace("\"", "")
                    .Replace("/", "")
                    .Replace("(", "")
                    .Replace(")", "")
                    .Replace("#", "")
                    .Replace("€", "")
                    .Trim();
            }
            //€
            return colHeaders;
        }

        static string UppercaseFirst(string s)
        {
            return string.IsNullOrEmpty(s) ? string.Empty : CultureInfo.CurrentCulture.TextInfo.ToTitleCase(s.ToLower());
        }

    //    public static int FindHeader(string[] rows)
    //    {
    //        ToCsvObject(rows);
    //        var columnCounts = new List<int> { 0, 0, 0, 0, 0, 0, 0, 0, 0 };
            
    //        for (var i = 0; i < columnCounts.Count; i++)
    //        {
    //            //foreach (var row in rows)
    //            //{
    //                var columns = rows[i].Split(',');

    //                for (var j=0; j<columns.Length; j++)
    //                {
    //                    if (!string.IsNullOrEmpty(columns[j])) columnCounts[i]++;
    //                }
    //            //}
    //        }

    //        var headerColumn = 0;
    //        var maxColCount = 0;

    //        //find 1st largest value

    //        for (var i = 0; i < columnCounts.Count; i++)
    //        {
    //            if (columnCounts[i] > maxColCount)
    //            {
    //                headerColumn = i;
    //                maxColCount = columnCounts[i];
    //            }
    //        }

    //        return headerColumn;
    //    }

    //    private static void ToCsvObject(string pathv)
    //    {
    //        // Create a StreamReader to access the file.
    //        var byt = csv.Select(byte.Parse).ToArray();
    //        //var byteArray = Encoding.ASCII.GetBytes(byt);

    //        var  stream = new MemoryStream(byt);
    //        using (var mem = new MemoryStream(byt))
    //        {
    //            using (var reader = new StreamReader("path\\to\\file.csv"))
    //            using (var csvObj = new CsvReader(reader, CultureInfo.InvariantCulture))
    //            {
    //                var records = csvObj.GetRecords<MagicMillionsCsv>();
    //            }
    //        }
    //    }
    //}


}
