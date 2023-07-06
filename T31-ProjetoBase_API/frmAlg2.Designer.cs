namespace T31_ProjetoBase
{
    partial class frmAlg2
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
            btnCalcular = new Button();
            txtHr = new TextBox();
            txtKm = new TextBox();
            label2 = new Label();
            label1 = new Label();
            SuspendLayout();
            // 
            // btnCalcular
            // 
            btnCalcular.Location = new Point(211, 164);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(197, 43);
            btnCalcular.TabIndex = 2;
            btnCalcular.Text = "Calcular Velocidade Média";
            btnCalcular.UseVisualStyleBackColor = true;
            btnCalcular.Click += btnCalcular_Click;
            // 
            // txtHr
            // 
            txtHr.Location = new Point(211, 120);
            txtHr.Name = "txtHr";
            txtHr.Size = new Size(100, 23);
            txtHr.TabIndex = 1;
            // 
            // txtKm
            // 
            txtKm.Location = new Point(211, 63);
            txtKm.Name = "txtKm";
            txtKm.Size = new Size(100, 23);
            txtKm.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(32, 123);
            label2.Name = "label2";
            label2.Size = new Size(142, 15);
            label2.TabIndex = 6;
            label2.Text = "Tempo Gasto ( em horas )";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(32, 66);
            label1.Name = "label1";
            label1.Size = new Size(93, 15);
            label1.TabIndex = 5;
            label1.Text = "KMs Percorridos";
            // 
            // frmAlg2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(484, 319);
            Controls.Add(btnCalcular);
            Controls.Add(txtHr);
            Controls.Add(txtKm);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "frmAlg2";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Algorítmo 02";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnCalcular;
        private TextBox txtHr;
        private TextBox txtKm;
        private Label label2;
        private Label label1;
    }
}