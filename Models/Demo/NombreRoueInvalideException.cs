using System;
using System.Collections.Generic;
using System.Text;

namespace Models.Demo
{
	public class NombreRoueInvalideException: Exception
	{
		public NombreRoueInvalideException(): this("Nombre de roue invalide") { }
		public NombreRoueInvalideException(string message): base(message){ }
	}
}
