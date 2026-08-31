namespace prjPedrazaInterfazGrafica
{
    partial class frmCalculadora
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCalculadora));
            label2 = new Label();
            label3 = new Label();
            txtNumero1 = new TextBox();
            txtNumero2 = new TextBox();
            btnSuma = new Button();
            btnResta = new Button();
            btnMultiplicación = new Button();
            btnDivisión = new Button();
            label4 = new Label();
            lblTotal = new TextBox();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Thistle;
            label2.Location = new Point(31, 34);
            label2.Name = "label2";
            label2.Size = new Size(63, 15);
            label2.TabIndex = 1;
            label2.Text = "Numero 1:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Thistle;
            label3.Location = new Point(31, 85);
            label3.Name = "label3";
            label3.Size = new Size(63, 15);
            label3.TabIndex = 2;
            label3.Text = "Numero 2:";
            label3.Click += label3_Click;
            // 
            // txtNumero1
            // 
            txtNumero1.Location = new Point(107, 34);
            txtNumero1.Name = "txtNumero1";
            txtNumero1.Size = new Size(100, 23);
            txtNumero1.TabIndex = 3;
            txtNumero1.TextChanged += txtNumero1_TextChanged;
            // 
            // txtNumero2
            // 
            txtNumero2.Location = new Point(107, 82);
            txtNumero2.Name = "txtNumero2";
            txtNumero2.Size = new Size(100, 23);
            txtNumero2.TabIndex = 4;
            // 
            // btnSuma
            // 
            btnSuma.BackColor = Color.PaleVioletRed;
            btnSuma.Location = new Point(39, 127);
            btnSuma.Name = "btnSuma";
            btnSuma.Size = new Size(45, 27);
            btnSuma.TabIndex = 5;
            btnSuma.Text = "+";
            btnSuma.UseVisualStyleBackColor = false;
            btnSuma.Click += btnSuma_Click;
            // 
            // btnResta
            // 
            btnResta.BackColor = Color.PaleVioletRed;
            btnResta.Location = new Point(99, 127);
            btnResta.Name = "btnResta";
            btnResta.Size = new Size(45, 28);
            btnResta.TabIndex = 6;
            btnResta.Text = "-";
            btnResta.UseVisualStyleBackColor = false;
            btnResta.Click += btnResta_Click;
            // 
            // btnMultiplicación
            // 
            btnMultiplicación.BackColor = Color.PaleVioletRed;
            btnMultiplicación.Location = new Point(159, 128);
            btnMultiplicación.Name = "btnMultiplicación";
            btnMultiplicación.Size = new Size(44, 27);
            btnMultiplicación.TabIndex = 7;
            btnMultiplicación.Text = "x";
            btnMultiplicación.UseVisualStyleBackColor = false;
            btnMultiplicación.Click += btnMultiplicación_Click;
            // 
            // btnDivisión
            // 
            btnDivisión.BackColor = Color.PaleVioletRed;
            btnDivisión.Location = new Point(219, 127);
            btnDivisión.Name = "btnDivisión";
            btnDivisión.Size = new Size(45, 27);
            btnDivisión.TabIndex = 8;
            btnDivisión.Text = "÷";
            btnDivisión.UseVisualStyleBackColor = false;
            btnDivisión.Click += button4_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Plum;
            label4.Location = new Point(58, 194);
            label4.Name = "label4";
            label4.Size = new Size(62, 15);
            label4.TabIndex = 9;
            label4.Text = "Resultado:";
            // 
            // lblTotal
            // 
            lblTotal.Location = new Point(126, 191);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(100, 23);
            lblTotal.TabIndex = 10;
            // 
            // frmCalculadora
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.MistyRose;
            ClientSize = new Size(286, 233);
            Controls.Add(lblTotal);
            Controls.Add(label4);
            Controls.Add(btnDivisión);
            Controls.Add(btnMultiplicación);
            Controls.Add(btnResta);
            Controls.Add(btnSuma);
            Controls.Add(txtNumero2);
            Controls.Add(txtNumero1);
            Controls.Add(label3);
            Controls.Add(label2);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "frmCalculadora";
            Text = "frmCalculadora";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label2;
        private Label label3;
        private TextBox txtNumero1;
        private TextBox txtNumero2;
        private Button btnSuma;
        private Button btnResta;
        private Button btnMultiplicación;
        private Button btnDivisión;
        private Label label4;
        private TextBox lblTotal;
    }
}