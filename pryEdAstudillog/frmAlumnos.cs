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
    public partial class frmAlumnos : Form
    {
        public frmAlumnos()
        {
            InitializeComponent();
        }

        private void frmAlumnos_Load(object sender, EventArgs e)
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

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {
            if (txtNombre.Text == "")
            {
                cmbCarrera.Enabled = false;
            }
            else
            {
                cmbCarrera.Enabled = true;
            }
        }

        private void cmbCarrera_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (cmbCarrera.Text == "")
            {
                btnGrabar.Enabled = false;
            }
            else
            {
                btnGrabar.Enabled = true;
            }


        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnGrabar_Click(object sender, EventArgs e)
        {
            clsArchivo x = new clsArchivo();
            x.NomArchivo = "Alumnos.csv";
            x.Grabar(txtCodigo.Text, txtNombre.Text, cmbCarrera.Text);
            x.Recorrer(dgvAlumnos);
            MessageBox.Show("Alumno guardado con exito");
            txtCodigo.Clear();
            txtNombre.Clear();
            cmbCarrera.SelectedIndex = -1;

        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {

            if (dgvAlumnos.Rows.Count == 1 && dgvAlumnos.Rows[0].IsNewRow)
            {
                MessageBox.Show("No hay Alumnos cargados para borrar");
                return;
            }
            clsArchivo x = new clsArchivo();
            x.NomArchivo = "Alumnos.csv"; //csv excel
            x.Borrar();
            x.Recorrer(dgvAlumnos);
            MessageBox.Show("Datos Borrados");
            txtCodigo.Clear();
            txtNombre.Clear();
            cmbCarrera.SelectedIndex = -1;
        }
    }
    
}
