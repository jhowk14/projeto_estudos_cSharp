namespace T31_ProjetoBase
{
    partial class frmExtra04
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
            txtPalpite = new TextBox();
            label1 = new Label();
            btnResposta = new Button();
            SuspendLayout();
            // 
            // txtPalpite
            // 
            txtPalpite.Location = new Point(36, 38);
            txtPalpite.Name = "txtPalpite";
            txtPalpite.Size = new Size(100, 23);
            txtPalpite.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(27, 14);
            label1.Name = "label1";
            label1.Size = new Size(336, 21);
            label1.TabIndex = 1;
            label1.Text = "Tente adivinhar o número secreto ( de 1 a 100 )";
            // 
            // btnResposta
            // 
            btnResposta.Location = new Point(36, 81);
            btnResposta.Name = "btnResposta";
            btnResposta.Size = new Size(210, 52);
            btnResposta.TabIndex = 2;
            btnResposta.Text = "Confirmar Palpite";
            btnResposta.UseVisualStyleBackColor = true;
            btnResposta.Click += button1_Click;
            // 
            // frmExtra04
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(466, 275);
            Controls.Add(btnResposta);
            Controls.Add(label1);
            Controls.Add(txtPalpite);
            Name = "frmExtra04";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "POO - Jogo da Adivinhação";
            Load += frmExtra04_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtPalpite;
        private Label label1;
        private Button btnResposta;
    }
}