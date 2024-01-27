﻿using System.ComponentModel.DataAnnotations;

namespace MyWebSite.Models.Siniflar
{
	public class AnaSayfa
	{
		[Key]
		public int Id { get; set; }
		public string Profil { get; set; }
		public string İsim { get; set; }
		public string Unvan { get; set; }
		public string Aciklama { get; set; }
		public string İletisim { get; set; }
	}
}