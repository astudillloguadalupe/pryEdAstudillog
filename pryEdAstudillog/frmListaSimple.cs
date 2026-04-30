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
            clsNodo x = new clsNodo();
            x.Codigo = Convert.ToInt32(txtCodigo1.Text);
            x.Nombre = txtNombre1.Text;
            x.Tramite = txtTramite1.Text;   

            objLista.Agregar(x);
            objLista.Recorrer(lstLista);
            objLista.Recorrer(cmbCodigo);
            objLista.Recorrer(dgvGrilla);

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

        }
    }
}
