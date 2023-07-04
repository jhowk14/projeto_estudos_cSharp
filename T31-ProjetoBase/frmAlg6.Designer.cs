namespace T31_ProjetoBase
{
    partial class frmAlg6
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
            txtNumero = new TextBox();
            btnAdd = new Button();
            lboNumeros = new ListBox();
            btnOrdenar = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ActiveCaptionText;
            label1.Location = new Point(27, 9);
            label1.Name = "label1";
            label1.Size = new Size(141, 21);
            label1.TabIndex = 0;
            label1.Text = "Informe Números :";
            // 
            // txtNumero
            // 
            txtNumero.Location = new Point(37, 43);
            txtNumero.Name = "txtNumero";
            txtNumero.Size = new Size(100, 23);
            txtNumero.TabIndex = 1;
            // 
            // btnAdd
            // 
            btnAdd.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            btnAdd.Location = new Point(143, 36);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(42, 32);
            btnAdd.TabIndex = 2;
            btnAdd.Text = "+";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // lboNumeros
            // 
            lboNumeros.FormattingEnabled = true;
            lboNumeros.ItemHeight = 15;
            lboNumeros.Location = new Point(36, 74);
            lboNumeros.Name = "lboNumeros";
            lboNumeros.Size = new Size(120, 229);
            lboNumeros.TabIndex = 3;
            // 
            // btnOrdenar
            // 
            btnOrdenar.Location = new Point(173, 151);
            btnOrdenar.Name = "btnOrdenar";
            btnOrdenar.Size = new Size(102, 65);
            btnOrdenar.TabIndex = 4;
            btnOrdenar.Text = "Ordenar Números";
            btnOrdenar.UseVisualStyleBackColor = true;
            btnOrdenar.Click += btnOrdenar_Click;
            // 
            // frmAlg6
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(440, 350);
            Controls.Add(btnOrdenar);
            Controls.Add(lboNumeros);
            Controls.Add(btnAdd);
            Controls.Add(txtNumero);
            Controls.Add(label1);
            Name = "frmAlg6";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Algorítmo 06";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtNumero;
        private Button btnAdd;
        private ListBox lboNumeros;
        private Button btnOrdenar;
    }
}