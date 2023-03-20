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

        private void AbrirTela(object formTela)
        {
            if (this.panelSubTela.Controls.Count > 0)
                this.panelSubTela.Controls.RemoveAt(0);
            Form ft = formTela as Form;
            ft.TopLevel = false;
            ft.Dock = DockStyle.Fill;
            this.panelSubTela.Controls.Add(ft);
            this.panelSubTela.Tag = ft;
            ft.Show();
        }

        private void optAluno_Click(object sender, EventArgs e)
        {
            if (telaAluno == "fechada")
            {
                AbrirTela(new FAluno());
                telaAluno = "aberta";
            }
            else if (telaAluno == "aberta")
            {
                telaAluno = "fechada";
                //AbrirTela(new FFundo());
                if (this.panelSubTela.Controls.Count > 0)
                {
                    this.panelSubTela.Controls.RemoveAt(0);
                }

            }
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (telaCurso == "fechada")
            {
                AbrirTela(new FCursos());
                telaCurso = "aberta";
            }
            else if (telaCurso == "aberta")
            {
                telaCurso = "fechada";
                //AbrirTela(new FFundo());
                if (this.panelSubTela.Controls.Count > 0)
                {
                    this.panelSubTela.Controls.RemoveAt(0);
                }

            }
            
        }

        private void sair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
