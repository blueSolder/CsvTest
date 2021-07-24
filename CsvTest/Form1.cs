using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Globalization;
using System.Linq;
using CsvHelper;
using System.IO;
using System.Net;
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
            foreach (var csv in Directory.GetFiles(@"D:\temp\MakePocos\Csvs"))
            {
                var poco =PocoFromCsv.DoIt(csv);
                File.WriteAllText(@"D:\temp\MakePocos\Pocos\" + Path.GetFileNameWithoutExtension(csv) + "Csv.cs", poco );
            }

            

            var a = CsvToPoco.Parse<MagicMillionsCsv, MagicMillionsCsvMap>(@"D:\temp\MakePocos\Csvs\MagicMillions.csv");

            
        }
    }
}
