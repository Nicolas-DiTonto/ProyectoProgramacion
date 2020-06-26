using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoProgramacion
{
    public partial class FormDividir : Form
    {
        private Form frm;
        private int TipoDeMesa;

        public FormDividir(FormPincipal inicio, int t)
        {
            frm = inicio;
            TipoDeMesa = t;
            InitializeComponent();
        }

        
        public int Tipo
        {
            get
            {
                return TipoDeMesa;
            }
            set
            {
                TipoDeMesa = value;
            }
        }
        
    
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void FormDividir_Load(object sender, EventArgs e)
        {

        }

        private void btnReorg_Click(object sender, EventArgs e)
        {

            
            if (Reorganizar.Modificar(Tipo))
            {
                MessageBox.Show("MESAS REORGANIZADAS");
                frm.Show();
                this.Hide();              
            }
            else
                MessageBox.Show("NO HAY MESAS DISPONIBLES\nPARA LA REORGANIZACIÓN");
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            frm.Show();
            this.Hide();
        }
    }
}
