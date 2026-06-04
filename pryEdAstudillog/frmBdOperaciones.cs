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
    public partial class frmBdOperaciones : Form
    {
        public frmBdOperaciones()
        {
            InitializeComponent();
        }
        clsBaseDatos objBaseDatos = new clsBaseDatos();
        private void btnProySimple_Click(object sender, EventArgs e)
        {
            String varSQL = "SELECT TITULO " +
                "FROM LIBRO" + 
                "ORDEN BY 1 DESC";
            objBaseDatos.Listar(dgvBaseDatos, varSQL);
        }

        private void btnProyMulti_Click(object sender, EventArgs e)
        {
            String varSQL = "SELECT TITULO, AÑO " +
                "FROM LIBRO" +
                "ORDEN BY TITULO ASC";
            objBaseDatos.Listar(dgvBaseDatos, varSQL);
        }
    }
}
