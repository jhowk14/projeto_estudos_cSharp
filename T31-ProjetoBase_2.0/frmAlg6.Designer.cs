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
            lboNum = new ListBox();
            button1 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(48, 24);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(140, 15);
            label1.TabIndex = 0;
            label1.Text = "Informe Numeros";
            // 
            // txtNumero
            // 
            txtNumero.Location = new Point(48, 58);
            txtNumero.Margin = new Padding(4, 3, 4, 3);
            txtNumero.Name = "txtNumero";
            txtNumero.Size = new Size(127, 22);
            txtNumero.TabIndex = 1;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(183, 58);
            btnAdd.Margin = new Padding(4, 3, 4, 3);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(96, 23);
            btnAdd.TabIndex = 2;
            btnAdd.Text = "+";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // lboNum
            // 
            lboNum.FormattingEnabled = true;
            lboNum.ItemHeight = 15;
            lboNum.Location = new Point(48, 85);
            lboNum.Name = "lboNum";
            lboNum.Size = new Size(127, 319);
            lboNum.TabIndex = 3;
            // 
            // button1
            // 
            button1.Location = new Point(183, 176);
            button1.Name = "button1";
            button1.Size = new Size(96, 44);
            button1.TabIndex = 4;
            button1.Text = "Ordenar Números";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // frmAlg6
            // 
            AutoScaleDimensions = new SizeF(9F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(306, 415);
            Controls.Add(button1);
            Controls.Add(lboNum);
            Controls.Add(btnAdd);
            Controls.Add(txtNumero);
            Controls.Add(label1);
            Font = new Font("Showcard Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point);
            Margin = new Padding(4, 3, 4, 3);
            Name = "frmAlg6";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmAlg6";
            Load += frmAlg6_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtNumero;
        private Button btnAdd;
        private ListBox lboNum;
        private Button button1;
    }
}