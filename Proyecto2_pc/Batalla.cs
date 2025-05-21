
using System;
using System.Xml;
using Codigo1;
namespace CODIGO1;

class Batalla : Tableros
{
    public static dynamic coordenada1, coordenada2;
    public static int turno1 = 15, turno2 = 15;
    public static void batalla()
    {
        bool salida = false;
        Console.ForegroundColor = ConsoleColor.Blue;
        Console.WriteLine("Bien, ahora 💥 ¡¡¡vamos a empezar nuestra batalla!!! 💥");
        do
        {
            Console.WriteLine($"Es tu turno jugador 1\tTurnos restantes: {turno1}");
            --turno1;
            Console.WriteLine("Estado actual de tus navíos: ");
            Console.ForegroundColor = ConsoleColor.White;
            mostrarTablero1();
            Console.WriteLine("Campo enemigo:");
            imprimirMapa1();
            do
            {
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("❌ Ingresa las coordenadas de ataque capitan!! ❌");
                coordenada1 = Console.ReadLine().ToUpper();
                Principal.condicionSalida();
                try
                {
                    string[] partes = coordenada1.Split('-'); //se dividen los elementos de la coordenada
                    char letraFila = partes[0][0];       // Coordenadas x 'A' a 'F' se tiene [0][0] para acceder al primer caracter de la cadena, en este caso A o B...
                    int columna = int.Parse(partes[1]);  // coordenadas y 1 a 6
                    int fila = letraFila - 'A'; //usando el valor del caracter se hace la resta para que indique el valor de la fila (en este caso A=65, entonces si el usuario ingresa A 65-65=0, entonces se escribe en la fila 0 del arreglo)
                    int col = columna - 1;
                    if (fila < 0 || fila >= 6 || col < 0 || col >= 6) //validación para saber si las coordenadas ingresadas están fuera de la matriz
                    {
                        Console.WriteLine("¡Coordenadas fuera del rango!");
                        continue;
                    }
                    else
                    {
                        if (mapa1[fila, col] == "X" || mapa1[fila, col] == "O")
                        {
                            Console.WriteLine("Parece que ya atacaste ese lugar, tratemos con otro");
                        }
                        else if (tablero2[fila, col] == "▨")
                        {
                            Console.WriteLine("ACERTASTE!! Sigue así!!");
                            mapa1[fila, col] = "O";
                            tablero2[fila, col] = "▣";
                            Jugadores.Winner();
                            salida = true;
                        }
                        else
                        {
                            Console.WriteLine("Suerte para la próxima capitán");
                            mapa1[fila, col] = "X";
                            salida = true;
                        }
                        imprimirMapa1();
                        Jugadores.mostrarPuntos1();
                        Console.Write("Pulse cualquier tecla para continuar");
                        Console.ReadKey();
                        Console.Clear();
                    }
                }
                catch
                {
                    Console.WriteLine("Formato inválido. Usa el formato A-1.");
                }
            } while (salida == false);
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine($"Es tu turno jugador 2\tTurnos restantes: {turno2}");
            --turno2;
            Console.WriteLine("Estado actual de tus navíos:");
            Console.ForegroundColor = ConsoleColor.White;
            mostrarTablero2();
            Console.WriteLine("Campo enemigo:");
            imprimirMapa2();
            do
            {
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("❌ Ingresa las coordenadas de ataque capitan!! ❌");
                coordenada2 = Console.ReadLine().ToUpper();
                Principal.condicionSalida();
                try
                {
                    string[] partes = coordenada2.Split('-'); //se dividen los elementos de la coordenada
                    char letraFila = partes[0][0];       // 'A' a 'F'
                    int columna = int.Parse(partes[1]);  // 1 a 6
                    int fila = letraFila - 'A';
                    int col = columna - 1;
                    if (fila < 0 || fila >= 6 || col < 0 || col >= 6)
                    {
                        Console.WriteLine("¡Coordenadas fuera del rango!");
                        continue;
                    }
                    else
                    {
                        if (mapa2[fila, col] == "X" || mapa2[fila, col] == "O")
                        {
                            Console.WriteLine("Parece que ya atacaste ese lugar, tratemos con otro");
                        }
                        else if (tablero1[fila, col] == "▨")
                        {
                            Console.WriteLine("ACERTASTE!! Sigue así!!");
                            mapa2[fila, col] = "O";
                            tablero1[fila, col] = "▣";
                            Jugadores.Winner();
                            salida = false;
                        }
                        else
                        {
                            Console.WriteLine("Suerte para la próxima capitán");
                            mapa2[fila, col] = "X";
                            salida = false;
                        }
                        imprimirMapa2();
                        Jugadores.mostrarPuntos2();
                        Console.Write("Pulse cualquier tecla para continuar");
                        Console.ReadKey();
                        Console.Clear();
                    }
                }
                catch
                {
                    Console.WriteLine("Formato inválido. Usa el formato A-1.");
                }
            } while (salida == true);

        } while (turno1 > 0 && turno2 > 0); //se repite el ataque hasta que los turnos de los jugadores sea 0
        if (turno1 <= 0 && turno2 <= 0) //Condición si los turnos llegan a 0
        {
            Console.WriteLine("¡Parece que ambos capitanes se han quedado sin munición!");
            EvaluarPuntos.verGanador();
        }
    }
    static void imprimirMapa1() //Mapa mostrado como campo enemigo al jugador
    {
        int l = 0;
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("  1 2 3 4 5 6");
        Console.Write("A");
        for (int i = 0; i < 6; i++)
        {
            for (int j = 0; j < 6; j++)
            {
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write(" " + mapa1[i, j]);
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
    }
    static void imprimirMapa2() //Mapa mostrado como campo enemigo
    {
        int l = 0;
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("  1 2 3 4 5 6");
        Console.Write("A");
        for (int i = 0; i < 6; i++)
        {
            for (int j = 0; j < 6; j++)
            {
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write(" " + mapa2[i, j]);
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
    }
    static void mostrarTablero1() //Método para mostrar el estado de los barcos en batalla
    {
        for (int i = 0; i < 6; i++)
        {
            for (int j = 0; j < 6; j++)
            {
                Console.Write(" " + tablero1[i, j]);
            }
            Console.WriteLine("");
        }
    }
    static void mostrarTablero2()
    {
        for (int i = 0; i < 6; i++)
        {
            for (int j = 0;j<6;j++)
            {
                Console.Write(" " + tablero2[i, j]);
            }
            Console.WriteLine("");
        }
    }
}