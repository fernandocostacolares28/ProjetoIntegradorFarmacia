namespace ProjetoIntegradorFarmacia.Telas
{
    partial class TelaEditarFornecedor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TelaEditarFornecedor));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
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
            this.DgvFornecedor = new System.Windows.Forms.DataGridView();
            this.BtExcluir = new System.Windows.Forms.Button();
            this.BtCancelar = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvFornecedor)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.PaleTurquoise;
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 425);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 25);
            this.panel1.TabIndex = 34;
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
            // BtSalvarFornecedor
            // 
            this.BtSalvarFornecedor.Location = new System.Drawing.Point(278, 114);
            this.BtSalvarFornecedor.Name = "BtSalvarFornecedor";
            this.BtSalvarFornecedor.Size = new System.Drawing.Size(75, 23);
            this.BtSalvarFornecedor.TabIndex = 33;
            this.BtSalvarFornecedor.Text = "Salvar";
            this.BtSalvarFornecedor.UseVisualStyleBackColor = true;
            this.BtSalvarFornecedor.Click += new System.EventHandler(this.BtSalvarFornecedor_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(18, 124);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 13);
            this.label5.TabIndex = 32;
            this.label5.Text = "Endereço";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(18, 98);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 13);
            this.label4.TabIndex = 31;
            this.label4.Text = "Telefone";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 72);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 13);
            this.label3.TabIndex = 30;
            this.label3.Text = "CNPJ";
            // 
            // TbEnderecoFornecedor
            // 
            this.TbEnderecoFornecedor.Location = new System.Drawing.Point(75, 117);
            this.TbEnderecoFornecedor.Name = "TbEnderecoFornecedor";
            this.TbEnderecoFornecedor.Size = new System.Drawing.Size(165, 20);
            this.TbEnderecoFornecedor.TabIndex = 29;
            // 
            // TbTelefoneFornecedor
            // 
            this.TbTelefoneFornecedor.Location = new System.Drawing.Point(75, 91);
            this.TbTelefoneFornecedor.Name = "TbTelefoneFornecedor";
            this.TbTelefoneFornecedor.Size = new System.Drawing.Size(165, 20);
            this.TbTelefoneFornecedor.TabIndex = 28;
            // 
            // TbCNPJ
            // 
            this.TbCNPJ.Location = new System.Drawing.Point(75, 65);
            this.TbCNPJ.Name = "TbCNPJ";
            this.TbCNPJ.Size = new System.Drawing.Size(165, 20);
            this.TbCNPJ.TabIndex = 27;
            // 
            // TbNomeFornecedor
            // 
            this.TbNomeFornecedor.Location = new System.Drawing.Point(75, 39);
            this.TbNomeFornecedor.Name = "TbNomeFornecedor";
            this.TbNomeFornecedor.Size = new System.Drawing.Size(165, 20);
            this.TbNomeFornecedor.TabIndex = 26;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 25;
            this.label2.Text = "Nome";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 13);
            this.label1.TabIndex = 24;
            this.label1.Text = "ID";
            // 
            // TbIdFornecedor
            // 
            this.TbIdFornecedor.Location = new System.Drawing.Point(75, 13);
            this.TbIdFornecedor.Name = "TbIdFornecedor";
            this.TbIdFornecedor.ReadOnly = true;
            this.TbIdFornecedor.Size = new System.Drawing.Size(44, 20);
            this.TbIdFornecedor.TabIndex = 23;
            // 
            // DgvFornecedor
            // 
            this.DgvFornecedor.AllowUserToAddRows = false;
            this.DgvFornecedor.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DgvFornecedor.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.DgvFornecedor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvFornecedor.Location = new System.Drawing.Point(12, 154);
            this.DgvFornecedor.MultiSelect = false;
            this.DgvFornecedor.Name = "DgvFornecedor";
            this.DgvFornecedor.ReadOnly = true;
            this.DgvFornecedor.RowHeadersVisible = false;
            this.DgvFornecedor.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgvFornecedor.Size = new System.Drawing.Size(773, 256);
            this.DgvFornecedor.TabIndex = 35;
            this.DgvFornecedor.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvCliente_CellContentClick);
            this.DgvFornecedor.SelectionChanged += new System.EventHandler(this.DgvFornecedor_SelectionChanged);
            // 
            // BtExcluir
            // 
            this.BtExcluir.Location = new System.Drawing.Point(359, 114);
            this.BtExcluir.Name = "BtExcluir";
            this.BtExcluir.Size = new System.Drawing.Size(75, 23);
            this.BtExcluir.TabIndex = 36;
            this.BtExcluir.Text = "Excluir";
            this.BtExcluir.UseVisualStyleBackColor = true;
            this.BtExcluir.Click += new System.EventHandler(this.BtExcluir_Click);
            // 
            // BtCancelar
            // 
            this.BtCancelar.Location = new System.Drawing.Point(440, 114);
            this.BtCancelar.Name = "BtCancelar";
            this.BtCancelar.Size = new System.Drawing.Size(75, 23);
            this.BtCancelar.TabIndex = 37;
            this.BtCancelar.Text = "Cancelar";
            this.BtCancelar.UseVisualStyleBackColor = true;
            this.BtCancelar.Click += new System.EventHandler(this.BtCancelar_Click);
            // 
            // TelaEditarFornecedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCyan;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BtCancelar);
            this.Controls.Add(this.BtExcluir);
            this.Controls.Add(this.DgvFornecedor);
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
            this.Name = "TelaEditarFornecedor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Editar Fornecedor";
            this.Load += new System.EventHandler(this.TelaEditarFornecedor_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvFornecedor)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
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
        private System.Windows.Forms.DataGridView DgvFornecedor;
        private System.Windows.Forms.Button BtExcluir;
        private System.Windows.Forms.Button BtCancelar;
    }
}