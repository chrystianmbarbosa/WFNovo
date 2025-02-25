namespace WFNovo
{
    partial class FrmVerCadastro
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
            lblTelefone = new Label();
            lblCelular = new Label();
            lblEmail = new Label();
            lblBairro = new Label();
            lblEstado = new Label();
            lblEndereco = new Label();
            lblNome = new Label();
            SuspendLayout();
            // 
            // lblTelefone
            // 
            lblTelefone.AutoSize = true;
            lblTelefone.Location = new Point(31, 206);
            lblTelefone.Name = "lblTelefone";
            lblTelefone.Size = new Size(54, 15);
            lblTelefone.TabIndex = 13;
            lblTelefone.Text = "Telefone:";
            // 
            // lblCelular
            // 
            lblCelular.AutoSize = true;
            lblCelular.Location = new Point(35, 245);
            lblCelular.Name = "lblCelular";
            lblCelular.Size = new Size(47, 15);
            lblCelular.TabIndex = 12;
            lblCelular.Text = "Celular:";
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Location = new Point(42, 283);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(39, 15);
            lblEmail.TabIndex = 11;
            lblEmail.Text = "Email:";
            // 
            // lblBairro
            // 
            lblBairro.AutoSize = true;
            lblBairro.Location = new Point(42, 127);
            lblBairro.Name = "lblBairro";
            lblBairro.Size = new Size(41, 15);
            lblBairro.TabIndex = 10;
            lblBairro.Text = "Bairro:";
            // 
            // lblEstado
            // 
            lblEstado.AutoSize = true;
            lblEstado.Location = new Point(35, 167);
            lblEstado.Name = "lblEstado";
            lblEstado.Size = new Size(45, 15);
            lblEstado.TabIndex = 9;
            lblEstado.Text = "Estado:";
            // 
            // lblEndereco
            // 
            lblEndereco.AutoSize = true;
            lblEndereco.Location = new Point(26, 86);
            lblEndereco.Name = "lblEndereco";
            lblEndereco.Size = new Size(59, 15);
            lblEndereco.TabIndex = 8;
            lblEndereco.Text = "Endereço:";
            // 
            // lblNome
            // 
            lblNome.AutoSize = true;
            lblNome.Location = new Point(42, 48);
            lblNome.Name = "lblNome";
            lblNome.Size = new Size(43, 15);
            lblNome.TabIndex = 7;
            lblNome.Text = "Nome:";
            // 
            // FrmVerCadastro
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(466, 382);
            Controls.Add(lblTelefone);
            Controls.Add(lblCelular);
            Controls.Add(lblEmail);
            Controls.Add(lblBairro);
            Controls.Add(lblEstado);
            Controls.Add(lblEndereco);
            Controls.Add(lblNome);
            Name = "FrmVerCadastro";
            Text = "FrmVerCadastro";
            Load += FrmVerCadastro_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTelefone;
        private Label lblCelular;
        private Label lblEmail;
        private Label lblBairro;
        private Label lblEstado;
        private Label lblEndereco;
        private Label lblNome;
    }
}