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
    public partial class frmGrafo : Form
    {
        clsGrafo Grafo = new clsGrafo();
        public frmGrafo()
        {
            InitializeComponent();
        }

        private void frmGrafo_Load(object sender, EventArgs e)
        {
            Grafo.MostrarCiudades(cmbOrigen1);
            Grafo.MostrarCiudades(cmbDestino1);

            Grafo.MostrarCiudades(cmbOrigen2);
            Grafo.MostrarCiudades(cmbDestino2);

            Grafo.MostrarCiudades(cmbDesde);
            Grafo.MostrarCiudades(cmbHasta);

            Grafo.MostrarTodo(dgvLista);
        }

        private void btnCargar_Click(object sender, EventArgs e)
        {
            Int32 origen = cmbOrigen1.SelectedIndex;
            Int32 destino = cmbDestino1.SelectedIndex;

            if (origen == -1 || destino == -1)
            {
                MessageBox.Show("Seleccione origen y destino.");
                return;
            }

            if (!Decimal.TryParse(txtPrecio.Text, out Decimal precio))
            {
                MessageBox.Show("Ingrese un precio válido.");
                txtPrecio.Focus();
                return;
            }

            Grafo.Agregar(origen, destino, precio);

            MessageBox.Show("Viaje cargado");

            txtPrecio.Clear();

            Grafo.MostrarTodo(dgvLista);
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            Int32 origen = cmbOrigen2.SelectedIndex;
            Int32 destino = cmbDestino2.SelectedIndex;

            Decimal precio = Grafo.Consultar(origen, destino);

            if (precio == 0)
            {
                MessageBox.Show("No existe un viaje cargado entre esas ciudades.");
                txtPrecio.Text = "";
            }
            else
            {
                lblPrecioRTA.Text = precio.ToString();
            }
        }

        private void btnListarOrigenes_Click(object sender, EventArgs e)
        {
            Int32 destino = cmbHasta.SelectedIndex;

            Grafo.MostrarOrigenes(destino, dgvLista);
        }

        private void btnVerViajes_Click(object sender, EventArgs e)
        {
            Grafo.MostrarTodo(dgvLista);
        }

        private void btnListarDestinos_Click(object sender, EventArgs e)
        {
            Int32 origen = cmbDesde.SelectedIndex;

            Grafo.MostrarDestinos(origen, dgvLista);
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            Int32 origen = cmbOrigen2.SelectedIndex;
            Int32 destino = cmbDestino2.SelectedIndex;

            Grafo.Eliminar(origen, destino);

            txtPrecio.Text = "";

            Grafo.MostrarTodo(dgvLista);

            MessageBox.Show("El viaje seleccionado fue eliminado correctamente.");
        }

        private void btnBorrarTodo_Click(object sender, EventArgs e)
        {
            Grafo.BorrarTodo();
            Grafo.MostrarTodo(dgvLista);

            MessageBox.Show("Se borraron todos los viajes.");
        }
    }
}
