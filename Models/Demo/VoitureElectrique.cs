using System;
using System.Collections.Generic;
using System.Text;

namespace Models.Demo
{
	public class VoitureElectrique: Voiture
	{
		public VoitureElectrique(): this(4)
		{ 
		}
		public VoitureElectrique(int nbRoue) : base(nbRoue, "électrique") // fait appel au constructeur de voiture avec nombre de roue et carburant
		{
		}
	}
}
