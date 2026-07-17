using System;
using System.Collections.Generic;
using System.Text;

namespace Models.Demo
{
	public class ListeValeurPaire
	{
		//List<int> valeurs = new List<int>() { 0, 2, 4, 6, 8 };
		//public ListeValeurPaire()
		//{
		//	for (int i = 0; i < 10; i += 2)
		//	{
		//		valeurs.Add(i);
		//	}
		//}

		public static IEnumerable<int> getNombres()
		{
			for (int i = 0; i < 10; i += 2)
			{
				yield return i;
			}
		}

		public static IEnumerable<int> getNombres2()
		{
			yield return 0;
			yield return 2;
			yield return 4;
			yield return 6;
			yield return 8;
		}


	}
}
