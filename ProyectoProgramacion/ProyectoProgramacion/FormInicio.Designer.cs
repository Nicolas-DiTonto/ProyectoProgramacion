namespace ProyectoProgramacion
{
    partial class FormInicio
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnInicio = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cBMesa1 = new System.Windows.Forms.ComboBox();
            this.cBMesa2 = new System.Windows.Forms.ComboBox();
            this.cBMesa3 = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // btnInicio
            // 
            this.btnInicio.Location = new System.Drawing.Point(111, 241);
            this.btnInicio.Name = "btnInicio";
            this.btnInicio.Size = new System.Drawing.Size(179, 66);
            this.btnInicio.TabIndex = 0;
            this.btnInicio.Text = "Ingresar";
            this.btnInicio.UseVisualStyleBackColor = true;
            this.btnInicio.Click += new System.EventHandler(this.btnInicio_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(108, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Mesas para dos";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(108, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Mesas para tres";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(108, 136);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Mesas para cuatro";
            // 
            // cBMesa1
            // 
            this.cBMesa1.DisplayMember = "0";
            this.cBMesa1.FormattingEnabled = true;
            this.cBMesa1.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20"});
            this.cBMesa1.Location = new System.Drawing.Point(220, 40);
            this.cBMesa1.Name = "cBMesa1";
            this.cBMesa1.Size = new System.Drawing.Size(49, 21);
            this.cBMesa1.TabIndex = 4;
            this.cBMesa1.SelectedIndexChanged += new System.EventHandler(this.cBMesa1_SelectedIndexChanged);
            // 
            // cBMesa2
            // 
            this.cBMesa2.FormattingEnabled = true;
            this.cBMesa2.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20"});
            this.cBMesa2.Location = new System.Drawing.Point(220, 88);
            this.cBMesa2.Name = "cBMesa2";
            this.cBMesa2.Size = new System.Drawing.Size(49, 21);
            this.cBMesa2.TabIndex = 5;
            this.cBMesa2.SelectedIndexChanged += new System.EventHandler(this.cBMesa2_SelectedIndexChanged);
            // 
            // cBMesa3
            // 
            this.cBMesa3.FormattingEnabled = true;
            this.cBMesa3.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20"});
            this.cBMesa3.Location = new System.Drawing.Point(220, 133);
            this.cBMesa3.Name = "cBMesa3";
            this.cBMesa3.Size = new System.Drawing.Size(49, 21);
            this.cBMesa3.TabIndex = 6;
            this.cBMesa3.SelectedIndexChanged += new System.EventHandler(this.cBMesa3_SelectedIndexChanged);
            // 
            // FormInicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(401, 330);
            this.Controls.Add(this.cBMesa3);
            this.Controls.Add(this.cBMesa2);
            this.Controls.Add(this.cBMesa1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnInicio);
            this.Name = "FormInicio";
            this.Text = "Inicio";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnInicio;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cBMesa1;
        private System.Windows.Forms.ComboBox cBMesa2;
        private System.Windows.Forms.ComboBox cBMesa3;
    }
}

