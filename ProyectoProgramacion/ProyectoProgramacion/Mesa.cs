using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoProgramacion
{
    [Serializable]
    public class Mesa
    {
        private string Nombre;
        private int NumeroDeMesa;
        private decimal acumulado;      
        private int Tipo;               /* Mesa de 2, 3 o 4 personas */
        private bool Disponible;        /* Modificable al reservar/liberar */


        public Mesa(int nro, int tip) 
        {
            NumeroDeMesa = nro;
            Tipo = tip;
            Disponible = true;
        }

        public string N
        {
            get
            {
                return Nombre;
            }
            set
            {
                Nombre = value;
            }
        }

        public int Numero
        {
            get
            {
                return NumeroDeMesa;
            }
        }

        public int T
        {
            get
            {
                return Tipo;
            }
            set
            {
                Tipo = value;
            }
        }

        public bool Disp
        {
            get
            {
                return Disponible;
            }
        }

        public void Reservar (string Nom)
        {
            Nombre = Nom;
            Disponible = false;
        }
        public void Pedido(decimal Mont)
        {
            acumulado += Mont;
        }

        public decimal Monto()
        {
            return acumulado;
        }
        public string Persona()
        {
            return Nombre;
        }

        public void CerrarMesa()
        {
            Disponible = true;
        }



    }

}