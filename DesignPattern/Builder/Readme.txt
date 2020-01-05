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
