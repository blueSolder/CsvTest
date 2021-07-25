using CsvHelper.Configuration;

namespace TW_CsvGrabber
{
	public class FasigTiptonCsv
	{
		public string SaleTitle { get; set; }
		public string Session { get; set; }
		public string Hip { get; set; }
		public string Color { get; set; }
		public string Sex { get; set; }
		public string Sire { get; set; }
		public string Dam { get; set; }
		public string SireOfDam { get; set; }
		public string PropertyLine { get; set; }
		public string Purchaser { get; set; }
		public string Price { get; set; }
		public string PrivateSale { get; set; }
		public string YearOfBirth { get; set; }
		public string Foaled { get; set; }
		public string Barn { get; set; }
		public string CoverDate { get; set; }
		public string SoldAsDescription { get; set; }
		public string VirtualInspection { get; set; }
	}

	public sealed class FasigTiptonCsvMap : ClassMap<FasigTiptonCsv>
{
		public FasigTiptonCsvMap()
		{
			Map(m => m.SaleTitle).Name("SALE TITLE");
			Map(m => m.Session).Name("SESSION");
			Map(m => m.Hip).Name("HIP");
			Map(m => m.Color).Name("COLOR");
			Map(m => m.Sex).Name("SEX");
			Map(m => m.Sire).Name("SIRE");
			Map(m => m.Dam).Name("DAM");
			Map(m => m.SireOfDam).Name("SIRE OF DAM");
			Map(m => m.PropertyLine).Name("PROPERTY LINE");
			Map(m => m.Purchaser).Name("PURCHASER");
			Map(m => m.Price).Name("PRICE");
			Map(m => m.PrivateSale).Name("PRIVATE SALE");
			Map(m => m.YearOfBirth).Name("YEAR OF BIRTH");
			Map(m => m.Foaled).Name("FOALED");
			Map(m => m.Barn).Name("BARN");
			Map(m => m.CoverDate).Name("COVER DATE");
			Map(m => m.SoldAsDescription).Name("SOLD AS DESCRIPTION");
			Map(m => m.VirtualInspection).Name("VIRTUAL INSPECTION");

		}
	}
}