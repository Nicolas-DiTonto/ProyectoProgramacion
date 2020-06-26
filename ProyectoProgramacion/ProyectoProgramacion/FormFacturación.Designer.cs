namespace ProyectoProgramacion
{
    partial class FormFacturación
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.comboListMesas = new System.Windows.Forms.ComboBox();
            this.btnFac = new System.Windows.Forms.Button();
            this.lblNom = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblCampoRes = new System.Windows.Forms.Label();
            this.lblCampoSaldo = new System.Windows.Forms.Label();
            this.lblSaldo = new System.Windows.Forms.Label();
            this.lblTipo = new System.Windows.Forms.Label();
            this.lblTipoDeMesa = new System.Windows.Forms.Label();
            this.btnAgregarCon = new System.Windows.Forms.Button();
            this.btnVolver = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // comboListMesas
            // 
            this.comboListMesas.FormattingEnabled = true;
            this.comboListMesas.Location = new System.Drawing.Point(250, 33);
            this.comboListMesas.Name = "comboListMesas";
            this.comboListMesas.Size = new System.Drawing.Size(41, 21);
            this.comboListMesas.TabIndex = 0;
            this.comboListMesas.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // btnFac
            // 
            this.btnFac.Enabled = false;
            this.btnFac.Location = new System.Drawing.Point(261, 259);
            this.btnFac.Name = "btnFac";
            this.btnFac.Size = new System.Drawing.Size(89, 36);
            this.btnFac.TabIndex = 1;
            this.btnFac.Text = "Cerrar Mesa";
            this.btnFac.UseVisualStyleBackColor = true;
            this.btnFac.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblNom
            // 
            this.lblNom.AutoSize = true;
            this.lblNom.Location = new System.Drawing.Point(247, 75);
            this.lblNom.Name = "lblNom";
            this.lblNom.Size = new System.Drawing.Size(10, 13);
            this.lblNom.TabIndex = 2;
            this.lblNom.Text = " ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Número de mesa:";
            // 
            // lblCampoRes
            // 
            this.lblCampoRes.AutoSize = true;
            this.lblCampoRes.Location = new System.Drawing.Point(35, 75);
            this.lblCampoRes.Name = "lblCampoRes";
            this.lblCampoRes.Size = new System.Drawing.Size(115, 13);
            this.lblCampoRes.TabIndex = 4;
            this.lblCampoRes.Text = "Reserva a nombre de: ";
            this.lblCampoRes.Visible = false;
            this.lblCampoRes.Click += new System.EventHandler(this.lblCampoRes_Click);
            // 
            // lblCampoSaldo
            // 
            this.lblCampoSaldo.AutoSize = true;
            this.lblCampoSaldo.Location = new System.Drawing.Point(35, 114);
            this.lblCampoSaldo.Name = "lblCampoSaldo";
            this.lblCampoSaldo.Size = new System.Drawing.Size(95, 13);
            this.lblCampoSaldo.TabIndex = 5;
            this.lblCampoSaldo.Text = "Saldo acumulado: ";
            this.lblCampoSaldo.Visible = false;
            // 
            // lblSaldo
            // 
            this.lblSaldo.AutoSize = true;
            this.lblSaldo.Location = new System.Drawing.Point(247, 114);
            this.lblSaldo.Name = "lblSaldo";
            this.lblSaldo.Size = new System.Drawing.Size(0, 13);
            this.lblSaldo.TabIndex = 6;
            this.lblSaldo.EnabledChanged += new System.EventHandler(this.lblSaldo_EnabledChanged);
            // 
            // lblTipo
            // 
            this.lblTipo.AutoSize = true;
            this.lblTipo.Location = new System.Drawing.Point(35, 156);
            this.lblTipo.Name = "lblTipo";
            this.lblTipo.Size = new System.Drawing.Size(78, 13);
            this.lblTipo.TabIndex = 7;
            this.lblTipo.Text = "Tipo de Mesa: ";
            this.lblTipo.Visible = false;
            this.lblTipo.Click += new System.EventHandler(this.lblTipoDeMesa_Click);
            // 
            // lblTipoDeMesa
            // 
            this.lblTipoDeMesa.AutoSize = true;
            this.lblTipoDeMesa.Location = new System.Drawing.Point(247, 156);
            this.lblTipoDeMesa.Name = "lblTipoDeMesa";
            this.lblTipoDeMesa.Size = new System.Drawing.Size(0, 13);
            this.lblTipoDeMesa.TabIndex = 8;
            // 
            // btnAgregarCon
            // 
            this.btnAgregarCon.Enabled = false;
            this.btnAgregarCon.Location = new System.Drawing.Point(142, 259);
            this.btnAgregarCon.Name = "btnAgregarCon";
            this.btnAgregarCon.Size = new System.Drawing.Size(89, 36);
            this.btnAgregarCon.TabIndex = 9;
            this.btnAgregarCon.Text = "Agregar Consumo";
            this.btnAgregarCon.UseVisualStyleBackColor = true;
            this.btnAgregarCon.Click += new System.EventHandler(this.btnAgregarCon_Click);
            // 
            // btnVolver
            // 
            this.btnVolver.Location = new System.Drawing.Point(26, 259);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(89, 36);
            this.btnVolver.TabIndex = 10;
            this.btnVolver.Text = "Volver";
            this.btnVolver.UseVisualStyleBackColor = true;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // FormFacturación
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(363, 334);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.btnAgregarCon);
            this.Controls.Add(this.lblTipoDeMesa);
            this.Controls.Add(this.lblTipo);
            this.Controls.Add(this.lblSaldo);
            this.Controls.Add(this.lblCampoSaldo);
            this.Controls.Add(this.lblCampoRes);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblNom);
            this.Controls.Add(this.btnFac);
            this.Controls.Add(this.comboListMesas);
            this.Name = "FormFacturación";
            this.Text = "FormFacturación";
            this.Load += new System.EventHandler(this.FormFacturación_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboListMesas;
        private System.Windows.Forms.Button btnFac;
        private System.Windows.Forms.Label lblNom;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblCampoRes;
        private System.Windows.Forms.Label lblCampoSaldo;
        public System.Windows.Forms.Label lblSaldo;
        private System.Windows.Forms.Label lblTipo;
        private System.Windows.Forms.Label lblTipoDeMesa;
        private System.Windows.Forms.Button btnAgregarCon;
        private System.Windows.Forms.Button btnVolver;
    }
}