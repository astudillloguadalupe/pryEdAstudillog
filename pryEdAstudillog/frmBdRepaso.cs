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
    public partial class frmBdRepaso : Form
    {
        public frmBdRepaso()
        {
            InitializeComponent();
        }
        clsBaseDatos objBaseDatos = new clsBaseDatos();
        private void frmBdRepaso_Load(object sender, EventArgs e)
        {
            btnListar.Enabled = false;

            cmbOperacion.Items.Clear();
            cmbOperacion.Items.Add("Todos los libros ordenados por título");
            cmbOperacion.Items.Add("Libros con su autor");
            cmbOperacion.Items.Add("Libros por país");
            cmbOperacion.Items.Add("Libros por idioma");
            cmbOperacion.Items.Add("Todos los autores");
        }

        private void btnListar_Click(object sender, EventArgs e)
        {
            if (cmbOperacion.SelectedIndex == -1)
            {
                MessageBox.Show("Seleccione una operación.");
                return;
            }

            string sql = "";

            switch (cmbOperacion.SelectedIndex)
            {
                case 0:
                    sql = "SELECT IDLIBRO, TITULO, AÑO, PRECIO FROM LIBRO ORDER BY TITULO ASC";
                    break;

                case 1:
                    sql = "SELECT Libro.Titulo, Autor.Nombre, Libro.AÑO " +
                          "FROM Libro INNER JOIN Autor ON Libro.IdAutor = Autor.IdAutor " +
                          "ORDER BY Libro.Titulo ASC";
                    break;

                case 2:
                    sql = "SELECT Libro.Titulo, Pais.Nombre, Libro.AÑO " +
                          "FROM Libro INNER JOIN Pais ON Libro.IdPais = Pais.IdPais " +
                          "ORDER BY Pais.Nombre ASC";
                    break;

                case 3:
                    sql = "SELECT Libro.Titulo, Idioma.Nombre, Libro.PRECIO " +
                          "FROM Libro INNER JOIN Idioma ON Libro.IdIdioma = Idioma.IdIdioma " +
                          "ORDER BY Idioma.Nombre ASC";
                    break;

                case 4:
                    sql = "SELECT * FROM Autor ORDER BY Nombre ASC";
                    break;
            }

            objBaseDatos.Listar(dgvLista, sql);
        }

        private void cmbOperacion_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnListar.Enabled = cmbOperacion.SelectedIndex != -1;
        }
    }
}
