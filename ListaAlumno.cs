using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Registro_alumnos
{
    class ListaAlumno
    {
        private Nodo head;
        public Nodo Head
        { get { return head; }
            set { head = value; }
        }
        public ListaAlumno()
        {
            head = null;
        }

        //Operaciones
        //Agregar

        public void Agregar(Nodo n)
        {
            //lista vacia
            if (head == null)
            {
                head = n;
                return;
            }
            //no esta vacia
            if (n.Numero < head.Numero)
            {
                //al inicio
                n.Siguiente = head;
                head = n;
                return;
            }
        }

        public void Eliminar(int d)
        {
            //revisat que no esta vacia
            if (head == null)
            {
                return;
            }
            //Si el nodo a eliminar es el primero(head)
            if (head.Numero == d)
            {
                head = head.Siguiente;
                return;
            }
            Nodo h = head;
            while (h.Siguiente != null)
            {
                if (h.Siguiente.Numero == d)
                {
                    break;
                }
                h = h.Siguiente;
            }
            if (h.Siguiente != null)
            {
                h.Siguiente = h.Siguiente.Siguiente;
            }

        }

        public bool Buscar(int d,Nodo b)
        {
            //Revisar que no este vacio
            if (head == null)
            {
                return false;
            }
            //si el nodo a eliminar es el primero(head
            if (head.Numero == d)
            {
                head = head.Siguiente;
                b = head;
                return true;
            }
            Nodo h = head;
            while (h.Siguiente != null)
            {
                if (h.Siguiente.Numero == d)
                {
                    b = h.Siguiente;
                    return true;
                }
                h = h.Siguiente;
            }
            return false;
        }

        public void Mostrar(ListBox lista)
        {
            Nodo h = head;
            lista.Items.Clear();
            while (h != null)
            {
                lista.Items.Add(h.ToString());
                h = h.Siguiente;
            }
        }

        public override string ToString()
        {
            string listaEnTexto = "";
            Nodo h = head;
            while (h != null)
            {
                listaEnTexto += h.Numero + " ";
                h = h.Siguiente;
            }
            return listaEnTexto;
        }
    }
}
