namespace T31_ProjetoBase
{
    partial class frmExtra03
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
            txtFrase = new TextBox();
            lboResultado = new ListBox();
            btnExibir = new Button();
            SuspendLayout();
            // 
            // txtFrase
            // 
            txtFrase.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            txtFrase.ForeColor = Color.Blue;
            txtFrase.Location = new Point(44, 27);
            txtFrase.Name = "txtFrase";
            txtFrase.Size = new Size(497, 29);
            txtFrase.TabIndex = 0;
            // 
            // lboResultado
            // 
            lboResultado.FormattingEnabled = true;
            lboResultado.ItemHeight = 15;
            lboResultado.Location = new Point(44, 117);
            lboResultado.Name = "lboResultado";
            lboResultado.Size = new Size(497, 94);
            lboResultado.TabIndex = 1;
            // 
            // btnExibir
            // 
            btnExibir.Location = new Point(44, 62);
            btnExibir.Name = "btnExibir";
            btnExibir.Size = new Size(119, 34);
            btnExibir.TabIndex = 2;
            btnExibir.Text = "Exibir";
            btnExibir.UseVisualStyleBackColor = true;
            btnExibir.Click += btnExibir_Click;
            // 
            // frmExtra03
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(585, 223);
            Controls.Add(btnExibir);
            Controls.Add(lboResultado);
            Controls.Add(txtFrase);
            Name = "frmExtra03";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Exibir Frase";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtFrase;
        private ListBox lboResultado;
        private Button btnExibir;
    }
}