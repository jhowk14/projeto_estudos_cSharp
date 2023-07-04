namespace T31_ProjetoBase
{
    partial class frmBco2
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
            cboSelecionar = new ComboBox();
            dgvCategories = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvCategories).BeginInit();
            SuspendLayout();
            // 
            // cboSelecionar
            // 
            cboSelecionar.FormattingEnabled = true;
            cboSelecionar.Location = new Point(30, 12);
            cboSelecionar.Name = "cboSelecionar";
            cboSelecionar.Size = new Size(162, 23);
            cboSelecionar.TabIndex = 0;
            cboSelecionar.SelectedIndexChanged += cboSelecionar_SelectedIndexChanged;
            // 
            // dgvCategories
            // 
            dgvCategories.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCategories.Location = new Point(27, 41);
            dgvCategories.Name = "dgvCategories";
            dgvCategories.RowTemplate.Height = 25;
            dgvCategories.Size = new Size(746, 383);
            dgvCategories.TabIndex = 2;
            // 
            // frmBco2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dgvCategories);
            Controls.Add(cboSelecionar);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "frmBco2";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Northwind - Exemplo 2";
            Load += frmBco2_Load;
            ((System.ComponentModel.ISupportInitialize)dgvCategories).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private ComboBox cboSelecionar;
        private DataGridView dgvCategories;
    }
}