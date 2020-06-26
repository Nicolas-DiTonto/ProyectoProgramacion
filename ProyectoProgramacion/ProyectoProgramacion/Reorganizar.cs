using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoProgramacion
{
    static class Reorganizar
     
    {
        static private List<Mesa> ListaDeMesas;

        static public bool Modificar(int tipo)
        {
            if (tipo == 2)
            {
                if (Dividir())
                    return true;
                return false;
            }

            if (tipo == 4)
            {
                if (Juntar())
                    return true;
                return false;
            }
            else
                return false;
            
        }

        static public bool Dividir()
        {
            int i;
            bool flag = true;
            ListaDeMesas = Lista.L;

            

            if (Lista.cantidadMesasDisponibles (4) > 0)
            {
                for (i = 0; i < ListaDeMesas.Count && flag; i++)      /* Recorro la lista */
                {
                    if (ListaDeMesas[i].T == 4)
                    {
                        if (ListaDeMesas[i].Disp)
                        {
                            ListaDeMesas.RemoveAt(i);
                            
                            ListaDeMesas.Add(new Mesa(Lista.GenerarNroMesa() , 2));
                            ListaDeMesas.Add(new Mesa(Lista.GenerarNroMesa(), 2));
                            flag = false;                            
                        }
                    }
                }
                return true;
            }
            else
                return false;
        }

        static public bool Juntar()
        {
            int i;
            int cont = 0;
            bool flag = true;

     
            ListaDeMesas = Lista.L;

            

            if (Lista.cantidadMesasDisponibles(2) > 1)
            {
                for (i = ListaDeMesas.Count - 1 ; i >= 0 && flag; i--)     
                {
                    if (ListaDeMesas[i].T == 2)
                    {
                        if (ListaDeMesas[i].Disp)
                        {
                            ListaDeMesas.RemoveAt(i);
                            cont++;

                            if (cont == 2)
                            {
                                ListaDeMesas.Add(new Mesa(Lista.GenerarNroMesa(), 4));
                                
                                flag = false;
                            }
                        }
                    }
                }
                
                return true;
            }
            else
                return false;
        }


    }
}

