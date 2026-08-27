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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            textBox5 = new TextBox();
            label7 = new Label();
            comboBox1 = new ComboBox();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            label11 = new Label();
            label12 = new Label();
            label13 = new Label();
            label14 = new Label();
            label15 = new Label();
            label16 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(130, 21);
            label1.Name = "label1";
            label1.Size = new Size(133, 15);
            label1.TabIndex = 0;
            label1.Text = "GESTIÓN DE FARMACIA";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(25, 56);
            label2.Name = "label2";
            label2.Size = new Size(86, 15);
            label2.TabIndex = 1;
            label2.Text = "Medicamentos";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(25, 85);
            label3.Name = "label3";
            label3.Size = new Size(68, 15);
            label3.TabIndex = 2;
            label3.Text = "Laboratorio";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(25, 118);
            label4.Name = "label4";
            label4.Size = new Size(46, 15);
            label4.TabIndex = 3;
            label4.Text = "Código";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(31, 155);
            label5.Name = "label5";
            label5.Size = new Size(40, 15);
            label5.TabIndex = 4;
            label5.Text = "Precio";
            label5.Click += label5_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(35, 197);
            label6.Name = "label6";
            label6.Size = new Size(36, 15);
            label6.TabIndex = 5;
            label6.Text = "Stock";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(144, 52);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(143, 23);
            textBox1.TabIndex = 6;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(144, 81);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(143, 23);
            textBox2.TabIndex = 7;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(144, 114);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(143, 23);
            textBox3.TabIndex = 8;
            textBox3.TextChanged += textBox3_TextChanged;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(144, 151);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(143, 23);
            textBox4.TabIndex = 9;
            textBox4.TextChanged += textBox4_TextChanged;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(144, 193);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(143, 23);
            textBox5.TabIndex = 10;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(37, 259);
            label7.Name = "label7";
            label7.Size = new Size(34, 15);
            label7.TabIndex = 11;
            label7.Text = "Tipo:";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(95, 259);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(121, 23);
            comboBox1.TabIndex = 12;
            comboBox1.Text = "Venta Libre";
            // 
            // button1
            // 
            button1.Location = new Point(31, 328);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 13;
            button1.Text = "AGREGAR";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(144, 328);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 14;
            button2.Text = "MODIFICAR";
            button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Location = new Point(260, 328);
            button3.Name = "button3";
            button3.Size = new Size(75, 23);
            button3.TabIndex = 15;
            button3.Text = "BORRAR";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Location = new Point(92, 504);
            button4.Name = "button4";
            button4.Size = new Size(171, 40);
            button4.TabIndex = 16;
            button4.Text = "BUSCAR MEDICAMENTO";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.White;
            label8.Location = new Point(66, 385);
            label8.Name = "label8";
            label8.Size = new Size(81, 15);
            label8.TabIndex = 17;
            label8.Text = "Medicamento";
            label8.Click += label8_Click;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = Color.White;
            label9.Location = new Point(158, 385);
            label9.Name = "label9";
            label9.Size = new Size(40, 15);
            label9.TabIndex = 18;
            label9.Text = "Precio";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.BackColor = Color.White;
            label10.Location = new Point(217, 385);
            label10.Name = "label10";
            label10.Size = new Size(36, 15);
            label10.TabIndex = 19;
            label10.Text = "Stock";
            label10.Click += label10_Click;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.BackColor = Color.White;
            label11.Location = new Point(70, 412);
            label11.Name = "label11";
            label11.Size = new Size(73, 15);
            label11.TabIndex = 20;
            label11.Text = "Paracetamol";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.BackColor = Color.White;
            label12.Location = new Point(73, 435);
            label12.Name = "label12";
            label12.Size = new Size(66, 15);
            label12.TabIndex = 21;
            label12.Text = "Ibuprofeno";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.BackColor = Color.White;
            label13.Location = new Point(160, 412);
            label13.Name = "label13";
            label13.Size = new Size(37, 15);
            label13.TabIndex = 22;
            label13.Text = "$2500";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.BackColor = Color.White;
            label14.Location = new Point(160, 435);
            label14.Name = "label14";
            label14.Size = new Size(37, 15);
            label14.TabIndex = 23;
            label14.Text = "$3200";
            label14.Click += label14_Click;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.BackColor = Color.White;
            label15.Location = new Point(226, 407);
            label15.Name = "label15";
            label15.Size = new Size(19, 15);
            label15.TabIndex = 24;
            label15.Text = "35";
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.BackColor = Color.White;
            label16.Location = new Point(226, 435);
            label16.Name = "label16";
            label16.Size = new Size(19, 15);
            label16.TabIndex = 25;
            label16.Text = "20";
            // 
            // frmFarmacia
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(358, 571);
            Controls.Add(label16);
            Controls.Add(label15);
            Controls.Add(label14);
            Controls.Add(label13);
            Controls.Add(label12);
            Controls.Add(label11);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(comboBox1);
            Controls.Add(label7);
            Controls.Add(textBox5);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "frmFarmacia";
            Text = "frmFarmacia";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private TextBox textBox5;
        private Label label7;
        private ComboBox comboBox1;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Label label8;
        private Label label9;
        private Label label10;
        private Label label11;
        private Label label12;
        private Label label13;
        private Label label14;
        private Label label15;
        private Label label16;
    }
}