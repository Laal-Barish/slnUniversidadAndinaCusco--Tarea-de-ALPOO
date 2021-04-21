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
    public partial class frmPPP : Form
    {
        public frmPPP()
        {
            InitializeComponent();
        }

        //Instanciar la clase a traves de un objeto
        //En esta parte del código se declaran variables globales
        CapaNegocio.PPP pPP1 = new CapaNegocio.PPP();


        private void btnLeer_Click(object sender, EventArgs e)
        {
            //Leer los datos del formulario
            string área = txtÁrea.Text;
            string lugar = txtLugar.Text;
            string turno = txtTurno.Text;
            int horas = int.Parse(txtHoras.Text);
            int subvención = int.Parse(txtSubvención.Text);

            pPP1.Área = área;
            pPP1.Lugar = lugar;
            pPP1.Horas = horas;
            pPP1.Turno = turno;
            pPP1.Subvención = subvención;
            MessageBox.Show("Se han registrado correctamente los datos de la Práctica Pre Profesional 1");
        }

        private void btnEscribir_Click(object sender, EventArgs e)
        {
            //Mostrar los datos almacenados en el objeto 1
            string área = pPP1.Área;
            string lugar = pPP1.Lugar;
            int horas = pPP1.Horas;
            string turno = pPP1.Turno;
            int subvención = pPP1.Subvención;

            MessageBox.Show(" Área: " + área + "  Lugar: " + lugar +  "  Turno:" + turno + "  Horas:" + horas +
                " Subvención: " + subvención);
        }

        private void btnTrabajar_Click(object sender, EventArgs e)
        {
            //Mostrar método u operación Trabajar
            MessageBox.Show(pPP1.Trabajar());
        }

        private void btnAplicar_Click(object sender, EventArgs e)
        {
            MessageBox.Show(pPP1.Aplicar());
        }

        private void btnVer_Click(object sender, EventArgs e)
        {
            //Mostrar método u operación Verr
            MessageBox.Show(pPP1.Ver());
        }

        private void btnAprender_Click(object sender, EventArgs e)
        {
            //Mostrar método u operación Aprenderr
            MessageBox.Show(pPP1.Aprender());
        }
    }
}
