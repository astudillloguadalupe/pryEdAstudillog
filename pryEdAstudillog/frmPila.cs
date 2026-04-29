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
    public partial class frmPila : Form
    {
        public frmPila()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

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

        private void frmPila_Load(object sender, EventArgs e)
        {

        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {
            if (txtNombre.Text=="")
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
            if (txtTramite.Text=="")
            {
                btnAgregar.Enabled = false; 
            }
            else
            {
                btnAgregar.Enabled= true;
            }
        }

        clsPila objPila = new clsPila();
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            clsNodo x = new clsNodo();
            x.Codigo = Convert.ToInt32(txtCodigo.Text);
            x.Nombre = txtNombre.Text;
            x.Tramite = txtTramite.Text;

            objPila.Agregar(x);
            objPila.Recorrer(dgvPila);
            objPila.Recorrer(lstPila);
            objPila.Recorrer("Pila.csv");

            txtCodigo.Text = "";
            txtNombre.Text = "";
            txtTramite.Text = "";
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (objPila.Primero != null)
            {
                lblCodigoRTA.Text = Convert.ToString(objPila.Primero.Codigo);
                lblNombreRTA.Text = objPila.Primero.Nombre;
                lblTramiteRTA.Text = objPila.Primero.Tramite;

                objPila.Eliminar();
                objPila.Recorrer(dgvPila);
                objPila.Recorrer("Pila.csv");
                objPila.Recorrer(lstPila);
            }
            else
            {
                lblCodigoRTA.Text = "";
                lblNombreRTA.Text = "";
                lblTramiteRTA.Text = "";
                MessageBox.Show("No hay personas para eliminar en la pila");
            }
        }
    }
}
