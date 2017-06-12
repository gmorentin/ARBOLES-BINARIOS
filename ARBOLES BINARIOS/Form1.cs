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
            arbol.Evaluar(txtExpresion.Text);
        }

        private void btnPreOrden_Click(object sender, EventArgs e)
        {
            txtResultadoPre.Text=arbol.PreOrden(txtPreOrden.Text);
        }

        private void btnPostOrden_Click(object sender, EventArgs e)
        {
            txtResultadoPost.Text = arbol.PostOrden2(txtPostOrden.Text);
        }
    }
}
