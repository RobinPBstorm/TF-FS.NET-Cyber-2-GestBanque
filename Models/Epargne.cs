using System;
using System.Collections.Generic;
using System.Text;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Models
{
	public class Epargne: Compte
	{
		
		private DateTime dateDernierRetrait;
		public DateTime DateDernierRetrait
		{
			get
			{
				return dateDernierRetrait;
			}
			set
			{
				DateTime aujourdhui = DateTime.Now;
				if (value <= aujourdhui)
				{
					dateDernierRetrait = value;
				}
			}
		}

		public override void Retrait(double montant)
		{
			if (Solde - montant >= 0)
			{
				DateDernierRetrait = DateTime.Now;
				base.Retrait(montant);
			}
		}

		protected override double CalculInteret()
		{
			return Solde * 4.5 / 100;
		}
	}
}
