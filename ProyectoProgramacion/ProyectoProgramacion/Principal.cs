using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace ProyectoProgramacion
{
    public partial class FormPincipal : Form
    {

        private Form formdividir;
        private Form formFactura;
        private FormInicio Finicio;
        Auxiliar AUX2 = new Auxiliar();


        public FormPincipal(FormInicio inicio)

        {
            InitializeComponent();
            Finicio = inicio;
            AUX2.L = Lista.L;
        }

        private void button1_Click(object sender, EventArgs e)
        {
        }

        public string retornoMesa()
        {
            return txtNombre.Text;
        }
        
        public void LimpiarCampos()
        {                   
            txtNombre.Clear();
            comboNro.Text = "";
        }
        

        private void btnReserva_Click(object sender, EventArgs e)
        {
            /* CHEQUEOS DE CAMPOS */

            if (txtNombre.TextLength < 1)
            {
                MessageBox.Show("Ingrese nombre de la reserva", "Error");
                return;
            }

            if (string.IsNullOrEmpty(comboNro.Text))
            {
                MessageBox.Show("Ingrese tipo de mesa","Error");
                return;
            }

            /* -------------------------------------*/

            
            int Tipo = Int32.Parse(comboNro.Text);
            int mesaReservada = Lista.ReservaDeMesa(Tipo, txtNombre.Text);
            

            if ( mesaReservada != 0)
            {
                MessageBox.Show("RESERVA REALIZADA\nMESA NÚMERO: " + mesaReservada.ToString());
            }
            else
                if(Tipo == 3)
                {
                    MessageBox.Show("NO HAY MESAS DISPONIBLES");
                }
                else
                {
                    formdividir = new FormDividir(this, Tipo);
                    formdividir.Show();
                    this.Hide();
                }
        }

        private void label1_Click(object sender, EventArgs e)
        {
        }

        private void FormPincipal_Load(object sender, EventArgs e)
        {

        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void bt_Click(object sender, EventArgs e)
        {
            
        }

        private void btnFac_Click(object sender, EventArgs e)
        {
            formFactura = new FormFacturación(this);
            formFactura.Show();
            this.Hide();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            Auxiliar.guardar(AUX2);
        }

        private void btnAbrir_Click(object sender, EventArgs e)
        {
            Auxiliar.abrir(AUX2);
            AUX2.L = Lista.L;
        }
    }
}
