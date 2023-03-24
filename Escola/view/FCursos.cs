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
    public partial class FCursos : Form
    {
        private string status = "";

        public FCursos()
        {
            InitializeComponent();
        }

        public void desabilitarCampos()
        {
            txtCursoID.Enabled = false;
            txtNomeCurso.Enabled = false;
            txtCargaHoraria.Enabled = false;
            txtPeriodo.Enabled = false;
            txtNomeCoordenador.Enabled = false;
            txtObjetivo.Enabled = false;
            txtPerfilEgresso.Enabled = false;

            botaoEditarCurso.Enabled = false;
            botaoExcluirCurso.Enabled = false;
            botaoSalvarCurso.Enabled = false;
        }

        public void habilitarCampos()
        {
            txtCursoID.Enabled = true;
            txtNomeCurso.Enabled = true;
            txtCargaHoraria.Enabled = true;
            txtPeriodo.Enabled = true;
            txtNomeCoordenador.Enabled = true;
            txtObjetivo.Enabled = true;
            txtPerfilEgresso.Enabled = true;

            botaoSalvarCurso.Enabled = true;
        }

        public void limparCampos()
        {
            txtCursoID.Text = String.Empty;
            txtNomeCurso.Text = String.Empty;
            txtCargaHoraria.Text = String.Empty;
            txtPeriodo.Text = String.Empty;
            txtNomeCoordenador.Text = String.Empty;
            txtObjetivo.Text = String.Empty;
            txtPerfilEgresso.Text = String.Empty;
            txtNomeCurso.Focus();
        }

        private void botaoNovoCurso_Click(object sender, EventArgs e)
        {
            if (txtCursoID.Enabled == false)
            {
                habilitarCampos();
                limparCampos();
                status = "inserindo";
                botaoNovoCurso.Enabled = false;
            }
            else
            {
                MessageBox.Show("Você ja esta criando um cadrastro!");
            }
        }

        private void FCursos_Load(object sender, EventArgs e)
        {
            desabilitarCampos();
        }

        private void botaoSalvarCurso_Click(object sender, EventArgs e)
        {
            if (txtCursoID.Enabled == true)
            {
                // Receber os dados dentro do model
                Curso obj = new Curso();
                obj.nome_curso = txtNomeCurso.Text;
                obj.carga_horaria = int.Parse(txtCargaHoraria.Text);
                obj.periodo = txtPeriodo.Text;
                obj.nome_coordenador = txtNomeCoordenador.Text;
                obj.objetivo = txtObjetivo.Text;
                obj.perfil_egresso = txtPerfilEgresso.Text;

                //Criar um obj do tipo alunoControler e cadrastrar o metodo cadrastraraluno

                cursoController controller = new cursoController();

                if (status == "inserindo")
                {
                    controller.cadrastroCurso(obj);
                    status = "success";
                    desabilitarCampos();
                }
                else if (status == "alterando")
                {
                    obj.Id = int.Parse(txtCursoID.Text);
                    controller.alterarCurso(obj);
                    status = "success";
                    desabilitarCampos();
                }

                limparCampos();
                desabilitarCampos();
                tabelaCurso.DataSource = controller.listarCursos();
            }
            else { MessageBox.Show("Primeiro crie um novo cadrastro!"); }
        }
        private void bPesquisarCurso_Click(object sender, EventArgs e)
        {
            string nome = "%" + txtPesquisarCurso.Text + "%";
            cursoController controller = new cursoController();

            tabelaCurso.DataSource = controller.buscaPorNome(nome);
            if (tabelaCurso.Rows.Count == 0)
            {
                MessageBox.Show("Nenhum Curso encontrado com esse Nome.");
                tabelaCurso.DataSource = controller.listarCursos();
            }
            botaoExcluirCurso.Enabled = true;
        }

        private void txtPeriodo_TextChanged(object sender, EventArgs e)
        {
            txtPeriodo.MaxLength = 45;
        }

        private void txtNomeCurso_TextChanged(object sender, EventArgs e)
        {
            txtNomeCurso.MaxLength = 200;
        }

        private void txtNomeCoordenador_TextChanged(object sender, EventArgs e)
        {
            txtNomeCoordenador.MaxLength = 200;
        }

        private void botaoExcluirCurso_Click(object sender, EventArgs e)
        {
            //Pergunta ao user se realmente quer remover o registro.
            DialogResult dialogResult = MessageBox.Show("Tem certeza que deseja excluir ?", "Pergunta", MessageBoxButtons.YesNo);

            if (dialogResult == DialogResult.Yes)
            {//se user responder sim - Instancia o objeto curso.
                Curso obj = new Curso();
                //captura o valor de ID na caixa de texto.
                obj.Id = int.Parse(txtCursoID.Text);
                //instancia o método excluir curso
                cursoController controller = new cursoController();
                //executa a metodo excluir aluno.
                controller.excluirCurso(obj);
                //atualiza a consulta dos alunos cadrastrado.
                tabelaCurso.DataSource = controller.listarCursos();
            }
            //limpa dados do aluno removido.
            limparCampos();
            botaoEditarCurso.Enabled = false;
            botaoExcluirCurso.Enabled = false;
        }

        private void tabelaCurso_CellDoubleClick_1(object sender, DataGridViewCellEventArgs e)
        {
            //if para evitar bug do botao novo com editar registro
            if (status == "inserindo")
            {
                desabilitarCampos();
                status = "";

            }

            //Pegar os itens da linha seecionada para o texbox

            txtCursoID.Text = tabelaCurso.CurrentRow.Cells[0].Value.ToString();
            txtNomeCurso.Text = tabelaCurso.CurrentRow.Cells[1].Value.ToString();
            txtCargaHoraria.Text = tabelaCurso.CurrentRow.Cells[2].Value.ToString();
            txtPeriodo.Text = tabelaCurso.CurrentRow.Cells[3].Value.ToString();
            txtNomeCoordenador.Text = tabelaCurso.CurrentRow.Cells[4].Value.ToString();
            txtObjetivo.Text = tabelaCurso.CurrentRow.Cells[5].Value.ToString();
            txtPerfilEgresso.Text = tabelaCurso.CurrentRow.Cells[6].Value.ToString();

            tabControl1.SelectedTab = tabPage1;

            botaoEditarCurso.Enabled = true;//Habilita o botão EDITAR
            botaoExcluirCurso.Enabled = true;
        }

        private void botaoEditarCurso_Click(object sender, EventArgs e)
        {
            habilitarCampos();
            botaoSalvarCurso.Enabled = true;
            status = "alterando";
        }

        private void tabelaCurso_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtCursoID.Text = tabelaCurso.CurrentRow.Cells[0].Value.ToString();
        }
    }
}
