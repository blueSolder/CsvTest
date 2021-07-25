using CsvHelper.Configuration;

namespace CsvTest
{
	public class TattersallsIreCsv
	{
		public string Year { get; set; }
		public string Sale { get; set; }
		public string Day { get; set; }
		public string Lot { get; set; }
		public string Name { get; set; }
		public string Sex { get; set; }
		public string Colour { get; set; }
		public string Sire { get; set; }
		public string Dam { get; set; }
		public string YearFoaled { get; set; }
		public string Grandsire { get; set; }
		public string Damsire { get; set; }
		public string CoveredBy { get; set; }
		public string Consignor { get; set; }
		public string Purchaser { get; set; }
		public string Price(€) { get; set; }
		public string Stabling { get; set; }
	}

	public sealed class TattersallsIreCsvMap : ClassMap<TattersallsIreCsv>
{
		public TattersallsIreCsvMap()
		{
			Map(m => m.Year).Name("Year");
			Map(m => m.Sale).Name("Sale");
			Map(m => m.Day).Name("Day");
			Map(m => m.Lot).Name("Lot");
			Map(m => m.Name).Name("Name");
			Map(m => m.Sex).Name("Sex");
			Map(m => m.Colour).Name("Colour");
			Map(m => m.Sire).Name("Sire");
			Map(m => m.Dam).Name("Dam");
			Map(m => m.YearFoaled).Name("Year Foaled");
			Map(m => m.Grandsire).Name("Grandsire");
			Map(m => m.Damsire).Name("Damsire");
			Map(m => m.CoveredBy).Name("Covered by");
			Map(m => m.Consignor).Name("Consignor");
			Map(m => m.Purchaser).Name("Purchaser");
			Map(m => m.Price(€)).Name("Price (€)");
			Map(m => m.Stabling).Name("Stabling");

		}
	}
}