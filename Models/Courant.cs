using System;
using System.Collections.Generic;
using System.Text;

namespace Models
{
	public class Courant
	{
		public string Numero { get; set; }
		private double solde = 0;

		public double Solde
		{
			get	
			{ 
				return solde; 
			}
			private set 
			{
				if (value >= - LigneDeCredit)
				{
					solde = value; 
				}
			}
		}

		private double ligneDeCredit;

		public double LigneDeCredit
		{
			get 
			{ 
				return ligneDeCredit; 
			}
			set 
			{
				if (value >= 0)
				{
					ligneDeCredit = value; 
				}
			}
		}

		public Personne Titulaire { get; set; }

		public void Retrait(double montant)
		{
			Solde -= montant;
		}
		public void Depot(double montant)
		{
			Solde += montant;
		}
		public void Depot()
		{
			Depot(50d);
		}

		// +(élément à gauche, élément à droite)
		public static double operator +(Courant courant, double montant)
		{
			if (courant.Solde > 0)
			{
				return courant.Solde + montant;
			}
			return montant;
		}
		public static double operator +(double montant, Courant courant)
		{
			return courant + montant;
		}

	}
}
