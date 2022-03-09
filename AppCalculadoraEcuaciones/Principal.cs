using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppCalculadoraEcuaciones
{
    public partial class Principal : Form
    {
        public Principal()
        {
            InitializeComponent();
        }

        private void arbolToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void arbolToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            GUIArbol gui = new GUIArbol();
            gui.Show();

        }

        private void infoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("presentado por:" + "\n\n" + "Nicolas Sanchez Pacheco" + "\n" + "Luis Miguel Espinosa", "Mesanje", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Desea Salir?", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == System.Windows.Forms.DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void ayudaToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
