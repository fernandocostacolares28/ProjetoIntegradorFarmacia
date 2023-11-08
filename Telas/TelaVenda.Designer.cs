namespace ProjetoIntegradorFarmacia
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TelaVenda));
            this.TbValorProduto = new System.Windows.Forms.TextBox();
            this.TbQuantidadeVenda = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btVender = new System.Windows.Forms.Button();
            this.TbValorTotalVenda = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.CbProduto = new System.Windows.Forms.ComboBox();
            this.CbCliente = new System.Windows.Forms.ComboBox();
            this.DgvVenda = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvVenda)).BeginInit();
            this.SuspendLayout();
            // 
            // TbValorProduto
            // 
            this.TbValorProduto.Location = new System.Drawing.Point(145, 74);
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
            this.TbQuantidadeVenda.TextChanged += new System.EventHandler(this.TbQuantidadeVenda_TextChanged);
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
            this.TbValorTotalVenda.Location = new System.Drawing.Point(551, 97);
            this.TbValorTotalVenda.Name = "TbValorTotalVenda";
            this.TbValorTotalVenda.Size = new System.Drawing.Size(166, 20);
            this.TbValorTotalVenda.TabIndex = 7;
            this.TbValorTotalVenda.TextChanged += new System.EventHandler(this.TbValorTotalVenda_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(487, 100);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Valor Total";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.PaleTurquoise;
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 425);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 25);
            this.panel1.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(654, 3);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(134, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "by Fernando Costa Colares";
            this.label5.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(3, 3);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "V 1.0 - 2023";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(487, 56);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(39, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "Cliente";
            // 
            // CbProduto
            // 
            this.CbProduto.FormattingEnabled = true;
            this.CbProduto.Location = new System.Drawing.Point(145, 33);
            this.CbProduto.Name = "CbProduto";
            this.CbProduto.Size = new System.Drawing.Size(192, 21);
            this.CbProduto.TabIndex = 13;
            this.CbProduto.SelectedIndexChanged += new System.EventHandler(this.CbProduto_SelectedIndexChanged);
            this.CbProduto.TextChanged += new System.EventHandler(this.CbProduto_TextChanged);
            // 
            // CbCliente
            // 
            this.CbCliente.FormattingEnabled = true;
            this.CbCliente.Location = new System.Drawing.Point(551, 53);
            this.CbCliente.Name = "CbCliente";
            this.CbCliente.Size = new System.Drawing.Size(192, 21);
            this.CbCliente.TabIndex = 14;
            this.CbCliente.SelectedIndexChanged += new System.EventHandler(this.CbCliente_SelectedIndexChanged);
            // 
            // DgvVenda
            // 
            this.DgvVenda.AllowUserToAddRows = false;
            this.DgvVenda.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DgvVenda.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.DgvVenda.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvVenda.Location = new System.Drawing.Point(12, 175);
            this.DgvVenda.MultiSelect = false;
            this.DgvVenda.Name = "DgvVenda";
            this.DgvVenda.ReadOnly = true;
            this.DgvVenda.RowHeadersVisible = false;
            this.DgvVenda.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgvVenda.Size = new System.Drawing.Size(776, 244);
            this.DgvVenda.TabIndex = 16;
            this.DgvVenda.SelectionChanged += new System.EventHandler(this.DgvVenda_SelectionChanged);
            // 
            // TelaVenda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCyan;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.DgvVenda);
            this.Controls.Add(this.CbCliente);
            this.Controls.Add(this.CbProduto);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.TbValorTotalVenda);
            this.Controls.Add(this.btVender);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TbQuantidadeVenda);
            this.Controls.Add(this.TbValorProduto);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "TelaVenda";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Venda";
            this.Load += new System.EventHandler(this.TelaVenda_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvVenda)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox TbValorProduto;
        private System.Windows.Forms.TextBox TbQuantidadeVenda;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btVender;
        private System.Windows.Forms.TextBox TbValorTotalVenda;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox CbProduto;
        private System.Windows.Forms.ComboBox CbCliente;
        private System.Windows.Forms.DataGridView DgvVenda;
    }
}