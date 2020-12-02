using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test1
{
    public class Dispositivo
    {
        public string marca;

        public string Marca
        {
            get { return marca; }
            set { marca = value; }
        }

        public Dispositivo() 
        {
            marca = "";
        }
        public override string ToString()
        {
            return marca + " ";
        }

    }
}
