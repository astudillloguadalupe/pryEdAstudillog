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
    public partial class frmCola : Form
    {
        public frmCola()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txtCodigo1_TextChanged(object sender, EventArgs e)
        {
            if (txtCodigo1.Text=="")
            {
                txtNombre1.Enabled = false;
            }
            else
            {
                txtNombre1.Enabled = true;
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
        
        clsCola ColaEspera = new clsCola();
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (!Int32.TryParse(txtCodigo1.Text, out Int32 codigo))
            {
                MessageBox.Show("El código debe ser numérico.");
                txtCodigo1.Focus();
                return;
            }

            clsNodo Persona = new clsNodo();

            Persona.Codigo = codigo;
            Persona.Nombre = txtNombre1.Text;
            Persona.Tramite = txtTramite1.Text;

            ColaEspera.Agregar(Persona);

            ColaEspera.Recorrer(dgvGrilla);
            ColaEspera.Recorrer("Cola.csv");
            ColaEspera.Recorrer(lstListar);

            txtCodigo1.Clear();
            txtNombre1.Clear();
            txtTramite1.Clear();

            txtNombre1.Enabled = false;
            txtTramite1.Enabled = false;
            btnAgregar.Enabled = false;

            txtCodigo1.Focus();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (ColaEspera.Primero != null)
            {
                lblCod.Text = Convert.ToString(ColaEspera.Primero.Codigo);
                lblNom.Text = ColaEspera.Primero.Nombre;
                lblTra.Text = ColaEspera.Primero.Tramite;

                ColaEspera.Eliminar();
                ColaEspera.Recorrer(dgvGrilla);
                ColaEspera.Recorrer("Cola.csv");
                ColaEspera.Recorrer(lstListar);
            }
            else
            {
                lblCod.Text = "";
                lblNom.Text = "";
                lblTra.Text = "";
                MessageBox.Show("No hay personas para eliminar en la cola");
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

        private void frmCola_Load(object sender, EventArgs e)
        {

        }
    }
}
