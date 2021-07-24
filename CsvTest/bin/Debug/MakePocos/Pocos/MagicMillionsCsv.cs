using CsvHelper.Configuration;

namespace CsvTest
{
	public class MagicMillionsCsv
	{
		public string LotNumber { get; set; }
		public string Book { get; set; }
		public string Vendor { get; set; }
		public string LotName { get; set; }
		public string Colour { get; set; }
		public string Sex { get; set; }
		public string InFoal { get; set; }
		public string Dob { get; set; }
		public string Sire { get; set; }
		public string Dam { get; set; }
		public string ServingSire { get; set; }
		public string Bonus_Scheme { get; set; }
		public string SaleDate { get; set; }
		public string Buyer { get; set; }
		public string Location { get; set; }
		public string Price { get; set; }
		public string Type { get; set; }
		public string BreezeUpDate { get; set; }
		public string BreezeUpTime { get; set; }
		public string BreezeUpLocation { get; set; }
		public string Stable { get; set; }
		public string Box { get; set; }
		public string Row { get; set; }
		public string DamSire { get; set; }
	}

	public sealed class MagicMillionsCsvMap : ClassMap<MagicMillionsCsv>
{
		public MagicMillionsCsvMap()
		{
			Map(m => m.LotNumber).Name("lot number");
			Map(m => m.Book).Name("book");
			Map(m => m.Vendor).Name("vendor");
			Map(m => m.LotName).Name("lot name");
			Map(m => m.Colour).Name("colour");
			Map(m => m.Sex).Name("sex");
			Map(m => m.InFoal).Name("in foal");
			Map(m => m.Dob).Name("dob");
			Map(m => m.Sire).Name("sire");
			Map(m => m.Dam).Name("dam");
			Map(m => m.ServingSire).Name("serving sire");
			Map(m => m.Bonus_Scheme).Name("bonus_scheme");
			Map(m => m.SaleDate).Name("sale date");
			Map(m => m.Buyer).Name("buyer");
			Map(m => m.Location).Name("location");
			Map(m => m.Price).Name("price");
			Map(m => m.Type).Name("type");
			Map(m => m.BreezeUpDate).Name("breeze up date");
			Map(m => m.BreezeUpTime).Name("breeze up time");
			Map(m => m.BreezeUpLocation).Name("breeze up location");
			Map(m => m.Stable).Name("stable");
			Map(m => m.Box).Name("box");
			Map(m => m.Row).Name("row");
			Map(m => m.DamSire).Name("dam sire");

		}
	}
}