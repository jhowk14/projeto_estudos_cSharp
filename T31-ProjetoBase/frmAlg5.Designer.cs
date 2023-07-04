namespace T31_ProjetoBase
{
    partial class frmAlg5
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
            lboResultado = new ListBox();
            btnCalcular = new Button();
            txtTabuada = new TextBox();
            label1 = new Label();
            SuspendLayout();
            // 
            // lboResultado
            // 
            lboResultado.FormattingEnabled = true;
            lboResultado.ItemHeight = 15;
            lboResultado.Location = new Point(135, 70);
            lboResultado.Name = "lboResultado";
            lboResultado.Size = new Size(168, 184);
            lboResultado.TabIndex = 7;
            // 
            // btnCalcular
            // 
            btnCalcular.Location = new Point(44, 70);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(75, 23);
            btnCalcular.TabIndex = 6;
            btnCalcular.Text = "Calcular";
            btnCalcular.UseVisualStyleBackColor = true;
            btnCalcular.Click += btnCalcular_Click;
            // 
            // txtTabuada
            // 
            txtTabuada.Location = new Point(249, 26);
            txtTabuada.Name = "txtTabuada";
            txtTabuada.Size = new Size(54, 23);
            txtTabuada.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(135, 29);
            label1.Name = "label1";
            label1.Size = new Size(108, 15);
            label1.TabIndex = 4;
            label1.Text = "Informe a Tabuada:";
            // 
            // frmAlg5
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(351, 308);
            Controls.Add(lboResultado);
            Controls.Add(btnCalcular);
            Controls.Add(txtTabuada);
            Controls.Add(label1);
            Name = "frmAlg5";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Algorítmo 05";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox lboResultado;
        private Button btnCalcular;
        private TextBox txtTabuada;
        private Label label1;
    }
}