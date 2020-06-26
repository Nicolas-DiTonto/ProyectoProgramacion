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
    public partial class FormFacturación : Form
    {
        static private List<Mesa> ListM;
        private Form frmppal;
        private Form frmConsumo;
        
        public FormFacturación(Form inicio)
        {
            InitializeComponent();
            
            frmppal = inicio;
            ListM = Lista.L;

            Lista.MesasOcupadas(comboListMesas);          

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int i = ListM.FindIndex(Elemento => Elemento.Numero == Int32.Parse(comboListMesas.Text));
            lblNom.Text = ListM[i].N;
            lblSaldo.Text = ListM[i].Monto().ToString();
            lblTipoDeMesa.Text = ListM[i].T.ToString();
            btnFac.Enabled = true;
            btnAgregarCon.Enabled = true;
            lblCampoSaldo.Visible = true;
            lblCampoRes.Visible = true;
            lblTipo.Visible = true;                   
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
       
        }

        private void comboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int i = ListM.FindIndex(Elemento => Elemento.Numero == Int32.Parse(comboListMesas.Text));
            ListM[i].CerrarMesa();
            MessageBox.Show("MESA CERRADA");
            frmppal.Show();
            this.Hide();

        }

        private void FormFacturación_Load(object sender, EventArgs e)
        {
         
        }

        public void actualizarCampo()
        {
            if (!string.IsNullOrEmpty(comboListMesas.Text))
                lblSaldo.Text = ListM[ListM.FindIndex(Elemento => Elemento.Numero == Int32.Parse(comboListMesas.Text))].Monto().ToString();

        }

        private void lblCampoRes_Click(object sender, EventArgs e)
        {

        }

        private void lblTipoDeMesa_Click(object sender, EventArgs e)
        {

        }

        private void btnAgregarCon_Click(object sender, EventArgs e)
        {
            frmConsumo = new FormAgregarConsumo(Int32.Parse(comboListMesas.Text), this);
            frmConsumo.Show();
        }

        private void lblSaldo_EnabledChanged(object sender, EventArgs e)
        {
            
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
           
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            frmppal.Show();
            this.Hide();
        }
    }
}
    

