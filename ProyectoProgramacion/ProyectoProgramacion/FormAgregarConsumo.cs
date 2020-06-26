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
    public partial class FormAgregarConsumo : Form
    {
        private int NumMesa;
        private FormFacturación FrmDeFac;
        private List<Mesa> listaDeMesa;
        public FormAgregarConsumo(int numero, FormFacturación frmFac)
        {
            NumMesa = numero;
            FrmDeFac = frmFac;
            listaDeMesa = Lista.L;
            InitializeComponent();
            lblNumMesa.Text = NumMesa.ToString();

        }

        private void label3_Click(object sender, EventArgs e)
        {
            
        }

        private void FormAgregarConsumo_Load(object sender, EventArgs e)
        {

        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            FrmDeFac.Show();
            this.Hide();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtImporte.Text))
            {
                MessageBox.Show("Ingrese Importe", "Error");
                return;
            }
            decimal valor = 0;

            if(! decimal.TryParse(txtImporte.Text, out valor))
            {
                MessageBox.Show("Importe no válido", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            else
            {
                listaDeMesa[listaDeMesa.FindIndex(Elemento => Elemento.Numero == NumMesa)].Pedido(valor);
                MessageBox.Show("Monto cargado");
                FrmDeFac.actualizarCampo();
                FrmDeFac.Show();
                this.Hide();
               
            }

        }

        private void txtImporte_TextChanged(object sender, EventArgs e)
        {

        }

     
    }
}
