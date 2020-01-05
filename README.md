# DesignPattern

Design pattern > Créateurs

Design pattern > Créateurs > Singleton
--------------------------------------

Ce patron vise à assurer qu'il n'y a toujours qu'une seule instance d'une classe en fournissant 
une interface pour la manipuler. C'est un des patrons les plus simples. L'objet qui ne doit exister 
qu'en une seule instance comporte une méthode pour obtenir cette unique instance et un mécanisme 
pour empêcher la création d'autres instances.


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

Design pattern > Créateurs > Builder
--------------------------------------

Ce patron sépare le processus de construction d'un objet du résultat obtenu. 
Permet d'utiliser le même processus pour obtenir différents résultats.

C'est une alternative au pattern factory.

Au lieu d'une méthode pour créer un objet, à laquelle est passée un ensemble de paramètres, 
la classe factory comporte une méthode pour créer un objet - le builder. 

Cet objet comporte des propriétés qui peuvent être modifiées et une méthode pour créer l'objet final en tenant 
compte de toutes les propriétés. Ce pattern est particulièrement utile quand il y a de nombreux 
paramètres de création, presque tous optionnels.

Design pattern > Créateurs > Factory Method
-------------------------------------------

Ce patron fournit une interface pour créer un objet qui laisse la possibilité aux sous-classes 
de décider quel type d'objet créer. Ce patron est utilisé lorsque la classe d'un objet n'est 
pas connue au moment de la compilation. Une méthode pour créer un objet factory method est 
définie dans une classe abstraite, et implémentée dans les différentes sous-classes. 
La factory method peut également comporter une implémentation par défaut.

Design pattern > Créateurs > Prototype
--------------------------------------

Ce patron permet de définir le genre d'objet à créer en dupliquant une instance qui sert d'exemple - le prototype. 
L'objectif de ce patron est d'économiser le temps nécessaire pour instancier des objets. 
Selon ce patron, une application comporte une instance d'un objet, qui sert de prototype. 
Cet objet comporte une méthode clone pour créer des duplicata. 
Des langages de programmation comme PHP ont une méthode clone incorporée dans tous les objets.