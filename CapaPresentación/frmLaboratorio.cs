using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentación
{
    public partial class frmLaboratorio : Form
    {
        public frmLaboratorio()
        {
            InitializeComponent();
        }

        //Instanciar la clase a traves de un objeto
        //En esta parte del código se declaran variables globales

        CapaNegocio.Laboratorio laboratorio1 = new CapaNegocio.Laboratorio();


        private void btnInvestigar_Click(object sender, EventArgs e)
        {
            //Mostrar método u operación Investigar
            MessageBox.Show(laboratorio1.Investigar());
        }

        private void btnLeer_Click(object sender, EventArgs e)
        {
            //Leer los datos del formulario
            string tipo = txtTipo.Text;
            string instrumento = txtInstrumento.Text;
            int aforo = int.Parse(txtAforo.Text);
            
            laboratorio1.Tipo = tipo;
            laboratorio1.Instrumento = instrumento;
            laboratorio1.Aforo = aforo;

            MessageBox.Show("Se han registrado correctamente los datos del Laboratorio 1");

        }

        private void btnEscribir_Click(object sender, EventArgs e)
        {
            //Mostrar los datos almacenados en el objeto 1
            string tipo = laboratorio1.Tipo;
            string instrumento = laboratorio1.Instrumento;
            int aforo = laboratorio1.Aforo;

            MessageBox.Show(" Tipo de laboratorio: " + tipo + "  Instrumento: " + instrumento +
                "  Aforo: " + aforo);
        }

        private void btnExperimentar_Click(object sender, EventArgs e)
        {
            //Mostrar método u operación Experimentar
            MessageBox.Show(laboratorio1.Experimentar());
        }

        private void btnAnalizar_Click(object sender, EventArgs e)
        {
            //Mostrar método u operación Analizar
            MessageBox.Show(laboratorio1.Analizar());
        }
    }
}
