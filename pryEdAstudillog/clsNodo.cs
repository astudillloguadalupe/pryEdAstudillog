using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO; //permite trabajar con archivos
using System.Windows.Forms;

namespace pryEdAstudillog
{
    internal class clsNodo
    {
        //Campos del nodo 
        private Int32 cod;
        private String nom;
        private String tram;
        private clsNodo sig;


        public Int32 Codigo
        { 
            get { return cod; } //tomo el valor de un campo
            set { cod = value; } //asigno un valor a un campo
        }
        public String Nombre 
        { 
            get { return nom; } 
            set { nom = value; } 
        }
        public String Tramite 
        { 
            get { return tram; } 
            set { tram = value; } 
        }
        public clsNodo Siguiente 
        { 
            get { return sig; } 
            set { sig = value; } 
        }

    }

}
