using System;
using System.Collections.Generic;
using System.Text;

namespace Models.Demo
{
	public class Voiture: Vehicule
	{
		private string carburant;
		public string Carburant 
		{ 
			get 
			{
				return carburant;
			}
			set 
			{ 
				carburant = value;
			} 
		}


		private int nbRoue;
		public int NbRoue
		{
			get 
			{
				return nbRoue;
			}
			set 
			{
				if (value >= 0 && value <= 6)
				{
					nbRoue = value;
				}
			}
		}

		/*Equivalent en Java
		public int GetNbRoue()
		{
			return nbRoue;
		}
		public void SetNbRoue(int value)
		{
			if (value >= 0 && value <= 6)
			{
				nbRoue = value
			}
		}

		// accès par fonction !
		mazda3.SetNbRoue(4);
		System.out.println(mazda3.GetNbRoue());
		mazda3.SetNbRoue(mazda3.GetNbRoue() + 1);
		 */

		// Raccourci avec Visual Studio
		// prop
		public string MyProperty { get; set; }
		// propfull
		private bool estDisponible;

		public bool EstDisponible
		{
			// lecture de la variable estDisponible
			get { return estDisponible; }
			// modification de la variable estDisponible
			set { estDisponible = value; }
		}

		// internal Garage garage;

		public override void Accelerer(int vitesseSup = 10)
		{
			Console.WriteLine("Accélération depuis Voiture");
			if (vitesseSup > 120)
			{
				vitesseSup = 120;
			}
			Vitesse += vitesseSup;

			// à la place, on peut faire appel à la même
			//base.Accelerer(vitesseSup);
		}

		// new = on réécrit le comportement d'une méthode
		public new void Decelerer(int vitesseDif = 10)
		{
			Console.WriteLine("Décélération depuis Voiture");
			Vitesse -= vitesseDif;
		}

		public string Klaxonner()
		{
			return "Bip bip";
		}

		public override string ToString()
		{
			return base.ToString();
		}
	}
}
