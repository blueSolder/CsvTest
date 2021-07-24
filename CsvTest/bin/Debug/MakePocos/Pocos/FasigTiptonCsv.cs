using CsvHelper.Configuration;

namespace CsvTest
{
	public class FasigTiptonCsv
	{
		public string SaleTitle,Session,Hip,Color,Sex,Sire,Dam,SireOfDam,PropertyLine,Purchaser,Price,PrivateSale,YearOfBirth,Foaled,Barn,CoverDate,SoldAsDescription,VirtualInspection { get; set; }
	}

	public sealed class FasigTiptonCsvMap : ClassMap<FasigTiptonCsv>
{
		public FasigTiptonCsvMap()
		{
			Map(m => m.SaleTitle,Session,Hip,Color,Sex,Sire,Dam,SireOfDam,PropertyLine,Purchaser,Price,PrivateSale,YearOfBirth,Foaled,Barn,CoverDate,SoldAsDescription,VirtualInspection).Name("SALE TITLE,SESSION,HIP,COLOR,SEX,SIRE,DAM,SIRE OF DAM,PROPERTY LINE,PURCHASER,PRICE,PRIVATE SALE,YEAR OF BIRTH,FOALED,BARN,COVER DATE,SOLD AS DESCRIPTION,VIRTUAL INSPECTION");

		}
	}
}