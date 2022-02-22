namespace PDVProject.UI
{
    partial class CadastroFuncionario
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
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtComissao = new System.Windows.Forms.TextBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.btnSalvarContinuar = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbTecnico = new System.Windows.Forms.RadioButton();
            this.rbCaixa = new System.Windows.Forms.RadioButton();
            this.rbGerente = new System.Windows.Forms.RadioButton();
            this.rbEntregador = new System.Windows.Forms.RadioButton();
            this.rbVendedor = new System.Windows.Forms.RadioButton();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.lbFuncionario = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(169, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Funcionário";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(50, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nome";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(50, 115);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 15);
            this.label4.TabIndex = 4;
            this.label4.Text = "Comissão";
            // 
            // txtComissao
            // 
            this.txtComissao.Location = new System.Drawing.Point(144, 112);
            this.txtComissao.Name = "txtComissao";
            this.txtComissao.Size = new System.Drawing.Size(280, 23);
            this.txtComissao.TabIndex = 2;
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(144, 72);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(280, 23);
            this.txtNome.TabIndex = 1;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(337, 263);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(87, 23);
            this.button3.TabIndex = 9;
            this.button3.Text = "Limpar";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnSalvarContinuar
            // 
            this.btnSalvarContinuar.Location = new System.Drawing.Point(169, 263);
            this.btnSalvarContinuar.Name = "btnSalvarContinuar";
            this.btnSalvarContinuar.Size = new System.Drawing.Size(116, 23);
            this.btnSalvarContinuar.TabIndex = 8;
            this.btnSalvarContinuar.Text = "Salvar e continuar";
            this.btnSalvarContinuar.UseVisualStyleBackColor = true;
            this.btnSalvarContinuar.Click += new System.EventHandler(this.btnSalvarContinuar_Click);
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(47, 263);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(75, 23);
            this.btnSalvar.TabIndex = 7;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbTecnico);
            this.groupBox1.Controls.Add(this.rbCaixa);
            this.groupBox1.Controls.Add(this.rbGerente);
            this.groupBox1.Controls.Add(this.rbEntregador);
            this.groupBox1.Controls.Add(this.rbVendedor);
            this.groupBox1.Location = new System.Drawing.Point(50, 157);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(374, 88);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Função";
            // 
            // rbTecnico
            // 
            this.rbTecnico.AutoSize = true;
            this.rbTecnico.Location = new System.Drawing.Point(257, 47);
            this.rbTecnico.Name = "rbTecnico";
            this.rbTecnico.Size = new System.Drawing.Size(65, 19);
            this.rbTecnico.TabIndex = 6;
            this.rbTecnico.TabStop = true;
            this.rbTecnico.Text = "Técnico";
            this.rbTecnico.UseVisualStyleBackColor = true;
            this.rbTecnico.CheckedChanged += new System.EventHandler(this.rbTecnico_CheckedChanged);
            // 
            // rbCaixa
            // 
            this.rbCaixa.AutoSize = true;
            this.rbCaixa.Location = new System.Drawing.Point(290, 22);
            this.rbCaixa.Name = "rbCaixa";
            this.rbCaixa.Size = new System.Drawing.Size(54, 19);
            this.rbCaixa.TabIndex = 5;
            this.rbCaixa.TabStop = true;
            this.rbCaixa.Text = "Caixa";
            this.rbCaixa.UseVisualStyleBackColor = true;
            // 
            // rbGerente
            // 
            this.rbGerente.AutoSize = true;
            this.rbGerente.Location = new System.Drawing.Point(192, 21);
            this.rbGerente.Name = "rbGerente";
            this.rbGerente.Size = new System.Drawing.Size(66, 19);
            this.rbGerente.TabIndex = 4;
            this.rbGerente.TabStop = true;
            this.rbGerente.Text = "Gerente";
            this.rbGerente.UseVisualStyleBackColor = true;
            // 
            // rbEntregador
            // 
            this.rbEntregador.AutoSize = true;
            this.rbEntregador.Location = new System.Drawing.Point(120, 47);
            this.rbEntregador.Name = "rbEntregador";
            this.rbEntregador.Size = new System.Drawing.Size(83, 19);
            this.rbEntregador.TabIndex = 6;
            this.rbEntregador.TabStop = true;
            this.rbEntregador.Text = "Entregador";
            this.rbEntregador.UseVisualStyleBackColor = true;
            // 
            // rbVendedor
            // 
            this.rbVendedor.AutoSize = true;
            this.rbVendedor.Location = new System.Drawing.Point(96, 21);
            this.rbVendedor.Name = "rbVendedor";
            this.rbVendedor.Size = new System.Drawing.Size(75, 19);
            this.rbVendedor.TabIndex = 3;
            this.rbVendedor.TabStop = true;
            this.rbVendedor.Text = "Vendedor";
            this.rbVendedor.UseVisualStyleBackColor = true;
            // 
            // txtCodigo
            // 
            this.txtCodigo.Enabled = false;
            this.txtCodigo.Location = new System.Drawing.Point(363, 27);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(61, 23);
            this.txtCodigo.TabIndex = 20;
            this.txtCodigo.TabStop = false;
            // 
            // lbFuncionario
            // 
            this.lbFuncionario.AutoSize = true;
            this.lbFuncionario.ForeColor = System.Drawing.Color.Red;
            this.lbFuncionario.Location = new System.Drawing.Point(12, 305);
            this.lbFuncionario.Name = "lbFuncionario";
            this.lbFuncionario.Size = new System.Drawing.Size(38, 15);
            this.lbFuncionario.TabIndex = 21;
            this.lbFuncionario.Text = "label3";
            // 
            // CadastroFuncionario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(492, 329);
            this.Controls.Add(this.lbFuncionario);
            this.Controls.Add(this.txtCodigo);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.btnSalvarContinuar);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.txtComissao);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "CadastroFuncionario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CadastroFuncionario";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtComissao;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button btnSalvarContinuar;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbTecnico;
        private System.Windows.Forms.RadioButton rbCaixa;
        private System.Windows.Forms.RadioButton rbGerente;
        private System.Windows.Forms.RadioButton rbEntregador;
        private System.Windows.Forms.RadioButton rbVendedor;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Label lbFuncionario;
    }
}