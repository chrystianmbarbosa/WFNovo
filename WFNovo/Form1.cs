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
            if (lblNome.Text == "Botão Clicado")
            {
                lblNome.Text = "Clicou Denovo";
            }
            else
            {
                lblNome.Text = "Botão Clicado";
            }

        }
    }
}
