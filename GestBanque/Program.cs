using Models;
using Models.Demo;


#region demo
//Voiture mazda3 = new Voiture();
//mazda3.Carburant = "Diesel";
//mazda3.NbRoue = 4;

//mazda3.NbRoue = 1000;

//Console.WriteLine(mazda3.NbRoue);

//Console.WriteLine(mazda3.Vitesse);

//Console.WriteLine("Hello, World!");
#endregion

#region test d'exercice
Personne personne = new Personne();
personne.Prenom = "Bruce";
personne.Nom = "Wayne";
personne.DateNaiss = new DateTime(1972,2,19);

Console.WriteLine($"{personne.Prenom} {personne.Nom} {personne.DateNaiss}");
#endregion