using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class Docente
    {
        //atributos
        private string apellidos;
        private string nombres;
        private DateTime fechaNacimiento;
        private string dni;
        private int edad;

        //propiedades

        public string Apellidos
        {
            get { return apellidos; } // lectura del atributo
            set { apellidos = value; } //escritura del atributo

        }
        public string Nombres
        {
            get { return nombres; }
            set { nombres = value; }
        }

        public DateTime FechaNacimiento
        {
            get { return fechaNacimiento;  }
            set { fechaNacimiento = value; }
        }

        public string Dni
        {
            get { return dni; }
            set { dni = value;  }
        }

        public int Edad
        {
            get { return edad; }
            set { edad = value; }
        }
    

        //métodos u operaciones

        public string Enseñar()
        {
            return "No se ha implementado el método Enseñar";
        }
        public string Desaprobar()
        {
            return "No se ha implementado el método Desaprobar";
        }

        public string Aprobar()
        {
            return "No se ha implementado el método Aprobar";
        }
    }

}
