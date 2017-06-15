using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ARBOLES_BINARIOS
{
    public partial class Form1 : Form
    {
        Arbol arbol = new Arbol();

        public Form1()
        {
            InitializeComponent();
        }

        private void btnEvaluar_Click(object sender, EventArgs e)
        {
            string Datos = txtExpresion.Text;
            char[] cadena = Datos.ToCharArray();
            foreach (char ch in cadena)
            {
                Nodo nuevo = new Nodo();
                nuevo._dato = ch;
                arbol.Agregar(nuevo);
            }
            arbol.Evaluar();
            txtPreOrden.Text = arbol.PreOrden();
            txtPostOrden.Text = arbol.PostOrden();
        }

        private void btnPreOrden_Click(object sender, EventArgs e)
        {
            txtResultadoPre.Text=arbol.PreOrden(txtPreOrden.Text);
        }

        private void btnPostOrden_Click(object sender, EventArgs e)
        {
            txtResultadoPost.Text = arbol.PostOrden(txtPostOrden.Text);
        }
    }
}
