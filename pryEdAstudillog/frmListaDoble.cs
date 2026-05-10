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
    public partial class frmListaDoble : Form
    {
        public frmListaDoble()
        {
            InitializeComponent();
        }

        private void txtCodigo_TextChanged(object sender, EventArgs e)
        {
            if (txtCodigo.Text == "")
            {
                txtNombre.Enabled = false;
            }
            else
            {
                txtNombre.Enabled = true;
            }
        }

        private void frmListaDoble_Load(object sender, EventArgs e)
        {

        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {
            if (txtNombre.Text == "")
            {
                txtTramite.Enabled = false;
            }
            else
            {
                txtTramite.Enabled = true;
            }
        }

        private void txtTramite_TextChanged(object sender, EventArgs e)
        {
            if (txtTramite.Text == "")
            {
                btnAgregar.Enabled = false;
            }
            else
            {
                btnAgregar.Enabled = true;
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
           if (objLista.Primero != null)
           {
               int codigo = Convert.ToInt32(cmbCodigo.Text);
               objLista.Eliminar(codigo);
               objLista.Recorrer(dgvGrilla);
               objLista.Recorrer(lstLista);
               objLista.Recorrer(cmbCodigo);
           }
           else
            {
                MessageBox.Show("No hay elementos para eliminar");
            }
        }

        private void cmbCodigo_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        clsListaDoble objLista = new clsListaDoble();

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            clsNodo objNodo = new clsNodo();
            objNodo.Codigo = Convert.ToInt32(txtCodigo.Text);
            objNodo.Nombre = txtNombre.Text;
            objNodo.Tramite = txtTramite.Text;

            objLista.Agregar(objNodo);
            objLista.Recorrer(dgvGrilla);
            objLista.Recorrer(lstLista);
            objLista.Recorrer(cmbCodigo);

            txtCodigo.Text = "";
            txtNombre.Text = "";
            txtTramite.Text = "";
        }

        private void radAsc_CheckedChanged(object sender, EventArgs e)
        {
            objLista.Recorrer(dgvGrilla);
            objLista.Recorrer(lstLista);
            objLista.Recorrer(cmbCodigo);
        }

        private void radDes_CheckedChanged(object sender, EventArgs e)
        {

            objLista.Recorrer(dgvGrilla);
            objLista.Recorrer(lstLista);
            objLista.Recorrer(cmbCodigo);
        }
    }
}
