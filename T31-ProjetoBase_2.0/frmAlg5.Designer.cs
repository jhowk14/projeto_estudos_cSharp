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
            txtTab = new TextBox();
            lbltab = new Label();
            btoTab = new ListBox();
            btnCalc = new Button();
            SuspendLayout();
            // 
            // txtTab
            // 
            txtTab.Location = new Point(165, 64);
            txtTab.Name = "txtTab";
            txtTab.Size = new Size(100, 23);
            txtTab.TabIndex = 0;
            // 
            // lbltab
            // 
            lbltab.AutoSize = true;
            lbltab.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            lbltab.Location = new Point(35, 64);
            lbltab.Name = "lbltab";
            lbltab.Size = new Size(124, 19);
            lbltab.TabIndex = 1;
            lbltab.Text = "informe a Tabuada:";
            // 
            // btoTab
            // 
            btoTab.FormattingEnabled = true;
            btoTab.ItemHeight = 15;
            btoTab.Location = new Point(145, 147);
            btoTab.Name = "btoTab";
            btoTab.Size = new Size(120, 154);
            btoTab.TabIndex = 2;
            // 
            // btnCalc
            // 
            btnCalc.Location = new Point(50, 147);
            btnCalc.Name = "btnCalc";
            btnCalc.Size = new Size(75, 23);
            btnCalc.TabIndex = 3;
            btnCalc.Text = "Calcular";
            btnCalc.UseVisualStyleBackColor = true;
            btnCalc.Click += btnCalc_Click;
            // 
            // frmAlg5
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(332, 314);
            Controls.Add(btnCalc);
            Controls.Add(btoTab);
            Controls.Add(lbltab);
            Controls.Add(txtTab);
            Name = "frmAlg5";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Algoritimo 5";
            Load += frmAlg5_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtTab;
        private Label lbltab;
        private ListBox btoTab;
        private Button btnCalc;
    }
}