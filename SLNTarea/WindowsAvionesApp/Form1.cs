using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TareaAviones.Models.Base;
using TareaAviones.Models;

namespace WindowsAvionesApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

       

        private void btnCrearAvionComercial_Click(object sender, EventArgs e)
        {
            Avion avion = new Comercial("Pepe Gomez", "Pedro Silva", "Florencia Perez", 250, "American Airlines");
            MessageBox.Show(avion.ToString());

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Avion avion = new Comercial("Pepe Gomez", "Pedro Silva", "Florencia Perez", 250, "American Airlines");
            MessageBox.Show(avion.Despega());

        }

        private void button5_Click(object sender, EventArgs e)
        {
            Avion avion = new Comercial("Pepe Gomez", "Pedro Silva", "Florencia Perez", 250, "American Airlines");
            MessageBox.Show(avion.Aterriza());
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Avion avion = new Comercial("Pepe Gomez", "Pedro Silva", "Florencia Perez", 250, "American Airlines");
            MessageBox.Show(avion.ToString());
        }

        private void btnCrearAvionCarga_Click(object sender, EventArgs e)
        {
            Avion avion = new Carga("Pepe Gomez", "Pedro Silva", "Florencia Perez", 150, "Electronicos");
            MessageBox.Show(avion.ToString());
        }

        private void btnDespegaCarga_Click(object sender, EventArgs e)
        {
            Avion avion = new Carga("Pepe Gomez", "Pedro Silva", "Florencia Perez", 150, "Electronicos");
            MessageBox.Show(avion.Despega());
        }

        private void btnAterrizaCarga_Click(object sender, EventArgs e)
        {
            Avion avion = new Carga("Pepe Gomez", "Pedro Silva", "Florencia Perez", 150, "Electronicos");
            MessageBox.Show(avion.Aterriza());
        }

        private void btnStringCarga_Click(object sender, EventArgs e)
        {
            Avion avion = new Carga("Pepe Gomez", "Pedro Silva", "Florencia Perez", 150, "Electronicos");
            MessageBox.Show(avion.ToString());
        }
    }
}
