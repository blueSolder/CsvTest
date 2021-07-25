using CsvHelper.Configuration;

namespace CsvTest
{
	public class Cape Thoroughbred SalesCsv
	{
		public string Lot { get; set; }
		public string Name { get; set; }
		public string Sex { get; set; }
		public string Sire { get; set; }
		public string Dam { get; set; }
		public string Vendor { get; set; }
		public string Buyer { get; set; }
		public string Amount { get; set; }
	}

	public sealed class Cape Thoroughbred SalesCsvMap : ClassMap<Cape Thoroughbred SalesCsv>
{
		public Cape Thoroughbred SalesCsvMap()
		{
			Map(m => m.Lot).Name("Lot");
			Map(m => m.Name).Name("Name");
			Map(m => m.Sex).Name("Sex");
			Map(m => m.Sire).Name("Sire");
			Map(m => m.Dam).Name("Dam");
			Map(m => m.Vendor).Name("Vendor");
			Map(m => m.Buyer).Name("Buyer");
			Map(m => m.Amount).Name("Amount");

		}
	}
}