namespace CODIGO1;
using System;
using Codigo1;
class Jugadores : Tableros
{
    //atributos de la clase
    public static int punteoJ1, punteoJ2;
    //metodo del ganador
    static void miGanador()
    {
        switch (numeroMapa1) //se evalúan las posibles ubicaciones de los barcos para la validación de puntos del jugador
        {
            case 1:
                if (tablero1[5, 0] == "▣" && tablero1[5, 1] == "▣")
                {
                    barco1 = Math.Min(barco1 + 2, 2); //esto es por medida precautoria de que cada vez que evalúe la ubicación no vuelva a sumar otros 2
                }
                if (tablero1[0, 2] == "▣" && tablero1[1, 2] == "▣" && tablero1[2, 2] == "▣" && tablero1[3, 2] == "▣")
                {
                    barco2 = Math.Min(barco2 + 4, 4);
                }
                if (tablero1[5, 3] == "▣" && tablero1[4, 3] == "▣" && tablero1[3, 3] == "▣")
                {
                    barco3 = Math.Min(barco3 + 3, 3);
                }
                punteoJ2 = barco1 + barco2 + barco3;
                break;
            case 2:
                if (tablero1[3, 4] == "▣" && tablero1[3, 5] == "▣")
                {
                    barco1 = Math.Min(barco1 + 2, 2);
                }
                if (tablero1[0, 2] == "▣" && tablero1[0, 3] == "▣" && tablero1[0, 4] == "▣" && tablero1[0, 5] == "▣")
                {
                    barco2 = Math.Min(barco2 + 4, 4);
                }
                if (tablero1[5, 0] == "▣" && tablero1[4, 0] == "▣" && tablero1[3, 0] == "▣")
                {
                    barco3 = Math.Min(barco3 + 3, 3);
                }
                punteoJ2 = barco1 + barco2 + barco3;
                break;
            case 3:
                if (tablero1[0, 4] == "▣" && tablero1[0, 5] == "▣")
                {
                    barco1 = Math.Min(barco1 + 2, 2);
                }
                if (tablero1[3, 0] == "▣" && tablero1[3, 1] == "▣" && tablero1[3, 2] == "▣" && tablero1[3, 3] == "▣")
                {
                    barco2 = Math.Min(barco2 + 4, 4);
                }
                if (tablero1[5, 5] == "▣" && tablero1[4, 5] == "▣" && tablero1[3, 5] == "▣")
                {
                    barco3 = Math.Min(barco3 + 3, 3);
                }
                punteoJ2 = barco1 + barco2 + barco3;
                break;
            case 4:
                if (tablero1[1, 0] == "▣" && tablero1[1, 1] == "▣")
                {
                    barco1 = Math.Min(barco1 + 2, 2);
                }
                if (tablero1[1, 3] == "▣" && tablero1[2, 3] == "▣" && tablero1[3, 3] == "▣" && tablero1[4, 3] == "▣")
                {
                    barco2 = Math.Min(barco2 + 4, 4);
                }
                if (tablero1[0, 5] == "▣" && tablero1[1, 5] == "▣" && tablero1[2, 5] == "▣")
                {
                    barco3 = Math.Min(barco3 + 3, 3);
                }
                punteoJ2 = barco1 + barco2 + barco3;
                break;
        } 
        switch (numeroMapa2)
        {
            case 1:
                if (tablero2[3, 2] == "▣" && tablero2[3, 3] == "▣")
                {
                    barco11 = Math.Min(barco11 + 2, 2);
                }
                if (tablero2[1, 2] == "▣" && tablero2[1, 3] == "▣" && tablero2[1, 3] == "▣" && tablero2[1, 4] == "▣")
                {
                    barco22 = Math.Min(barco22 + 4, 4);
                }
                if (tablero2[2, 5] == "▣" && tablero2[3, 5] == "▣" && tablero2[4, 5] == "▣")
                {
                    barco33 = Math.Min(barco33 + 3, 3);
                }
                punteoJ1 = barco11 + barco22 + barco33;
                break;
            case 2:
                if (tablero2[0, 2] == "▣" && tablero2[0, 3] == "▣")
                {
                    barco11 = Math.Min(barco11 + 2, 2);
                }
                if (tablero2[3, 0] == "▣" && tablero2[3, 1] == "▣" && tablero2[3, 2] == "▣" && tablero2[3, 3] == "▣")
                {
                    barco22 = Math.Min(barco22 + 4, 4);
                }
                if (tablero2[2, 5] == "▣" && tablero2[3, 5] == "▣" && tablero2[4, 5] == "▣")
                {
                    barco33 = Math.Min(barco33 + 3, 3);
                }
                punteoJ1 = barco11 + barco22 + barco33;
                break;
            case 3:
                if (tablero2[4, 2] == "▣" && tablero2[4, 3] == "▣")
                {
                    barco11 = Math.Min(barco11 + 2, 2);
                }
                if (tablero2[1, 4] == "▣" && tablero2[2, 4] == "▣" && tablero2[3, 4] == "▣" && tablero2[4, 4] == "▣")
                {
                    barco22= Math.Min(barco22 + 4, 4);
                }
                if (tablero2[1, 0] == "▣" && tablero2[2, 0] == "▣" && tablero2[3, 0] == "▣")
                {
                    barco33 = Math.Min(barco33 + 3, 3);
                }
                punteoJ1 = barco11 + barco22 + barco33;
                break;
            case 4:
                if (tablero2[5, 4] == "▣" && tablero2[5, 5] == "▣")
                {
                    barco11 = Math.Min(barco11 + 2, 2);
                }
                if (tablero2[0, 0] == "▣" && tablero2[1, 0] == "▣" && tablero2[2, 0] == "▣" && tablero2[3, 0] == "▣")
                {
                    barco22 = Math.Min(barco22 + 4, 4);
                }
                if (tablero2[1, 3] == "▣" && tablero2[2, 3] == "▣" && tablero2[3, 3] == "▣")
                {
                    barco33 = Math.Min(barco33 + 3, 3);
                }
                punteoJ1 = barco11 + barco22 + barco33;
                break;
        }
    }
    public static void Winner()
    {
        miGanador();
        if (punteoJ1 >= 9)
        {
            ElGanador.gana1();
            Console.WriteLine("Muchas veces la estrategia puede llegar a vencer la fuerza bruta... ☠️");
            Environment.Exit(0);
        }
        else if (punteoJ2 >= 9)
        {
            ElGanador.gana2();
            Console.WriteLine("Muchas veces la estrategia puede llegar a vencer la fuerza bruta... ☠️");
            Environment.Exit(0);
        }
    }
    public static void mostrarPuntos1()
    {
        Console.WriteLine("Punteo actual: " + punteoJ1);
    }
    public static void mostrarPuntos2()
    {
        Console.WriteLine("Punteo actual: " + punteoJ2);
    }
}
class EvaluarPuntos : Jugadores
{
    public static void verGanador()
    {
        if (punteoJ1 > punteoJ2) //mostrar mensaje si el jugador 1 tiene más puntos que el jugador 2 al final del juego
        {
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            ElGanador.gana1();
            Console.WriteLine("Ha ganado con " + punteoJ1 + " puntos");
        }
        else if (punteoJ1 < punteoJ2) //mostrar mensaje si el jugador 2 tiene más puntos que el jugador 1 al final del juego
        {
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            ElGanador.gana2();
            Console.WriteLine("Ha ganado con " + punteoJ2 + " puntos");
        }
        else //mensaje a mostrar en caso que haya empate
        {
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine("🤕 Ambos capitanes parecen tener los mismos daños al final... 🤕");
            Console.WriteLine("No se ganó esta batalla, pero no será la última...");
        }

    }

}
class ElGanador : Principal
{
    public static void gana1()
    {
        Console.WriteLine("GANA " + jugador1 + " ¡felicidades!");
    }
    public static void gana2()
    {
        Console.WriteLine("GANA " + jugador2 + " ¡felicidades!");
    }
}