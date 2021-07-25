using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.IO;
using ExcelDataReader;

namespace CsvTest
{
    public class ExcelToPoco
    {
        private static DataSet ReadExcelUrl(string url)
        {
            using (var webClient = new System.Net.WebClient())
            {
                var a = webClient.DownloadData(url);

                using (var stream = new MemoryStream(a))
                {
                    try
                    {
                        using (var reader = ExcelReaderFactory.CreateReader(stream))
                        {
                            return reader.AsDataSet();
                        }
                    }
                    catch { }

                    using (var reader = ExcelReaderFactory.CreateCsvReader(stream))
                    {
                        return reader.AsDataSet();
                    }
                }
            }
        }

        public static string Doit(string filePath)
        {
            var reader = Read(filePath);
            var headerRowIndex = FindHeader(reader);
            var csv = ToCsv(reader, headerRowIndex);


            return "";
        }

        private static string ToCsv(DataSet reader, int index)
        {
            var csv = "";

            for (var i = index; i < reader.Tables[0].Rows.Count; i++)
            {
                foreach (var col in reader.Tables[0].Rows[i].ItemArray)
                {
                    csv = csv + "\"" + col.ToString() + "\", ";
                }

                csv = csv.Substring(0, csv.Length - 2);
                csv = csv + "\n";
                
            }

            return csv;
        }

        private static int FindHeader(DataSet reader)
        {
            var columnCounts = new List<int> {0, 0};

            var headers = reader.Tables[0].Rows[0].ItemArray;
            var rows = reader.Tables[0].Rows;

            for (var i=0; i<2; i++)
            {
                foreach (var column in reader.Tables[0].Rows[i].ItemArray)
                {
                    if (!string.IsNullOrEmpty(column.ToString())) columnCounts[i]++;
                }
            }

            return columnCounts[0] > columnCounts[1] ? 0 : 1;
        }

        public static DataSet Read(string filePath)
        {
            //DataSet result2;

            using (var stream = File.Open(filePath, FileMode.Open, FileAccess.Read))
            {
                using (var reader = ExcelReaderFactory.CreateReader(stream))
                {
                    do
                    {
                        while (reader.Read())
                        {
                            // reader.GetDouble(0);
                        }
                    } while (reader.NextResult());

                    // 2. Use the AsDataSet extension method
                     return reader.AsDataSet();
                     

                     //var headers = result2.Tables[0].Rows[1].ItemArray;
                     //var rows = result2.Tables[0].Rows;
                    // The result of each spreadsheet is in result.Tables
                }

                //var headers = result2.Tables[0].Rows[1].ItemArray;
                //var rows = result2.Tables[0].Rows;
            }
        }
    }
}
