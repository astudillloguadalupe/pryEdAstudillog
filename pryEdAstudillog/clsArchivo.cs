 using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Crear una libreria
using System.IO; //permite trabajar con archivos
using System.Windows.Forms; //permite usar controles gráficos como ListBox, ComboBox, botones, etc.

namespace pryEdAstudillog
{
    internal class clsArchivo
    {
        //Creamos un campo
        public String NomArchivo = "Colores.txt"; //guarda el nombre del archivo.

        public void Grabar()
        {
            //Abrimos archivo de escritura
            StreamWriter AD = new StreamWriter(NomArchivo); //Abre el archivo para escribir. Si el archivo no existe, lo crea. Si el archivo ya existe, lo sobrescribe.
            AD.WriteLine("Hola"); //Escribe una línea en el archivo.
            AD.Close();
        }
        public void Grabar(String Dato)
        {
            //Abrimos archivo de lectura
            StreamWriter AD = new StreamWriter(NomArchivo, true); //true agregar sin borrar lo anterior
            AD.WriteLine(Dato);
            AD.Close();

        }
        public void Recorrer(ListBox lstDatos) //Leer el archivo, Mostrar los datos en un ListBox
        {
            lstDatos.Items.Clear(); //borra si hay algo escrito en el listbox, para mostrar solo lo que hay en el archivo
            String DatoLeido = ""; // se guarda cada línea leída.
            StreamReader AD = new StreamReader(NomArchivo); //Abre el archivo para lectura.
            DatoLeido = AD.ReadLine(); //lee la primera línea del archivo y la guarda en DatoLeido

            while (DatoLeido != null) //Mientras haya datos
            {
                //Agrega la línea al ListBox.
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
