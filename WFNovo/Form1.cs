namespace WFNovo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnClick_Click(object sender, EventArgs e)
        {
            if (lblNome.Text == "Bot�o Clicado")
            {
                lblNome.Text = "Clicou Denovo";
            }
            else
            {
                lblNome.Text = "Bot�o Clicado";
            }

        }
    }
}
