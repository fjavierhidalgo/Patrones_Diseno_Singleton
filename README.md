# Patrones Diseño: Singleton
Ejercicio patrones diseño - Singleton

Problema y Contexto:
Nuestro sistema requiere que una determinada clase sólo pueda ser instanciada una vez. Esto es útil cuando varios clientes desean utilizar una funcionalidad que es proporcionada por un único objeto. Nuestro objetivo será garantizar que la clase en cuestión no pueda generar más de una instancia y proporcionar un punto de acceso fijo a la misma.

Se aplica cuando:

Nuestro sistema tiene una clase que sólo deba ser instanciada una vez.
Dicha clase requiere de un punto de acceso global y conocido.

Solución y Estructura:

Para que éste escenario sea posible debemos asegurarnos que nuestra clase es instanciada si y sólo si no ha sido instanciada antes. Para controlar esta característica debemos hacer que el constructor sea privado, es decir, regulamos la instanciación de la clase dentro de la misma clase.

Para acceder a la clase debemos crear un atributo estático que represente una instancia de la misma, que debe ser de tipo privado. El acceso al atributo se hará desde un método público y estático que, en caso de no estar instanciado el atributo que representa la instancia, lo crea y en caso de que dicho atributo ya esté instanciado, lo devuelve.
