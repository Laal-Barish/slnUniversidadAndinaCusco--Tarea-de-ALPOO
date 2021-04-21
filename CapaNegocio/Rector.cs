using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class Rector
    {
        //atributos
        private string apellidos;
        private string nombres;
        private DateTime fechaNacimiento;
        private string dni;
        
        private string profesión;
        private int añosExperiencia;

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
            get { return fechaNacimiento; }
            set { fechaNacimiento = value; }
        }

        public string Dni
        {
            get { return dni; }
            set { dni = value; }
        }

       
        public string Profesión
        {
            get { return profesión; }
            set { profesión = value; }
        }

        public int AñosExperiencia
        {
            get { return añosExperiencia; }
            set { añosExperiencia = value; }
        }

        //métodos u operaciones

        public string Representar()
        {
            return "No se ha implementado el método Representar";
        }
        public string Evaluar()
        {
            return "No se ha implementado el método Evaluar";
        }

        public string Autorizar()
        {
            return "No se ha implementado el método Autorizar";
        }

        public string Administrar()
        {
            return "No se ha implementado el método Administrar";
        }

        public string Reglamentar()
        {
            return "No se ha implementado el método Reglamentar";
        }

        public string Dirigir()
        {
            return "No se ha implementado el método Dirigir";
        }

        public string Presidir()
        {
            return "No se ha implementado el método Presidir";
        }
    }
}
