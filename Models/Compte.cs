using System;
using System.Collections.Generic;
using System.Numerics;
using System.Text;

namespace Models
{
	public abstract class Compte: IBanker, ICustomer
	{
		public string Numero { get; private set; }
		public Personne Titulaire { get; private set; }

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

		public Compte(string numero, Personne titulaire)
		{
			Numero = numero;
			Titulaire = titulaire;
		}
		public Compte(string numero, Personne titulaire, double solde): this(numero, titulaire)
		{
			Solde = solde;
		}



		#region méthode
		public void Depot(double montant)
		{
			//if (! (montant > 0))
			if (montant <= 0)
			{
				throw new ArgumentOutOfRangeException("montant", "Pas de montant inférieur ou égal à 0");
			}
			Solde += montant;
		}

		public virtual void Retrait(double montant)
		{
			Solde -= montant;
		}

		// Design Pattern
		protected abstract double CalculInteret();
		public void AppliquerInteret()
		{
			Solde += CalculInteret();
		}
		#endregion


		#region surcharge opérateur
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
		#endregion

	}
}
