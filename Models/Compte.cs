using System;
using System.Collections.Generic;
using System.Numerics;
using System.Text;

namespace Models
{
	public class Compte
	{
		public string Numero { get; set; }
		public Personne Titulaire { get; set; }

		private double solde = 0;

		public double Solde
		{
			get
			{
				return solde;
			}
			private set
			{
				solde = value;
			}
		}

		public void Depot(double montant)
		{
			Solde += montant;
		}

		public virtual void Retrait(double montant)
		{
			Solde -= montant;
		}


		// +(élément à gauche, élément à droite)
		public static double operator +(Compte compte, double montant)
		{
			if (compte.Solde > 0)
			{
				return compte.Solde + montant;
			}
			return montant;
		}
		public static double operator +(double montant, Compte compte)
		{
			return compte + montant;
		}
	}
}
