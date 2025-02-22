namespace WFNovo
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void btnLogar_Click(object sender, EventArgs e)
        {
            string username = txtUserName.Text.Trim();
            string password = txtPassword.Text.Trim();

            if (username != string.Empty && password != string.Empty)
            {
                FrmCadastro frmCadastro = new FrmCadastro();
                frmCadastro.ShowDialog();
            }
            else
            {
                MessageBox.Show("Os campos não podem estar vazios",
                    "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
