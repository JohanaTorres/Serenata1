using BE;
using System;
using System.Collections.Generic;
using System.Text;

namespace business
{
    public class obtenerDatos
    {
        
        public int RandomNumber(int min, int max)
        {
            Random random = new Random();
            return random.Next(min, max);
        }

        public string obtenerAmigos(int ini, int fin)
        {
            string nombre = string.Empty;
            int amigo = RandomNumber(ini, fin);
            nombre = nombres[amigo];
            return nombre;
        }

        public string obtenerInstrumento(int ini, int fin)
        {
            string instr = string.Empty;
            int instru = RandomNumber(ini, fin);
            instr = tipoIns[instru];
            return instr;
        }

        Dictionary<int, String> tipoIns = new Dictionary<int, string>
        {
        {1, "violin"},
        {2, "guitarra"},
        {3, "trompeta"},
        {4, "Piano"},
         };

        Dictionary<int, String> nombres = new Dictionary<int, string>
        {
        {1, "Johana"},
        {2, "Leonardo"},
        {3, "Royer"},
        {4, "Kaomy"},
        {5, "Esteban"},
        {6, "Ivan"},
        {7, "Carlos"},
        {8, "Andres"},
        {9, "Maria"},
        {10, "Sofia"},
        {11, "Nestor"},
        {12, "Jorge"},
        {13, "Nicolas"},
        {14, "Javier"},
        {15, "David"},
        {16, "Miguel"},
        {17, "Cesar"},
        {18, "Sergio"},
        {19, "Pablo"},
         };

    }
}
