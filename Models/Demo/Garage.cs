using System;
using System.Collections.Generic;
using System.Text;

namespace Models.Demo
{
	public class Garage
	{
		private List<Vehicule> vehicules = new List<Vehicule>();

		public List<Vehicule> Voitures
		{
			get { return vehicules; }
			set { vehicules = value; }
		}

		public Vehicule this[int position]
		{
			get
			{
				Vehicule voiture = null;
				if (position >= 0 && position < vehicules.Count)
				{
					voiture = vehicules[position];
				}
				return voiture;
			}
			set
			{
				if (position == Voitures.Count)
				{
					Voitures.Add(value);
				}
				else if (position >= 0 && position < Voitures.Count)
				{
					Voitures[position] = value;
				}
			}
		}

		public Dictionary<string, Personne> Employes { get; set; } = new Dictionary<string, Personne>();
		public Personne this[string key]
		{
			get
			{
				return Employes[key];
			}
			set
			{
				Employes[key] = value;
			}
		}

		public static int operator +(Garage garage, Voiture voiture)
		{
			if (garage.Voitures.Contains(voiture))
			{
				return garage.Voitures.Count;
			}

			garage.Voitures.Add(voiture);
			return garage.Voitures.Count;
		}

	}
}
