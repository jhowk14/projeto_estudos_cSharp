namespace T31_ProjetoBase
{
    partial class frmAlg3
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
            lblResultado = new Label();
            btnMultiplicar = new Button();
            btnDividir = new Button();
            btnSubtrair = new Button();
            btnSomar = new Button();
            txtValor2 = new TextBox();
            txtValor1 = new TextBox();
            label2 = new Label();
            label1 = new Label();
            SuspendLayout();
            // 
            // lblResultado
            // 
            lblResultado.AutoSize = true;
            lblResultado.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblResultado.Location = new Point(38, 138);
            lblResultado.Name = "lblResultado";
            lblResultado.Size = new Size(43, 21);
            lblResultado.TabIndex = 17;
            lblResultado.Text = "===";
            // 
            // btnMultiplicar
            // 
            btnMultiplicar.Location = new Point(219, 107);
            btnMultiplicar.Name = "btnMultiplicar";
            btnMultiplicar.Size = new Size(75, 23);
            btnMultiplicar.TabIndex = 16;
            btnMultiplicar.Text = "Multiplicar";
            btnMultiplicar.UseVisualStyleBackColor = true;
            btnMultiplicar.Click += btnMultiplicar_Click;
            // 
            // btnDividir
            // 
            btnDividir.Location = new Point(219, 78);
            btnDividir.Name = "btnDividir";
            btnDividir.Size = new Size(75, 23);
            btnDividir.TabIndex = 15;
            btnDividir.Text = "Dividir";
            btnDividir.UseVisualStyleBackColor = true;
            btnDividir.Click += btnDividir_Click;
            // 
            // btnSubtrair
            // 
            btnSubtrair.Location = new Point(219, 49);
            btnSubtrair.Name = "btnSubtrair";
            btnSubtrair.Size = new Size(75, 23);
            btnSubtrair.TabIndex = 14;
            btnSubtrair.Text = "Subtrair";
            btnSubtrair.UseVisualStyleBackColor = true;
            btnSubtrair.Click += btnSubtrair_Click;
            // 
            // btnSomar
            // 
            btnSomar.Location = new Point(219, 20);
            btnSomar.Name = "btnSomar";
            btnSomar.Size = new Size(75, 23);
            btnSomar.TabIndex = 13;
            btnSomar.Text = "Somar";
            btnSomar.UseVisualStyleBackColor = true;
            btnSomar.Click += btnSomar_Click;
            // 
            // txtValor2
            // 
            txtValor2.Location = new Point(98, 62);
            txtValor2.Name = "txtValor2";
            txtValor2.Size = new Size(100, 23);
            txtValor2.TabIndex = 12;
            // 
            // txtValor1
            // 
            txtValor1.Location = new Point(98, 23);
            txtValor1.Name = "txtValor1";
            txtValor1.Size = new Size(100, 23);
            txtValor1.TabIndex = 11;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(38, 62);
            label2.Name = "label2";
            label2.Size = new Size(42, 15);
            label2.TabIndex = 10;
            label2.Text = "Valor 2";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(38, 24);
            label1.Name = "label1";
            label1.Size = new Size(42, 15);
            label1.TabIndex = 9;
            label1.Text = "Valor 1";
            // 
            // frmAlg3
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(315, 201);
            Controls.Add(lblResultado);
            Controls.Add(btnMultiplicar);
            Controls.Add(btnDividir);
            Controls.Add(btnSubtrair);
            Controls.Add(btnSomar);
            Controls.Add(txtValor2);
            Controls.Add(txtValor1);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "frmAlg3";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Algorítmo 03";
            Load += frmAlg3_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblResultado;
        private Button btnMultiplicar;
        private Button btnDividir;
        private Button btnSubtrair;
        private Button btnSomar;
        private TextBox txtValor2;
        private TextBox txtValor1;
        private Label label2;
        private Label label1;
    }
}