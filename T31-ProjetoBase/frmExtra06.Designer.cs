namespace T31_ProjetoBase
{
    partial class frmExtra06
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
            button1 = new Button();
            txtNumero = new TextBox();
            label1 = new Label();
            btnRodar = new Button();
            txtCentena = new TextBox();
            txtDezena = new TextBox();
            txtUnidade = new TextBox();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(112, 167);
            button1.Name = "button1";
            button1.Size = new Size(135, 31);
            button1.TabIndex = 13;
            button1.Text = "Rodar e Parar em ...";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // txtNumero
            // 
            txtNumero.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            txtNumero.Location = new Point(144, 214);
            txtNumero.Name = "txtNumero";
            txtNumero.Size = new Size(68, 34);
            txtNumero.TabIndex = 12;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(0, 0, 192);
            label1.Location = new Point(102, 36);
            label1.Name = "label1";
            label1.Size = new Size(157, 21);
            label1.TabIndex = 11;
            label1.Text = "Odômetro de 3 casas";
            // 
            // btnRodar
            // 
            btnRodar.Location = new Point(112, 114);
            btnRodar.Name = "btnRodar";
            btnRodar.Size = new Size(135, 34);
            btnRodar.TabIndex = 10;
            btnRodar.Text = "Rodar";
            btnRodar.UseVisualStyleBackColor = true;
            btnRodar.Click += btnRodar_Click;
            // 
            // txtCentena
            // 
            txtCentena.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            txtCentena.Location = new Point(112, 70);
            txtCentena.Name = "txtCentena";
            txtCentena.Size = new Size(41, 34);
            txtCentena.TabIndex = 9;
            // 
            // txtDezena
            // 
            txtDezena.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            txtDezena.Location = new Point(159, 70);
            txtDezena.Name = "txtDezena";
            txtDezena.Size = new Size(41, 34);
            txtDezena.TabIndex = 8;
            // 
            // txtUnidade
            // 
            txtUnidade.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            txtUnidade.Location = new Point(206, 70);
            txtUnidade.Name = "txtUnidade";
            txtUnidade.Size = new Size(41, 34);
            txtUnidade.TabIndex = 7;
            // 
            // frmExtra06
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(356, 303);
            Controls.Add(button1);
            Controls.Add(txtNumero);
            Controls.Add(label1);
            Controls.Add(btnRodar);
            Controls.Add(txtCentena);
            Controls.Add(txtDezena);
            Controls.Add(txtUnidade);
            Name = "frmExtra06";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmExtra06";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private TextBox txtNumero;
        private Label label1;
        private Button btnRodar;
        private TextBox txtCentena;
        private TextBox txtDezena;
        private TextBox txtUnidade;
    }
}