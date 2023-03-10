using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Escola;
using Escola.controller;
using Escola.model;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Escola.view
{
    public partial class FAluno : Form
    {
        public FAluno()
        {
            InitializeComponent();
        }
        public void desabilitarCampos()
        {
            txtid.Enabled = false;
            txtnome.Enabled = false;
            txtcpf.Enabled = false;
            txtrg.Enabled = false;
            txtemail.Enabled = false;
            txtcelular.Enabled = false;
            txtendereco.Enabled = false;
            txtnumero.Enabled = false;
            txtcep.Enabled = false;
            txtbairro.Enabled = false;
            txtcidade.Enabled = false;
            txtuf.Enabled = false;
        }

        public void habilitarCampos()
        {
            txtid.Enabled = true;
            txtnome.Enabled = true;
            txtcpf.Enabled = true;
            txtrg.Enabled = true;
            txtemail.Enabled = true;
            txtcelular.Enabled = true;
            txtendereco.Enabled = true;
            txtnumero.Enabled = true;
            txtcep.Enabled = true;
            txtbairro.Enabled = true;
            txtcidade.Enabled = true;
            txtuf.Enabled = true;
        }

        public void limparCampos()
        {
            txtid.Text = String.Empty;
            txtnome.Text = String.Empty;
            txtcpf.Text = String.Empty;
            txtrg.Text = String.Empty;
            txtemail.Text = String.Empty;
            txtcelular.Text = String.Empty;
            txtendereco.Text = String.Empty;
            txtnumero.Text = String.Empty;
            txtcep.Text = String.Empty;
            txtbairro.Text = String.Empty;
            txtcidade.Text = String.Empty;
            txtuf.Text = String.Empty;
            txtnome.Focus();
        }

        private void botaonovo_Click(object sender, EventArgs e)
        {
            if (txtid.Enabled == false)
            {
                habilitarCampos();
                limparCampos();
            }
            else
            {
                MessageBox.Show("Você ja esta criando um cadrastro!");
            }
                
        }

        private void FAluno_Load(object sender, EventArgs e)
        {
            desabilitarCampos();
        }

        private void botaosalvar_Click(object sender, EventArgs e)
        {
            if (txtid.Enabled == true) { 
            // 1 passo receber os dados dentro do model
            Aluno obj = new Aluno();
            obj.nome = txtnome.Text;
            obj.rg = txtrg.Text;
            obj.email = txtemail.Text;
            obj.uf = txtuf.Text;
            obj.cep = txtcep.Text;
            obj.celular = txtcelular.Text;
            obj.bairro = txtbairro.Text;
            obj.cidade = txtcidade.Text;
            obj.cpf = txtcpf.Text;
            obj.endereco = txtendereco.Text;
            obj.numero = txtnumero.Text;

            // 2 passo criar um obj do tipo alunoControler e cadrastrar o metodo cadrastraraluno

            alunoController controller= new alunoController();
            controller.cadrastroAluno(obj);

            limparCampos();
            desabilitarCampos();
            }
            else { MessageBox.Show("Primeiro crie um novo cadrastro!"); }
        }
    }
}
