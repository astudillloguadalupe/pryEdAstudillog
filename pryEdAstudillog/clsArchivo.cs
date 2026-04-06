 using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Crear una libreria
using System.IO;
using System.Windows.Forms;

namespace pryEdAstudillog
{
    internal class clsArchivo
    {
        //Creamos un campo
        public String NomArchivo = "Colores.txt";

        public void Grabar()
        {
            //Abrimos archivo de escritura
            StreamWriter AD = new StreamWriter(NomArchivo);
            AD.WriteLine("Hola");
            AD.Close();
        }
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
            String DatoLeido = "";
            StreamReader AD = new StreamReader(NomArchivo);
            DatoLeido = AD.ReadLine();
            while (DatoLeido != null)
            {
                //Lineas de codigo que hagan falta para mostrar el dato leido en el listbox
                lstDatos.Items.Add(DatoLeido);
                DatoLeido = AD.ReadLine();
            }
            AD.Close();
        }

        private void Recorrer(ComboBox cboDatos)
        {
            cboDatos.Items.Clear();
            String DatoLeido = "";
            StreamReader AD = new StreamReader(NomArchivo);
            DatoLeido = AD.ReadLine();
            while (DatoLeido != null)
            {
                cboDatos.Items.Add(DatoLeido);
                DatoLeido = AD.ReadLine();
            }
            AD.Close();
        }
    }
}
