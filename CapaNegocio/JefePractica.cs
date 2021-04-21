using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class JefePractica
    {
        //atributos
        private string apellidos;
        private string nombres;
        private int edad;
        private string lugarNacimiento;
        private string dni;

        // propiedades
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
        public int Edad
        {
            get { return edad; }
            set { edad = value; }
        }

        public string LugarNacimiento
        {
            get { return this.lugarNacimiento; }
            set { this.lugarNacimiento = value; }

        }

        public string Dni
        {
            get { return dni; }
            set { dni = value; }
        }

        // métodos u operaciones
        public string Enseñar()
        {
            return "No se ha implementado el método Enseñar";
        }
        public string Evaluar()
        {
            return "No se ha implementado el método Evaluar";
        }

        public string Revisar()
        {
            return "No se ha implementado el método Revisar";
        }

        public string Aprobar()
        {
            return "No se ha implementado el método Aprobar";
        }

    }
}
