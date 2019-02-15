using System;
using System.Collections.Generic;
using Tarea1.Entidades;


namespace Tarea1
{
    class Program
    {
        static void Main(string[] args)
        {
            LlamadaDepartamental llamadaDepto = new LlamadaDepartamental();
            llamadaDepto.NumeroOrigen = "123";
            llamadaDepto.NumeroDestino = "123";
            llamadaDepto.Franja = 0;
            llamadaDepto.Duracion = 10;
            llamadaDepto.PrecioUno = 1.5;



            LlamadaLocal llamadaLocal = new LlamadaLocal();
            llamadaLocal.NumeroOrigen = "456";
            llamadaLocal.NumeroDestino = "456";
            llamadaLocal.Duracion = 5;
            llamadaLocal.Precio = 0.96;


            LlamadaLocal otraLocal = new LlamadaLocal();
            otraLocal.NumeroOrigen = "789";
            otraLocal.NumeroDestino = "789";
            otraLocal.Duracion = 25;
            otraLocal.Precio = 0.96;


            List<Llamada> llamadasRealizadas = new List<Llamada>();
            llamadasRealizadas.Add(llamadaDepto);
            llamadasRealizadas.Add(llamadaLocal);
            llamadasRealizadas.Add(otraLocal);            


            foreach(Llamada item in llamadasRealizadas){
                if(item is LlamadaLocal){
                    Console.WriteLine("Llamada Local Precio: " + item.CalcularPrecio()+" variable: "+item);
                }else if(item is LlamadaDepartamental){
                    Console.WriteLine("LLamada Departamental Precio" + item.CalcularPrecio() + " variable: "+item);
                }
                
            }

            Console.ReadKey();

        }
    }
}
