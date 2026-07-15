using System;
using System.Collections.Generic;
using System.Text;

namespace Models.Autres_exercices
{
	public class Celsius
	{
		public float Degre { get; set; }

		public static implicit operator Fahrenheit(Celsius celsius)
		{
			Fahrenheit fahrenheit = new Fahrenheit();
			fahrenheit.Degre = (celsius.Degre * 9 / 5) + 32;
			return fahrenheit;
		}
	}
}
