using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test1
{
    class Laptop : Computadora
    {

        private int memoria;

        public int Memoria
        {
            get { return memoria; }
            set { memoria = value; }
        }

        public Laptop() : base()
        {
            memoria = 0 ;
        }
        public override string ToString()
        {
            return base.ToString() + memoria  + " GB ";
        }
    }
}
    
   