namespace T31_ProjetoBase
{
    partial class POO
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
            txtPalp = new TextBox();
            btnPalp = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(33, 24);
            label1.Name = "label1";
            label1.Size = new Size(252, 15);
            label1.TabIndex = 0;
            label1.Text = "Tente adivinhar o número secreto ( de 1 a 100 )";
            // 
            // txtPalp
            // 
            txtPalp.Location = new Point(78, 55);
            txtPalp.Name = "txtPalp";
            txtPalp.Size = new Size(156, 23);
            txtPalp.TabIndex = 1;
            // 
            // btnPalp
            // 
            btnPalp.Location = new Point(78, 98);
            btnPalp.Name = "btnPalp";
            btnPalp.Size = new Size(156, 48);
            btnPalp.TabIndex = 2;
            btnPalp.Text = "Confirmar Palpite";
            btnPalp.UseVisualStyleBackColor = true;
            btnPalp.Click += btnPalp_Click;
            // 
            // POO
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(319, 181);
            Controls.Add(btnPalp);
            Controls.Add(txtPalp);
            Controls.Add(label1);
            Name = "POO";
            Text = "POO";
            Load += POO_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtPalp;
        private Button btnPalp;
    }
}