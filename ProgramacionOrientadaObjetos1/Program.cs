//Primer ejemplo de programacion orientada a objetos
//construmos un objeto de tipo producto

using System.Runtime.CompilerServices;

Producto Refresco = new Producto("Coca Cola", 15.50m, -2); // instanciar un objeto de tipo producto







Console.WriteLine(Refresco.MostrarInfo());

//DEFINMOS UNA CLASE
public class Producto
{
	// una propiedad es una manera de alamacenar informacion en un objeto con un extra de 
	//flexiblidad para poder evaluar la informacion antes de almacenarlos y antes de devolverlos



	//Campos privados en una clase 
	private decimal _precioUnitario;



	//// Atributos que puede tener un producto o un objeto 
	///Propiedad
	public string Nombre { get; set; }

	public decimal Precio { get; set; }


	// Acceder al campo privado
	public decimal PrecioUnitario
	{
		get
		{
			return _precioUnitario;
		}
		set
		{
			if (value <= 0)
			{
				throw new Exception("El precio unitario debe ser mayor a 0");
			}
			_precioUnitario = value;
		}
	}

	//Metodo constructor para obligar que un objeto tenga un nombre y un precio 
	// si vas a crear un objeto de tipo producto es obligatorio que tenga un nombre y un precio

	public Producto(string nombre, decimal precio, decimal presiounit)
	{
		Nombre = nombre;
		Precio = precio;
		PrecioUnitario = presiounit;
	}



	// Funciones o comportamientos dentro de una clase ejemplo
	public string MostrarInfo()
	{
		return $"Producto: {Nombre} Precio: {Precio}";
	}
}

// algunas cosas importantes de la programacion orientada a objetos
// set y get son metodos que se utilizan para asignar y obtener valores de las propiedades de un objeto
// set    asigna un valor a la propiedad
// get    obtiene el valor de la propiedad
// protegemos la informacion con get y set 
// 1. Encapsulamiento
// 2. Herencia
// 3. Polimorfismo
// 4. Abstraccion
// 5. Clases
// 6. Objetos
// 7. Metodos
// 8. Propiedades
// 9. Constructores
// 10. Interfaces
// 11. Clases abstractas
// 12. Clases selladas
// 13. Enumeraciones
// 14. Delegados
// 15. Eventos
// 16. Excepciones
// 17. Genericos
// 18. Colecciones
// 19. LINQ
// 20. Expresiones lambda	
// 21. Extensiones
// 22. Expresiones regulares
// 23. Hilos
// 24. Tareas
// 25. Paralelismo
// 26. Serializacion
// 27. Reflection
// 28. Atributos
// 29. Metodos de extension

