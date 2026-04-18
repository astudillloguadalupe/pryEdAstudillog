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
    public partial class frmColores : Form
    {
        public frmColores()
        {
            InitializeComponent();
        }

        private void btnGrabar_Click(object sender, EventArgs e)
        {
            clsArchivo x = new clsArchivo(); //Creás un objeto de la clase clsArchivo
            x.NomArchivo = "Colores.txt"; //csv excel 

            x.Grabar(txtNombre.Text); //Guarda el texto del TextBox.
            x.Recorrer(lstColores); //Actualiza el ListBox con los datos del archivo.

            MessageBox.Show("Datos Grabados"); 

            txtNombre.Text = ""; 
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

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            if (lstColores.Items.Count == 0)
            {
                MessageBox.Show("No hay Colores Cargados para borrar");
                return;
            }
            clsArchivo colores = new clsArchivo();
            colores.NomArchivo = "Colores.csv";
            colores.Borrar();
            colores.Recorrer(lstColores);
            MessageBox.Show("Datos Borrados");

        }
    }
}
