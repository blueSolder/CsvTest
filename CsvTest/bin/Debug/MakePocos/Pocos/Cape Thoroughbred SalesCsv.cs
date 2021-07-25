using CsvHelper.Configuration;

namespace TW_CsvGrabber
{
	public class CapeThoroughbredSalesCsv
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

	public sealed class CapeThoroughbredSalesCsvMap : ClassMap<CapeThoroughbredSalesCsv>
{
		public CapeThoroughbredSalesCsvMap()
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