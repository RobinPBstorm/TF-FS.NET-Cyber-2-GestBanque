using System;
using System.Collections.Generic;
using System.Text;

namespace Models.Demo
{
	public class Velo : Vehicule
	{
		public bool AvecAssistanceElectrique { get; set;/*init;*/ }
		public Velo() 
		{
			AvecAssistanceElectrique = false;
		}

		public void SetAssistance(bool avecAssistanceElectrique) 
		{
			AvecAssistanceElectrique = avecAssistanceElectrique;
		}
		public override void Entretenir()
		{
			Console.WriteLine("Graisser la chaine");
			Console.WriteLine("Regonfler les pneux");
		}
	}
}
