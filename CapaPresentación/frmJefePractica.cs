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
    public partial class frmJefePractica : Form
    {
        public frmJefePractica()
        {
            InitializeComponent();
        }

        //Instanciar la clase a traves de un objeto
        //En esta parte del código se declaran variables globales

        CapaNegocio.JefePractica jefePractica1 = new CapaNegocio.JefePractica();

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnLeer_Click(object sender, EventArgs e)
        {
            //Leer los datos del formulario
            string apellidos = txtApellidos.Text;
            string nombres = txtNombres.Text;
            string lugarNacimiento = txtLugarNacimiento.Text;
            string dni = txtDni.Text;
            int edad = int.Parse(txtEdad.Text);
            
            jefePractica1.Apellidos = apellidos;
            jefePractica1.Nombres = nombres;
            jefePractica1.LugarNacimiento = lugarNacimiento;
            jefePractica1.Dni = dni;
            jefePractica1.Edad = edad;


            MessageBox.Show("Se han registrado correctamente los datos del Jefe de Práctica 1");
        }

        private void btnEscribir_Click(object sender, EventArgs e)
        {
            //Mostrar los datos almacenados en el objeto 1
            string apellidos = jefePractica1.Apellidos;
            string nombres = jefePractica1.Nombres;
            string lugarNacimiento = jefePractica1.LugarNacimiento;
            string dni = jefePractica1.Dni;
            int edad = jefePractica1.Edad;
            

            MessageBox.Show(" Apellidos: " + apellidos + "  Nombres: " + nombres +
                "  Lugar de Nacimiento: " + lugarNacimiento + "  Dni: " + dni + " Edad:" + edad);

        }

        private void btnEnseñar_Click(object sender, EventArgs e)
        {
            //Mostrar método u operación Estudiar
            MessageBox.Show(jefePractica1.Enseñar());
        }

        private void btnEvaluar_Click(object sender, EventArgs e)
        {
            //Mostrar método u operación Evaluar
            MessageBox.Show(jefePractica1.Evaluar());
        }

        private void btnRevisar_Click(object sender, EventArgs e)
        {
            //Mostrar método u operación Revisar
            MessageBox.Show(jefePractica1.Revisar());
        }

        private void btnAprobar_Click(object sender, EventArgs e)
        {
            //Mostrar método u operación Aprobar
            MessageBox.Show(jefePractica1.Aprobar());
        }
    }
}
