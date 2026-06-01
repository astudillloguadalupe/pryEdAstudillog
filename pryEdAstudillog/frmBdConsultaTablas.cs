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
    public partial class frmBdConsultaTablas : Form
    {
        public frmBdConsultaTablas()
        {
            InitializeComponent();
        }

        private void btnListar_Click(object sender, EventArgs e)
        {
            clsBaseDatos bd = new clsBaseDatos();
            bd.Listar(cmbTablas.Text, dgvConsultaTabla);
        }
    }
}
