using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Globalization;
using System.Linq;
using CsvHelper;
using System.IO;
using System.Reflection;
using System.Windows.Forms;

namespace CsvTest
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            var path = GetFilesPath();
            var poco = "";

            foreach (var csv in Directory.GetFiles(path + "Csvs"))
            {
                var x = Path.GetExtension(csv);
                if (Path.GetExtension(csv) == ".csv")
                {
                    poco = PocoFromCsv.DoIt(csv);
                }

                if (Path.GetExtension(csv) == ".xls" || Path.GetExtension(csv) == ".xlsx")
                {
                    var csvArr = ExcelToPoco.Doit(csv);
                    poco = PocoFromCsv.DoIt(csv, csvArr);
                }

                var savePath = path + @"\Pocos\" + Path.GetFileNameWithoutExtension(csv) + "Csv.cs";
                File.WriteAllText(path + @"\Pocos\" + Path.GetFileNameWithoutExtension(csv) + "Csv.cs", poco);
            }

            

            var a = CsvToPoco.Parse<MagicMillionsCsv, MagicMillionsCsvMap>(@"D:\temp\MakePocos\Csvs\MagicMillions.csv");

            
        }

        private string GetFilesPath()
        {
            var strExeFilePath = System.Reflection.Assembly.GetExecutingAssembly().Location;
            var strWorkPath = System.IO.Path.GetDirectoryName(strExeFilePath);

            return Path.Combine(strWorkPath, @"MakePocos\");
        }
    }
}
