using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO; //permite trabajar con archivos
using System.Windows.Forms;

namespace pryEdAstudillog
{
    internal class clsListaSimple
    {
        private clsNodo pri;

        public clsNodo Primero //propiedad  de la clase
        {
            get { return pri; }
            set { pri = value; }
        }

        public void Agregar(clsNodo Nuevo)
        {
            if (Primero == null)
            {
                Primero = Nuevo;
            }
            else
            {
               if (Nuevo.Codigo <= Primero.Codigo)
                {
                    Nuevo.Siguiente = Primero;
                    Primero = Nuevo;
                }
                else
                {
                    clsNodo aux = Primero;
                    clsNodo ant = Primero;

                   while (aux.Codigo < Nuevo.Codigo)
                   {
                        ant = aux;
                        aux = aux.Siguiente;
                        if (aux == null)
                        {
                            break;
                        }
                   }
                    aux.Siguiente = Nuevo;
                    Nuevo.Siguiente = aux;
                    
                }
            }
        }

        public void Eliminar(Int32 Codigo)
        {
            if (Primero.Codigo == Codigo)
            {
                Primero = Primero.Siguiente;
            }
            else
            {
                clsNodo aux1 = Primero;
                clsNodo aux2 = Primero;
                while (aux1.Codigo != Codigo)
                {
                    aux2 = aux1;
                    aux1 = aux1.Siguiente;
                }
                aux2.Siguiente = aux1.Siguiente;
            }
        }
        public void Recorrer(DataGridView Grilla)
        {
            clsNodo aux = Primero;
            Grilla.Rows.Clear();

            while (aux != null)
            {
                Grilla.Rows.Add(aux.Codigo, aux.Nombre, aux.Tramite);
                aux = aux.Siguiente;

            }
        }
        public void Recorrer(ListBox lst)
        {
            clsNodo aux = Primero;
            lst.Items.Clear();
            while (aux != null)
            {
                lst.Items.Add(aux.Codigo);
                aux = aux.Siguiente;
            }
        }

        public void Recorrer(String NombreArchivo)
        {

                clsNodo aux = Primero;
                StreamWriter AD = new StreamWriter(NombreArchivo, false, Encoding.UTF8);
                AD.WriteLine("Lista de espera\n");
                AD.WriteLine("Codigo,Nombre,Tramite");

            while (aux != null)
            {
                AD.Write(aux.Codigo);
                AD.Write(";");
                AD.Write(aux.Nombre);
                AD.Write(";");
                AD.WriteLine(aux.Tramite);
                aux = aux.Siguiente;
            }
            AD.Close();

        }

        public void Recorrer(ComboBox cmb)
        {
            clsNodo aux = Primero;
            cmb.Items.Clear();

            while (aux != null)
            {
                cmb.Items.Add(aux.Codigo); // o lo que quieras mostrar
                aux = aux.Siguiente;
            }
        }

    }
}
