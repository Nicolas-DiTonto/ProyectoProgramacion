using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace ProyectoProgramacion
{
     static class Lista /* Desde esta clase accedo a la dirección de la Lista desde cualquier Form */
    {

        static private List<Mesa> ListaMesa;
        static private List<Mesa> AUX;      /* Lista Auxiliar para mostrar el comboBox ordenado por Nro de Mesa */



        static public List<Mesa> L
        {
                set
                {
                    ListaMesa = value;
                }
                get
                {
                    return ListaMesa;
                }
        }

        static public int cantidadMesasDisponibles(int tipoDeMesa)
        {
            int i, cantidadDisponible = 0;
            for (i = 0; i < L.Count; i++)
            {
                if (L[i].T == tipoDeMesa)
                    if (L[i].Disp)
                        cantidadDisponible++;

            }
                return cantidadDisponible;
        }

        static public bool NroDeMesaDisponible (int nro)
        {
            int k;

            for (k = 0; k < L.Count; k++)
            {
                if (L[k].Numero == nro)
                    return false;
            }
            return true;
        }

        static public int GenerarNroMesa()
        {
            int i;

            for (i = 1; i <= L.Count; i++)
            {
                if (NroDeMesaDisponible(i))
                    return i;
            }
            return i;

        }

        static public int ReservaDeMesa(int tipo, string nom )
        {
            int k;

            for (k = 0; k < L.Count; k++)
            {
                if (L[k].T == tipo)
                    if (L[k].Disp)
                    {
                        L[k].Reservar(nom);
                        return L[k].Numero;
                    }
            }

            return 0;                        
        }


        static public void MesasOcupadas(ComboBox box)
        {
            AUX = ListaMesa;
            AUX = AUX.OrderBy(o => o.Numero).ToList();

            int i;
            for (i = 0; i < AUX.Count; i++)
            {
                if (!AUX[i].Disp)
                {
                    box.Items.Add(AUX[i].Numero.ToString());
                }
            }
        }
    
    }
}
