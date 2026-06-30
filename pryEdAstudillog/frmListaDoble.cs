using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO; //permite trabajar con archivos

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
                if (cmbCodigo.SelectedIndex != -1)
                {
                    int x = Convert.ToInt32(cmbCodigo.SelectedItem);
                    objLista.Eliminar(x);

                    objLista.Recorrer(dgvGrilla);
                    objLista.Recorrer(lstLista);
                    objLista.Recorrer(cmbCodigo);
                }
                else
                {
                    MessageBox.Show("Debe seleccionar un código para eliminar");
                }
            }
            else
            {
                MessageBox.Show("No hay datos para eliminar");
            }
        }

        private void cmbCodigo_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        clsListaDoble objLista = new clsListaDoble();

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (!Int32.TryParse(txtCodigo.Text, out Int32 codigo))
            {
                MessageBox.Show("El código debe ser numérico.");
                txtCodigo.Focus();
                return;
            }

            clsNodo objNodo = new clsNodo();

            objNodo.Codigo = codigo;
            objNodo.Nombre = txtNombre.Text;
            objNodo.Tramite = txtTramite.Text;

            objLista.Agregar(objNodo);

            objLista.Recorrer(lstLista);
            objLista.Recorrer(dgvGrilla);

            txtCodigo.Clear();
            txtNombre.Clear();
            txtTramite.Clear();

            txtCodigo.Focus();


        }

        private void radAsc_CheckedChanged(object sender, EventArgs e)
        {
            objLista.Recorrer(dgvGrilla);
            objLista.Recorrer(lstLista);
            objLista.Recorrer(cmbCodigo);
        }

        private void radDes_CheckedChanged(object sender, EventArgs e)
        {

            objLista.RecorrerDES(dgvGrilla);
            objLista.Recorrer(lstLista);
            objLista.Recorrer(cmbCodigo);
        }
    }
}
