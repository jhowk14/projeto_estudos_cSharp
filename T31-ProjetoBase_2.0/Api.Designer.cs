namespace T31_ProjetoBase
{
    partial class Api
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
            btnAPI = new Button();
            lboAPI = new ListBox();
            txtAPI = new TextBox();
            label1 = new Label();
            txtToken = new TextBox();
            label2 = new Label();
            SuspendLayout();
            // 
            // btnAPI
            // 
            btnAPI.Location = new Point(52, 447);
            btnAPI.Name = "btnAPI";
            btnAPI.Size = new Size(249, 23);
            btnAPI.TabIndex = 1;
            btnAPI.Text = "Chamada";
            btnAPI.UseVisualStyleBackColor = true;
            btnAPI.Click += btnAPI_Click;
            // 
            // lboAPI
            // 
            lboAPI.FormattingEnabled = true;
            lboAPI.ItemHeight = 15;
            lboAPI.Location = new Point(52, 114);
            lboAPI.Name = "lboAPI";
            lboAPI.Size = new Size(249, 319);
            lboAPI.TabIndex = 2;
            // 
            // txtAPI
            // 
            txtAPI.Location = new Point(52, 27);
            txtAPI.Name = "txtAPI";
            txtAPI.Size = new Size(249, 23);
            txtAPI.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(72, 9);
            label1.Name = "label1";
            label1.Size = new Size(205, 15);
            label1.TabIndex = 4;
            label1.Text = "ESCREVA A SUA CHAMADA A API AQ";
            // 
            // txtToken
            // 
            txtToken.Location = new Point(52, 81);
            txtToken.Name = "txtToken";
            txtToken.Size = new Size(249, 23);
            txtToken.TabIndex = 5;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(83, 57);
            label2.Name = "label2";
            label2.Size = new Size(192, 15);
            label2.TabIndex = 6;
            label2.Text = "TOKEN PARA ROTAS AUTORIZADAS";
            // 
            // Api
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(351, 500);
            Controls.Add(label2);
            Controls.Add(txtToken);
            Controls.Add(label1);
            Controls.Add(txtAPI);
            Controls.Add(lboAPI);
            Controls.Add(btnAPI);
            Name = "Api";
            Text = "Api";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btnAPI;
        private ListBox lboAPI;
        private TextBox txtAPI;
        private Label label1;
        private TextBox txtToken;
        private Label label2;
    }
}