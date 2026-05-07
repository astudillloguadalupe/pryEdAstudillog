using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO; //permite trabajar con archivos
using System.Windows.Forms;
using System.Reflection;

namespace pryEdAstudillog
{
    
    internal class clsListaDoble
    {
        private clsNodo pri;
        private clsNodo ult;

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
    

         public void Agregar(clsNodo Nvo)
         {
            if (Primero == null)
            {
                Primero = Nvo;
                Ultimo = Nvo;
            }
            else
            {
                if (Nvo.Codigo> Ultimo.Codigo)
                {
                    Ultimo.Siguiente = Nvo;
                    Nvo.Anterior = Ultimo;
                    Ultimo= Nvo;
                }
                else
                {
                    clsNodo aux = Primero;
                    clsNodo ant = Primero;
                    while (aux.Codigo < Nvo.Codigo)
                    {
                        ant = aux;
                        aux = aux.Siguiente;
                    }
                    ant.Siguiente = aux;
                    Nvo.Anterior = ant;
                    Nvo.Siguiente = aux;
                    aux.Anterior = Nvo;
                }
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

        public void RecorrerDES(DataGridView Grilla)
        {
            clsNodo aux = Ultimo;
            Grilla.Rows.Clear();

            while (aux != null)
            {
                Grilla.Rows.Add(aux.Codigo, aux.Nombre, aux.Tramite);
                aux = aux.Anterior;

            }
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
        public void Eliminar(Int32 Codigo)
        {
            if (Primero.Codigo == Codigo && Ultimo == Primero)
            {
                Primero = null;
                Primero.Anterior = null;
            }
            else
            {
                if (Primero.Codigo ==Codigo)
                {
                    Primero = Primero.Siguiente;
                    Primero.Anterior = null;

                }
                else
                {
                    if (Ultimo.Codigo == Codigo)
                    {
                        Ultimo = Ultimo.Anterior;
                        Ultimo.Siguiente = null;
                    }
                    else
                    {
                         clsNodo aux = Primero;
                         clsNodo ant = Primero;
                         while (aux.Codigo > Codigo)
                         {
                            ant = aux;
                            aux = aux.Siguiente;
                         }
                         aux = aux.Siguiente;
                         ant.Siguiente = aux;
                         aux.Anterior = ant;
                        
                    }

                }
                
               
            }
        }
    }
}
