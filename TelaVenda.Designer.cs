﻿namespace ProjetoIntegradorFarmacia
{
    partial class TelaVenda
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TelaVenda));
            this.TbNomeProduto = new System.Windows.Forms.TextBox();
            this.TbValorProduto = new System.Windows.Forms.TextBox();
            this.TbQuantidadeVenda = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btVender = new System.Windows.Forms.Button();
            this.TbValorTotalVenda = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.PnVenda = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // TbNomeProduto
            // 
            this.TbNomeProduto.Location = new System.Drawing.Point(145, 36);
            this.TbNomeProduto.Name = "TbNomeProduto";
            this.TbNomeProduto.Size = new System.Drawing.Size(179, 20);
            this.TbNomeProduto.TabIndex = 0;
            // 
            // TbValorProduto
            // 
            this.TbValorProduto.Location = new System.Drawing.Point(145, 78);
            this.TbValorProduto.Name = "TbValorProduto";
            this.TbValorProduto.Size = new System.Drawing.Size(179, 20);
            this.TbValorProduto.TabIndex = 1;
            // 
            // TbQuantidadeVenda
            // 
            this.TbQuantidadeVenda.Location = new System.Drawing.Point(145, 120);
            this.TbQuantidadeVenda.Name = "TbQuantidadeVenda";
            this.TbQuantidadeVenda.Size = new System.Drawing.Size(179, 20);
            this.TbQuantidadeVenda.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(55, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Nome Produto";
            this.label1.Click += new System.EventHandler(this.Label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(55, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Produto Valor";
            this.label2.Click += new System.EventHandler(this.Label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(55, 123);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Quantidade";
            // 
            // btVender
            // 
            this.btVender.Location = new System.Drawing.Point(145, 146);
            this.btVender.Name = "btVender";
            this.btVender.Size = new System.Drawing.Size(75, 23);
            this.btVender.TabIndex = 6;
            this.btVender.Text = "Vender";
            this.btVender.UseVisualStyleBackColor = true;
            this.btVender.Click += new System.EventHandler(this.BtVender_Click);
            // 
            // TbValorTotalVenda
            // 
            this.TbValorTotalVenda.Location = new System.Drawing.Point(551, 120);
            this.TbValorTotalVenda.Name = "TbValorTotalVenda";
            this.TbValorTotalVenda.Size = new System.Drawing.Size(166, 20);
            this.TbValorTotalVenda.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(487, 123);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Valor Total";
            // 
            // PnVenda
            // 
            this.PnVenda.Location = new System.Drawing.Point(12, 217);
            this.PnVenda.Name = "PnVenda";
            this.PnVenda.Size = new System.Drawing.Size(776, 221);
            this.PnVenda.TabIndex = 9;
            this.PnVenda.Paint += new System.Windows.Forms.PaintEventHandler(this.PnVenda_Paint);
            // 
            // TelaVenda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.BurlyWood;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.PnVenda);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.TbValorTotalVenda);
            this.Controls.Add(this.btVender);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TbQuantidadeVenda);
            this.Controls.Add(this.TbValorProduto);
            this.Controls.Add(this.TbNomeProduto);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "TelaVenda";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Venda";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TbNomeProduto;
        private System.Windows.Forms.TextBox TbValorProduto;
        private System.Windows.Forms.TextBox TbQuantidadeVenda;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btVender;
        private System.Windows.Forms.TextBox TbValorTotalVenda;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel PnVenda;
    }
}