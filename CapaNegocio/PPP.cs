using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class PPP
    {
        //atributos
        private string área;
        private string lugar;
        private int horas;
        private string turno;
        private int subvención;


        //Propiedades
        public string Área
        {
            get { return área; } // lectura del atributo
            set { área = value; } //escritura del atributo

        }

        public string Lugar
        {
            get { return lugar; } // lectura del atributo
            set { lugar = value; } //escritura del atributo

        }

        public int Horas
        {
            get { return horas; } // lectura del atributo
            set { horas = value; } //escritura del atributo

        }

        public string Turno
        {
            get { return turno; } // lectura del atributo
            set { turno = value; } //escritura del atributo

        }

        public int Subvención
        {
            get { return subvención; } // lectura del atributo
            set { subvención = value; } //escritura del atributo

        }

        // métodos u operaciones
        public string Trabajar()
        {
            return "No se ha implementado el método Trabajar";
        }
        public string Aplicar()
        {
            return "No se ha implementado el método Aplicar";
        }

        public string Ver()
        {
            return "No se ha implementado el método Ver";
        }

        public string Aprender()
        {
            return "No se ha implementado el método Aprender";
        }
    }


}

