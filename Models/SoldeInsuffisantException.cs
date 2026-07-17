using System;
using System.Collections.Generic;
using System.Text;

namespace Models
{
	public class SoldeInsuffisantException: Exception
	{
		public SoldeInsuffisantException(): base("Solde insuffisant pour effectuer cette opération") { }
	}
}
