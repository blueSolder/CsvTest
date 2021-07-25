using CsvHelper.Configuration;

namespace TW_CsvGrabber
{
	public class InglissCsv
	{
		public string 2021GreatSouthernBroodmareSale { get; set; }
	}

	public sealed class InglissCsvMap : ClassMap<InglissCsv>
{
		public InglissCsvMap()
		{
			Map(m => m.2021GreatSouthernBroodmareSale).Name("2021 Great Southern Broodmare Sale");

		}
	}
}