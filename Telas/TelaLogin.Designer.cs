namespace ProjetoIntegradorFarmacia
{
    partial class TelaLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TelaLogin));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TbUsuario = new System.Windows.Forms.TextBox();
            this.TbSenha = new System.Windows.Forms.TextBox();
            this.BtLogar = new System.Windows.Forms.Button();
            this.BtCancelar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(328, 89);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Usuario";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(328, 129);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Senha";
            // 
            // TbUsuario
            // 
            this.TbUsuario.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TbUsuario.Location = new System.Drawing.Point(331, 106);
            this.TbUsuario.Name = "TbUsuario";
            this.TbUsuario.Size = new System.Drawing.Size(144, 20);
            this.TbUsuario.TabIndex = 2;
            // 
            // TbSenha
            // 
            this.TbSenha.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TbSenha.Location = new System.Drawing.Point(331, 146);
            this.TbSenha.Name = "TbSenha";
            this.TbSenha.PasswordChar = '*';
            this.TbSenha.Size = new System.Drawing.Size(144, 20);
            this.TbSenha.TabIndex = 3;
            // 
            // BtLogar
            // 
            this.BtLogar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BtLogar.Location = new System.Drawing.Point(331, 172);
            this.BtLogar.Name = "BtLogar";
            this.BtLogar.Size = new System.Drawing.Size(144, 23);
            this.BtLogar.TabIndex = 4;
            this.BtLogar.Text = "Login";
            this.BtLogar.UseVisualStyleBackColor = true;
            this.BtLogar.Click += new System.EventHandler(this.BtLogar_Click);
            // 
            // BtCancelar
            // 
            this.BtCancelar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BtCancelar.Location = new System.Drawing.Point(331, 202);
            this.BtCancelar.Name = "BtCancelar";
            this.BtCancelar.Size = new System.Drawing.Size(144, 23);
            this.BtCancelar.TabIndex = 5;
            this.BtCancelar.Text = "Cancelar";
            this.BtCancelar.UseVisualStyleBackColor = true;
            this.BtCancelar.Click += new System.EventHandler(this.BtCancelar_Click);
            // 
            // TelaLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.BurlyWood;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BtCancelar);
            this.Controls.Add(this.BtLogar);
            this.Controls.Add(this.TbSenha);
            this.Controls.Add(this.TbUsuario);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "TelaLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TbUsuario;
        private System.Windows.Forms.TextBox TbSenha;
        private System.Windows.Forms.Button BtLogar;
        private System.Windows.Forms.Button BtCancelar;
    }
}