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
    public partial class frmListaSimple : Form
    {
        public frmListaSimple()
        {
            InitializeComponent();
        }

        private void txtCodigo1_TextChanged(object sender, EventArgs e)
        {
            if (txtCodigo1.Text == "")
            {
                txtNombre1.Enabled = false;
            }
            else
            {
                txtNombre1.Enabled= true;
            }
        }

        private void txtNombre1_TextChanged(object sender, EventArgs e)
        {
            if (txtNombre1.Text == "")
            {
                txtTramite1.Enabled = false;
            }
            else
            {
                txtTramite1.Enabled = true;
            }
        }

        private void txtTramite1_TextChanged(object sender, EventArgs e)
        {
            if (txtTramite1.Text == "")
            {
                btnAgregar.Enabled = false;
            }
            else
            {
                btnAgregar.Enabled = true;
            }
        }
         clsListaSimple objLista = new clsListaSimple();
        private void btnAgregar_Click(object sender, EventArgs e)
        {

            if (!Int32.TryParse(txtCodigo1.Text, out Int32 codigo))
            {
                MessageBox.Show("El código debe ser numérico.");
                txtCodigo1.Focus();
                return;
            }

            clsNodo x = new clsNodo();

            x.Codigo = codigo;
            x.Nombre = txtNombre1.Text;
            x.Tramite = txtTramite1.Text;

            objLista.Agregar(x);

            objLista.Recorrer(lstLista);
            objLista.Recorrer(cmbCodigo);
            objLista.Recorrer(dgvGrilla);

            txtCodigo1.Clear();
            txtNombre1.Clear();
            txtTramite1.Clear();

            txtCodigo1.Focus();

        }


        private void cmbCodigo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cmbCodigo.SelectedIndex == -1)
            {
                btnEliminar.Enabled = false;
            }
            else            
            {
                btnEliminar.Enabled = true;
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (objLista.Primero != null)
            {
                Int32 x = Convert.ToInt32(cmbCodigo.Text);

                objLista.Eliminar(x);
                objLista.Recorrer(dgvGrilla);
                objLista.Recorrer(lstLista);
                objLista.Recorrer(cmbCodigo);
            }
            else
            {
                MessageBox.Show("La lista esta vacio");
            }
            btnEliminar.Enabled = false;
        }

        private void frmListaSimple_Load(object sender, EventArgs e)
        {

        }
    }
}
