namespace ProjetoIntegradorFarmacia.Telas
{
    partial class TelaEditarCliente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TelaEditarCliente));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.BtSalvarCliente = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.TbEnderecoCliente = new System.Windows.Forms.TextBox();
            this.TbTelefoneCliente = new System.Windows.Forms.TextBox();
            this.TbCPFCliente = new System.Windows.Forms.TextBox();
            this.TbNome = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.TbIdCliente = new System.Windows.Forms.TextBox();
            this.BtCancelar = new System.Windows.Forms.Button();
            this.BtExcluir = new System.Windows.Forms.Button();
            this.DgvCliente = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvCliente)).BeginInit();
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
            this.panel1.TabIndex = 25;
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
            // BtSalvarCliente
            // 
            this.BtSalvarCliente.Location = new System.Drawing.Point(272, 64);
            this.BtSalvarCliente.Name = "BtSalvarCliente";
            this.BtSalvarCliente.Size = new System.Drawing.Size(75, 23);
            this.BtSalvarCliente.TabIndex = 24;
            this.BtSalvarCliente.Text = "Salvar";
            this.BtSalvarCliente.UseVisualStyleBackColor = true;
            this.BtSalvarCliente.Click += new System.EventHandler(this.BtSalvarCliente_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 126);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 13);
            this.label5.TabIndex = 23;
            this.label5.Text = "Endereço";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 100);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 13);
            this.label4.TabIndex = 22;
            this.label4.Text = "Telefone";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(27, 13);
            this.label3.TabIndex = 21;
            this.label3.Text = "CPF";
            // 
            // TbEnderecoCliente
            // 
            this.TbEnderecoCliente.Location = new System.Drawing.Point(69, 119);
            this.TbEnderecoCliente.Name = "TbEnderecoCliente";
            this.TbEnderecoCliente.Size = new System.Drawing.Size(165, 20);
            this.TbEnderecoCliente.TabIndex = 20;
            // 
            // TbTelefoneCliente
            // 
            this.TbTelefoneCliente.Location = new System.Drawing.Point(69, 93);
            this.TbTelefoneCliente.Name = "TbTelefoneCliente";
            this.TbTelefoneCliente.Size = new System.Drawing.Size(165, 20);
            this.TbTelefoneCliente.TabIndex = 19;
            // 
            // TbCPFCliente
            // 
            this.TbCPFCliente.Location = new System.Drawing.Point(69, 67);
            this.TbCPFCliente.Name = "TbCPFCliente";
            this.TbCPFCliente.Size = new System.Drawing.Size(165, 20);
            this.TbCPFCliente.TabIndex = 18;
            // 
            // TbNome
            // 
            this.TbNome.Location = new System.Drawing.Point(69, 41);
            this.TbNome.Name = "TbNome";
            this.TbNome.Size = new System.Drawing.Size(165, 20);
            this.TbNome.TabIndex = 17;
            this.TbNome.TextChanged += new System.EventHandler(this.TbNome_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 16;
            this.label2.Text = "Nome";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 13);
            this.label1.TabIndex = 15;
            this.label1.Text = "ID";
            // 
            // TbIdCliente
            // 
            this.TbIdCliente.Location = new System.Drawing.Point(69, 15);
            this.TbIdCliente.Name = "TbIdCliente";
            this.TbIdCliente.ReadOnly = true;
            this.TbIdCliente.Size = new System.Drawing.Size(44, 20);
            this.TbIdCliente.TabIndex = 14;
            this.TbIdCliente.TextChanged += new System.EventHandler(this.TbIdCliente_TextChanged);
            // 
            // BtCancelar
            // 
            this.BtCancelar.Location = new System.Drawing.Point(272, 116);
            this.BtCancelar.Name = "BtCancelar";
            this.BtCancelar.Size = new System.Drawing.Size(75, 23);
            this.BtCancelar.TabIndex = 26;
            this.BtCancelar.Text = "Cancelar";
            this.BtCancelar.UseVisualStyleBackColor = true;
            // 
            // BtExcluir
            // 
            this.BtExcluir.Location = new System.Drawing.Point(272, 90);
            this.BtExcluir.Name = "BtExcluir";
            this.BtExcluir.Size = new System.Drawing.Size(75, 23);
            this.BtExcluir.TabIndex = 27;
            this.BtExcluir.Text = "Excluir";
            this.BtExcluir.UseVisualStyleBackColor = true;
            this.BtExcluir.Click += new System.EventHandler(this.BtExcluir_Click);
            // 
            // DgvCliente
            // 
            this.DgvCliente.AllowUserToAddRows = false;
            this.DgvCliente.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DgvCliente.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.DgvCliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvCliente.Location = new System.Drawing.Point(15, 163);
            this.DgvCliente.MultiSelect = false;
            this.DgvCliente.Name = "DgvCliente";
            this.DgvCliente.ReadOnly = true;
            this.DgvCliente.RowHeadersVisible = false;
            this.DgvCliente.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgvCliente.Size = new System.Drawing.Size(773, 256);
            this.DgvCliente.TabIndex = 28;
            this.DgvCliente.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.DgvCliente.SelectionChanged += new System.EventHandler(this.DgvCliente_SelectionChanged);
            // 
            // TelaEditarCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCyan;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.DgvCliente);
            this.Controls.Add(this.BtExcluir);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.BtSalvarCliente);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TbEnderecoCliente);
            this.Controls.Add(this.TbTelefoneCliente);
            this.Controls.Add(this.TbCPFCliente);
            this.Controls.Add(this.TbNome);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TbIdCliente);
            this.Controls.Add(this.BtCancelar);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "TelaEditarCliente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Editar Cliente";
            this.Load += new System.EventHandler(this.TelaEditarCliente_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvCliente)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button BtSalvarCliente;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TbEnderecoCliente;
        private System.Windows.Forms.TextBox TbTelefoneCliente;
        private System.Windows.Forms.TextBox TbCPFCliente;
        private System.Windows.Forms.TextBox TbNome;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TbIdCliente;
        private System.Windows.Forms.Button BtCancelar;
        private System.Windows.Forms.Button BtExcluir;
        private System.Windows.Forms.DataGridView DgvCliente;
    }
}