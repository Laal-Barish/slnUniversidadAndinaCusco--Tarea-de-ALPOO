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
    public partial class frmNota : Form
    {
        public frmNota()
        {
            InitializeComponent();
        }

        //Instanciar la clase a traves de un objeto
        //En esta parte del código se declaran variables globales
        CapaNegocio.Nota nota1 = new CapaNegocio.Nota();

        private void btnLeer_Click(object sender, EventArgs e)
        {
            //Leer los datos del formulario
            string nivel = txtNivel.Text;
            int calificación = int.Parse(txtCalificación.Text);
            string instrumento = txtInstrumento.Text;
            
            nota1.Nivel = nivel;
            nota1.Instrumento = instrumento;
            nota1.Calificación = calificación;

            MessageBox.Show("Se han registrado correctamente los datos de la Nota 1");
        }

        private void btnDesaprobar_Click(object sender, EventArgs e)
        {
            MessageBox.Show(nota1.Desaprobar());
        }

        private void btnAprobar_Click(object sender, EventArgs e)
        {
            MessageBox.Show(nota1.Aprobar());
        }

        private void btnEscribir_Click(object sender, EventArgs e)
        {
            //Mostrar los datos almacenados en el objeto 1
            string nivel = nota1.Nivel;
            string instrumento = nota1.Instrumento;
            int calificación = nota1.Calificación;

            MessageBox.Show(" Nivel de conocimientos:" + nivel + "  Calificación:" + calificación +
                "  Instrumento de calificación:" + instrumento);

        }
    }
}
