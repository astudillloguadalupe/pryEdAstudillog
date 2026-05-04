using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO; //permite trabajar con archivos
using System.Windows.Forms;

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



    }
}
