using System;
using System.Collections.Generic;
using System.Text;

namespace Models
{
	public class Personne
	{
		public string Nom { get; init; }
		public string Prenom { get; init; }
		private DateTime dateNaiss;
		public DateTime DateNaiss {
			get
			{
				return dateNaiss;
			}
			private set
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

		public Personne(string nom, string prenom, DateTime dateNaiss)
		{
			Nom = nom;
			Prenom = prenom;
			DateNaiss = dateNaiss;
		}
	}
}
