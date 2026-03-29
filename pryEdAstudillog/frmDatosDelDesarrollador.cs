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
    public partial class frmDatosDelDesarrollador : Form
    {
        public frmDatosDelDesarrollador()
        {
            InitializeComponent();
        }

        

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void txtEdad_TextChanged(object sender, EventArgs e)
        {
            if (txtEdad.Text=="")
            {
                txtDNI.Enabled = false;
            }
            else { txtDNI.Enabled = true; }
        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {
            if (txtNombre.Text == "")
            {
                txtEdad.Enabled = false;
            }
            else
            {
                txtEdad.Enabled=true;
            }
        }

        private void txtDNI_TextChanged(object sender, EventArgs e)
        {
            if (txtDNI.Text == "")
            {
                txtTelefono.Enabled = false;
            }
            else
            {
                txtTelefono.Enabled = true;
            }
        }

        private void txtFecha_TextChanged(object sender, EventArgs e)
        {
          if(txtFecha.Text== "")
          {
             btnGuardar.Enabled = false;

          }
           else
           {
               btnGuardar.Enabled=true;
           }
        }

        private void txtTelefono_TextChanged(object sender, EventArgs e)
        {
            if (txtTelefono.Text == "")
            {
                txtFecha.Enabled = false;
            }
            else
            {
                txtFecha.Enabled = true;
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtNombre.Clear();
            txtFecha.Clear();
            txtTelefono.Clear();
            txtEdad.Clear();
            txtDNI.Clear();
        }
    }
}
