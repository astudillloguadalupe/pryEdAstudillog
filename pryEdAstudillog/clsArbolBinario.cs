using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryEdAstudillog
{
    internal class clsArbolBinario
    {
        private clsNodo pri;

        public clsNodo Raiz
        {
            get {  return pri; }
            set { pri = value; }
        }

        public void Agregar (clsNodo Nvo)
        {
            if (Raiz == null)
            {
                Raiz = Nvo;
            }
            else
            {
                clsNodo P = Raiz; //ant
                clsNodo Aux = Raiz;
                while (Aux !=null)
                {
                    P= Aux;
                    if (Nvo.Codigo < Aux.Codigo) Aux = Aux.Izquierdo;
                    else Aux = Aux.Derecho;
                }
                if (Nvo.Codigo < P.Codigo) P = P.Izquierdo = Nvo;
                else P.Derecho = Nvo;
            }
        }

        public void  Recorrer (DataGridView Grilla)
        {
            Grilla.Rows.Clear ();
            InOrdenAsc(Grilla, Raiz);
        }
        private void InOrdenAsc (DataGridView dgv, clsNodo R)
        {
            if (R.Izquierdo != null) InOrdenAsc(dgv, R.Izquierdo);
            dgv.Rows.Add(R.Codigo, R.Nombre, R.Tramite);
            if (R.Derecho != null) InOrdenAsc(dgv, R.Derecho);
        }

        public void  Recorrer (ComboBox lista)
        {
            lista.Items.Clear ();
            InOrdenAsc(lista, Raiz);
        }
        private void InOrdenAsc (ComboBox lst, clsNodo R)
        {
            if (R.Izquierdo != null) InOrdenAsc(lst, R.Izquierdo);
            lst.Items.Add(R.Codigo);
            if (R.Derecho != null) InOrdenAsc(lst, R.Derecho);
        }
    }
}
