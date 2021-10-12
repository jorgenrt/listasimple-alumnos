using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Registro_alumnos
{
    class Nodo
    {

        private int numero;
        private string matricula;
        private string nombre;
        private string apaterno;
        private string amaterno;
        private string especialidad;
        private int semestre;
        private int promedio;
        private Nodo siguiente;




        public Nodo Siguiente
        {
            get { return siguiente; }
            set { siguiente = value; }
        }

        public int Numero
        {
            get { return numero; }
            set { numero = value; }
        }
        public string Matricula
        {
            get { return matricula; }
            set { matricula = value; }
        }
        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }
        public string Apaterno
        {
            get { return apaterno; }
            set { apaterno = value; }
        }
        public string Amaterno
        {
            get { return amaterno; }
            set { amaterno = value; }
        }
        public string Especialidad
        {
            get { return especialidad; }
            set { especialidad = value; }
        }
        public int Semestre
        {
            get { return semestre; }
            set { semestre = value; }
        }
        public int Promedio
        {
            get { return promedio; }
            set { promedio = value; }
        }

        public Nodo()
        {
            numero = 0;
            matricula = "";
            nombre = "";
            apaterno = "";
            amaterno = "";
            especialidad = "";
            semestre = 0;
            promedio = 0;
        }

        public Nodo(int num, string mat, string nom, string apat, string amat, string esp, int sem)
        {
            numero = num;
            matricula = mat;
            nombre = nom;
            apaterno = apat;
            amaterno = amat;
            especialidad = esp;
            semestre = sem;
           
        }
        public override string ToString()
        {
            return numero + " - " + matricula + " - " + nombre + " - " + apaterno + " - " + amaterno + " - " + especialidad + "-" + semestre;
        }



    }
}
