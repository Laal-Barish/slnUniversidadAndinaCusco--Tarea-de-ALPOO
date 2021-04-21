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
    public partial class frmRector : Form
    {
        public frmRector()
        {
            InitializeComponent();
        }

        //Instanciar la clase a traves de un objeto
        //En esta parte del código se declaran variables globales

        CapaNegocio.Rector rector = new CapaNegocio.Rector();


        private void btnLeer_Click(object sender, EventArgs e)
        {
            //Leer los datos del formulario
            string apellidos = txtApellidos.Text;
            string nombres = txtNombres.Text;
            DateTime fechaNacimiento = dtFechaNacimiento.Value; //el tuyo
            string dni = txtDni.Text;
            int añosExperiencia = int.Parse(txtAñosExperiencia.Text);
            string profesión = txtProfesión.Text;

            rector.Apellidos = apellidos;
            rector.Nombres = nombres;
            rector.FechaNacimiento = fechaNacimiento;
            rector.Dni = dni;
            rector.AñosExperiencia = añosExperiencia;
            rector.Profesión = profesión;


            MessageBox.Show("Se han registrado correctamente los datos del Rector");
        }

        private void btnEscribir_Click(object sender, EventArgs e)
        {
            //Mostrar los datos almacenados en el objeto 1
            string apellidos = rector.Apellidos;
            string nombres = rector.Nombres;
            DateTime fechaNacimiento = rector.FechaNacimiento;
            string dni = rector.Dni;
            int añosExperiencia = rector.AñosExperiencia;

            MessageBox.Show(" Apellidos: " + apellidos + "  Nombres: " + nombres +
                "  Fecha de Nacimiento: " + fechaNacimiento + "  Dni: " + dni + "  Años de experiencia:" + añosExperiencia);

        }

        private void btnRepresentar_Click(object sender, EventArgs e)
        {
            //Mostrar método u operación Representar
            MessageBox.Show(rector.Representar());
        }

        private void btnEvaluar_Click(object sender, EventArgs e)
        {
            //Mostrar método u operación Evaluar
            MessageBox.Show(rector.Evaluar());
        }

        private void btnAdministrar_Click(object sender, EventArgs e)
        {
            //Mostrar método u operación Administrar
            MessageBox.Show(rector.Administrar());
        }

        private void btnAutorizar_Click(object sender, EventArgs e)
        {
            //Mostrar método u operación Autorizar
            MessageBox.Show(rector.Autorizar());
        }

        private void btnReglamentar_Click(object sender, EventArgs e)
        {
            //Mostrar método u operación Reglamentar
            MessageBox.Show(rector.Reglamentar());
        }

        private void btnDirigir_Click(object sender, EventArgs e)
        {
            //Mostrar método u operación Dirigir
            MessageBox.Show(rector.Dirigir());
        }

        private void btnPresidir_Click(object sender, EventArgs e)
        {
            //Mostrar método u operación Presidir
            MessageBox.Show(rector.Presidir());
        }
    }
}
