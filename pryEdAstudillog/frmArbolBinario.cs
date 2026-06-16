using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryEdAstudillog
{
    public partial class frmArbolBinario : Form
    {
        public frmArbolBinario()
        {
            InitializeComponent();
        }

        private void frmArbolBinario_Load(object sender, EventArgs e)
        {
            Arbol.Recorrer(dgvGrilla);
        }

        clsArbolBinario Arbol = new clsArbolBinario();
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            clsNodo x = new clsNodo();
            x.Codigo= Convert.ToInt32(txtCodigo.Text);
            x.Nombre = txtNombre.Text;
            x.Tramite = txtTramite.Text;

            Arbol.Agregar(x);
            Arbol.Recorrer(dgvGrilla);
            Arbol.Recorrer(cmbCodigo);
            Arbol.PreOrden(trvArbol);

            txtCodigo.Clear();
            txtNombre.Clear();
            txtTramite.Clear();
            txtCodigo.Focus();
        }

        private void radInOrden_CheckedChanged(object sender, EventArgs e)
        {
            if (radInOrden.Checked)
                Arbol.Recorrer(dgvGrilla);
        }

        private void radPreOrden_CheckedChanged(object sender, EventArgs e)
        {
            if (radPreOrden.Checked)
                Arbol.PreOrden(dgvGrilla);
        }

        private void radPostOrden_CheckedChanged(object sender, EventArgs e)
        {
            if (radPostOrden.Checked)
                Arbol.PostOrden(dgvGrilla);
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {

            if (cmbCodigo.SelectedIndex == -1)
            {
                MessageBox.Show(
                    "Seleccione un elemento de la lista para poder eliminarlo.",
                    "Atención",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }

            int cod = Convert.ToInt32(cmbCodigo.SelectedItem);

            Arbol.Eliminar(cod);

            Arbol.Recorrer(dgvGrilla);
            Arbol.Recorrer(cmbCodigo);
            Arbol.PreOrden(trvArbol);

            MessageBox.Show(
                "Nodo eliminado correctamente.",
                "Eliminar nodo",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }

        private void btnEquilibrar_Click(object sender, EventArgs e)
        {
            if (Arbol.Raiz == null)
            {
                MessageBox.Show("El árbol está vacío.");
                return;
            }

            Arbol.Equilibrar();

            Arbol.Recorrer(dgvGrilla);
            Arbol.Recorrer(cmbCodigo);
            Arbol.PreOrden(trvArbol);
        }
    }

}
