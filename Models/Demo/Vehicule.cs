using System;
using System.Collections.Generic;
using System.Text;

namespace Models.Demo
{
	public class Vehicule
	{

		protected int vitesse = 0;

		public int Vitesse
		{
			get { return vitesse; }
			protected set
			{
				if (value >= 0)
				{
					vitesse = value;
				}
			}
		}

		// virtual = permet de donner un corps à notre fonction (notre logique de fonction)
		// et de dire qu'elle pourra être réécrite
		public virtual void Accelerer(int vitesseSup = 10)
		{
			Console.WriteLine("Accélération depuis Véhicule");
			Vitesse += vitesseSup;
		}
		public void Decelerer(int vitesseDif = 10)
		{
			Console.WriteLine("Décélération depuis Véhicule");
			Vitesse -= vitesseDif;
		}

		// override = on réécrit le comrtement d'une fonction (avec virtual par exemple)
		public override string ToString()
		{
			return "C'est un véhicule";
		}
	}
}
