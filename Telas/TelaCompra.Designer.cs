﻿namespace ProjetoIntegradorFarmacia
{
    partial class TelaCompra
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TelaCompra));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.LbxFornecedor = new System.Windows.Forms.ListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.TbValorTotalVenda = new System.Windows.Forms.TextBox();
            this.BtComprar = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.TbQuantidadeVenda = new System.Windows.Forms.TextBox();
            this.TbValorProduto = new System.Windows.Forms.TextBox();
            this.TbNomeProduto = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.PaleTurquoise;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 425);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 25);
            this.panel1.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(654, 3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(134, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "by Fernando Costa Colares";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "V 1.0 - 2023";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(487, 65);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(61, 13);
            this.label7.TabIndex = 24;
            this.label7.Text = "Fornecedor";
            // 
            // LbxFornecedor
            // 
            this.LbxFornecedor.FormattingEnabled = true;
            this.LbxFornecedor.Location = new System.Drawing.Point(551, 61);
            this.LbxFornecedor.Name = "LbxFornecedor";
            this.LbxFornecedor.Size = new System.Drawing.Size(166, 17);
            this.LbxFornecedor.TabIndex = 23;
            this.LbxFornecedor.SelectedIndexChanged += new System.EventHandler(this.LbxFornecedor_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(487, 132);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 13);
            this.label4.TabIndex = 21;
            this.label4.Text = "Valor Total";
            // 
            // TbValorTotalVenda
            // 
            this.TbValorTotalVenda.Location = new System.Drawing.Point(551, 129);
            this.TbValorTotalVenda.Name = "TbValorTotalVenda";
            this.TbValorTotalVenda.Size = new System.Drawing.Size(166, 20);
            this.TbValorTotalVenda.TabIndex = 20;
            this.TbValorTotalVenda.TextChanged += new System.EventHandler(this.TbValorTotalVenda_TextChanged);
            // 
            // BtComprar
            // 
            this.BtComprar.Location = new System.Drawing.Point(145, 155);
            this.BtComprar.Name = "BtComprar";
            this.BtComprar.Size = new System.Drawing.Size(75, 23);
            this.BtComprar.TabIndex = 19;
            this.BtComprar.Text = "Vender";
            this.BtComprar.UseVisualStyleBackColor = true;
            this.BtComprar.Click += new System.EventHandler(this.BtComprar_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(55, 132);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 13);
            this.label3.TabIndex = 18;
            this.label3.Text = "Quantidade";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(55, 90);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 13);
            this.label5.TabIndex = 17;
            this.label5.Text = "Produto Valor";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(55, 45);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(75, 13);
            this.label6.TabIndex = 16;
            this.label6.Text = "Nome Produto";
            // 
            // TbQuantidadeVenda
            // 
            this.TbQuantidadeVenda.Location = new System.Drawing.Point(145, 129);
            this.TbQuantidadeVenda.Name = "TbQuantidadeVenda";
            this.TbQuantidadeVenda.Size = new System.Drawing.Size(179, 20);
            this.TbQuantidadeVenda.TabIndex = 15;
            this.TbQuantidadeVenda.TextChanged += new System.EventHandler(this.TbQuantidadeVenda_TextChanged);
            // 
            // TbValorProduto
            // 
            this.TbValorProduto.Location = new System.Drawing.Point(145, 83);
            this.TbValorProduto.Name = "TbValorProduto";
            this.TbValorProduto.Size = new System.Drawing.Size(179, 20);
            this.TbValorProduto.TabIndex = 14;
            this.TbValorProduto.TextChanged += new System.EventHandler(this.TbValorProduto_TextChanged);
            // 
            // TbNomeProduto
            // 
            this.TbNomeProduto.Location = new System.Drawing.Point(145, 45);
            this.TbNomeProduto.Name = "TbNomeProduto";
            this.TbNomeProduto.Size = new System.Drawing.Size(179, 20);
            this.TbNomeProduto.TabIndex = 13;
            this.TbNomeProduto.TextChanged += new System.EventHandler(this.TbNomeProduto_TextChanged);
            // 
            // TelaCompra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCyan;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.LbxFornecedor);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.TbValorTotalVenda);
            this.Controls.Add(this.BtComprar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.TbQuantidadeVenda);
            this.Controls.Add(this.TbValorProduto);
            this.Controls.Add(this.TbNomeProduto);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "TelaCompra";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Compra";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ListBox LbxFornecedor;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TbValorTotalVenda;
        private System.Windows.Forms.Button BtComprar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox TbQuantidadeVenda;
        private System.Windows.Forms.TextBox TbValorProduto;
        private System.Windows.Forms.TextBox TbNomeProduto;
    }
}