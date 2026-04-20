 using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Crear una libreria
using System.IO; //permite trabajar con archivos
using System.Windows.Forms;
using System.Drawing.Text;
using System.Security.Cryptography.X509Certificates;

namespace pryEdAstudillog
{
    internal class clsArchivo
    {
        //Creamos un campo
        public String NomArchivo = ""; 

        
        public void Grabar(String Dato)
        {
            //Abrimos archivo de lectura
            StreamWriter AD = new StreamWriter(NomArchivo, true); 
            AD.WriteLine(Dato);
            AD.Close();

        }
        public void Recorrer(ListBox lstDatos) 
        {
            lstDatos.Items.Clear();

            if (string.IsNullOrEmpty(NomArchivo))
            {
                MessageBox.Show("Error: nombre de archivo vacío");
                return;
            }

            if (!File.Exists(NomArchivo))
            {
                File.Create(NomArchivo).Close();
                return;
            }

            using (StreamReader AD = new StreamReader(NomArchivo))
            {
                string DatoLeido;

                while ((DatoLeido = AD.ReadLine()) != null)
                {
                    lstDatos.Items.Add(DatoLeido);
                }
            }
        }

       
        public void Borrar()
        {
            StreamWriter AD = new StreamWriter(NomArchivo,false);
            AD.Close();
        }

        public void Grabar(String Dato1, String Dato2, String Dato3)
        {
            using (StreamWriter AD = new StreamWriter(NomArchivo, true))
            {
                AD.Write(Dato1);
                AD.Write(";");
                AD.Write(Dato2);
                AD.Write(";");
                AD.WriteLine(Dato3);
            }


        }
        public void Recorrer(DataGridView Grilla)
        {
            Grilla.Rows.Clear();
            String DatoLeido = "";
            StreamReader AD = new StreamReader(NomArchivo);
            DatoLeido = AD.ReadLine();

            while (DatoLeido != null)
            {
                //Agrega la línea.
                Grilla.Rows.Add(DatoLeido.Split(';'));
                DatoLeido = AD.ReadLine();
            }
            AD.Close();
        }

        public void Recorrer(ComboBox cmbCarrera)
        {
            cmbCarrera.Items.Clear();

            if (string.IsNullOrEmpty(NomArchivo)) return;

            if (!File.Exists(NomArchivo))
            {
                File.Create(NomArchivo).Close();
                return;
            }

            using (StreamReader AD = new StreamReader(NomArchivo))
            {
                string DatoLeido;

                while ((DatoLeido = AD.ReadLine()) != null)
                {
                    cmbCarrera.Items.Add(DatoLeido);
                }
            }

            if (cmbCarrera .Items.Count > 0)
            {
                cmbCarrera.SelectedIndex = 0;
            }
        }

    }

}
