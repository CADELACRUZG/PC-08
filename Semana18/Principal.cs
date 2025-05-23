#pragma warning disable
using System;
using System.Security.Cryptography.X509Certificates;
namespace ACTIVIDAD1_SEMANA18;
internal class Principal
{
    static void Main(string[] args)
    {
        Solicitud.PedirNombres();
        do
        {
            Menu.MenuPrincipal();
        }while(true);
        
    }
}
internal class Solicitud
{
    internal static int NotaAprobada,NotaNoAprobada;
    static string Nombre="";
    internal static double Nota,Promedio=0,Suma=0,PromedioAlumnos=0;
    internal static string[] nombres = new string[10];
    internal static double[,] notas = new double[10,10];
    internal static void PedirNombres()
    {
        Console.WriteLine("Ingrese los nombres y notas correspondientes a cada estudiante");
        NombresNotas();
    }
    internal static void NombresNotas()
    {
        
        for(int i=0;i<notas.GetLength(0);i++)
        {
            Console.WriteLine("Nombre: ");
            Nombre=Console.ReadLine();
            nombres[i]=Nombre;
            int k=1;
            for (int j=0;j<notas.GetLength(1);j++)
            {
                Console.WriteLine("Nota "+ (k++) +":");
                while(true)
                {
                    try
                    {
                        Nota = Convert.ToDouble(Console.ReadLine());
                        notas[i,j]=Nota;
                        break;
                    }
                    catch(FormatException)
                    {
                        Console.WriteLine("Dato invalido, vuelva a intentar");
                    }
                }
            }
        }
    }
    internal static void Opcion1()
    {
        for (int i=0;i<notas.GetLength(0);i++)
        {
            Console.WriteLine(nombres[i]);
            NotaAprobada=0;
            for (int j=0;j<notas.GetLength(1);j++)
            {
                if (notas[i,j]>=65)
                {
                    NotaAprobada++;
                }
            }
            Console.WriteLine("Notas aprobadas: " + NotaAprobada);
        }
    }
    internal static void Opcion2()
    {
        for (int i=0;i<notas.GetLength(0);i++)
        {
            Console.WriteLine(nombres[i]);
            NotaNoAprobada=0;
            for (int j=0;j<notas.GetLength(1);j++)
            {
                if (notas[i,j]<65)
                {
                    NotaNoAprobada++;
                }
            }
            Console.WriteLine("Notas no aprobadas: " + NotaNoAprobada);
        }
    }
    internal static void Opcion3()
    {
        for (int i=0;i<notas.GetLength(0);i++)
        {
            for (int j=0;j<notas.GetLength(1);j++)
            {
                Suma+=notas[i,j];
            }
            Promedio=Suma/10;
            PromedioAlumnos+=Promedio;
        }
        Console.WriteLine("Promedio del grupo: " + PromedioAlumnos/10);
    }
}
class Menu
{
    internal static int Opcion;
    internal static void MenuPrincipal()
    {
        Console.WriteLine("Selecciones una de las siguientes opciones");
        Console.WriteLine("(1) Mostrar nombre y notas aprobadas de cada alumno");
        Console.WriteLine("(2) Mostrar nombre y notas no aprobadas de cada alumno");
        Console.WriteLine("(3) Mostrar el promedio de notas del grupo");
        Console.WriteLine("(4) Salir del programa");
        while(true)
        {
            if(int.TryParse(Console.ReadLine(),out Opcion))
            {
                if(Opcion>=1||Opcion<=4)
                {
                    switch (Opcion)
                    {
                        case 1:
                            Solicitud.Opcion1();
                            break;
                        case 2:
                            Solicitud.Opcion2();
                            break;
                        case 3:
                            Solicitud.Opcion3();
                            break;
                        case 4:
                            Environment.Exit(0);
                            break;
                        default:
                            Console.WriteLine("Opción no encontrada");
                            break;
                    }
                    break;
                }
                else
                {
                    Console.WriteLine("Opción no válida, vuelva a intentar");
                }
            }
            else
            {
                Console.WriteLine("Opción no válida, vuelva a intentar");
            }
        }
    }
}