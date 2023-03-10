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
    }
}
