using System;
using System.Runtime.Serialization;

namespace BE 
{
    
    public class Amigos : ISerenata
    {
        private string nombre;
        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        public string elemento { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public string crear()
        {
            return "Asiste el amigo: "+ nombre; 
        }
    }
}
