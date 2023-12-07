using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Consola
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int uno = 270, dos = 340, tres = 390, totalMoneda = 0, cambio = 0;
            int moneda10 = 0, moneda50 = 0, moneda100 = 0;
            int contadorCompraUno = 0, contadorCompraDos = 0, contadorCompraTres = 0;
            int contadorCambioUno = 0, contadorCambioDos = 0, contadorCambioTres = 0;
            bool bandera = true;
            Console.WriteLine("Ingrese su nombre:  ");
            string nombre = Console.ReadLine();
            Console.WriteLine("¡¡¡Bienvenido!!" + nombre);

            while (bandera == true)
            {
                Console.WriteLine("Seleccione un producto: 1- $270.00  2- $340.00  3- $390.00 4- FINALIZAR");
                int op = int.Parse(Console.ReadLine());

                if (op == 1)
                {
                    contadorCompraUno = contadorCompraUno + 1;
                    Console.Write("Introduzca la cantidad de monedas $10: ");
                    moneda10 = int.Parse(Console.ReadLine());
                    moneda10 = moneda10 * 10;
                    Console.Write("Introduzca la cantidad de monedas $50: ");
                    moneda50 = int.Parse(Console.ReadLine());
                    moneda50 = moneda50 * 50;
                    Console.Write("Introduzca la cantidad de monedas $100: ");
                    moneda100 = int.Parse(Console.ReadLine());
                    moneda100 = moneda100 * 100;
                    totalMoneda = moneda10 + moneda50 + moneda100;
                    if (totalMoneda < uno)
                    {
                        Console.WriteLine("No te alcanza para el producto");
                    }
                    else
                    {
                        cambio = totalMoneda - uno;
                        int millares = cambio / 1000;
                        int centenas = (cambio - (millares * 1000)) / 100;
                        int decenas = (cambio - (millares * 1000 + centenas * 100)) / 10;
                        int unidades = cambio - (millares * 1000 + centenas * 100 + decenas * 10);
                        Console.WriteLine("Tu cambio es: " + cambio);
                        Console.WriteLine(millares * 1000);
                        Console.WriteLine(centenas * 100);
                        Console.WriteLine(decenas * 10);
                        Console.WriteLine(unidades);
                        contadorCambioUno = contadorCambioUno + 1;
                    }

                }
                else if (op == 2)
                {
                    contadorCompraDos = contadorCompraDos + 1;
                    Console.WriteLine("Introduzca la cantidad de monedas $10: ");
                    moneda10 = int.Parse(Console.ReadLine());
                    moneda10 = moneda10 * 10;
                    Console.Write("Introduzca la cantidad de monedas $50$: ");
                    moneda50 = int.Parse(Console.ReadLine());
                    moneda50 = moneda50 * 50;
                    Console.Write("Introduzca la cantidad de monedas $100: ");
                    moneda100 = int.Parse(Console.ReadLine());
                    moneda100 = moneda100 * 100;
                    totalMoneda = moneda10 + moneda50 + moneda100;
                    if (totalMoneda < dos)
                    {
                        Console.Write("No te alcanza para el producto");
                    }
                    else
                    {
                        cambio = totalMoneda - dos;
                        int millares = cambio / 1000;
                        int centenas = (cambio - (millares * 1000)) / 100;
                        int decenas = (cambio - (millares * 1000 + centenas * 100)) / 10;
                        int unidades = cambio - (millares * 1000 + centenas * 100 + decenas * 10);
                        Console.WriteLine("Tu cambio es: " + cambio);
                        Console.WriteLine(millares * 1000);
                        Console.WriteLine(centenas * 100);
                        Console.WriteLine(decenas * 10);
                        Console.WriteLine(unidades);
                        contadorCambioUno = contadorCambioUno + 1;
                    }



                }
                else if (op == 3)
                {
                    contadorCompraTres = contadorCompraTres + 1;
                    Console.Write("Introduzca la cantidad de monedas $10: ");
                    moneda10 = int.Parse(Console.ReadLine());
                    moneda10 = moneda10 * 10;
                    Console.Write("Introduzca la cantidad de monedas $50$: ");
                    moneda50 = int.Parse(Console.ReadLine());
                    moneda50 = moneda50 * 50;
                    Console.Write("Introduzca la cantidad de monedas $100: ");
                    moneda100 = int.Parse(Console.ReadLine());
                    moneda100 = moneda100 * 100;
                    totalMoneda = moneda10 + moneda50 + moneda100;
                    if (totalMoneda < tres)
                    {
                        Console.WriteLine("No te alcanza para el producto");
                    }
                    else
                    {
                        cambio = totalMoneda - tres;
                        int millares = cambio / 1000;
                        int centenas = (cambio - (millares * 1000)) / 100;
                        int decenas = (cambio - (millares * 1000 + centenas * 100)) / 10;
                        int unidades = cambio - (millares * 1000 + centenas * 100 + decenas * 10);
                        Console.WriteLine("Tu cambio es: " + cambio);
                        Console.WriteLine(millares * 1000);
                        Console.WriteLine(centenas * 100);
                        Console.WriteLine(decenas * 10);
                        Console.WriteLine(unidades);
                        contadorCambioUno = contadorCambioUno + 1;

                    }
                }

                else
                {
                    bandera = false;
                    int totalCompra = contadorCompraUno + contadorCompraDos + contadorCompraTres;
                    int totalCambio = contadorCambioUno + contadorCompraDos + contadorCompraTres;
                    Console.WriteLine("Total de compras realizadas " + totalCompra);
                    Console.WriteLine("Total de veces de cambio entregado: " + totalCambio);
                    Console.WriteLine();
                    Console.WriteLine("Hasta Luego!!" + nombre);

                }

            }

            Console.ReadKey();

        }


    }
    }

