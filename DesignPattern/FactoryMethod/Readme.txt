Design pattern > Créateurs > Factory Method
-------------------------------------------

Ce patron fournit une interface pour créer un objet qui laisse la possibilité aux sous-classes 
de décider quel type d'objet créer. Ce patron est utilisé lorsque la classe d'un objet n'est 
pas connue au moment de la compilation. Une méthode pour créer un objet factory method est 
définie dans une classe abstraite, et implémentée dans les différentes sous-classes. 
La factory method peut également comporter une implémentation par défaut.