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
    public partial class frmClientes : Form
    {
        public frmClientes()
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

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {
            if (txtNombre.Text == "")
            {
                txtDeuda.Enabled = false;
            }
            else
            {
                txtDeuda.Enabled = true;
            }
        }

        private void txtDeuda_TextChanged(object sender, EventArgs e)
        {
            if (txtDeuda.Text == "")
            {
                btnGuardar.Enabled = false;
            }
            else
            {
                btnGuardar.Enabled = true;
            }
        }

        private void frmClientes_Load(object sender, EventArgs e)
        {

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            clsArchivo x = new clsArchivo();
            x.NomArchivo = "Clientes.csv";
            x.Grabar(txtCodigo.Text, txtNombre.Text, txtDeuda.Text);
            x.Recorrer(dtgvClientes);
            MessageBox.Show("Cliente guardado con exito");
            txtCodigo.Clear();
            txtNombre.Clear();
            txtDeuda.Clear();

        }

        private void dtgvClientes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            if(dtgvClientes.Rows.Count == 1 && dtgvClientes.Rows[0].IsNewRow) //Validacion si hay datos cargados
    {
                MessageBox.Show("No hay clientes cargados para borrar");
                return;
            }

            clsArchivo x = new clsArchivo();
            x.NomArchivo = "Clientes.csv";
            x.Borrar();
            x.Recorrer(dtgvClientes);

            MessageBox.Show("Datos borrados");

            txtCodigo.Clear();
            txtNombre.Clear();
            txtDeuda.Clear();
        }
    }
}