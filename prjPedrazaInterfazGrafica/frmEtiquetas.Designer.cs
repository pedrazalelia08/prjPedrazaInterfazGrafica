namespace prjPedrazaInterfazGrafica
{
    partial class frmEtiquetas
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
            lblNombre = new Label();
            lblEdad = new Label();
            lblCarrera = new Label();
            lblApellido = new Label();
            txtNombre = new TextBox();
            txtApellido = new TextBox();
            txtEdad = new TextBox();
            txtCarrera = new TextBox();
            btnPresentar = new Button();
            SuspendLayout();
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Location = new Point(39, 40);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(51, 15);
            lblNombre.TabIndex = 0;
            lblNombre.Text = "Nombre";
            lblNombre.Click += label1_Click;
            // 
            // lblEdad
            // 
            lblEdad.AutoSize = true;
            lblEdad.Location = new Point(39, 104);
            lblEdad.Name = "lblEdad";
            lblEdad.Size = new Size(33, 15);
            lblEdad.TabIndex = 2;
            lblEdad.Text = "Edad";
            lblEdad.Click += lblEdad_Click;
            // 
            // lblCarrera
            // 
            lblCarrera.AutoSize = true;
            lblCarrera.Location = new Point(39, 137);
            lblCarrera.Name = "lblCarrera";
            lblCarrera.Size = new Size(45, 15);
            lblCarrera.TabIndex = 3;
            lblCarrera.Text = "Carrera";
            lblCarrera.Click += label4_Click;
            // 
            // lblApellido
            // 
            lblApellido.AutoSize = true;
            lblApellido.Location = new Point(39, 73);
            lblApellido.Name = "lblApellido";
            lblApellido.Size = new Size(51, 15);
            lblApellido.TabIndex = 4;
            lblApellido.Text = "Apellido";
            lblApellido.Click += label5_Click;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(112, 41);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(123, 23);
            txtNombre.TabIndex = 5;
            // 
            // txtApellido
            // 
            txtApellido.Location = new Point(107, 70);
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(128, 23);
            txtApellido.TabIndex = 6;
            // 
            // txtEdad
            // 
            txtEdad.Location = new Point(107, 104);
            txtEdad.Name = "txtEdad";
            txtEdad.Size = new Size(31, 23);
            txtEdad.TabIndex = 7;
            // 
            // txtCarrera
            // 
            txtCarrera.Location = new Point(107, 136);
            txtCarrera.Name = "txtCarrera";
            txtCarrera.Size = new Size(128, 23);
            txtCarrera.TabIndex = 8;
            // 
            // btnPresentar
            // 
            btnPresentar.Location = new Point(133, 180);
            btnPresentar.Name = "btnPresentar";
            btnPresentar.Size = new Size(75, 23);
            btnPresentar.TabIndex = 9;
            btnPresentar.Text = "Presentar";
            btnPresentar.UseVisualStyleBackColor = true;
            // 
            // frmEtiquetas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(298, 231);
            Controls.Add(btnPresentar);
            Controls.Add(txtCarrera);
            Controls.Add(txtEdad);
            Controls.Add(txtApellido);
            Controls.Add(txtNombre);
            Controls.Add(lblApellido);
            Controls.Add(lblCarrera);
            Controls.Add(lblEdad);
            Controls.Add(lblNombre);
            Name = "frmEtiquetas";
            Text = "Presentación Personal";
            Load += frmEtiquetas_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblNombre;
        private Label lblEdad;
        private Label lblCarrera;
        private Label lblApellido;
        private TextBox txtNombre;
        private TextBox txtApellido;
        private TextBox txtEdad;
        private TextBox txtCarrera;
        private Button btnPresentar;
    }
}