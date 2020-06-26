using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;
using System.Windows.Forms;

namespace ProyectoProgramacion
{
    [Serializable]
    class Auxiliar
    {
        private List<Mesa> listaOriginal;

        public Auxiliar()
        {
            listaOriginal = new List<Mesa>();
        }

        public void agregar(Mesa m)
        {
            listaOriginal.Add(m);
        }

        

        public List<Mesa> L
        {
            get
            {
                return listaOriginal;
            }
            set
            {
                listaOriginal = value;
            }
        }


        static public void guardar(Auxiliar AUX)
        {
            Stream flujo = new FileStream("GuardadoMesas.bin", FileMode.Create, FileAccess.Write, FileShare.None); 
            BinaryFormatter archivo = new BinaryFormatter();
            archivo.Serialize(flujo, AUX);
            flujo.Close();
            MessageBox.Show("GUARDADO");
        }

        static public void abrir(Auxiliar AUX)
        {
            try
            {
                Stream flujo = new FileStream("GuardadoMesas.bin", FileMode.Open, FileAccess.Read, FileShare.None);  
                BinaryFormatter guardado = new BinaryFormatter();
                AUX = (Auxiliar)guardado.Deserialize(flujo);
                flujo.Close();
                Lista.L = AUX.L;
                MessageBox.Show("CARGADO");
            }
            catch (Exception e)
            {
                MessageBox.Show("ARCHIVO NO ENCONTRADO");
                return;
            }
        }

    }
}


