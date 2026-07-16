# GESTBANQUE

GestBanque est un projet en C# pour explorer les bases de l'orienté objet.

## Notion de classe

Nos **classes** sont comme des moules. \
Nous y définissons les caractèristiques de nos objets.\

```C#
	public class Personne {
		public string nom;
	}
```

Dans notre analogie, tous ce qui ressorira de notre moule seront des **instances**.\

```C#
	Personne tim = new Personne();
	tim.nom = "Tim";
```

### Pour créer une classe

Clique droit sur le projet/dossier\
ajouter/add\
Classe.../Class...\
Choisissez la classe et donnez lui un nom.

## Encapsulation

Certaines variables ou méthodes dans notre classe ne doivent pas être disponible depuis n'importe où dans le code.

Pour se faire, on limitera l'accés avec ces mots clés:
 - **public**				(pas de limite)
 - **private**				(accessible que dans la classe)
 - **internal**				(accessible que dans l'assembly)
 - **protected**			(accessible dans la classe et ses dérivés)
 - **protected internal**	(restreint à l’assembly courant ou à aux
types dérivés de la classe conteneur)
 - **private protected**	(restreint aux types dérivés de la classe
conteneur uniquement dans le même assembly)

## Les propriétées

Il est plus que judicieux de limiter l'accés et la modification des variables de nos classes.\
C'est ici que nos **propriétées** vont nous aider.

```C#
	private int count = 0;
	public int Count {
		get 
		{
			return count;
		}
		set
		{
			count = value;
		}
	}
```

Remarque: Même s'ils sont employés comme des variables, cela reste des méthodes !

```C#
	monInstance.Count += 1;
	Console.WriteLine(monInstance.Count)
```

## Les indexeurs

**Spécificité de C#**

Si nous avons une collections d'élément dans notre classe, nous pouvons créer un indexeurs pour chaque instance puisse accéder plus facilement à un élement de notre collection.

```
	private List<Voiture> voitures = new List<Voiture>();

	public Voiture this[int position]
	{
		get
		{
			Voiture voiture = null;
			if (position >= 0 && position < voitures.Count)
			{
				voiture = voitures[position];
			}
			return voiture;
		}
		set
		{
			if (position == voitures.Count)
			{
				voitures.Add(value);
			}
			else if (position >= 0 && position < voitures.Count)
			{
				voitures[position] = value;
			}
		}
	}
```


```C#
	Voiture mazda3 = new Voiture();

	Garage garage = new Garage();
	garage[0] = mazda3;  
```