namespace T31_ProjetoBase
{
    partial class frmExtra061
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
            button2 = new Button();
            button1 = new Button();
            txt3 = new TextBox();
            txt2 = new TextBox();
            txt4 = new TextBox();
            txt1 = new TextBox();
            SuspendLayout();
            // 
            // button2
            // 
            button2.Location = new Point(39, 92);
            button2.Name = "button2";
            button2.Size = new Size(110, 23);
            button2.TabIndex = 6;
            button2.Text = "Rodar e Parar em";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.Location = new Point(39, 52);
            button1.Name = "button1";
            button1.RightToLeft = RightToLeft.Yes;
            button1.Size = new Size(110, 23);
            button1.TabIndex = 7;
            button1.Text = "Rodar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // txt3
            // 
            txt3.Location = new Point(119, 23);
            txt3.Name = "txt3";
            txt3.Size = new Size(30, 23);
            txt3.TabIndex = 2;
            // 
            // txt2
            // 
            txt2.Location = new Point(79, 23);
            txt2.Name = "txt2";
            txt2.Size = new Size(30, 23);
            txt2.TabIndex = 3;
            // 
            // txt4
            // 
            txt4.Location = new Point(39, 139);
            txt4.Name = "txt4";
            txt4.Size = new Size(110, 23);
            txt4.TabIndex = 4;
            // 
            // txt1
            // 
            txt1.Location = new Point(39, 23);
            txt1.Name = "txt1";
            txt1.Size = new Size(30, 23);
            txt1.TabIndex = 5;
            // 
            // frmExtra061
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(182, 202);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(txt3);
            Controls.Add(txt2);
            Controls.Add(txt4);
            Controls.Add(txt1);
            Name = "frmExtra061";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmExtra061";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button2;
        private Button button1;
        private TextBox txt3;
        private TextBox txt2;
        private TextBox txt4;
        private TextBox txt1;
    }
}