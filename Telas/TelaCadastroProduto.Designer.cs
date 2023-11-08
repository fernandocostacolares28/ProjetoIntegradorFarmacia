namespace ProjetoIntegradorFarmacia
{
    partial class TelaCadastroProduto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TelaCadastroProduto));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.TbIdProduto = new System.Windows.Forms.TextBox();
            this.TbNomeProduto = new System.Windows.Forms.TextBox();
            this.TbQtdProduto = new System.Windows.Forms.TextBox();
            this.TbPrecoProduto = new System.Windows.Forms.TextBox();
            this.BtSalvarProduto = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.estoqueToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.PaleTurquoise;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 140);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(684, 25);
            this.panel1.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(538, 3);
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
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 39);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(18, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "ID";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(27, 64);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Nome";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(27, 91);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Preço";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(27, 117);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(62, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "Quantidade";
            // 
            // TbIdProduto
            // 
            this.TbIdProduto.Location = new System.Drawing.Point(95, 36);
            this.TbIdProduto.Name = "TbIdProduto";
            this.TbIdProduto.ReadOnly = true;
            this.TbIdProduto.Size = new System.Drawing.Size(35, 20);
            this.TbIdProduto.TabIndex = 7;
            this.TbIdProduto.TextChanged += new System.EventHandler(this.TbIdProduto_TextChanged);
            // 
            // TbNomeProduto
            // 
            this.TbNomeProduto.Location = new System.Drawing.Point(95, 61);
            this.TbNomeProduto.Name = "TbNomeProduto";
            this.TbNomeProduto.Size = new System.Drawing.Size(298, 20);
            this.TbNomeProduto.TabIndex = 8;
            this.TbNomeProduto.TextChanged += new System.EventHandler(this.TbNomeProduto_TextChanged);
            // 
            // TbQtdProduto
            // 
            this.TbQtdProduto.Location = new System.Drawing.Point(95, 110);
            this.TbQtdProduto.Name = "TbQtdProduto";
            this.TbQtdProduto.Size = new System.Drawing.Size(298, 20);
            this.TbQtdProduto.TabIndex = 9;
            this.TbQtdProduto.TextChanged += new System.EventHandler(this.TbQtdProduto_TextChanged);
            // 
            // TbPrecoProduto
            // 
            this.TbPrecoProduto.Location = new System.Drawing.Point(95, 84);
            this.TbPrecoProduto.Name = "TbPrecoProduto";
            this.TbPrecoProduto.Size = new System.Drawing.Size(298, 20);
            this.TbPrecoProduto.TabIndex = 10;
            this.TbPrecoProduto.TextChanged += new System.EventHandler(this.TbPrecoProduto_TextChanged);
            // 
            // BtSalvarProduto
            // 
            this.BtSalvarProduto.Location = new System.Drawing.Point(475, 106);
            this.BtSalvarProduto.Name = "BtSalvarProduto";
            this.BtSalvarProduto.Size = new System.Drawing.Size(75, 23);
            this.BtSalvarProduto.TabIndex = 11;
            this.BtSalvarProduto.Text = "Salvar";
            this.BtSalvarProduto.UseVisualStyleBackColor = true;
            this.BtSalvarProduto.Click += new System.EventHandler(this.BtSalvarProduto_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.estoqueToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(684, 24);
            this.menuStrip1.TabIndex = 12;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // estoqueToolStripMenuItem
            // 
            this.estoqueToolStripMenuItem.Name = "estoqueToolStripMenuItem";
            this.estoqueToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.estoqueToolStripMenuItem.Text = "Estoque";
            this.estoqueToolStripMenuItem.Click += new System.EventHandler(this.estoqueToolStripMenuItem_Click);
            // 
            // TelaCadastroProduto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCyan;
            this.ClientSize = new System.Drawing.Size(684, 165);
            this.Controls.Add(this.BtSalvarProduto);
            this.Controls.Add(this.TbPrecoProduto);
            this.Controls.Add(this.TbQtdProduto);
            this.Controls.Add(this.TbNomeProduto);
            this.Controls.Add(this.TbIdProduto);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "TelaCadastroProduto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro Produto";
            this.Load += new System.EventHandler(this.TelaCadastroProduto_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox TbIdProduto;
        private System.Windows.Forms.TextBox TbNomeProduto;
        private System.Windows.Forms.TextBox TbQtdProduto;
        private System.Windows.Forms.TextBox TbPrecoProduto;
        private System.Windows.Forms.Button BtSalvarProduto;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem estoqueToolStripMenuItem;
    }
}