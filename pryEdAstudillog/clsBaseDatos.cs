using System;
using System;
using System.Collections.Generic;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace pryEdAstudillog
{
    internal class clsBaseDatos
    {
        private OleDbConnection conexion = new OleDbConnection();
        private OleDbCommand comando = new OleDbCommand();
        private OleDbDataAdapter adaptador = new OleDbDataAdapter();

        private string CadenaConexion1 = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=Libreria.mdb";
        private string CadenaConexion2 = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=Libreria.mdb"

        public void Listar(DataGridView grilla)
        {
            try
            {
                conexion.ConnectionString = CadenaConexion1
                conexion.Open();

                comando.Connection = conexion;
                comandO.commandType = CommandType.Text;
                comando.CommandText = "Libro"

                DataSet Ds = new DataSet();
                adaptador = new OleDbDataAdapter(comando);
                adaptador.Fill(Ds, "Libro");

                grilla.DataSource = null
                grilla.DataSource = Ds.Tables["Libro"];

                conexion.Close();
            }
            catch (Exception x)
            {

                MessageBox.Show(x.ToString());
            }
        }

        public void Listar(String tabla, DataGridView grilla)
        {
            try
            {
                conexion.ConnectionString = CadenaConexion1
                conexion.Open();

                comando.Connection = conexion;
                comandO.commandType = CommandType.Text;
                comando.CommandText = tabla;

                DataSet Ds = new DataSet();
                adaptador = new OleDbDataAdapter(comando);
                adaptador.Fill(Ds,tabla);

                grilla.DataSource = null
                grilla.DataSource = Ds.Tables[tabla];

                conexion.Close();

            }
            catch (Exception e )
            {
                MessageBox.Show (e.Message)
                conexion.Close ();
            }
        }
        
        public void Listar (DataGridView grilla, String varIntruccionSQL)
        {
            try
            {
                conexion.ConnectionString = CadenaConexion1
                conexion.Open();

                comando.Connection = conexion;
                comandO.commandType = CommandType.Text;
                comando.CommandText = varIntruccionSQL;

                DataSet Ds = new DataSet();
                adaptador = new OleDbDataAdapter(comando);
                adaptador.Fill(Ds, "Resultado");

                grilla.DataSource = null
                grilla.DataSource = Ds.Tables["Resultado"];

                conexion.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message)
                conexion.Close();

            }
        }

     
    





    }
}
