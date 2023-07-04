namespace T31_ProjetoBase
{
    partial class frmExtra01
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
            txtNumero = new TextBox();
            btnVerificar = new Button();
            button1 = new Button();
            SuspendLayout();
            // 
            // txtNumero
            // 
            txtNumero.Location = new Point(12, 28);
            txtNumero.Name = "txtNumero";
            txtNumero.Size = new Size(100, 23);
            txtNumero.TabIndex = 0;
            // 
            // btnVerificar
            // 
            btnVerificar.Location = new Point(128, 12);
            btnVerificar.Name = "btnVerificar";
            btnVerificar.Size = new Size(100, 64);
            btnVerificar.TabIndex = 1;
            btnVerificar.Text = "Verificar";
            btnVerificar.UseVisualStyleBackColor = true;
            btnVerificar.Click += btnVerificar_Click;
            // 
            // button1
            // 
            button1.Location = new Point(23, 118);
            button1.Name = "button1";
            button1.Size = new Size(317, 37);
            button1.TabIndex = 2;
            button1.Text = "Teste If Ternário com Interpolação de String";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // frmExtra01
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(369, 189);
            Controls.Add(button1);
            Controls.Add(btnVerificar);
            Controls.Add(txtNumero);
            Name = "frmExtra01";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Verificador de Par ou Ímpar";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtNumero;
        private Button btnVerificar;
        private Button button1;
    }
}