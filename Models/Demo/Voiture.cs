using System;
using System.Collections.Generic;
using System.Text;

namespace Models
{
	public class Voiture
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

		internal Garage garage;

		private int vitesse = 0;

		public int Vitesse
		{
			get { return vitesse; }
			private set 
			{
				if (value >= 0)
				{
					vitesse = value; 
				}
			}
		}

		public void Accelerer(int vitesseSup = 10)
		{
			Vitesse += vitesseSup;
		}
		public void Decelerer(int vitesseDif = 10)
		{
			Vitesse -= vitesseDif;
		}


	}
}
