using System;
using System.Collections.Generic;
using System.Text;

namespace Models
{
	public class Personne
	{
		public string Nom { get; set; }
		public string Prenom { get; set; }
		private DateTime dateNaiss;
		public DateTime DateNaiss {
			get
			{
				return dateNaiss;
			}
			set
			{
				DateTime aujourdhui = DateTime.Now;
				// si la valeur amené est plus petite ou égale à ajd
				// et la valeur est strictement plus grande à ajd - 110 ans
				if (value <= aujourdhui && value > aujourdhui.AddYears(-110))
				{
					dateNaiss = value;
				}
			}
		}
	}
}
