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
    public partial class FrmCadastro : Form
    {
        public FrmCadastro()
        {
            InitializeComponent();
        }

        private void btnVerCadastro_Click(object sender, EventArgs e)
        {
            Cliente cliente = new Cliente();
            cliente.nome = txtNome.Text;
            cliente.endereco = txtEndereco.Text;
            cliente.bairro = txtBairro.Text;
            cliente.estado = cbxEstado.Text;
            cliente.telefone = txtTelefone.Text;
            cliente.celular = txtCelular.Text;
            cliente.email = txtEmail.Text;

            FrmVerCadastro frmVerCadastro = new FrmVerCadastro(cliente);
            frmVerCadastro.ShowDialog();

        }
    }
}
