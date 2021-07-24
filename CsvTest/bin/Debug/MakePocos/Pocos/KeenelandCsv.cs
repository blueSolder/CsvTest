using CsvHelper.Configuration;

namespace CsvTest
{
	public class KeenelandCsv
	{
		public string Sale { get; set; }
		public string Hip { get; set; }
		public string Sire { get; set; }
		public string Dam { get; set; }
		public string BroodmareSire { get; set; }
		public string Dob { get; set; }
		public string AreaFoaled { get; set; }
		public string HorseName { get; set; }
		public string Color { get; set; }
		public string Sex { get; set; }
		public string BreedersCupEligible { get; set; }
		public string CoveringSire { get; set; }
		public string SoldAs { get; set; }
		public string Consignor { get; set; }
		public string Barn(S) { get; set; }
		public string Session { get; set; }
		public string Book { get; set; }
		public string Out { get; set; }
		public string Location { get; set; }
	}

	public sealed class KeenelandCsvMap : ClassMap<KeenelandCsv>
{
		public KeenelandCsvMap()
		{
			Map(m => m.Sale).Name("Sale");
			Map(m => m.Hip).Name("Hip");
			Map(m => m.Sire).Name("Sire");
			Map(m => m.Dam).Name("Dam");
			Map(m => m.BroodmareSire).Name("Broodmare Sire");
			Map(m => m.Dob).Name("DOB");
			Map(m => m.AreaFoaled).Name("Area Foaled");
			Map(m => m.HorseName).Name("Horse Name");
			Map(m => m.Color).Name("Color");
			Map(m => m.Sex).Name("Sex");
			Map(m => m.BreedersCupEligible).Name("Breeders Cup Eligible");
			Map(m => m.CoveringSire).Name("Covering Sire");
			Map(m => m.SoldAs).Name("Sold As");
			Map(m => m.Consignor).Name("Consignor");
			Map(m => m.Barn(S)).Name("Barn(s)");
			Map(m => m.Session).Name("Session");
			Map(m => m.Book).Name("Book");
			Map(m => m.Out).Name("Out");
			Map(m => m.Location).Name("Location");

		}
	}
}