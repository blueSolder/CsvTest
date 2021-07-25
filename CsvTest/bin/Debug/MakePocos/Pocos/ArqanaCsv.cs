using CsvHelper.Configuration;

namespace CsvTest
{
	public class ArqanaCsv
	{
		public string Lot { get; set; }
		public string Sexe { get; set; }
		public string DateDeNaissance { get; set; }
		public string Produit { get; set; }
		public string Nom { get; set; }
		public string Père { get; set; }
		public string Mère { get; set; }
		public string Vendeur { get; set; }
		public string Cour/Box { get; set; }
		public string Suffixe { get; set; }
		public string SuffixePère { get; set; }
		public string SuffixeMère { get; set; }
		public string PèreDeMère { get; set; }
		public string PleineDe { get; set; }
		public string Issue { get; set; }
		public string Acheteur { get; set; }
		public string Enchères { get; set; }
	}

	public sealed class ArqanaCsvMap : ClassMap<ArqanaCsv>
{
		public ArqanaCsvMap()
		{
			Map(m => m.Lot).Name("Lot");
			Map(m => m.Sexe).Name("Sexe");
			Map(m => m.DateDeNaissance).Name("Date de naissance");
			Map(m => m.Produit).Name("Produit");
			Map(m => m.Nom).Name("Nom");
			Map(m => m.Père).Name("Père");
			Map(m => m.Mère).Name("Mère");
			Map(m => m.Vendeur).Name("Vendeur");
			Map(m => m.Cour/Box).Name("Cour / Box");
			Map(m => m.Suffixe).Name("Suffixe");
			Map(m => m.SuffixePère).Name("Suffixe Père");
			Map(m => m.SuffixeMère).Name("Suffixe Mère");
			Map(m => m.PèreDeMère).Name("Père de Mère");
			Map(m => m.PleineDe).Name("Pleine de");
			Map(m => m.Issue).Name("Issue");
			Map(m => m.Acheteur).Name("Acheteur");
			Map(m => m.Enchères).Name("Enchères");

		}
	}
}