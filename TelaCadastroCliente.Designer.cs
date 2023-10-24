namespace ProjetoIntegradorFarmacia
{
    partial class TelaCadastroCliente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TelaCadastroCliente));
            this.TbIdCliente = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TbNome = new System.Windows.Forms.TextBox();
            this.TbCPFCliente = new System.Windows.Forms.TextBox();
            this.TbTelefoneCliente = new System.Windows.Forms.TextBox();
            this.TbEnderecoCliente = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.BtSalvarCliente = new System.Windows.Forms.Button();
            this.PnCliente = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // TbIdCliente
            // 
            this.TbIdCliente.Location = new System.Drawing.Point(69, 30);
            this.TbIdCliente.Name = "TbIdCliente";
            this.TbIdCliente.Size = new System.Drawing.Size(44, 20);
            this.TbIdCliente.TabIndex = 0;
            this.TbIdCliente.TextChanged += new System.EventHandler(this.TbIdCliente_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nome";
            // 
            // TbNome
            // 
            this.TbNome.Location = new System.Drawing.Point(69, 56);
            this.TbNome.Name = "TbNome";
            this.TbNome.Size = new System.Drawing.Size(165, 20);
            this.TbNome.TabIndex = 3;
            this.TbNome.TextChanged += new System.EventHandler(this.TbNome_TextChanged);
            // 
            // TbCPFCliente
            // 
            this.TbCPFCliente.Location = new System.Drawing.Point(69, 82);
            this.TbCPFCliente.Name = "TbCPFCliente";
            this.TbCPFCliente.Size = new System.Drawing.Size(165, 20);
            this.TbCPFCliente.TabIndex = 4;
            // 
            // TbTelefoneCliente
            // 
            this.TbTelefoneCliente.Location = new System.Drawing.Point(69, 108);
            this.TbTelefoneCliente.Name = "TbTelefoneCliente";
            this.TbTelefoneCliente.Size = new System.Drawing.Size(165, 20);
            this.TbTelefoneCliente.TabIndex = 5;
            this.TbTelefoneCliente.TextChanged += new System.EventHandler(this.TbTelefoneCliente_TextChanged);
            // 
            // TbEnderecoCliente
            // 
            this.TbEnderecoCliente.Location = new System.Drawing.Point(69, 134);
            this.TbEnderecoCliente.Name = "TbEnderecoCliente";
            this.TbEnderecoCliente.Size = new System.Drawing.Size(165, 20);
            this.TbEnderecoCliente.TabIndex = 6;
            this.TbEnderecoCliente.TextChanged += new System.EventHandler(this.TbEnderecoCliente_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 89);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(27, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "CPF";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 115);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Telefone";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 141);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Endereço";
            // 
            // BtSalvarCliente
            // 
            this.BtSalvarCliente.Location = new System.Drawing.Point(272, 131);
            this.BtSalvarCliente.Name = "BtSalvarCliente";
            this.BtSalvarCliente.Size = new System.Drawing.Size(75, 23);
            this.BtSalvarCliente.TabIndex = 10;
            this.BtSalvarCliente.Text = "Salvar";
            this.BtSalvarCliente.UseVisualStyleBackColor = true;
            // 
            // PnCliente
            // 
            this.PnCliente.Location = new System.Drawing.Point(12, 174);
            this.PnCliente.Name = "PnCliente";
            this.PnCliente.Size = new System.Drawing.Size(776, 251);
            this.PnCliente.TabIndex = 11;
            this.PnCliente.Paint += new System.Windows.Forms.PaintEventHandler(this.PnCliente_Paint);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Tan;
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 425);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 25);
            this.panel1.TabIndex = 12;
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
            // TelaCadastroCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.BurlyWood;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.PnCliente);
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
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "TelaCadastroCliente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro Cliente";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TbIdCliente;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TbNome;
        private System.Windows.Forms.TextBox TbCPFCliente;
        private System.Windows.Forms.TextBox TbTelefoneCliente;
        private System.Windows.Forms.TextBox TbEnderecoCliente;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button BtSalvarCliente;
        private System.Windows.Forms.Panel PnCliente;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
    }
}