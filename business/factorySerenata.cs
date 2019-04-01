using BE;
using System;
using System.Collections.Generic;
using System.Text;

namespace business
{
    public class factorySerenata
    {
        public ISerenata CrearObjeto(string elemento)
        {
            ISerenata serenata;
            obtenerDatos datos = new obtenerDatos();
            switch (elemento)
            {
                case "amigo":
                    
                    serenata = new Amigos() {Nombre=datos.obtenerAmigos(1,20)};
                    break;
                case "instrumento":
                    serenata = new Instrumentos() { Instrumento = datos.obtenerInstrumento(1, 4) };
                    break;
                default:
                    serenata = null;
                    break;
            }
            return serenata;
        }
    }
}
