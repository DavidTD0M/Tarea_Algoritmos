int edad;
char genero;
int opcion;
string nombre;
Console.WriteLine("=== CINE CLUB ===");
static string edadcon(int edad)// <----- Funcion de retorno segun la edad (Niño, adolecente, etc...)
{
    if (edad >= 18 && edad < 20)
    {
        return "Adolecente";
    }
    else if (edad >= 20 && edad < 60)
    {
        return "Adulto";
    }
    else if (edad >= 60 && edad < 110)
    {
        return "Adulto mayor";
    }
    {
        return "Edad inválida";
    }
} 
static string generocon(char genero)// <------ Funcion para que retorne los precios (Tal vez era mas facil de hacer)
{
    if (genero == 'F')
    {
        return "Entrada GRATIS";
    }
    else if (genero == 'M')
    {
        return "RD$300";
    }
    else
    {
        return "Género inválido";
    }
}
do
{
    Console.WriteLine("1) Registrar  2) Tarifas  3) Salir;

    Console.Write("Opción: ");
    opcion = Convert.ToInt32(Console.ReadLine());
    if (opcion < 1 || opcion > 3)
    {
        Console.WriteLine("Opción inválida. Por favor, ingrese una opción válida.");
        Console.WriteLine();
    }
 switch (opcion)// <------ El switch dentro del do while
    {
        case 1:
            Console.Write("Nombre: ");
            nombre = Console.ReadLine();
            Console.Write("Edad: ");
            edad = Convert.ToInt32(Console.ReadLine());
            Console.Write("Género (F/M): ");
            genero = Convert.ToChar(Console.ReadLine().ToUpper());

            if (edad >= 18 && edad < 110 && (genero == 'F' || genero == 'M'))
            {
                Console.WriteLine(nombre + " | " + edadcon(edad) + " | " + generocon(genero));
            }
            else if (genero != 'F' && genero != 'M')
            {
                Console.WriteLine("Género inválido.");
                continue;
            }
            else if (edad < 18)
            {
                Console.WriteLine("No se permiten menores de edad.");
                continue;
            }
            break;
        case 2:
            Console.WriteLine("Tarifas:");
            Console.WriteLine();
            Console.WriteLine("Adultos: RD$300");
            Console.WriteLine("Mujeres: Gratis");
            break;
        case 3:
            Console.WriteLine("Saliendo del programa...");
            break;
    } 
} while (opcion < 1 || opcion > 3);