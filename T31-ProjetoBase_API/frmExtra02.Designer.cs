namespace T31_ProjetoBase
{
    partial class frmExtra02
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
            cboCidades = new ComboBox();
            btnExibir = new Button();
            SuspendLayout();
            // 
            // cboCidades
            // 
            cboCidades.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            cboCidades.ForeColor = Color.Blue;
            cboCidades.FormattingEnabled = true;
            cboCidades.Items.AddRange(new object[] { "São Paulo", "Rio de Janeiro", "Belo Horizonte", "Curitiba", "Salvador", "Porto Alegre", "Recife" });
            cboCidades.Location = new Point(37, 25);
            cboCidades.Name = "cboCidades";
            cboCidades.Size = new Size(255, 29);
            cboCidades.TabIndex = 0;
            // 
            // btnExibir
            // 
            btnExibir.Location = new Point(37, 80);
            btnExibir.Name = "btnExibir";
            btnExibir.Size = new Size(255, 53);
            btnExibir.TabIndex = 1;
            btnExibir.Text = "Exibir Cidade Selecionada";
            btnExibir.UseVisualStyleBackColor = true;
            btnExibir.Click += btnExibir_Click;
            // 
            // frmExtra02
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(336, 160);
            Controls.Add(btnExibir);
            Controls.Add(cboCidades);
            Name = "frmExtra02";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Exibição de Cidade Selecionada";
            ResumeLayout(false);
        }

        #endregion

        private ComboBox cboCidades;
        private Button btnExibir;
    }
}