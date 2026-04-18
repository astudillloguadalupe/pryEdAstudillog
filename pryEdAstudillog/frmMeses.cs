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
    public partial class frmMeses : Form
    {
        public frmMeses()
        {
            InitializeComponent();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnListar_Click(object sender, EventArgs e)
        {
           
        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {
            
            if (txtNombre.Text == "")
            {
                btnGrabar.Enabled = false;
            }
            else
            {
                btnGrabar.Enabled = true;
            }
        }

        private void btnGrabar_Click(object sender, EventArgs e)
        {
            clsArchivo x = new clsArchivo(); 
            x.NomArchivo = "Meses.txt"; //csv excel 

            x.Grabar(txtNombre.Text); 
            x.Recorrer(lstMeses); 

            MessageBox.Show("Datos Grabados");

            txtNombre.Text = "";
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            if (lstMeses.Items.Count == 0)
            {
                MessageBox.Show("No hay Meses Cargados para borrar");
                return;
            }
            clsArchivo meses = new clsArchivo();
            meses.NomArchivo = "Meses.csv";
            meses.Borrar();
            meses.Recorrer(lstMeses);
            MessageBox.Show("Datos Borrados");
        }
    }
}
