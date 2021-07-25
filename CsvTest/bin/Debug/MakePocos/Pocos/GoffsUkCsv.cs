using CsvHelper.Configuration;

namespace TW_CsvGrabber
{
	public class GoffsUkCsv
	{
		public string Lot { get; set; }
		public string Name { get; set; }
		public string Year { get; set; }
		public string Sex { get; set; }
		public string Colour { get; set; }
		public string Sire { get; set; }
		public string Dam { get; set; }
		public string Consignor { get; set; }
		public string Purchaser { get; set; }
		public string Price { get; set; }
	}

	public sealed class GoffsUkCsvMap : ClassMap<GoffsUkCsv>
{
		public GoffsUkCsvMap()
		{
			Map(m => m.Lot).Name("Lot");
			Map(m => m.Name).Name("Name");
			Map(m => m.Year).Name("Year");
			Map(m => m.Sex).Name("Sex");
			Map(m => m.Colour).Name("Colour");
			Map(m => m.Sire).Name("Sire");
			Map(m => m.Dam).Name("Dam");
			Map(m => m.Consignor).Name("Consignor");
			Map(m => m.Purchaser).Name("Purchaser");
			Map(m => m.Price).Name("Price");

		}
	}
}