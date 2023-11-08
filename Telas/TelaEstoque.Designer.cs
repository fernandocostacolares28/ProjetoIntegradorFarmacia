namespace ProjetoIntegradorFarmacia
{
    partial class TelaEstoque
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TelaEstoque));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.BtSalvarProduto = new System.Windows.Forms.Button();
            this.TbPrecoProduto = new System.Windows.Forms.TextBox();
            this.TbQtdProduto = new System.Windows.Forms.TextBox();
            this.TbNomeProduto = new System.Windows.Forms.TextBox();
            this.TbIdProduto = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.BtExcluir = new System.Windows.Forms.Button();
            this.BtCancelar = new System.Windows.Forms.Button();
            this.DgvEstoque = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvEstoque)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Tan;
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
            // BtSalvarProduto
            // 
            this.BtSalvarProduto.Location = new System.Drawing.Point(15, 134);
            this.BtSalvarProduto.Name = "BtSalvarProduto";
            this.BtSalvarProduto.Size = new System.Drawing.Size(75, 23);
            this.BtSalvarProduto.TabIndex = 38;
            this.BtSalvarProduto.Text = "Salvar";
            this.BtSalvarProduto.UseVisualStyleBackColor = true;
            this.BtSalvarProduto.Click += new System.EventHandler(this.BtSalvarProduto_Click);
            // 
            // TbPrecoProduto
            // 
            this.TbPrecoProduto.Location = new System.Drawing.Point(86, 69);
            this.TbPrecoProduto.Name = "TbPrecoProduto";
            this.TbPrecoProduto.Size = new System.Drawing.Size(298, 20);
            this.TbPrecoProduto.TabIndex = 37;
            // 
            // TbQtdProduto
            // 
            this.TbQtdProduto.Location = new System.Drawing.Point(86, 95);
            this.TbQtdProduto.Name = "TbQtdProduto";
            this.TbQtdProduto.Size = new System.Drawing.Size(298, 20);
            this.TbQtdProduto.TabIndex = 36;
            // 
            // TbNomeProduto
            // 
            this.TbNomeProduto.Location = new System.Drawing.Point(86, 46);
            this.TbNomeProduto.Name = "TbNomeProduto";
            this.TbNomeProduto.Size = new System.Drawing.Size(298, 20);
            this.TbNomeProduto.TabIndex = 35;
            // 
            // TbIdProduto
            // 
            this.TbIdProduto.Location = new System.Drawing.Point(86, 21);
            this.TbIdProduto.Name = "TbIdProduto";
            this.TbIdProduto.ReadOnly = true;
            this.TbIdProduto.Size = new System.Drawing.Size(35, 20);
            this.TbIdProduto.TabIndex = 34;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(18, 102);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(62, 13);
            this.label6.TabIndex = 33;
            this.label6.Text = "Quantidade";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(18, 76);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 32;
            this.label5.Text = "Preço";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(18, 49);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 31;
            this.label4.Text = "Nome";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(18, 13);
            this.label3.TabIndex = 30;
            this.label3.Text = "ID";
            // 
            // BtExcluir
            // 
            this.BtExcluir.Location = new System.Drawing.Point(96, 134);
            this.BtExcluir.Name = "BtExcluir";
            this.BtExcluir.Size = new System.Drawing.Size(75, 23);
            this.BtExcluir.TabIndex = 39;
            this.BtExcluir.Text = "Excluir";
            this.BtExcluir.UseVisualStyleBackColor = true;
            this.BtExcluir.Click += new System.EventHandler(this.BtExcluir_Click);
            // 
            // BtCancelar
            // 
            this.BtCancelar.Location = new System.Drawing.Point(713, 134);
            this.BtCancelar.Name = "BtCancelar";
            this.BtCancelar.Size = new System.Drawing.Size(75, 23);
            this.BtCancelar.TabIndex = 40;
            this.BtCancelar.Text = "Cancelar";
            this.BtCancelar.UseVisualStyleBackColor = true;
            this.BtCancelar.Click += new System.EventHandler(this.BtCancelar_Click);
            // 
            // DgvEstoque
            // 
            this.DgvEstoque.AllowUserToAddRows = false;
            this.DgvEstoque.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DgvEstoque.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.DgvEstoque.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvEstoque.Location = new System.Drawing.Point(6, 163);
            this.DgvEstoque.MultiSelect = false;
            this.DgvEstoque.Name = "DgvEstoque";
            this.DgvEstoque.ReadOnly = true;
            this.DgvEstoque.RowHeadersVisible = false;
            this.DgvEstoque.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgvEstoque.Size = new System.Drawing.Size(782, 256);
            this.DgvEstoque.TabIndex = 41;
            this.DgvEstoque.SelectionChanged += new System.EventHandler(this.DgvEstoque_SelectionChanged);
            // 
            // TelaEstoque
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.BurlyWood;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.DgvEstoque);
            this.Controls.Add(this.BtCancelar);
            this.Controls.Add(this.BtExcluir);
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
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "TelaEstoque";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Estoque";
            this.Load += new System.EventHandler(this.TelaEstoque_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvEstoque)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtSalvarProduto;
        private System.Windows.Forms.TextBox TbPrecoProduto;
        private System.Windows.Forms.TextBox TbQtdProduto;
        private System.Windows.Forms.TextBox TbNomeProduto;
        private System.Windows.Forms.TextBox TbIdProduto;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button BtExcluir;
        private System.Windows.Forms.Button BtCancelar;
        private System.Windows.Forms.DataGridView DgvEstoque;
    }
}