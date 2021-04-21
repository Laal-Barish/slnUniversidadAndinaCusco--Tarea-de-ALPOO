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
    public partial class frmAsignatura : Form
    {
        public frmAsignatura()
        {
            InitializeComponent();
        }

        //Instanciar la clase a traves de un objeto
        //En esta parte del código se declaran variables globales

        CapaNegocio.Asignatura asignatura1 = new CapaNegocio.Asignatura();

        private void frmAsignatura_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Leer los datos del formulario
            string nombre = txtNombre.Text;
            string aula = txtAula.Text;
            int horas = int.Parse(txtHoras.Text);

            asignatura1.Nombre = nombre;
            asignatura1.Aula = aula;
            asignatura1.Horas = horas;
           
            MessageBox.Show("Se han registrado correctamente los datos de la asignatura 1");
        }

        private void btnExponer_Click(object sender, EventArgs e)
        {
            //Mostrar método u operación Exponer
            MessageBox.Show(asignatura1.Exponer());
        }

        private void btnDebatir_Click(object sender, EventArgs e)
        {
            //Mostrar método u operación Debatir
            MessageBox.Show(asignatura1.Debatir());
        }

        private void btnInvestigar_Click(object sender, EventArgs e)
        {
            //Mostrar método u operación Investigar
            MessageBox.Show(asignatura1.Investigar());
        }

        private void btnEstudiar_Click(object sender, EventArgs e)
        {
            //Mostrar método u operación Estudiar
            MessageBox.Show(asignatura1.Estudiar());
        }

        private void btnEscribir_Click(object sender, EventArgs e)
        {
            //Mostrar los datos almacenados en el objeto 1
            string nombre = asignatura1.Nombre;
            string aula = asignatura1.Aula;
            int horas = asignatura1.Horas;
           
            MessageBox.Show(" Nombre de la asignatura: " + nombre + "  Aula: " + aula +
                "  Horas de clase: " + horas );
        }
    }
    
}
