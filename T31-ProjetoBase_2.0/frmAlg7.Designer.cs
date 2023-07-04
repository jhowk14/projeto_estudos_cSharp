namespace T31_ProjetoBase
{
    partial class frmAlg7
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
            txtSoma = new TextBox();
            lboSoma = new ListBox();
            button1 = new Button();
            button2 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(60, 43);
            label1.Name = "label1";
            label1.Size = new Size(123, 15);
            label1.TabIndex = 0;
            label1.Text = "SOMATORIA DE 1 ATE:";
            // 
            // txtSoma
            // 
            txtSoma.Location = new Point(189, 43);
            txtSoma.Name = "txtSoma";
            txtSoma.Size = new Size(100, 23);
            txtSoma.TabIndex = 1;
            // 
            // lboSoma
            // 
            lboSoma.FormattingEnabled = true;
            lboSoma.ItemHeight = 15;
            lboSoma.Location = new Point(314, 43);
            lboSoma.Name = "lboSoma";
            lboSoma.Size = new Size(350, 304);
            lboSoma.TabIndex = 2;
            // 
            // button1
            // 
            button1.Location = new Point(60, 92);
            button1.Name = "button1";
            button1.Size = new Size(229, 23);
            button1.TabIndex = 3;
            button1.Text = "SOMAR O INTERVALO (FOR)";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(60, 142);
            button2.Name = "button2";
            button2.Size = new Size(229, 23);
            button2.TabIndex = 3;
            button2.Text = "SOMAR O INTERVALO (GAUSS)";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // frmAlg7
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(689, 386);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(lboSoma);
            Controls.Add(txtSoma);
            Controls.Add(label1);
            Name = "frmAlg7";
            Text = "frmAlg7";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtSoma;
        private ListBox lboSoma;
        private Button button1;
        private Button button2;
    }
}