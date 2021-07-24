using System;
using System.Globalization;
using System.IO;
using System.Linq;

namespace CsvTest
{
    public class PocoFromCsv
    {
        public static string DoIt(string path)
        {
            var name = Path.GetFileNameWithoutExtension(path);

            var csv = File.ReadAllLines(path);
            var headers = csv[0];

            var colHeaders = headers.Split(new string[] {"\","}, StringSplitOptions.None);
            colHeaders = CleanColHeaders(colHeaders);
            var map = CreateMap(colHeaders, name);
            var poco = CreatePoco(colHeaders, name);

            poco = "using CsvHelper.Configuration;\n\n" +
                   "namespace CsvTest\n{" +
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
                colHeaders[i] = colHeaders[i].Replace("\"", "").Trim();
            }

            return colHeaders;
        }

        static string UppercaseFirst(string s)
        {
            return string.IsNullOrEmpty(s) ? string.Empty : CultureInfo.CurrentCulture.TextInfo.ToTitleCase(s.ToLower());
        }
    }


}
