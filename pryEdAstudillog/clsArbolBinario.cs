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
                if (Nvo.Codigo < P.Codigo)
                    P.Izquierdo = Nvo;
                else
                    P.Derecho = Nvo;
            }
        }

        public void  Recorrer (DataGridView Grilla)
        {
            Grilla.Rows.Clear ();
            if (Raiz != null) InOrdenAsc(Grilla, Raiz);
            
        }
        private void InOrdenAsc (DataGridView dgv, clsNodo R)
        {
            if (R.Izquierdo != null) InOrdenAsc(dgv, R.Izquierdo);
            dgv.Rows.Add(R.Codigo, R.Nombre, R.Tramite);
            if (R.Derecho != null) InOrdenAsc(dgv, R.Derecho);
        }

        public void  Recorrer (ComboBox cmb)
        {
            cmb.Items.Clear ();
            if (Raiz != null) InOrdenAsc(cmb, Raiz);
        }
        private void InOrdenAsc (ComboBox cmb, clsNodo R)
        {
            if (R.Izquierdo != null) InOrdenAsc(cmb, R.Izquierdo);
            cmb.Items.Add(R.Codigo);
            if (R.Derecho != null) InOrdenAsc(cmb, R.Derecho);
        }
        public void Recorrer(clsNodo[] vector, ref int indice)
        {
            indice = 0;

            if (Raiz != null)
                InOrdenAsc(vector, ref indice, Raiz);
        }

        private void InOrdenAsc(clsNodo[] vector, ref int indice, clsNodo R)
        {
            if (R.Izquierdo != null)
                InOrdenAsc(vector, ref indice, R.Izquierdo);

            vector[indice] = R;
            indice++;

            if (R.Derecho != null)
                InOrdenAsc(vector, ref indice, R.Derecho);
        }

        public void PreOrden(DataGridView grilla)
        {
            grilla.Rows.Clear();

            if (Raiz != null)
                PreOrden(grilla, Raiz);
        }
        private void PreOrden(DataGridView grilla, clsNodo R)
        {
            grilla.Rows.Add(R.Codigo, R.Nombre, R.Tramite);

            if (R.Izquierdo != null)
                PreOrden(grilla, R.Izquierdo);

            if (R.Derecho != null)
                PreOrden(grilla, R.Derecho);
        }

        public void PreOrden (TreeView tree)
        {
            tree.Nodes.Clear();

            if (Raiz != null)
            {
                TreeNode nodoPadre = new TreeNode("Árbol");
                tree.Nodes.Add(nodoPadre);

                PreOrden(Raiz, nodoPadre);

                tree.ExpandAll();
            }
        }

        private void PreOrden (clsNodo R, TreeNode nodoTreeView)
        {
            TreeNode nuevoNodo = new TreeNode(R.Codigo.ToString());
            nodoTreeView.Nodes.Add(nuevoNodo);

            if (R.Izquierdo != null)
            {
                PreOrden(R.Izquierdo, nuevoNodo);
            }

            if (R.Derecho != null)
            {
                PreOrden(R.Derecho, nuevoNodo);
            }
        }
        public void PostOrden(DataGridView grilla)
        {
            grilla.Rows.Clear();

            if (Raiz != null)
                PostOrden(grilla, Raiz);
        }

        private void PostOrden(DataGridView grilla, clsNodo R)
        {
            if (R.Izquierdo != null)
                PostOrden(grilla, R.Izquierdo);

            if (R.Derecho != null)
                PostOrden(grilla, R.Derecho);

            grilla.Rows.Add(R.Codigo, R.Nombre, R.Tramite);
        }

        public void Eliminar(int codigo)
        {
            Raiz = EliminarNodo(Raiz, codigo);
        }

        private clsNodo EliminarNodo(clsNodo R, int codigo)
        {
            if (R == null)
            {
                MessageBox.Show("El código no existe en el árbol.");
                return null;
            }

            if (codigo < R.Codigo)
            {
                R.Izquierdo = EliminarNodo(R.Izquierdo, codigo);
            }
            else if (codigo > R.Codigo)
            {
                R.Derecho = EliminarNodo(R.Derecho, codigo);
            }
            else
            {
                if (R.Izquierdo == null && R.Derecho == null)
                    return null;

                if (R.Izquierdo == null)
                    return R.Derecho;

                if (R.Derecho == null)
                    return R.Izquierdo;

                clsNodo sucesor = BuscarMinimo(R.Derecho);

                R.Codigo = sucesor.Codigo;
                R.Nombre = sucesor.Nombre;
                R.Tramite = sucesor.Tramite;

                R.Derecho = EliminarNodo(R.Derecho, sucesor.Codigo);
            }

            return R;
        }

        private clsNodo BuscarMinimo(clsNodo R)
        {
            while (R.Izquierdo != null)
            {
                R = R.Izquierdo;
            }

            return R;
        }
        public void Equilibrar()
        {
            int cantidad = ContarNodos(Raiz);

            if (cantidad <= 1) return;

            clsNodo[] vector = new clsNodo[cantidad];
            int indice = 0;

            InOrdenAsc(vector, ref indice, Raiz);

            Raiz = null;

            InsertarBalanceado(vector, 0, cantidad - 1);
        }

        private int ContarNodos(clsNodo R)
        {
            if (R == null) return 0;

            return 1 + ContarNodos(R.Izquierdo) + ContarNodos(R.Derecho);
        }

        private void InsertarBalanceado(clsNodo[] vector, int inicio, int fin)
        {
            if (inicio > fin) return;

            int medio = (inicio + fin) / 2;

            vector[medio].Izquierdo = null;
            vector[medio].Derecho = null;

            Agregar(vector[medio]);

            InsertarBalanceado(vector, inicio, medio - 1);
            InsertarBalanceado(vector, medio + 1, fin);
        }
    }

}