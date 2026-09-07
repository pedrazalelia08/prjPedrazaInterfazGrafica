namespace prjPedrazaInterfazGrafica
{
    partial class frmCajaDeTexto
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
            txtCarrera = new TextBox();
            txtEdad = new TextBox();
            txtApellido = new TextBox();
            txtNombre = new TextBox();
            lblApellido = new Label();
            lblCarrera = new Label();
            lblEdad = new Label();
            lblNombre = new Label();
            btnPresentar = new Button();
            SuspendLayout();
            // 
            // txtCarrera
            // 
            txtCarrera.Location = new Point(96, 136);
            txtCarrera.Name = "txtCarrera";
            txtCarrera.Size = new Size(128, 23);
            txtCarrera.TabIndex = 16;
            // 
            // txtEdad
            // 
            txtEdad.Location = new Point(96, 104);
            txtEdad.Name = "txtEdad";
            txtEdad.Size = new Size(31, 23);
            txtEdad.TabIndex = 15;
            // 
            // txtApellido
            // 
            txtApellido.Location = new Point(96, 70);
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(128, 23);
            txtApellido.TabIndex = 14;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(101, 41);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(123, 23);
            txtNombre.TabIndex = 13;
            // 
            // lblApellido
            // 
            lblApellido.AutoSize = true;
            lblApellido.BackColor = Color.IndianRed;
            lblApellido.Location = new Point(28, 73);
            lblApellido.Name = "lblApellido";
            lblApellido.Size = new Size(51, 15);
            lblApellido.TabIndex = 12;
            lblApellido.Text = "Apellido";
            // 
            // lblCarrera
            // 
            lblCarrera.AutoSize = true;
            lblCarrera.BackColor = Color.Firebrick;
            lblCarrera.Location = new Point(28, 137);
            lblCarrera.Name = "lblCarrera";
            lblCarrera.Size = new Size(45, 15);
            lblCarrera.TabIndex = 11;
            lblCarrera.Text = "Carrera";
            // 
            // lblEdad
            // 
            lblEdad.AutoSize = true;
            lblEdad.BackColor = Color.Firebrick;
            lblEdad.Location = new Point(28, 104);
            lblEdad.Name = "lblEdad";
            lblEdad.Size = new Size(33, 15);
            lblEdad.TabIndex = 10;
            lblEdad.Text = "Edad";
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.BackColor = Color.LightCoral;
            lblNombre.Location = new Point(28, 40);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(51, 15);
            lblNombre.TabIndex = 9;
            lblNombre.Text = "Nombre";
            // 
            // btnPresentar
            // 
            btnPresentar.BackColor = Color.Tomato;
            btnPresentar.Location = new Point(71, 178);
            btnPresentar.Name = "btnPresentar";
            btnPresentar.Size = new Size(124, 37);
            btnPresentar.TabIndex = 17;
            btnPresentar.Text = "Presentar";
            btnPresentar.UseVisualStyleBackColor = false;
            btnPresentar.Click += btnPresentar_Click;
            // 
            // frmCajaDeTexto
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightCyan;
            ClientSize = new Size(285, 276);
            Controls.Add(btnPresentar);
            Controls.Add(txtCarrera);
            Controls.Add(txtEdad);
            Controls.Add(txtApellido);
            Controls.Add(txtNombre);
            Controls.Add(lblApellido);
            Controls.Add(lblCarrera);
            Controls.Add(lblEdad);
            Controls.Add(lblNombre);
            Name = "frmCajaDeTexto";
            Text = "Mi Presentación";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtCarrera;
        private TextBox txtEdad;
        private TextBox txtApellido;
        private TextBox txtNombre;
        private Label lblApellido;
        private Label lblCarrera;
        private Label lblEdad;
        private Label lblNombre;
        private Button btnPresentar;
    }
}