using System;
using System.Runtime.CompilerServices;
using CODIGO1;
namespace CODIGO1;

class Tableros
{
    //Propiedades
    public static int barco1,barco2,barco3,barco11,barco22,barco33,numeroMapa1,numeroMapa2;
    public static string[,] mapa1 = new string[6, 6]; //mapas que se van a mostrar durante la batalla
    public static string[,] mapa2 = new string[6, 6];
    public static string[,] tablero1 = new string[6, 6]; //se crea un arreglo de 6x6 para el jugador 1
    public static string[,] tablero2 = new string[6, 6]; //se crea un arreglo de 6x6 para el jugador 2
    //métodos
    public static void Recorrido()
    {
        for (int i = 0; i < tablero1.GetLength(0); i++)
        {
            for (int j = 0; j < tablero1.GetLength(1); j++)
            {
                Console.ForegroundColor = ConsoleColor.White;
                tablero1[i, j] = "■"; //Le asigno el valor a los arreglos
                tablero2[i, j] = "■";
                mapa1[i, j] = "~";
                mapa2[i, j] = "~";
            }
        }
        mapaRandom1();
        mapaRandom2();
    }
    static void mapaRandom1()
    {
        Random random = new Random();
        int numero = random.Next(1, 5); //posibles opciones de ubicaciones de barcos
        numeroMapa1 = numero;
        switch (numero)
        {
            case 1:
                tablero1[0, 2] = "▨";
                tablero1[1, 2] = "▨";
                tablero1[2, 2] = "▨";
                tablero1[3, 2] = "▨";

                tablero1[5, 0] = "▨";
                tablero1[5, 1] = "▨";

                tablero1[5, 3] = "▨";
                tablero1[4, 3] = "▨";
                tablero1[3, 3] = "▨";
                break;
            case 2:
                tablero1[0, 2] = "▨";
                tablero1[0, 3] = "▨";
                tablero1[0, 4] = "▨";
                tablero1[0, 5] = "▨";

                tablero1[3, 4] = "▨";
                tablero1[3, 5] = "▨";

                tablero1[5, 0] = "▨";
                tablero1[4, 0] = "▨";
                tablero1[3, 0] = "▨";
                break;
            case 3:
                tablero1[3, 0] = "▨";
                tablero1[3, 1] = "▨";
                tablero1[3, 2] = "▨";
                tablero1[3, 3] = "▨";

                tablero1[0, 4] = "▨";
                tablero1[0, 5] = "▨";

                tablero1[5, 5] = "▨";
                tablero1[4, 5] = "▨";
                tablero1[3, 5] = "▨";
                break;
            case 4:
                tablero1[1, 3] = "▨";
                tablero1[2, 3] = "▨";
                tablero1[3, 3] = "▨";
                tablero1[4, 3] = "▨";

                tablero1[1, 0] = "▨";
                tablero1[1, 1] = "▨";

                tablero1[0, 5] = "▨";
                tablero1[1, 5] = "▨";
                tablero1[2, 5] = "▨";
                break;
        }
    }
    static void mapaRandom2()
    {
        Random random = new Random();
        int numero = random.Next(1, 5);
        numeroMapa2 = numero;
        switch (numero)
        {
            case 1:
                tablero2[1, 1] = "▨";
                tablero2[1, 2] = "▨";
                tablero2[1, 3] = "▨";
                tablero2[1, 4] = "▨";

                tablero2[3, 2] = "▨";
                tablero2[3, 3] = "▨";

                tablero2[2, 5] = "▨";
                tablero2[3, 5] = "▨";
                tablero2[4, 5] = "▨";
                break;
            case 2:
                tablero2[3, 0] = "▨";
                tablero2[3, 1] = "▨";
                tablero2[3, 2] = "▨";
                tablero2[3, 3] = "▨";

                tablero2[0, 2] = "▨";
                tablero2[0, 3] = "▨";

                tablero2[2, 5] = "▨";
                tablero2[3, 5] = "▨";
                tablero2[4, 5] = "▨";
                break;
            case 3:
                tablero2[1, 4] = "▨";
                tablero2[2, 4] = "▨";
                tablero2[3, 4] = "▨";
                tablero2[4, 4] = "▨";

                tablero2[4, 2] = "▨";
                tablero2[4, 3] = "▨";

                tablero2[1, 0] = "▨";
                tablero2[2, 0] = "▨";
                tablero2[3, 0] = "▨";
                break;
            case 4:
                tablero2[0, 0] = "▨";
                tablero2[1, 0] = "▨";
                tablero2[2, 0] = "▨";
                tablero2[3, 0] = "▨";

                tablero2[5, 4] = "▨";
                tablero2[5, 5] = "▨";

                tablero2[1, 3] = "▨";
                tablero2[2, 3] = "▨";
                tablero2[3, 3] = "▨";
                break;
        }
    }
}