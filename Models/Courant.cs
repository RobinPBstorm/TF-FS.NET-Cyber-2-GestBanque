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
				if (value >= 0)
				{
					ligneDeCredit = value; 
				}
			}
		}


		public override void Retrait(double montant)
		{
			if (Solde - montant >= -LigneDeCredit)
			{
				base.Retrait(montant);
			}
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
