namespace T31_ProjetoBase
{
    partial class frmAlg1
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
            lblStatus = new Label();
            lblResultado = new Label();
            btnCalcular = new Button();
            txtN4 = new TextBox();
            txtN3 = new TextBox();
            txtN2 = new TextBox();
            txtN1 = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            SuspendLayout();
            // 
            // lblStatus
            // 
            lblStatus.AutoSize = true;
            lblStatus.Location = new Point(280, 97);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(31, 15);
            lblStatus.TabIndex = 18;
            lblStatus.Text = ">>>";
            // 
            // lblResultado
            // 
            lblResultado.AutoSize = true;
            lblResultado.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblResultado.ForeColor = Color.Blue;
            lblResultado.Location = new Point(38, 164);
            lblResultado.Name = "lblResultado";
            lblResultado.Size = new Size(72, 15);
            lblResultado.TabIndex = 17;
            lblResultado.Text = "-------------";
            // 
            // btnCalcular
            // 
            btnCalcular.Location = new Point(278, 51);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(172, 33);
            btnCalcular.TabIndex = 16;
            btnCalcular.Text = "Calcular a Média";
            btnCalcular.UseVisualStyleBackColor = true;
            btnCalcular.Click += btnCalcular_Click;
            // 
            // txtN4
            // 
            txtN4.Location = new Point(140, 123);
            txtN4.Name = "txtN4";
            txtN4.Size = new Size(100, 23);
            txtN4.TabIndex = 15;
            // 
            // txtN3
            // 
            txtN3.Location = new Point(140, 94);
            txtN3.Name = "txtN3";
            txtN3.Size = new Size(100, 23);
            txtN3.TabIndex = 14;
            // 
            // txtN2
            // 
            txtN2.Location = new Point(140, 65);
            txtN2.Name = "txtN2";
            txtN2.Size = new Size(100, 23);
            txtN2.TabIndex = 13;
            // 
            // txtN1
            // 
            txtN1.Location = new Point(140, 36);
            txtN1.Name = "txtN1";
            txtN1.Size = new Size(100, 23);
            txtN1.TabIndex = 12;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(35, 129);
            label4.Name = "label4";
            label4.Size = new Size(99, 15);
            label4.TabIndex = 8;
            label4.Text = "Informe a Nota 4:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(35, 99);
            label3.Name = "label3";
            label3.Size = new Size(99, 15);
            label3.TabIndex = 9;
            label3.Text = "Informe a Nota 3:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(35, 69);
            label2.Name = "label2";
            label2.Size = new Size(99, 15);
            label2.TabIndex = 10;
            label2.Text = "Informe a Nota 2:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(35, 39);
            label1.Name = "label1";
            label1.Size = new Size(99, 15);
            label1.TabIndex = 11;
            label1.Text = "Informe a Nota 1:";
            // 
            // frmAlg1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(477, 212);
            Controls.Add(lblStatus);
            Controls.Add(lblResultado);
            Controls.Add(btnCalcular);
            Controls.Add(txtN4);
            Controls.Add(txtN3);
            Controls.Add(txtN2);
            Controls.Add(txtN1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "frmAlg1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Algorítmo 01";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblStatus;
        private Label lblResultado;
        private Button btnCalcular;
        private TextBox txtN4;
        private TextBox txtN3;
        private TextBox txtN2;
        private TextBox txtN1;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
    }
}