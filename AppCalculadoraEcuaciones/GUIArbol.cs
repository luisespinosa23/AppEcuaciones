using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AppCalculadoraEcuaciones.Servicio;
using AppCalculadoraEcuaciones.Estructura;

namespace AppCalculadoraEcuaciones
{
    public partial class GUIArbol : Form
    {
        Nodo raiz = null;

        public GUIArbol()
        {
            InitializeComponent();
        }

        private void buttonPrueba_Click(object sender, EventArgs e)
        {
            String ecuacion = txtResp.Text.ToString();
            raiz = Servicios.generarArbol(ecuacion);
            Servicios.resolverEcuacion(raiz);
         
        }

        private void buttonPre_Click(object sender, EventArgs e)
        {
            String ecuacion = textBoxEcuacion.Text.Replace(" ", "");
            raiz = Servicios.generarArbol(ecuacion);
            string cad = "";
            cad = Servicios.recorrerArbolPREO(raiz, cad);
            textBoxPre.Text = cad;
        }

        private void buttonIn_Click(object sender, EventArgs e)
        {
            String ecuacion = textBoxEcuacion.Text.Replace(" ", "");
            raiz = Servicios.generarArbol(ecuacion);
            string cad = "";
            cad = Servicios.recorrerArbolINT(raiz, cad);
            textBoxIn.Text = cad;
        }

        private void buttonPos_Click(object sender, EventArgs e)
        {
            String ecuacion = textBoxEcuacion.Text.Replace(" ", "");
            raiz = Servicios.generarArbol(ecuacion);
            string cad = "";
            cad = Servicios.recorrerArbolPOSI(raiz, cad);
            textBoxPos.Text = cad;
        }
    }
}
