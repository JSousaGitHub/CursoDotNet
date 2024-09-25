

namespace CompletarCodigoConIndicaciones {

	internal class Program {

		static void Main(string[] args) {
			// Modificar para incorporar las siguientes características:    
			// Indicar el numero de intentos que le quedan
			// Indicar si el número a adivinar es mayor o menor que el introducido


			// Pedir al usuario que ingrese un número a adivinar
			Console.Write("Introduce un número para que otro jugador lo adivine: ");
			int numeroAdivinar = int.Parse(Console.ReadLine());

			// Limpiar la consola para que el segundo jugador no vea el número
			Console.Clear();

			// Dar tres oportunidades para adivinar el número
			for(int i = 1; i <= 3; i++) {

				Console.Write("Adivina el número: ");
				int intento = int.Parse(Console.ReadLine());

				if(intento == numeroAdivinar) {
					Console.WriteLine("¡Felicidades! Has adivinado el número.");
					return;
				} else {
					Console.WriteLine("Número incorrecto. Intenta de nuevo.");

					// informamos de la cantidad de intentos
					Console.WriteLine("\n Llevas {0} intentos", i);

					// ayuda de orientación al usuario 
					if(intento > numeroAdivinar) {
						Console.WriteLine("   el número debe ser menor al introducido \n");
					} else {
						Console.WriteLine("   el número debe ser mayor al introducido \n");
					}
				}
			}

			Console.WriteLine("Lo siento, no has adivinado el número.");
		}
	}
}
