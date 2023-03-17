using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Escola;
using Escola.controller;
using Escola.model;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

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

            botaoeditar.Enabled = false;
            botaoexcluir.Enabled = false;
            botaosalvar.Enabled = false;
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
            botaosalvar.Enabled = true;
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
            tabelaAluno.DataSource = controller.listarAlunos();
            }
            else { MessageBox.Show("Primeiro crie um novo cadrastro!"); }
        }

        private void bPesquisar_Click(object sender, EventArgs e)
        {
            string nome = "%"+ txtPesquisar.Text+"%";
            alunoController controller = new alunoController();

            tabelaAluno.DataSource = controller.buscaPorNome(nome);
            if (tabelaAluno.Rows.Count == 0)
            {
                MessageBox.Show("Nenhum aluno encontrado com esse Nome.");
                tabelaAluno.DataSource = controller.listarAlunos();
            }
        }

        private void tabelaAluno_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

            //Pegar os itens da linha seecionada para o texbox

            txtid.Text = tabelaAluno.CurrentRow.Cells[0].Value.ToString();
            txtnome.Text = tabelaAluno.CurrentRow.Cells[1].Value.ToString();
            txtrg.Text = tabelaAluno.CurrentRow.Cells[2].Value.ToString();
            txtcpf.Text = tabelaAluno.CurrentRow.Cells[3].Value.ToString();
            txtemail.Text = tabelaAluno.CurrentRow.Cells[4].Value.ToString();
            txtcelular.Text = tabelaAluno.CurrentRow.Cells[5].Value.ToString();
            txtcep.Text = tabelaAluno.CurrentRow.Cells[6].Value.ToString();
            txtendereco.Text = tabelaAluno.CurrentRow.Cells[7].Value.ToString();
            txtnumero.Text = tabelaAluno.CurrentRow.Cells[8].Value.ToString();
            txtbairro.Text = tabelaAluno.CurrentRow.Cells[9].Value.ToString();
            txtcidade.Text = tabelaAluno.CurrentRow.Cells[10].Value.ToString();
            txtuf.Text = tabelaAluno.CurrentRow.Cells[11].Value.ToString();

            tabControl1.SelectedTab = tabPage1;

            botaoeditar.Enabled = true;//Habilita o botão EDITAR
        }
    }
}
