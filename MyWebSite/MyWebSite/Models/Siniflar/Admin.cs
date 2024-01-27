using System.ComponentModel.DataAnnotations;

namespace MyWebSite.Models.Siniflar
{
	public class Admin
	{
		[Key]
		public int İd { get; set; }
		public string KullaniciAdi { get; set; }
		public string Sifre { get; set; }
	}
}