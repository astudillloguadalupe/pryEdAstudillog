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
    public partial class frmCarreras : Form
    {
        public frmCarreras()
        {
            InitializeComponent();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            clsArchivo x = new clsArchivo();
            x.NomArchivo = "Carrea.csv"; //csv excel 

            x.Grabar(txtCarrera.Text);
            x.Recorrer(lstCarreras);

            MessageBox.Show("Datos Grabados");

            txtCarrera.Text = "";
        }

        private void lstCarreras_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
