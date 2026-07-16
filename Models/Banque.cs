using System;
using System.Collections.Generic;
using System.Numerics;
using System.Text;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Models
{
	public class Banque
	{
		public string Nom { get; set; }
		private Dictionary<string,Courant> comptes = new Dictionary<string, Courant>();

		public Dictionary<string,Courant> Comptes
		{
			get { return comptes; }
			set { comptes = value; }
		}

		public Courant this[string numero]
		{
			get
			{
				Courant courant;
				Comptes.TryGetValue(numero, out courant);
				return courant;
			}
		}

		// ctrl + alt + clique => positionne un autre curseur
		public void Ajouter(Courant compte) 
		{
			if (!comptes.ContainsKey(compte.Numero))
			{
				Comptes[compte.Numero] = compte;
			}
		}
		public void Supprimer(string Numero)
		{
			if (comptes.ContainsKey(Numero))
			{
				Comptes.Remove(Numero);
			}
		}

		public double AvoirDesComptes(Personne titulaire)
		{
			double soldeTotal = 0;

			foreach (Courant courant in Comptes.Values)
			{
				if (courant.Titulaire == titulaire)
				{
					soldeTotal += courant;
				}
			}

			return soldeTotal;
		}
	}
}
