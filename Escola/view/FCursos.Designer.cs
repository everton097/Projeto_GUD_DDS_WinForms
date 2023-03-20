namespace Escola.view
{
    partial class FCursos
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FCursos));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtPerfilEgresso = new System.Windows.Forms.RichTextBox();
            this.labelPerfilEgresso = new System.Windows.Forms.Label();
            this.txtObjetivo = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNomeCoordenador = new System.Windows.Forms.TextBox();
            this.labelNomeCoordenador = new System.Windows.Forms.Label();
            this.txtPeriodo = new System.Windows.Forms.TextBox();
            this.labelPeriodo = new System.Windows.Forms.Label();
            this.txtCargaHoraria = new System.Windows.Forms.MaskedTextBox();
            this.labelCargaHoraria = new System.Windows.Forms.Label();
            this.txtNomeCurso = new System.Windows.Forms.TextBox();
            this.labelNomeCurso = new System.Windows.Forms.Label();
            this.txtCursoID = new System.Windows.Forms.TextBox();
            this.labelCursoID = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabelaCurso = new System.Windows.Forms.DataGridView();
            this.bPesquisarCurso = new System.Windows.Forms.Button();
            this.txtPesquisarCurso = new System.Windows.Forms.TextBox();
            this.LabelNomePesquisaCurso = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.botaoEditarCurso = new System.Windows.Forms.Button();
            this.botaoExcluirCurso = new System.Windows.Forms.Button();
            this.botaoSalvarCurso = new System.Windows.Forms.Button();
            this.botaoNovoCurso = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tabelaCurso)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold);
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1092, 560);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(60)))), ((int)(((byte)(149)))));
            this.tabPage1.Controls.Add(this.pictureBox1);
            this.tabPage1.Controls.Add(this.txtPerfilEgresso);
            this.tabPage1.Controls.Add(this.labelPerfilEgresso);
            this.tabPage1.Controls.Add(this.txtObjetivo);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.txtNomeCoordenador);
            this.tabPage1.Controls.Add(this.labelNomeCoordenador);
            this.tabPage1.Controls.Add(this.txtPeriodo);
            this.tabPage1.Controls.Add(this.labelPeriodo);
            this.tabPage1.Controls.Add(this.txtCargaHoraria);
            this.tabPage1.Controls.Add(this.labelCargaHoraria);
            this.tabPage1.Controls.Add(this.txtNomeCurso);
            this.tabPage1.Controls.Add(this.labelNomeCurso);
            this.tabPage1.Controls.Add(this.txtCursoID);
            this.tabPage1.Controls.Add(this.labelCursoID);
            this.tabPage1.Location = new System.Drawing.Point(4, 38);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1084, 518);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Dados do Curso";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(577, 79);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(418, 372);
            this.pictureBox1.TabIndex = 55;
            this.pictureBox1.TabStop = false;
            // 
            // txtPerfilEgresso
            // 
            this.txtPerfilEgresso.Location = new System.Drawing.Point(265, 372);
            this.txtPerfilEgresso.Name = "txtPerfilEgresso";
            this.txtPerfilEgresso.Size = new System.Drawing.Size(233, 109);
            this.txtPerfilEgresso.TabIndex = 54;
            this.txtPerfilEgresso.Text = "";
            // 
            // labelPerfilEgresso
            // 
            this.labelPerfilEgresso.AutoSize = true;
            this.labelPerfilEgresso.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold);
            this.labelPerfilEgresso.Location = new System.Drawing.Point(75, 365);
            this.labelPerfilEgresso.Name = "labelPerfilEgresso";
            this.labelPerfilEgresso.Size = new System.Drawing.Size(184, 29);
            this.labelPerfilEgresso.TabIndex = 53;
            this.labelPerfilEgresso.Text = "Perfil egresso:";
            this.labelPerfilEgresso.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // txtObjetivo
            // 
            this.txtObjetivo.Location = new System.Drawing.Point(265, 256);
            this.txtObjetivo.Name = "txtObjetivo";
            this.txtObjetivo.Size = new System.Drawing.Size(233, 109);
            this.txtObjetivo.TabIndex = 52;
            this.txtObjetivo.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(141, 249);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 29);
            this.label1.TabIndex = 51;
            this.label1.Text = "Objetivo:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // txtNomeCoordenador
            // 
            this.txtNomeCoordenador.Location = new System.Drawing.Point(265, 216);
            this.txtNomeCoordenador.Name = "txtNomeCoordenador";
            this.txtNomeCoordenador.Size = new System.Drawing.Size(100, 34);
            this.txtNomeCoordenador.TabIndex = 50;
            // 
            // labelNomeCoordenador
            // 
            this.labelNomeCoordenador.AutoSize = true;
            this.labelNomeCoordenador.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold);
            this.labelNomeCoordenador.Location = new System.Drawing.Point(13, 210);
            this.labelNomeCoordenador.Name = "labelNomeCoordenador";
            this.labelNomeCoordenador.Size = new System.Drawing.Size(246, 29);
            this.labelNomeCoordenador.TabIndex = 49;
            this.labelNomeCoordenador.Text = "Nome coordenador:";
            this.labelNomeCoordenador.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // txtPeriodo
            // 
            this.txtPeriodo.Location = new System.Drawing.Point(265, 176);
            this.txtPeriodo.Name = "txtPeriodo";
            this.txtPeriodo.Size = new System.Drawing.Size(100, 34);
            this.txtPeriodo.TabIndex = 48;
            // 
            // labelPeriodo
            // 
            this.labelPeriodo.AutoSize = true;
            this.labelPeriodo.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold);
            this.labelPeriodo.Location = new System.Drawing.Point(146, 169);
            this.labelPeriodo.Name = "labelPeriodo";
            this.labelPeriodo.Size = new System.Drawing.Size(113, 29);
            this.labelPeriodo.TabIndex = 47;
            this.labelPeriodo.Text = "Periodo:";
            this.labelPeriodo.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // txtCargaHoraria
            // 
            this.txtCargaHoraria.Location = new System.Drawing.Point(265, 136);
            this.txtCargaHoraria.Mask = "0000";
            this.txtCargaHoraria.Name = "txtCargaHoraria";
            this.txtCargaHoraria.Size = new System.Drawing.Size(71, 34);
            this.txtCargaHoraria.TabIndex = 46;
            this.txtCargaHoraria.ValidatingType = typeof(int);
            // 
            // labelCargaHoraria
            // 
            this.labelCargaHoraria.AutoSize = true;
            this.labelCargaHoraria.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold);
            this.labelCargaHoraria.Location = new System.Drawing.Point(80, 130);
            this.labelCargaHoraria.Name = "labelCargaHoraria";
            this.labelCargaHoraria.Size = new System.Drawing.Size(179, 29);
            this.labelCargaHoraria.TabIndex = 45;
            this.labelCargaHoraria.Text = "Carga horaria:";
            this.labelCargaHoraria.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // txtNomeCurso
            // 
            this.txtNomeCurso.Location = new System.Drawing.Point(265, 96);
            this.txtNomeCurso.Name = "txtNomeCurso";
            this.txtNomeCurso.Size = new System.Drawing.Size(233, 34);
            this.txtNomeCurso.TabIndex = 44;
            // 
            // labelNomeCurso
            // 
            this.labelNomeCurso.AutoSize = true;
            this.labelNomeCurso.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold);
            this.labelNomeCurso.Location = new System.Drawing.Point(162, 96);
            this.labelNomeCurso.Name = "labelNomeCurso";
            this.labelNomeCurso.Size = new System.Drawing.Size(97, 29);
            this.labelNomeCurso.TabIndex = 43;
            this.labelNomeCurso.Text = "Nome: ";
            this.labelNomeCurso.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // txtCursoID
            // 
            this.txtCursoID.Location = new System.Drawing.Point(265, 56);
            this.txtCursoID.Name = "txtCursoID";
            this.txtCursoID.Size = new System.Drawing.Size(100, 34);
            this.txtCursoID.TabIndex = 42;
            // 
            // labelCursoID
            // 
            this.labelCursoID.AutoSize = true;
            this.labelCursoID.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold);
            this.labelCursoID.Location = new System.Drawing.Point(214, 50);
            this.labelCursoID.Name = "labelCursoID";
            this.labelCursoID.Size = new System.Drawing.Size(45, 29);
            this.labelCursoID.TabIndex = 41;
            this.labelCursoID.Text = "ID:";
            this.labelCursoID.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.tabPage2.Controls.Add(this.tabelaCurso);
            this.tabPage2.Controls.Add(this.bPesquisarCurso);
            this.tabPage2.Controls.Add(this.txtPesquisarCurso);
            this.tabPage2.Controls.Add(this.LabelNomePesquisaCurso);
            this.tabPage2.Location = new System.Drawing.Point(4, 38);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1084, 518);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Consultar";
            // 
            // tabelaCurso
            // 
            this.tabelaCurso.AllowUserToAddRows = false;
            this.tabelaCurso.AllowUserToDeleteRows = false;
            this.tabelaCurso.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(60)))), ((int)(((byte)(149)))));
            this.tabelaCurso.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tabelaCurso.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tabelaCurso.Location = new System.Drawing.Point(3, 68);
            this.tabelaCurso.Name = "tabelaCurso";
            this.tabelaCurso.ReadOnly = true;
            this.tabelaCurso.RowHeadersWidth = 51;
            this.tabelaCurso.RowTemplate.Height = 24;
            this.tabelaCurso.Size = new System.Drawing.Size(1078, 447);
            this.tabelaCurso.TabIndex = 7;
            this.tabelaCurso.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tabelaCurso_CellDoubleClick);
            // 
            // bPesquisarCurso
            // 
            this.bPesquisarCurso.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.bPesquisarCurso.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold);
            this.bPesquisarCurso.ForeColor = System.Drawing.Color.White;
            this.bPesquisarCurso.Location = new System.Drawing.Point(297, 11);
            this.bPesquisarCurso.Margin = new System.Windows.Forms.Padding(4);
            this.bPesquisarCurso.Name = "bPesquisarCurso";
            this.bPesquisarCurso.Size = new System.Drawing.Size(145, 48);
            this.bPesquisarCurso.TabIndex = 6;
            this.bPesquisarCurso.Text = "Pesquisar";
            this.bPesquisarCurso.UseVisualStyleBackColor = false;
            this.bPesquisarCurso.Click += new System.EventHandler(this.bPesquisarCurso_Click);
            // 
            // txtPesquisarCurso
            // 
            this.txtPesquisarCurso.Location = new System.Drawing.Point(109, 20);
            this.txtPesquisarCurso.Name = "txtPesquisarCurso";
            this.txtPesquisarCurso.Size = new System.Drawing.Size(182, 34);
            this.txtPesquisarCurso.TabIndex = 5;
            // 
            // LabelNomePesquisaCurso
            // 
            this.LabelNomePesquisaCurso.AutoSize = true;
            this.LabelNomePesquisaCurso.ForeColor = System.Drawing.Color.White;
            this.LabelNomePesquisaCurso.Location = new System.Drawing.Point(17, 21);
            this.LabelNomePesquisaCurso.Name = "LabelNomePesquisaCurso";
            this.LabelNomePesquisaCurso.Size = new System.Drawing.Size(90, 29);
            this.LabelNomePesquisaCurso.TabIndex = 4;
            this.LabelNomePesquisaCurso.Text = "Nome:";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.panel2.Controls.Add(this.botaoEditarCurso);
            this.panel2.Controls.Add(this.botaoExcluirCurso);
            this.panel2.Controls.Add(this.botaoSalvarCurso);
            this.panel2.Controls.Add(this.botaoNovoCurso);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 560);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1092, 83);
            this.panel2.TabIndex = 2;
            // 
            // botaoEditarCurso
            // 
            this.botaoEditarCurso.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.botaoEditarCurso.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold);
            this.botaoEditarCurso.ForeColor = System.Drawing.Color.White;
            this.botaoEditarCurso.Location = new System.Drawing.Point(649, 16);
            this.botaoEditarCurso.Margin = new System.Windows.Forms.Padding(4);
            this.botaoEditarCurso.Name = "botaoEditarCurso";
            this.botaoEditarCurso.Size = new System.Drawing.Size(105, 50);
            this.botaoEditarCurso.TabIndex = 3;
            this.botaoEditarCurso.Text = "Editar";
            this.botaoEditarCurso.UseVisualStyleBackColor = false;
            // 
            // botaoExcluirCurso
            // 
            this.botaoExcluirCurso.BackColor = System.Drawing.Color.LightCoral;
            this.botaoExcluirCurso.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold);
            this.botaoExcluirCurso.ForeColor = System.Drawing.Color.White;
            this.botaoExcluirCurso.Location = new System.Drawing.Point(534, 16);
            this.botaoExcluirCurso.Margin = new System.Windows.Forms.Padding(4);
            this.botaoExcluirCurso.Name = "botaoExcluirCurso";
            this.botaoExcluirCurso.Size = new System.Drawing.Size(105, 50);
            this.botaoExcluirCurso.TabIndex = 2;
            this.botaoExcluirCurso.Text = "Excluir";
            this.botaoExcluirCurso.UseVisualStyleBackColor = false;
            // 
            // botaoSalvarCurso
            // 
            this.botaoSalvarCurso.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.botaoSalvarCurso.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold);
            this.botaoSalvarCurso.ForeColor = System.Drawing.Color.White;
            this.botaoSalvarCurso.Location = new System.Drawing.Point(419, 16);
            this.botaoSalvarCurso.Margin = new System.Windows.Forms.Padding(4);
            this.botaoSalvarCurso.Name = "botaoSalvarCurso";
            this.botaoSalvarCurso.Size = new System.Drawing.Size(105, 50);
            this.botaoSalvarCurso.TabIndex = 1;
            this.botaoSalvarCurso.Text = "Salvar";
            this.botaoSalvarCurso.UseVisualStyleBackColor = false;
            this.botaoSalvarCurso.Click += new System.EventHandler(this.botaoSalvarCurso_Click);
            // 
            // botaoNovoCurso
            // 
            this.botaoNovoCurso.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.botaoNovoCurso.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botaoNovoCurso.ForeColor = System.Drawing.Color.White;
            this.botaoNovoCurso.Location = new System.Drawing.Point(304, 16);
            this.botaoNovoCurso.Margin = new System.Windows.Forms.Padding(4);
            this.botaoNovoCurso.Name = "botaoNovoCurso";
            this.botaoNovoCurso.Size = new System.Drawing.Size(105, 50);
            this.botaoNovoCurso.TabIndex = 0;
            this.botaoNovoCurso.Text = "Novo";
            this.botaoNovoCurso.UseVisualStyleBackColor = false;
            this.botaoNovoCurso.Click += new System.EventHandler(this.botaoNovoCurso_Click);
            // 
            // FCursos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.ClientSize = new System.Drawing.Size(1092, 643);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FCursos";
            this.Text = "Cursos";
            this.Load += new System.EventHandler(this.FCursos_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tabelaCurso)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.RichTextBox txtPerfilEgresso;
        private System.Windows.Forms.Label labelPerfilEgresso;
        private System.Windows.Forms.RichTextBox txtObjetivo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNomeCoordenador;
        private System.Windows.Forms.Label labelNomeCoordenador;
        private System.Windows.Forms.TextBox txtPeriodo;
        private System.Windows.Forms.Label labelPeriodo;
        private System.Windows.Forms.MaskedTextBox txtCargaHoraria;
        private System.Windows.Forms.Label labelCargaHoraria;
        private System.Windows.Forms.TextBox txtNomeCurso;
        private System.Windows.Forms.Label labelNomeCurso;
        private System.Windows.Forms.TextBox txtCursoID;
        private System.Windows.Forms.Label labelCursoID;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button botaoEditarCurso;
        private System.Windows.Forms.Button botaoExcluirCurso;
        private System.Windows.Forms.Button botaoSalvarCurso;
        private System.Windows.Forms.Button botaoNovoCurso;
        private System.Windows.Forms.DataGridView tabelaCurso;
        private System.Windows.Forms.Button bPesquisarCurso;
        private System.Windows.Forms.TextBox txtPesquisarCurso;
        private System.Windows.Forms.Label LabelNomePesquisaCurso;
    }
}