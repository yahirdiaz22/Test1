using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Test1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Dispositivo computadora = new Dispositivo();
        Computadora portatil = new Computadora();
        Laptop HP = new Laptop();
        private void button1_Click(object sender, EventArgs e)
        {
            Dispositivo d;
            d = new Dispositivo();
            d.Marca = " Computadora ";
            MessageBox.Show(d.ToString());
        }

        private void btnComputadora_Click(object sender, EventArgs e)
        {
            Computadora c;
            c = new Computadora();
            c.Marca = "Lenovo";
            c.Año = 2018;
            MessageBox.Show(c.ToString());
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Laptop l;
            l = new Laptop();
            l.Marca = "HP";
            l.Año = 2019;
            l.Memoria = 16;
            MessageBox.Show(l.ToString());

        }
    }
}
