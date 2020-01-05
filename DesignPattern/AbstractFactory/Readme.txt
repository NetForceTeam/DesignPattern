Design pattern > Créateurs > Abstract Factory
--------------------------------------

Ce patron fournit une interface pour créer des familles d'objets sans spécifier la classe concrète. 
Le patron factory (en français fabrique) est un patron récurrent. Une fabrique simple retourne 
une instance d'une classe parmi plusieurs possibles, en fonction des paramètres qui ont été fournis. 
Toutes les classes ont un lien de parenté, et des méthodes communes, et chacune est optimisée en fonction 
d'une certaine donnée.

Le patron abstract factory (en français fabrique abstraite) va un pas plus loin que la fabrique simple. 
Une fabrique abstraite est utilisée pour obtenir un jeu d'objets connexes. Par exemple pour implémenter 
une charte graphique : il existe une fabrique qui retourne des objets (boutons, menus) dans le style de 
Windows, une qui retourne des objets dans le style de Motif, et une dans le style de Macintosh. 
Une fabrique abstraite est obtenue en utilisant une fabrique simple.


