
namespace PDVProject.UI
{
    partial class MainForm
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
            this.btnNovoCliente = new System.Windows.Forms.Button();
            this.btnNovoProduto = new System.Windows.Forms.Button();
            this.lb_caixa = new System.Windows.Forms.Label();
            this.btn_func = new System.Windows.Forms.Button();
            this.btn_vendas = new System.Windows.Forms.Button();
            this.btn_pg = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.btn_finalizar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnNovoCliente
            // 
            this.btnNovoCliente.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnNovoCliente.Location = new System.Drawing.Point(240, 474);
            this.btnNovoCliente.Name = "btnNovoCliente";
            this.btnNovoCliente.Size = new System.Drawing.Size(156, 40);
            this.btnNovoCliente.TabIndex = 0;
            this.btnNovoCliente.Text = "Clientes";
            this.btnNovoCliente.UseVisualStyleBackColor = true;
            this.btnNovoCliente.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnNovoProduto
            // 
            this.btnNovoProduto.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnNovoProduto.Location = new System.Drawing.Point(240, 547);
            this.btnNovoProduto.Name = "btnNovoProduto";
            this.btnNovoProduto.Size = new System.Drawing.Size(156, 40);
            this.btnNovoProduto.TabIndex = 1;
            this.btnNovoProduto.Text = "Produtos";
            this.btnNovoProduto.UseVisualStyleBackColor = true;
            this.btnNovoProduto.Click += new System.EventHandler(this.btnNovoProduto_Click);
            // 
            // lb_caixa
            // 
            this.lb_caixa.Font = new System.Drawing.Font("Segoe UI", 54F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lb_caixa.Location = new System.Drawing.Point(258, 105);
            this.lb_caixa.Name = "lb_caixa";
            this.lb_caixa.Size = new System.Drawing.Size(575, 96);
            this.lb_caixa.TabIndex = 3;
            this.lb_caixa.Text = "CAIXA FECHADO";
            this.lb_caixa.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_func
            // 
            this.btn_func.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_func.Location = new System.Drawing.Point(479, 474);
            this.btn_func.Name = "btn_func";
            this.btn_func.Size = new System.Drawing.Size(156, 40);
            this.btn_func.TabIndex = 4;
            this.btn_func.Text = "Funcionários";
            this.btn_func.UseVisualStyleBackColor = true;
            this.btn_func.Click += new System.EventHandler(this.btn_func_Click);
            // 
            // btn_vendas
            // 
            this.btn_vendas.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_vendas.Location = new System.Drawing.Point(479, 547);
            this.btn_vendas.Name = "btn_vendas";
            this.btn_vendas.Size = new System.Drawing.Size(156, 40);
            this.btn_vendas.TabIndex = 5;
            this.btn_vendas.Text = "Consultar vendas";
            this.btn_vendas.UseVisualStyleBackColor = true;
            // 
            // btn_pg
            // 
            this.btn_pg.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_pg.Location = new System.Drawing.Point(720, 474);
            this.btn_pg.Name = "btn_pg";
            this.btn_pg.Size = new System.Drawing.Size(156, 40);
            this.btn_pg.TabIndex = 6;
            this.btn_pg.Text = "Formas de pagamento";
            this.btn_pg.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button1.Location = new System.Drawing.Point(720, 547);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(156, 40);
            this.button1.TabIndex = 7;
            this.button1.Text = "Consultar caixas";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button2.Location = new System.Drawing.Point(240, 258);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(156, 58);
            this.button2.TabIndex = 8;
            this.button2.Text = "Iniciar caixa";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button3.Location = new System.Drawing.Point(479, 258);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(156, 58);
            this.button3.TabIndex = 9;
            this.button3.Text = "Configurações";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // btn_finalizar
            // 
            this.btn_finalizar.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_finalizar.Location = new System.Drawing.Point(720, 258);
            this.btn_finalizar.Name = "btn_finalizar";
            this.btn_finalizar.Size = new System.Drawing.Size(156, 58);
            this.btn_finalizar.TabIndex = 10;
            this.btn_finalizar.Text = "Finalizar";
            this.btn_finalizar.UseVisualStyleBackColor = true;
            this.btn_finalizar.Click += new System.EventHandler(this.btn_finalizar_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(1155, 667);
            this.Controls.Add(this.btn_finalizar);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btn_pg);
            this.Controls.Add(this.btn_vendas);
            this.Controls.Add(this.btn_func);
            this.Controls.Add(this.lb_caixa);
            this.Controls.Add(this.btnNovoProduto);
            this.Controls.Add(this.btnNovoCliente);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PDVProject";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnNovoCliente;
        private System.Windows.Forms.Button btnNovoProduto;
        private System.Windows.Forms.Label lb_caixa;
        private System.Windows.Forms.Button btn_func;
        private System.Windows.Forms.Button btn_vendas;
        private System.Windows.Forms.Button btn_pg;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button btn_finalizar;
    }
}