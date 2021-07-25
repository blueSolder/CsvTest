using CsvHelper.Configuration;

namespace TW_CsvGrabber
{
	public class ObsCsv
	{
		public string Hip { get; set; }
		public string Name { get; set; }
		public string Color { get; set; }
		public string Sex { get; set; }
		public string FoalDate { get; set; }
		public string Sire { get; set; }
		public string Dam { get; set; }
		public string DamSire { get; set; }
		public string SortByDam { get; set; }
		public string Consignor { get; set; }
		public string AreaId { get; set; }
		public string Barn { get; set; }
		public string WorkTime { get; set; }
		public string Set { get; set; }
		public string Day { get; set; }
		public string Buyer { get; set; }
		public string Price { get; set; }
		public string Ps { get; set; }
		public string Status { get; set; }
		public string OutDate { get; set; }
		public string Alphsort { get; set; }
	}

	public sealed class ObsCsvMap : ClassMap<ObsCsv>
{
		public ObsCsvMap()
		{
			Map(m => m.Hip).Name("hip");
			Map(m => m.Name).Name("Name");
			Map(m => m.Color).Name("Color");
			Map(m => m.Sex).Name("Sex");
			Map(m => m.FoalDate).Name("Foal Date");
			Map(m => m.Sire).Name("Sire");
			Map(m => m.Dam).Name("Dam");
			Map(m => m.DamSire).Name("Dam Sire");
			Map(m => m.SortByDam).Name("Sort By Dam");
			Map(m => m.Consignor).Name("Consignor");
			Map(m => m.AreaId).Name("Area ID");
			Map(m => m.Barn).Name("Barn");
			Map(m => m.WorkTime).Name("work time");
			Map(m => m.Set).Name("set");
			Map(m => m.Day).Name("day");
			Map(m => m.Buyer).Name("Buyer");
			Map(m => m.Price).Name("Price");
			Map(m => m.Ps).Name("PS");
			Map(m => m.Status).Name("Status");
			Map(m => m.OutDate).Name("Out Date");
			Map(m => m.Alphsort).Name("AlphSort");

		}
	}
}