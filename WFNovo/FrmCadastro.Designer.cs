namespace WFNovo
{
    partial class FrmCadastro
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
            lblNome = new Label();
            lblEndereco = new Label();
            lblBairro = new Label();
            lblEstado = new Label();
            lblTelefone = new Label();
            lblCelular = new Label();
            lblEmail = new Label();
            lblPreencha = new Label();
            btnGravarCadastro = new Button();
            btnNovoCadastro = new Button();
            btnVerCadastro = new Button();
            txtNome = new TextBox();
            txtEndereco = new TextBox();
            txtBairro = new TextBox();
            txtTelefone = new TextBox();
            txtCelular = new TextBox();
            txtEmail = new TextBox();
            cbxEstado = new ComboBox();
            SuspendLayout();
            // 
            // lblNome
            // 
            lblNome.AutoSize = true;
            lblNome.Location = new Point(36, 65);
            lblNome.Name = "lblNome";
            lblNome.Size = new Size(43, 15);
            lblNome.TabIndex = 0;
            lblNome.Text = "Nome:";
            // 
            // lblEndereco
            // 
            lblEndereco.AutoSize = true;
            lblEndereco.Location = new Point(20, 103);
            lblEndereco.Name = "lblEndereco";
            lblEndereco.Size = new Size(59, 15);
            lblEndereco.TabIndex = 1;
            lblEndereco.Text = "Endereço:";
            // 
            // lblBairro
            // 
            lblBairro.AutoSize = true;
            lblBairro.Location = new Point(36, 144);
            lblBairro.Name = "lblBairro";
            lblBairro.Size = new Size(41, 15);
            lblBairro.TabIndex = 3;
            lblBairro.Text = "Bairro:";
            // 
            // lblEstado
            // 
            lblEstado.AutoSize = true;
            lblEstado.Location = new Point(29, 184);
            lblEstado.Name = "lblEstado";
            lblEstado.Size = new Size(45, 15);
            lblEstado.TabIndex = 2;
            lblEstado.Text = "Estado:";
            // 
            // lblTelefone
            // 
            lblTelefone.AutoSize = true;
            lblTelefone.Location = new Point(25, 223);
            lblTelefone.Name = "lblTelefone";
            lblTelefone.Size = new Size(54, 15);
            lblTelefone.TabIndex = 6;
            lblTelefone.Text = "Telefone:";
            // 
            // lblCelular
            // 
            lblCelular.AutoSize = true;
            lblCelular.Location = new Point(29, 262);
            lblCelular.Name = "lblCelular";
            lblCelular.Size = new Size(47, 15);
            lblCelular.TabIndex = 5;
            lblCelular.Text = "Celular:";
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Location = new Point(36, 300);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(39, 15);
            lblEmail.TabIndex = 4;
            lblEmail.Text = "Email:";
            // 
            // lblPreencha
            // 
            lblPreencha.AutoSize = true;
            lblPreencha.Location = new Point(80, 20);
            lblPreencha.Name = "lblPreencha";
            lblPreencha.Size = new Size(253, 15);
            lblPreencha.TabIndex = 7;
            lblPreencha.Text = "Preencha os campos e clique em Gravar Dados";
            // 
            // btnGravarCadastro
            // 
            btnGravarCadastro.Location = new Point(36, 375);
            btnGravarCadastro.Name = "btnGravarCadastro";
            btnGravarCadastro.Size = new Size(105, 34);
            btnGravarCadastro.TabIndex = 8;
            btnGravarCadastro.Text = "Gravar Cadastro";
            btnGravarCadastro.UseVisualStyleBackColor = true;
            // 
            // btnNovoCadastro
            // 
            btnNovoCadastro.Location = new Point(147, 375);
            btnNovoCadastro.Name = "btnNovoCadastro";
            btnNovoCadastro.Size = new Size(100, 34);
            btnNovoCadastro.TabIndex = 9;
            btnNovoCadastro.Text = "Novo Cadastro";
            btnNovoCadastro.UseVisualStyleBackColor = true;
            // 
            // btnVerCadastro
            // 
            btnVerCadastro.Location = new Point(253, 375);
            btnVerCadastro.Name = "btnVerCadastro";
            btnVerCadastro.Size = new Size(104, 34);
            btnVerCadastro.TabIndex = 10;
            btnVerCadastro.Text = "Ver Cadastro";
            btnVerCadastro.UseVisualStyleBackColor = true;
            // 
            // txtNome
            // 
            txtNome.Location = new Point(80, 62);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(277, 23);
            txtNome.TabIndex = 11;
            // 
            // txtEndereco
            // 
            txtEndereco.Location = new Point(80, 100);
            txtEndereco.Name = "txtEndereco";
            txtEndereco.Size = new Size(277, 23);
            txtEndereco.TabIndex = 12;
            // 
            // txtBairro
            // 
            txtBairro.Location = new Point(80, 141);
            txtBairro.Name = "txtBairro";
            txtBairro.Size = new Size(277, 23);
            txtBairro.TabIndex = 13;
            // 
            // txtTelefone
            // 
            txtTelefone.Location = new Point(80, 220);
            txtTelefone.Name = "txtTelefone";
            txtTelefone.Size = new Size(277, 23);
            txtTelefone.TabIndex = 15;
            // 
            // txtCelular
            // 
            txtCelular.Location = new Point(80, 259);
            txtCelular.Name = "txtCelular";
            txtCelular.Size = new Size(277, 23);
            txtCelular.TabIndex = 16;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(80, 297);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(277, 23);
            txtEmail.TabIndex = 17;
            // 
            // cbxEstado
            // 
            cbxEstado.FormattingEnabled = true;
            cbxEstado.Items.AddRange(new object[] { "ES", "MG", "RJ", "SP" });
            cbxEstado.Location = new Point(80, 181);
            cbxEstado.Name = "cbxEstado";
            cbxEstado.Size = new Size(121, 23);
            cbxEstado.TabIndex = 18;
            // 
            // FrmCadastro
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(382, 450);
            Controls.Add(cbxEstado);
            Controls.Add(txtEmail);
            Controls.Add(txtCelular);
            Controls.Add(txtTelefone);
            Controls.Add(txtBairro);
            Controls.Add(txtEndereco);
            Controls.Add(txtNome);
            Controls.Add(btnVerCadastro);
            Controls.Add(btnNovoCadastro);
            Controls.Add(btnGravarCadastro);
            Controls.Add(lblPreencha);
            Controls.Add(lblTelefone);
            Controls.Add(lblCelular);
            Controls.Add(lblEmail);
            Controls.Add(lblBairro);
            Controls.Add(lblEstado);
            Controls.Add(lblEndereco);
            Controls.Add(lblNome);
            Name = "FrmCadastro";
            Text = "Cadastro de Cliente";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblNome;
        private Label lblEndereco;
        private Label lblBairro;
        private Label lblEstado;
        private Label lblTelefone;
        private Label lblCelular;
        private Label lblEmail;
        private Label lblPreencha;
        private Button btnGravarCadastro;
        private Button btnNovoCadastro;
        private Button btnVerCadastro;
        private TextBox txtNome;
        private TextBox txtEndereco;
        private TextBox txtBairro;
        private TextBox txtTelefone;
        private TextBox txtCelular;
        private TextBox txtEmail;
        private ComboBox cbxEstado;
    }
}