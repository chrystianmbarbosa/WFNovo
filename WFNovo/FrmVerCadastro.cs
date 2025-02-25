using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFNovo
{
    public partial class FrmVerCadastro : Form
    {
        private Cliente clienteVindo;
        public FrmVerCadastro(Cliente cli)
        {
            InitializeComponent();
            this.clienteVindo = cli;
        }

        private void FrmVerCadastro_Load(object sender, EventArgs e)
        {
            lblNome.Text += " " + clienteVindo.nome;
            lblEndereco.Text += " " + clienteVindo.endereco;
            lblBairro.Text += " " + clienteVindo.bairro;
            lblEstado.Text += " " + clienteVindo.estado;
            lblCelular.Text += " " + clienteVindo.celular;
            lblTelefone.Text += " " + clienteVindo.telefone;
            lblEmail.Text += " " + clienteVindo.email;
        }
    }
}
