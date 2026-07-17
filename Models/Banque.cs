using System;
using System.Collections.Generic;
using System.Numerics;
using System.Text;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Models
{
	public class Banque
	{
		public string Nom { get; init; }
		private Dictionary<string,Compte> comptes;

		public Dictionary<string,Compte> Comptes
		{
			get { return comptes; }
			init { comptes = value; }
		}

		public Banque (string nom)
		{
			Nom = nom;
			Comptes = new Dictionary<string,Compte>();
		}

		public Compte this[string numero]
		{
			get
			{
				Compte compte;
				Comptes.TryGetValue(numero, out compte);
				return compte;
			}
		}

		// ctrl + alt + clique => positionne un autre curseur
		public void Ajouter(Compte compte) 
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

			foreach (Compte compte in Comptes.Values)
			{
				if (compte.Titulaire == titulaire)
				{
					soldeTotal += compte;
				}
			}

			return soldeTotal;
		}
	}
}
