namespace PDVProject.UI.MainForm.MovForm
{
    partial class ExcluirProdutoForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtLinha = new System.Windows.Forms.TextBox();
            this.remover = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(192, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Informe qual linha deseja remover?";
            // 
            // txtLinha
            // 
            this.txtLinha.Location = new System.Drawing.Point(28, 44);
            this.txtLinha.Name = "txtLinha";
            this.txtLinha.Size = new System.Drawing.Size(100, 23);
            this.txtLinha.TabIndex = 1;
            // 
            // remover
            // 
            this.remover.Location = new System.Drawing.Point(26, 83);
            this.remover.Name = "remover";
            this.remover.Size = new System.Drawing.Size(75, 23);
            this.remover.TabIndex = 2;
            this.remover.Text = "Remover";
            this.remover.UseVisualStyleBackColor = true;
            this.remover.Click += new System.EventHandler(this.remover_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(118, 83);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 3;
            this.button2.Text = "Fechar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // ExcluirProdutoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(287, 131);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.remover);
            this.Controls.Add(this.txtLinha);
            this.Controls.Add(this.label1);
            this.Name = "ExcluirProdutoForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ExcluirProdutoForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtLinha;
        private System.Windows.Forms.Button remover;
        private System.Windows.Forms.Button button2;
    }
}