using System;
using System.Collections.Generic;
using System.Text;

namespace Models.Demo
{
	public class Velo : Vehicule
	{
		public override void Entretenir()
		{
			Console.WriteLine("Graisser la chaine");
			Console.WriteLine("Regonfler les pneux");
		}
	}
}
