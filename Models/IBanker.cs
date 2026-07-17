using System;
using System.Collections.Generic;
using System.Text;

namespace Models
{
	public interface IBanker: ICustomer
	{
		Personne Titulaire { get; }
		string Numero { get; set; }

		void AppliquerInteret();
	}
}
