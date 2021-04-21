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
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {
           
        }

        private void alumnoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Llamar la formulario Alumno
            frmAlumno formulario = new frmAlumno();
            formulario.Show();
        }

        private void docenteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Llamar el formulario Docente
            frmDocente formulario = new frmDocente();
            formulario.Show();
        }

        private void laboratorioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Llamar el formulario Laboratorio
            frmLaboratorio formulario = new frmLaboratorio();
            formulario.Show();
        }

        private void asignaturaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Llamar al formulario Asignatura
            frmAsignatura formulario = new frmAsignatura();
            formulario.Show();
        }

        private void jefedPToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Llamar al formulario JefedP
            frmJefePractica formulario = new frmJefePractica();
            formulario.Show();
        }

        private void rectorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Llamar al formulario Rector
            frmRector formulario = new frmRector();
            formulario.Show();
        }

        private void pPPToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Llamar al formulario PPP
            frmPPP formulario = new frmPPP();
            formulario.Show();
        }

        private void notasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Llamar al formulario Notas
            frmNota formulario = new frmNota();
            formulario.Show();
        }
    }
}
