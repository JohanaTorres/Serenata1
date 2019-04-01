using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class Instrumentos : ISerenata
    {
        private string instrumento;
        public string Instrumento
        {
            get { return instrumento; }
            set { instrumento = value; }
        }

        public string elemento { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public string crear()
        {
            return "Es el " +this.instrumento;
        }
    }
}
