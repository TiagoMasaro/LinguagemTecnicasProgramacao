namespace HelloWindowsForms
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            textPeso = new TextBox();
            textAltura = new TextBox();
            btnCalcular = new Button();
            lblResultado = new Label();
            lblInterpretacao = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F);
            label1.ForeColor = Color.CadetBlue;
            label1.Location = new Point(300, 33);
            label1.Name = "label1";
            label1.Size = new Size(158, 32);
            label1.TabIndex = 0;
            label1.Text = "SISTEMA IMC";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 18F);
            label2.ForeColor = Color.CadetBlue;
            label2.Location = new Point(35, 187);
            label2.Name = "label2";
            label2.Size = new Size(101, 32);
            label2.TabIndex = 1;
            label2.Text = "ALTURA:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 18F);
            label3.ForeColor = Color.CadetBlue;
            label3.Location = new Point(35, 115);
            label3.Name = "label3";
            label3.Size = new Size(75, 32);
            label3.TabIndex = 2;
            label3.Text = "PESO:";
            label3.Click += label3_Click;
            // 
            // textPeso
            // 
            textPeso.Location = new Point(168, 124);
            textPeso.Name = "textPeso";
            textPeso.Size = new Size(100, 23);
            textPeso.TabIndex = 3;
            // 
            // textAltura
            // 
            textAltura.Location = new Point(168, 196);
            textAltura.Name = "textAltura";
            textAltura.Size = new Size(100, 23);
            textAltura.TabIndex = 4;
            textAltura.TextChanged += textBox2_TextChanged;
            // 
            // btnCalcular
            // 
            btnCalcular.BackColor = SystemColors.ActiveCaption;
            btnCalcular.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCalcular.Location = new Point(78, 252);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(162, 46);
            btnCalcular.TabIndex = 5;
            btnCalcular.Text = "Calcular";
            btnCalcular.UseVisualStyleBackColor = false;
            btnCalcular.Click += button1_Click;
            // 
            // lblResultado
            // 
            lblResultado.AutoSize = true;
            lblResultado.Font = new Font("Segoe UI", 18F);
            lblResultado.ForeColor = Color.CadetBlue;
            lblResultado.Location = new Point(35, 325);
            lblResultado.Name = "lblResultado";
            lblResultado.Size = new Size(144, 32);
            lblResultado.TabIndex = 6;
            lblResultado.Text = "RESULTADO:";
            lblResultado.Click += label4_Click;
            // 
            // lblInterpretacao
            // 
            lblInterpretacao.AutoSize = true;
            lblInterpretacao.Font = new Font("Segoe UI", 18F);
            lblInterpretacao.ForeColor = Color.CadetBlue;
            lblInterpretacao.Location = new Point(35, 386);
            lblInterpretacao.Name = "lblInterpretacao";
            lblInterpretacao.Size = new Size(195, 32);
            lblInterpretacao.TabIndex = 7;
            lblInterpretacao.Text = "INTERPRETAÇÃO:";
            lblInterpretacao.Click += label4_Click_1;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblInterpretacao);
            Controls.Add(lblResultado);
            Controls.Add(btnCalcular);
            Controls.Add(textAltura);
            Controls.Add(textPeso);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox textPeso;
        private TextBox textAltura;
        private Button btnCalcular;
        private Label lblResultado;
        private Label lblInterpretacao;
    }
}
