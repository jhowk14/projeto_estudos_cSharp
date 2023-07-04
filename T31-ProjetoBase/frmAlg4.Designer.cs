namespace T31_ProjetoBase
{
    partial class frmAlg4
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
            txtIMC = new TextBox();
            btnCalcular = new Button();
            txtAltura = new TextBox();
            txtPeso = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            lblResultado = new Label();
            label1 = new Label();
            SuspendLayout();
            // 
            // txtIMC
            // 
            txtIMC.Location = new Point(124, 223);
            txtIMC.Name = "txtIMC";
            txtIMC.ReadOnly = true;
            txtIMC.Size = new Size(100, 23);
            txtIMC.TabIndex = 12;
            // 
            // btnCalcular
            // 
            btnCalcular.Location = new Point(32, 166);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(192, 40);
            btnCalcular.TabIndex = 11;
            btnCalcular.Text = "Calcular";
            btnCalcular.UseVisualStyleBackColor = true;
            btnCalcular.Click += btnCalcular_Click;
            // 
            // txtAltura
            // 
            txtAltura.Location = new Point(124, 120);
            txtAltura.Name = "txtAltura";
            txtAltura.Size = new Size(100, 23);
            txtAltura.TabIndex = 10;
            // 
            // txtPeso
            // 
            txtPeso.Location = new Point(124, 70);
            txtPeso.Name = "txtPeso";
            txtPeso.Size = new Size(100, 23);
            txtPeso.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(32, 225);
            label4.Name = "label4";
            label4.Size = new Size(39, 18);
            label4.TabIndex = 6;
            label4.Text = "IMC";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(32, 120);
            label3.Name = "label3";
            label3.Size = new Size(57, 18);
            label3.TabIndex = 7;
            label3.Text = "Altura";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(32, 70);
            label2.Name = "label2";
            label2.Size = new Size(47, 18);
            label2.TabIndex = 8;
            label2.Text = "Peso";
            // 
            // lblResultado
            // 
            lblResultado.AutoSize = true;
            lblResultado.Font = new Font("Verdana", 15F, FontStyle.Regular, GraphicsUnit.Point);
            lblResultado.Location = new Point(54, 267);
            lblResultado.Name = "lblResultado";
            lblResultado.Size = new Size(138, 25);
            lblResultado.TabIndex = 13;
            lblResultado.Text = "--------------";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Verdana", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(32, 24);
            label1.Name = "label1";
            label1.Size = new Size(192, 25);
            label1.TabIndex = 9;
            label1.Text = "Calcule o seu IMC";
            // 
            // frmAlg4
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(265, 333);
            Controls.Add(txtIMC);
            Controls.Add(btnCalcular);
            Controls.Add(txtAltura);
            Controls.Add(txtPeso);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(lblResultado);
            Controls.Add(label1);
            Name = "frmAlg4";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Algorítmo 04";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtIMC;
        private Button btnCalcular;
        private TextBox txtAltura;
        private TextBox txtPeso;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label lblResultado;
        private Label label1;
    }
}