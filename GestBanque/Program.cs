using Models;
using Models.Autres_exercices;
using Models.Demo;
using System.Xml;


#region demo
Voiture mazda3 = new Voiture();
mazda3.Carburant = "Diesel";
mazda3.NbRoue = 4;

mazda3.NbRoue = 1000;

Console.WriteLine(mazda3.NbRoue);

Console.WriteLine(mazda3.Vitesse);

Garage garage = new Garage();
Console.WriteLine("---surchage garage + voiture---");
Console.WriteLine(garage + mazda3);

Console.WriteLine(garage + mazda3);

Console.WriteLine("---indexeur---");
Console.WriteLine(garage.Voitures[0].Vitesse);
Console.WriteLine(garage[0].Vitesse);

Personne bruce = new Personne();
bruce.Prenom = "Bruce";
bruce.Nom = "Wayne";
bruce.DateNaiss = new DateTime(1972, 2, 19);

garage[bruce.Prenom] = bruce;
Console.WriteLine(garage[bruce.Prenom].Prenom);

int diviseur = 0;
Console.WriteLine(((float)10)/diviseur);

Fahrenheit fahrenheit = new Fahrenheit();
fahrenheit.Degre = 100;

Console.WriteLine(((Celsius)fahrenheit).Degre);

#endregion

#region test d'exercice
//Personne bruce = new Personne();
//bruce.Prenom = "Bruce";
//bruce.Nom = "Wayne";
//bruce.DateNaiss = new DateTime(1972, 2, 19);

//Console.WriteLine($"{bruce.Prenom} {bruce.Nom} {bruce.DateNaiss}");

//Courant courant = new Courant();
//courant.LigneDeCredit = 200;
//courant.Numero = "1";
//courant.Titulaire = bruce;
//courant.Depot(1000000);

//Console.WriteLine($"{courant.Numero} appartenant à {courant.Titulaire.Prenom} {courant.Titulaire.Nom} avec {courant.Solde}");

//Banque banque = new Banque();
//banque.Nom = "Gotham City Bank";

//banque.Ajouter(courant);
//Console.WriteLine(banque["1"]?.Solde);

#endregion