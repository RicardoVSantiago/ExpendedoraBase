using System;
using System.Threading;

namespace ExpendedoraBase
{
    class Expendedora
    {
        string Marca;
        byte Temperatura;
        string codigo;
        float precio;

        public Expendedora()
        {
            Saludar();
            Marca = "AMS"; 
            Console.WriteLine("Marca: " + Marca);
            ControlarTiempoDisplay();
            Temperatura = 14;
            Console.WriteLine("La Temperatura es: " + Temperatura+ "°C");
            ControlarTiempoDisplay();
            codigo = MostrarCodigoDeProductos();
            MostrarPrecio(codigo);


        }
        void ControlarTiempoDisplay()
        {
            Thread.Sleep(2000);
            Console.Clear();
        }
        void Saludar()
        {
            Console.WriteLine("Bienvenido, padrino");

        }
        string MostrarCodigoDeProductos()
        {
            Console.WriteLine("A1: Kinder Delice \tB2: Takis \tC3:Donitas");
            Console.WriteLine("Ingrese el codigo del produto a que desee:");
            string codigo = Console.ReadLine(); // La variable "codigo" es una variable local 
            return codigo; 
        }
        void MostrarPrecio(string codigo)
        {
            switch (codigo)
            {
                case "A1":
                    Console.WriteLine("El precio es {0}", precio);
                    break;
                case "B2":
                    Console.WriteLine("El precio es {0}", precio);
                    break;
                case "C3":
                    Console.WriteLine("El precio es {0}", precio);
                    break;
                default:
                    Console.WriteLine(" Producto no reconocido, padrino");
                    break;
            }
        }
    }
}
