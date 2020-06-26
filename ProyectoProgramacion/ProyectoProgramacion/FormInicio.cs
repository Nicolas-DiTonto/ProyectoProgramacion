using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;

namespace ProyectoProgramacion
{
    public partial class FormInicio : Form
    {
        private FormPincipal frmlPrincipal;
        List<Mesa> listaOriginal;
        Auxiliar AUX = new Auxiliar();
        

        public FormInicio()
        {
            
            InitializeComponent();

            Lista.L = AUX.L;
            listaOriginal = AUX.L;


            frmlPrincipal = new FormPincipal(this);


        }
     

        private void Form1_Load(object sender, EventArgs e)
        {
            cBMesa1.SelectedIndex = 0;
            cBMesa2.SelectedIndex = 0;
            cBMesa3.SelectedIndex = 0;
        }

        private void btnInicio_Click(object sender, EventArgs e)
        {

            int i = Int32.Parse(cBMesa1.Text);
            int j = Int32.Parse(cBMesa2.Text);
            int k = Int32.Parse(cBMesa3.Text);

            int z = i + j + k;


            while (i > 0)
            {
                AUX.agregar(new Mesa(z, 2));
                i--;
                z--;
            }
            while (j > 0)
            {
                AUX.agregar(new Mesa(z, 3));
                j--;
                z--;
            }
            while (k > 0)
            {
                AUX.agregar(new Mesa(z, 4));
                k--;
                z--;
            }
                 
            frmlPrincipal.Show();
            this.Hide();
        }



        private void cBMesa1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void cBMesa2_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void cBMesa3_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
    }
}
