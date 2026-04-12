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
            String DatoLeido = ""; 
            StreamReader AD = new StreamReader(NomArchivo); 
            DatoLeido = AD.ReadLine();

            while (DatoLeido != null) 
            {
                //Agrega la línea al ListBox.
                lstDatos.Items.Add(DatoLeido);
                DatoLeido = AD.ReadLine();
            }
            AD.Close();
        }

        public void Recorrer(ComboBox cboDatos)
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
        public void Borrar()
        {
            StreamWriter AD = new StreamWriter(NomArchivo,false);
            AD.Close();
        }

        public void Grabar(String Dato1, String Dato2, String Dato3)
        {
            StreamWriter AD = new StreamWriter(NomArchivo, true);
            AD.Write(Dato1);
            AD.Write(";");
            AD.Write(Dato2);
            AD.Write(";");
            AD.WriteLine(Dato3);
            AD.Close();
            
        }
    }

}
