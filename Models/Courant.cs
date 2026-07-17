using System;
using System.Collections.Generic;
using System.Text;

namespace Models
{
	public class Courant: Compte
	{
		private double ligneDeCredit;

		public double LigneDeCredit
		{
			get 
			{ 
				return ligneDeCredit; 
			}
			set 
			{
				if (value < 0)
				{
					throw new InvalidOperationException("La ligne de crédit ne peut être négative");
				}
				ligneDeCredit = value; 
			}
		}
		public Courant(string numero, Personne titulaire) : this(numero, titulaire, 0, 0)
		{
		}

		public Courant(string numero, Personne titulaire, double solde) : this(numero, titulaire, solde, 0)
		{
		}

		public Courant(string numero, Personne titulaire,double solde, double ligneDeCredit): base(numero, titulaire, solde)
		{
			LigneDeCredit = ligneDeCredit;
		}


		public override void Retrait(double montant)
		{
			if (Solde - montant < -LigneDeCredit)
			{
				throw new SoldeInsuffisantException();
			}
			base.Retrait(montant);
		}

		protected override double CalculInteret()
		{
			if (Solde < 0)
			{
				return Solde * 9.75 / 100;
			}
			return Solde * 3 / 100;
		}
	}
}
