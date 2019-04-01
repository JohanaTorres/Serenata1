using System;
using System.Collections.Generic;
using BE;
using business;

namespace serenata
{
    class Program
    {
        static void Main(string[] args)
        {


            obtenerDatos datos = new obtenerDatos();
            int ctdaAmi = datos.RandomNumber(1, 20);
            Console.WriteLine(" Los amigos que asisten son " + ctdaAmi);

            factorySerenata serenata =  new factorySerenata();
            int count = 1;
            while (count < ctdaAmi) { 
            ISerenata objAmigo = serenata.CrearObjeto("amigo");
            ISerenata objInstrumento = serenata.CrearObjeto("instrumento");
            serenata.CrearObjeto("serenata");
            Console.WriteLine(objAmigo.crear() + " " + objInstrumento.crear());
                count++;
            }

        }
    }
}
   
