using System;
using System.Security.Cryptography.X509Certificates;
using CODIGO1;
namespace CODIGO1;

class EleccionMapa : Tableros
{
    //Propiedades
    public static int eleccion1, eleccion2;
    //métodos
    public static void eleccionSi1()
    {
        Console.WriteLine("A continuación se encuentran las posibles posiciones de barcos del capitan 1\n¿Deseas continuar con esta ubicación?");
        Console.ForegroundColor = ConsoleColor.Red;
        int l = 0;
        Console.WriteLine("  1 2 3 4 5 6");
        Console.Write("A");
        Tableros.Recorrido();
        for (int i = 0; i < 6; i++)
        {
            for (int j = 0; j < 6; j++)
            {
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write(" " + tablero1[i, j]);
            }
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("");
            l++;
            switch (l)
            {
                case 1:
                    Console.Write("B");
                    break;
                case 2:
                    Console.Write("C");
                    break;
                case 3:
                    Console.Write("D");
                    break;
                case 4:
                    Console.Write("E");
                    break;
                case 5:
                    Console.Write("F");
                    break;
                case 6:
                    Console.Write(" ");
                    break;
            }
        }
        repetir1();
    }
    static void repetir1()
    {
        Console.WriteLine("(1) Si   (2) No");
        do
        {
            try
            {
                eleccion1 = Convert.ToInt16(Console.ReadLine());
                if (eleccion1 < 1 || eleccion1 > 2)
                {
                    Console.WriteLine("Opción no válida");
                }
                else
                {
                    switch (eleccion1)
                    {
                        case 1:
                            Console.Clear();
                            break;
                        case 2:
                            Console.Clear();
                            eleccionSi1();
                            break;
                    }
                    break;
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("Opción no válida");
            }
        } while (true);
    }
    public static void eleccionSi2()
    {
        Console.WriteLine("A continuación se encuentran las posibles posiciones de barcos del capitan 2\n¿Deseas continuar con esta ubicación?");
        Console.ForegroundColor = ConsoleColor.Red;
        int l = 0;
        Console.WriteLine("  1 2 3 4 5 6"); //enumeración para la parte de arriba
        Console.Write("A"); //primer índice de filas
        Tableros.Recorrido(); //llamado a asignación de valores en las celdas
        for (int i = 0; i < 6; i++)
        {
            for (int j = 0; j < 6; j++)
            {
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write(" " + tablero2[i, j]);
            }
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("");
            l++; //continuación de índice para filas
            switch (l)
            {
                case 1:
                    Console.Write("B");
                    break;
                case 2:
                    Console.Write("C");
                    break;
                case 3:
                    Console.Write("D");
                    break;
                case 4:
                    Console.Write("E");
                    break;
                case 5:
                    Console.Write("F");
                    break;
                case 6:
                    Console.Write(" ");
                    break;
            }
        }
        repetir2(); //llamado al método rapetir2
    }
    static void repetir2()
    {
        Console.WriteLine("(1) Si   (2) No");
        do
        { //se evalúa que el usuario ingrese una opción válida
            try
            {
                eleccion2 = Convert.ToInt16(Console.ReadLine());
                if (eleccion2 < 1 || eleccion2 > 2)
                {
                    Console.WriteLine("Opción no válida");
                }
                else
                {
                    switch (eleccion2)
                    {
                        case 1:
                            Console.Clear();
                            break;
                        case 2:
                            Console.Clear();
                            eleccionSi2(); //llamado para que vuelva a aparecer todo lo del método anterior
                            break;
                    }
                    break;
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("Opción no válida");
            }
        } while (true);
    }
}
