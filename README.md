###¿Cuándo utilizaría una Clase Abstracta en lugar de una Interfaz? Ejemplifique.###
Utilizaría una clases abstracta por ejemplo si estuviera programando una librería que va a usar un tercero dado que al definir un nuevo método en la interfaz puede comprometer a la compilación de todas las clases que implementen dicha interfaz, en el caso de las clases abstractas eso no sucede dado que por más que defina nuevos métodos las clases que heredan de clases abstractas no dejarán de compilar.
### ¿C# permite herencia múltiple? ###
No, c# no permite la herencia múltiple.
###¿Qué implica una relación de Generalización entre dos clases?###
Implica que la clase hija puede heredar los atributos, métodos y asociaciones de la clase padre.
Se dibujan mediante una flecha de triángulo blanco teniendo en cuenta que la flecha siempre apunta de la subclase hacia la superclase.  
###¿Qué implica una relación de Implementación entre una clase y una interfaz?###
Implica que la clase que implementa la interfaz debe implementar las funcionalidades definidas en la interfaz.
En otras palabras, las interfaces nos permiten definir un "contrato" sobre el que podemos estar seguros de que, las clases que las implementen, lo van a cumplir.
###¿Qué diferencia hay entre la relación de Composición y la Agregación?###
Una composición es un tipo de asociación donde un objeto contiene a otro mientras que una agregación es un tipo de asociación donde un objeto hace uso de otro.
### Indique V o F según corresponda. Diferencia entre Asociación y Agregación###
Una diferencia es que la segunda indica la relación entre un “todo” y sus “partes”, mientras que en la primera los objetos están al mismo nivel contextual. Verdadero.
Una diferencia es que la Agregación es de cardinalidad 1 a muchos mientras que la Asociación es de 1 a 1. Falso.
Una diferencia es que, en la Agregación, la vida o existencia de los objetos relacionados está fuertemente ligada, es decir que si “muere” el objeto contenedor también morirán las “partes”, en cambio en la Asociación los objetos viven y existen independientemente de la relación. 