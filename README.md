# DesignPattern

Design pattern > Cr�ateurs

Design pattern > Cr�ateurs > Singleton
--------------------------------------

Ce patron vise � assurer qu'il n'y a toujours qu'une seule instance d'une classe en fournissant 
une interface pour la manipuler. C'est un des patrons les plus simples. L'objet qui ne doit exister 
qu'en une seule instance comporte une m�thode pour obtenir cette unique instance et un m�canisme 
pour emp�cher la cr�ation d'autres instances.


Design pattern > Cr�ateurs > Abstract Factory
--------------------------------------

Ce patron fournit une interface pour cr�er des familles d'objets sans sp�cifier la classe concr�te. 
Le patron factory (en fran�ais fabrique) est un patron r�current. Une fabrique simple retourne 
une instance d'une classe parmi plusieurs possibles, en fonction des param�tres qui ont �t� fournis. 
Toutes les classes ont un lien de parent�, et des m�thodes communes, et chacune est optimis�e en fonction 
d'une certaine donn�e.

Le patron abstract factory (en fran�ais fabrique abstraite) va un pas plus loin que la fabrique simple. 
Une fabrique abstraite est utilis�e pour obtenir un jeu d'objets connexes. Par exemple pour impl�menter 
une charte graphique : il existe une fabrique qui retourne des objets (boutons, menus) dans le style de 
Windows, une qui retourne des objets dans le style de Motif, et une dans le style de Macintosh. 
Une fabrique abstraite est obtenue en utilisant une fabrique simple.

Design pattern > Cr�ateurs > Builder
--------------------------------------

Ce patron s�pare le processus de construction d'un objet du r�sultat obtenu. 
Permet d'utiliser le m�me processus pour obtenir diff�rents r�sultats.

C'est une alternative au pattern factory.

Au lieu d'une m�thode pour cr�er un objet, � laquelle est pass�e un ensemble de param�tres, 
la classe factory comporte une m�thode pour cr�er un objet - le builder. 

Cet objet comporte des propri�t�s qui peuvent �tre modifi�es et une m�thode pour cr�er l'objet final en tenant 
compte de toutes les propri�t�s. Ce pattern est particuli�rement utile quand il y a de nombreux 
param�tres de cr�ation, presque tous optionnels.

Design pattern > Cr�ateurs > Factory Method
-------------------------------------------

Ce patron fournit une interface pour cr�er un objet qui laisse la possibilit� aux sous-classes 
de d�cider quel type d'objet cr�er. Ce patron est utilis� lorsque la classe d'un objet n'est 
pas connue au moment de la compilation. Une m�thode pour cr�er un objet factory method est 
d�finie dans une classe abstraite, et impl�ment�e dans les diff�rentes sous-classes. 
La factory method peut �galement comporter une impl�mentation par d�faut.

Design pattern > Cr�ateurs > Prototype
--------------------------------------

Ce patron permet de d�finir le genre d'objet � cr�er en dupliquant une instance qui sert d'exemple - le prototype. 
L'objectif de ce patron est d'�conomiser le temps n�cessaire pour instancier des objets. 
Selon ce patron, une application comporte une instance d'un objet, qui sert de prototype. 
Cet objet comporte une m�thode clone pour cr�er des duplicata. 
Des langages de programmation comme PHP ont une m�thode clone incorpor�e dans tous les objets.