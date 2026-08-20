namespace prjPedrazaInterfazGrafica
{
    partial class frmFarmacia
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
            lblProductosDeFarmacia = new Label();
            lblCantidad = new Label();
            lblQuienRegistra = new Label();
            lblNombre = new Label();
            lblPrecio = new Label();
            lblPrecioIVA = new Label();
            lblLaboratorio = new Label();
            btnAlmacenar = new Button();
            txtCantidad = new TextBox();
            txtQuienRegistra = new TextBox();
            SuspendLayout();
            // 
            // lblProductosDeFarmacia
            // 
            lblProductosDeFarmacia.AutoSize = true;
            lblProductosDeFarmacia.Location = new Point(129, 28);
            lblProductosDeFarmacia.Name = "lblProductosDeFarmacia";
            lblProductosDeFarmacia.Size = new Size(128, 15);
            lblProductosDeFarmacia.TabIndex = 0;
            lblProductosDeFarmacia.Text = "Productos de Farmacia";
            // 
            // lblCantidad
            // 
            lblCantidad.AutoSize = true;
            lblCantidad.Location = new Point(65, 75);
            lblCantidad.Name = "lblCantidad";
            lblCantidad.Size = new Size(55, 15);
            lblCantidad.TabIndex = 1;
            lblCantidad.Text = "Cantidad";
            // 
            // lblQuienRegistra
            // 
            lblQuienRegistra.AutoSize = true;
            lblQuienRegistra.Location = new Point(258, 75);
            lblQuienRegistra.Name = "lblQuienRegistra";
            lblQuienRegistra.Size = new Size(84, 15);
            lblQuienRegistra.TabIndex = 2;
            lblQuienRegistra.Text = "Quien Registra";
            lblQuienRegistra.Click += label3_Click;
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Location = new Point(67, 197);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(51, 15);
            lblNombre.TabIndex = 3;
            lblNombre.Text = "Nombre";
            // 
            // lblPrecio
            // 
            lblPrecio.AutoSize = true;
            lblPrecio.Location = new Point(72, 302);
            lblPrecio.Name = "lblPrecio";
            lblPrecio.Size = new Size(40, 15);
            lblPrecio.TabIndex = 4;
            lblPrecio.Text = "Precio";
            // 
            // lblPrecioIVA
            // 
            lblPrecioIVA.AutoSize = true;
            lblPrecioIVA.Location = new Point(270, 312);
            lblPrecioIVA.Name = "lblPrecioIVA";
            lblPrecioIVA.Size = new Size(60, 15);
            lblPrecioIVA.TabIndex = 5;
            lblPrecioIVA.Text = "Precio IVA";
            // 
            // lblLaboratorio
            // 
            lblLaboratorio.AutoSize = true;
            lblLaboratorio.Location = new Point(266, 197);
            lblLaboratorio.Name = "lblLaboratorio";
            lblLaboratorio.Size = new Size(68, 15);
            lblLaboratorio.TabIndex = 6;
            lblLaboratorio.Text = "Laboratorio";
            // 
            // btnAlmacenar
            // 
            btnAlmacenar.Location = new Point(129, 366);
            btnAlmacenar.Name = "btnAlmacenar";
            btnAlmacenar.Size = new Size(127, 56);
            btnAlmacenar.TabIndex = 7;
            btnAlmacenar.Text = "Almacenar";
            btnAlmacenar.UseVisualStyleBackColor = true;
            // 
            // txtCantidad
            // 
            txtCantidad.Location = new Point(35, 110);
            txtCantidad.Name = "txtCantidad";
            txtCantidad.Size = new Size(116, 23);
            txtCantidad.TabIndex = 8;
            // 
            // txtQuienRegistra
            // 
            txtQuienRegistra.Location = new Point(242, 110);
            txtQuienRegistra.Name = "txtQuienRegistra";
            txtQuienRegistra.Size = new Size(100, 23);
            txtQuienRegistra.TabIndex = 9;
            // 
            // frmFarmacia
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(409, 457);
            Controls.Add(txtQuienRegistra);
            Controls.Add(txtCantidad);
            Controls.Add(btnAlmacenar);
            Controls.Add(lblLaboratorio);
            Controls.Add(lblPrecioIVA);
            Controls.Add(lblPrecio);
            Controls.Add(lblNombre);
            Controls.Add(lblQuienRegistra);
            Controls.Add(lblCantidad);
            Controls.Add(lblProductosDeFarmacia);
            Name = "frmFarmacia";
            Text = "frmFarmacia";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblProductosDeFarmacia;
        private Label lblCantidad;
        private Label lblQuienRegistra;
        private Label lblNombre;
        private Label lblPrecio;
        private Label lblPrecioIVA;
        private Label lblLaboratorio;
        private Button btnAlmacenar;
        private TextBox txtCantidad;
        private TextBox txtQuienRegistra;
    }
}