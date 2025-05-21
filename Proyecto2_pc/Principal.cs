#pragma warning disable
using CODIGO1;
using System;
namespace Codigo1;

class Principal:Batalla
{
    public static string jugador1, jugador2;
    public static void Main(string[] args)
    {
        Bienvenida();
        EleccionMapa.eleccionSi1(); //se muestra en pantallas las opciones de ubicaciones para cada jugador
        EleccionMapa.eleccionSi2();
        Instrucciones();
        Batalla.batalla();
    }
    public static void Bienvenida()
    {
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine("\t====== ¡Bienvenidos a Naval Warships! ======");
        Console.WriteLine("☠🏴‍☠️ - ¡Ingresen sus nombres honorables capitanes! - ☠🏴‍☠️ ");
        Console.Write("Jugador 1: ");
        jugador1 = Console.ReadLine();
        Console.Write("Jugador 2: ");
        jugador2 = Console.ReadLine();
    }
    static void Instrucciones()
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("LEER ANTES DE EMPEZAR");
        Console.ForegroundColor = ConsoleColor.White;
        Console.WriteLine("A continuación se llevará a cabo una batalla, cada uno de los jugadores debe ingresar las coordenadas\nen donde atacarán");
        Console.WriteLine("Ejemplo: A-2");
        Console.WriteLine("Luego se marcará en el mapa enemigo si le acertaron o no a un barco");
        Console.WriteLine("Si le acertaron a un barco se mostrará en el mapa un símbolo O, si huboun disparo fallido se mostrará\nuna X");
        Console.WriteLine("Cada uno de los jugadores tendrá 15 turnos cada jugador puede llegar hasta 9 puntos, el juego finaliza cuando los turnos lleguen a cero\ny ganará el que más puntos tenga o bien el que derrote primero todos los barcos enemigos");
        Console.WriteLine("Si alguno desea rendirse en el apartado de coordenadas escriba la palabra (salir)");
        Console.WriteLine("Presione cualquier tecla para continuar");
        Console.ReadKey();
        Console.Clear();
    }
    public static void condicionSalida()
    {
        if (coordenada1 == "SALIR"||coordenada2=="SALIR")
        {
            if (turno1 < turno2)
            {
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("A veces la mejor batalla es la que no peleas... 🏳️");
                Console.WriteLine("HA GANADO " + jugador2);
                Environment.Exit(0);
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("A veces la mejor batalla es la que no peleas... 🏳️");
                Console.WriteLine("HA GANADO " + jugador1);
                Environment.Exit(0);
            }
        }
    }
}
