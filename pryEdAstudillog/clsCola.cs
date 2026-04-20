using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Permissions;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.IO; //permite trabajar con archivos
using System.Windows.Forms;

namespace pryEdAstudillog
{
    internal class clsCola
    {
        //Campos de la clase 
        private clsNodo pri;
        private clsNodo ult;

        //propiedades de la clase 

        public clsNodo Primero
        {
            get { return pri; }
            set { pri = value; }
        }
        public clsNodo Ultimo
        {
            get { return ult; }
            set { ult = value; }
        }

        public void Agregar (clsNodo Nuevo)
        {
            if (Primero == null)
            {
                Primero = Nuevo;
                Ultimo = Nuevo;
            }
            else
            {
                Ultimo.Siguiente = Nuevo;
                Ultimo = Nuevo;
            }
        }

        public void Eliminar ()
        {
            if(Primero == Ultimo)
            {
                Primero = null;
                Ultimo = null;
            }
            else
            {
                Primero = Primero.Siguiente;
            }
        }

        public void Recorrer (DataGridView Grilla)
        {
            clsNodo aux = Primero;
            Grilla.Rows.Clear ();

            while (aux != null)
            {
                Grilla.Rows.Add(aux.Codigo, aux.Nombre, aux.Tramite);
                aux = aux.Siguiente;

            }
        }

        public void Recorrer (ListBox lst)
        {
            
        }


    }
}