using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Escola.view;
using System.Runtime.InteropServices;
using Escola.model;

namespace Escola
{
    public partial class FMenu : Form
    {
        public FMenu()
        {
            InitializeComponent();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void alunosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FAluno tela_aluno = new FAluno();
            tela_aluno.ShowDialog();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void BarraDeTitulo_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }



        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void BotaoMaximizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            BotaoMaximizar.Visible = false;
            BotaoRestaurar.Visible = true;
        }

        private void BotaoRestaurar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            BotaoRestaurar.Visible = false;
            BotaoMaximizar.Visible = true;
        }

        private void BotaoMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void BotaoFechar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        string telaAluno = "fechada";
        string telaCurso = "fechada";

        Form foAluno = new Form();
        Form foCurso = new Form();

        private void AbrirTelaAluno(object formTela)
        {
            if (foAluno.Controls.Count == 0 && telaAluno == "fechada")//Inicia uma nova tela de Aluno - se Controls de foAluno == 0 && telaAluno == "fechada"
            {
                this.panelSubTela.Controls.Clear(); 
                foAluno = formTela as Form;
                foAluno.TopLevel = false;
                foAluno.Dock = DockStyle.Fill;
                this.panelSubTela.Controls.Add(foAluno);
                this.panelSubTela.Tag = foAluno;
                foAluno.Show();
                telaAluno = "aberta";
                MessageBox.Show("Final de ABRIR \nQTDE de Controls: " + this.panelSubTela.Controls.Count + "\nStatus: " + telaAluno);
            }
            else if (foAluno.Controls.Count > 0 && telaAluno == "aberta")//Apaga os Controls da tela de Aluno - se existir Controls de foAluno > 0 && telaAluno == "aberta"
            {
                this.panelSubTela.Controls.Clear();
                foAluno.Controls.Clear();
                telaAluno = "fechada";
                MessageBox.Show("Final de FECHAR \nQTDE de Controls: " + this.panelSubTela.Controls.Count + "\nStatus: "+ telaAluno);
            } else if (this.panelSubTela.Controls.Count > 0 && telaAluno == "fechada")//Mostra a tela de Aluno - se existir Controls de Form foAluno > 0 && telaAluno == "fechada"
            {
                this.panelSubTela.Controls.Clear();
                foAluno.TopLevel = false;
                foAluno.Dock = DockStyle.Fill;
                this.panelSubTela.Controls.Add(foAluno);
                this.panelSubTela.Tag = foAluno;
                foAluno.Show();
                telaAluno = "aberta";
                MessageBox.Show("Final de ABRIR \nQTDE de Controls: " + this.panelSubTela.Controls.Count + "\nStatus: " + telaAluno);
            }
        }

        private void AbrirTelaCurso(object formTela)
        {
            if (foCurso.Controls.Count == 0 && telaCurso == "fechada")
            {
                this.panelSubTela.Controls.Clear();
                foCurso = formTela as Form;
                foCurso.TopLevel = false;
                foCurso.Dock = DockStyle.Fill;
                this.panelSubTela.Controls.Add(foCurso);
                this.panelSubTela.Tag = foCurso;
                foCurso.Show();
                telaCurso = "aberta";
                MessageBox.Show("Final de ABRIR \nQTDE de Controls: " + this.panelSubTela.Controls.Count + "\nStatus: " + telaCurso);
            }
            else if (foCurso.Controls.Count > 0 && telaCurso == "aberta")
            {
                this.panelSubTela.Controls.Clear();
                foCurso.Controls.Clear();
                telaCurso = "fechada";
                MessageBox.Show("Final de FECHAR \nQTDE de Controls: " + this.panelSubTela.Controls.Count + "\nStatus: " + telaCurso);
            }
            else if (this.panelSubTela.Controls.Count > 0 && telaCurso == "fechada")
            {
                this.panelSubTela.Controls.Clear();
                foCurso.TopLevel = false;
                foCurso.Dock = DockStyle.Fill;
                this.panelSubTela.Controls.Add(foCurso);
                this.panelSubTela.Tag = foCurso;
                foCurso.Show();
                telaCurso = "aberta";
                MessageBox.Show("Final de ABRIR \nQTDE de Controls: " + this.panelSubTela.Controls.Count + "\nStatus: " + telaCurso);
            }
        }


        private void optAluno_Click(object sender, EventArgs e)
        {
            MessageBox.Show("CLICK EM ALUNO \nQTDE SubTela Controls: " + this.panelSubTela.Controls.Count + "\nStatus Aluno: " + telaAluno+ "\nStatus Curso: " + telaCurso);
            AbrirTelaAluno(new FAluno());
            telaCurso = "fechada";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            telaAluno = "fechada";
            AbrirTelaCurso(new FCursos());
            MessageBox.Show("CLICK EM CURSO \nQTDE SubTela Controls: " + this.panelSubTela.Controls.Count + "\nStatus Aluno: " + telaAluno+ "\nStatus Curso: " + telaCurso);
        }

        private void sair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
