using System;
using System.Collections.Generic;
using System.Text;

namespace Models.Demo
{
	public static class VoitureExtension
	{
		public static void Peindre(this Voiture voiture, string couleur)
		{
			Console.WriteLine($"la voiture d'id {voiture.Id} est maintenant de couleur {couleur}");
		}
	}
}
