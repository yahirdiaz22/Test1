using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test1
{
    public class Computadora : Dispositivo
    {
        private int año;

        public int Año
        {
            get { return año; }
            set { año = value; }
        }

        public Computadora() : base()
        {
            año = 0 ;
        }
        public override string ToString()
        {
            return base.ToString()  + año ;
        }
    }
}




