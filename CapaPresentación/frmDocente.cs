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
    public partial class frmDocente : Form
    {
        public frmDocente()
        {
            InitializeComponent();
        }

        //Instanciar la clase a traves de un objeto
        //En esta parte del código se declaran variables globales
        CapaNegocio.Docente docente1 = new CapaNegocio.Docente();

        
        private void button1_Click(object sender, EventArgs e)
        {
            //Leer los datos del formulario
            string apellidos = txtApellidos.Text;
            string nombres = txtNombres.Text;
            DateTime fechaNacimiento = dtFechaNacimiento.Value; //el tuyo
            string dni = txtDni.Text;
            int edad = int.Parse(txtEdad.Text);
            docente1.Apellidos = apellidos;
            docente1.Nombres = nombres;
            docente1.FechaNacimiento = fechaNacimiento;
            docente1.Dni = dni;
            docente1.Edad = edad;
            

            MessageBox.Show("Se han registrado coreectamente los datos del Docente 1");
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtApellidos_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnEscribir_Click(object sender, EventArgs e)
        {
            //Mostrar los datos almacenados en el objeto 1
            string apellidos = docente1.Apellidos;
            string nombres = docente1.Nombres;
            DateTime fechaNacimiento = docente1.FechaNacimiento;
            string dni = docente1.Dni;
            int edad = docente1.Edad;
         
            MessageBox.Show(" Apellidos: " + apellidos + "  Nombres: " + nombres +
                "  Fecha de Nacimiento: " +fechaNacimiento + "  Dni: " + dni + " Edad:" + edad );
        }

        private void btnAprobar_Click(object sender, EventArgs e)
        {
            //Mostrar método u operación Aprobar
            MessageBox.Show(docente1.Aprobar());
        }

        private void btnDesaprobar_Click(object sender, EventArgs e)
        {
            //Mostrar método u operación Desaprobar
            MessageBox.Show(docente1.Desaprobar());
        }

        private void btnEnseñar_Click(object sender, EventArgs e)
        {
            //Mostrar método u operación Eenseñar
            MessageBox.Show(docente1.Enseñar());
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void txtEdad_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
