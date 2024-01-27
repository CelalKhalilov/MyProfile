using System.ComponentModel.DataAnnotations;

namespace MyWebSite.Models.Siniflar
{
	public class İkonlar
	{
		[Key]
		public int İd { get; set; }
		public string İkon { get; set; }
		public string Renk { get; set; }
		public string Link { get; set; }

	}
}