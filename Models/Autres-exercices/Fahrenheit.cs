using System;
using System.Collections.Generic;
using System.Text;

namespace Models.Autres_exercices
{
	public class Fahrenheit
	{
		public float Degre { get; set; }



		public static explicit operator Celsius(Fahrenheit fahrenheit)
		{
			Celsius celsius = new Celsius();
			celsius.Degre = (fahrenheit.Degre - 32) / 9 * 5;
			return celsius;
		}
	}
}
