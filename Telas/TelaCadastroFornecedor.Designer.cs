namespace ProjetoIntegradorFarmacia
{
    partial class TelaCadastroFornecedor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TelaCadastroFornecedor));
            this.BtSalvarFornecedor = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.TbEnderecoFornecedor = new System.Windows.Forms.TextBox();
            this.TbTelefoneFornecedor = new System.Windows.Forms.TextBox();
            this.TbCNPJ = new System.Windows.Forms.TextBox();
            this.TbNomeFornecedor = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.TbIdFornecedor = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // BtSalvarFornecedor
            // 
            this.BtSalvarFornecedor.Location = new System.Drawing.Point(278, 127);
            this.BtSalvarFornecedor.Name = "BtSalvarFornecedor";
            this.BtSalvarFornecedor.Size = new System.Drawing.Size(75, 23);
            this.BtSalvarFornecedor.TabIndex = 21;
            this.BtSalvarFornecedor.Text = "Salvar";
            this.BtSalvarFornecedor.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(18, 137);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 13);
            this.label5.TabIndex = 20;
            this.label5.Text = "Endereço";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(18, 111);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 13);
            this.label4.TabIndex = 19;
            this.label4.Text = "Telefone";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 85);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 13);
            this.label3.TabIndex = 18;
            this.label3.Text = "CNPJ";
            // 
            // TbEnderecoFornecedor
            // 
            this.TbEnderecoFornecedor.Location = new System.Drawing.Point(75, 130);
            this.TbEnderecoFornecedor.Name = "TbEnderecoFornecedor";
            this.TbEnderecoFornecedor.Size = new System.Drawing.Size(165, 20);
            this.TbEnderecoFornecedor.TabIndex = 17;
            this.TbEnderecoFornecedor.TextChanged += new System.EventHandler(this.TbEnderecoFornecedor_TextChanged);
            // 
            // TbTelefoneFornecedor
            // 
            this.TbTelefoneFornecedor.Location = new System.Drawing.Point(75, 104);
            this.TbTelefoneFornecedor.Name = "TbTelefoneFornecedor";
            this.TbTelefoneFornecedor.Size = new System.Drawing.Size(165, 20);
            this.TbTelefoneFornecedor.TabIndex = 16;
            this.TbTelefoneFornecedor.TextChanged += new System.EventHandler(this.TbTelefoneFornecedor_TextChanged);
            // 
            // TbCNPJ
            // 
            this.TbCNPJ.Location = new System.Drawing.Point(75, 78);
            this.TbCNPJ.Name = "TbCNPJ";
            this.TbCNPJ.Size = new System.Drawing.Size(165, 20);
            this.TbCNPJ.TabIndex = 15;
            this.TbCNPJ.TextChanged += new System.EventHandler(this.TbCNPJ_TextChanged);
            // 
            // TbNomeFornecedor
            // 
            this.TbNomeFornecedor.Location = new System.Drawing.Point(75, 52);
            this.TbNomeFornecedor.Name = "TbNomeFornecedor";
            this.TbNomeFornecedor.Size = new System.Drawing.Size(165, 20);
            this.TbNomeFornecedor.TabIndex = 14;
            this.TbNomeFornecedor.TextChanged += new System.EventHandler(this.TbNomeFornecedor_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Nome";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "ID";
            // 
            // TbIdFornecedor
            // 
            this.TbIdFornecedor.Location = new System.Drawing.Point(75, 26);
            this.TbIdFornecedor.Name = "TbIdFornecedor";
            this.TbIdFornecedor.ReadOnly = true;
            this.TbIdFornecedor.Size = new System.Drawing.Size(44, 20);
            this.TbIdFornecedor.TabIndex = 11;
            this.TbIdFornecedor.TextChanged += new System.EventHandler(this.TbIdFornecedor_TextChanged);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Tan;
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 167);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 25);
            this.panel1.TabIndex = 22;
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(654, 3);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(134, 13);
            this.label6.TabIndex = 1;
            this.label6.Text = "by Fernando Costa Colares";
            this.label6.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(3, 3);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 13);
            this.label7.TabIndex = 0;
            this.label7.Text = "V 1.0 - 2023";
            // 
            // TelaCadastroFornecedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.BurlyWood;
            this.ClientSize = new System.Drawing.Size(800, 192);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.BtSalvarFornecedor);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TbEnderecoFornecedor);
            this.Controls.Add(this.TbTelefoneFornecedor);
            this.Controls.Add(this.TbCNPJ);
            this.Controls.Add(this.TbNomeFornecedor);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TbIdFornecedor);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "TelaCadastroFornecedor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro Fornecedor";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.TelaCadastroFornecedor_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtSalvarFornecedor;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TbEnderecoFornecedor;
        private System.Windows.Forms.TextBox TbTelefoneFornecedor;
        private System.Windows.Forms.TextBox TbCNPJ;
        private System.Windows.Forms.TextBox TbNomeFornecedor;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TbIdFornecedor;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
    }
}