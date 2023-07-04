namespace T31_ProjetoBase
{
    partial class frmBco1
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
            dgvCategories = new DataGridView();
            btnCarregar = new Button();
            cboFornecedor = new ComboBox();
            btnCarregarCbo = new Button();
            btnEscolha = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvCategories).BeginInit();
            SuspendLayout();
            // 
            // dgvCategories
            // 
            dgvCategories.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCategories.Location = new Point(23, 22);
            dgvCategories.Name = "dgvCategories";
            dgvCategories.RowTemplate.Height = 25;
            dgvCategories.Size = new Size(746, 304);
            dgvCategories.TabIndex = 0;
            // 
            // btnCarregar
            // 
            btnCarregar.Location = new Point(23, 332);
            btnCarregar.Name = "btnCarregar";
            btnCarregar.Size = new Size(197, 41);
            btnCarregar.TabIndex = 1;
            btnCarregar.Text = "Carregar GRID";
            btnCarregar.UseVisualStyleBackColor = true;
            btnCarregar.Click += btnCarregar_Click;
            // 
            // cboFornecedor
            // 
            cboFornecedor.FormattingEnabled = true;
            cboFornecedor.Location = new Point(595, 332);
            cboFornecedor.Name = "cboFornecedor";
            cboFornecedor.Size = new Size(174, 23);
            cboFornecedor.TabIndex = 2;
            // 
            // btnCarregarCbo
            // 
            btnCarregarCbo.Location = new Point(405, 332);
            btnCarregarCbo.Name = "btnCarregarCbo";
            btnCarregarCbo.Size = new Size(174, 41);
            btnCarregarCbo.TabIndex = 3;
            btnCarregarCbo.Text = "Carregar Combo";
            btnCarregarCbo.UseVisualStyleBackColor = true;
            btnCarregarCbo.Click += btnCarregarCbo_Click;
            // 
            // btnEscolha
            // 
            btnEscolha.Enabled = false;
            btnEscolha.Location = new Point(405, 379);
            btnEscolha.Name = "btnEscolha";
            btnEscolha.Size = new Size(174, 41);
            btnEscolha.TabIndex = 3;
            btnEscolha.Text = "Selecionar Item";
            btnEscolha.UseVisualStyleBackColor = true;
            btnEscolha.Click += btnEscolha_Click;
            // 
            // frmBco1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnEscolha);
            Controls.Add(btnCarregarCbo);
            Controls.Add(cboFornecedor);
            Controls.Add(btnCarregar);
            Controls.Add(dgvCategories);
            Name = "frmBco1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Northwind - Exemplo 1";
            ((System.ComponentModel.ISupportInitialize)dgvCategories).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvCategories;
        private Button btnCarregar;
        private ComboBox cboFornecedor;
        private Button btnCarregarCbo;
        private Button btnEscolha;
    }
}