namespace Escola.view
{
    partial class FAluno
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.botaoeditar = new System.Windows.Forms.Button();
            this.botaoexcluir = new System.Windows.Forms.Button();
            this.botaosalvar = new System.Windows.Forms.Button();
            this.botaonovo = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.txtrg = new System.Windows.Forms.MaskedTextBox();
            this.txtnumero = new System.Windows.Forms.MaskedTextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txtuf = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtcidade = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtbairro = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtendereco = new System.Windows.Forms.TextBox();
            this.txtcep = new System.Windows.Forms.MaskedTextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtcelular = new System.Windows.Forms.MaskedTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtemail = new System.Windows.Forms.TextBox();
            this.txtcpf = new System.Windows.Forms.MaskedTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtnome = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtid = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabelaAluno = new System.Windows.Forms.DataGridView();
            this.bPesquisar = new System.Windows.Forms.Button();
            this.txtPesquisar = new System.Windows.Forms.TextBox();
            this.LabelNomePesquisa = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tabelaAluno)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SteelBlue;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1262, 63);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(16, 16);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(241, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cadastro de Alunos";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.botaoeditar);
            this.panel2.Controls.Add(this.botaoexcluir);
            this.panel2.Controls.Add(this.botaosalvar);
            this.panel2.Controls.Add(this.botaonovo);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 606);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1262, 67);
            this.panel2.TabIndex = 1;
            // 
            // botaoeditar
            // 
            this.botaoeditar.BackColor = System.Drawing.Color.SteelBlue;
            this.botaoeditar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botaoeditar.ForeColor = System.Drawing.Color.White;
            this.botaoeditar.Location = new System.Drawing.Point(516, 10);
            this.botaoeditar.Margin = new System.Windows.Forms.Padding(4);
            this.botaoeditar.Name = "botaoeditar";
            this.botaoeditar.Size = new System.Drawing.Size(105, 50);
            this.botaoeditar.TabIndex = 3;
            this.botaoeditar.Text = "Editar";
            this.botaoeditar.UseVisualStyleBackColor = false;
            // 
            // botaoexcluir
            // 
            this.botaoexcluir.BackColor = System.Drawing.Color.LightCoral;
            this.botaoexcluir.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botaoexcluir.ForeColor = System.Drawing.Color.White;
            this.botaoexcluir.Location = new System.Drawing.Point(401, 10);
            this.botaoexcluir.Margin = new System.Windows.Forms.Padding(4);
            this.botaoexcluir.Name = "botaoexcluir";
            this.botaoexcluir.Size = new System.Drawing.Size(105, 50);
            this.botaoexcluir.TabIndex = 2;
            this.botaoexcluir.Text = "Excluir";
            this.botaoexcluir.UseVisualStyleBackColor = false;
            // 
            // botaosalvar
            // 
            this.botaosalvar.BackColor = System.Drawing.Color.SteelBlue;
            this.botaosalvar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botaosalvar.ForeColor = System.Drawing.Color.White;
            this.botaosalvar.Location = new System.Drawing.Point(286, 10);
            this.botaosalvar.Margin = new System.Windows.Forms.Padding(4);
            this.botaosalvar.Name = "botaosalvar";
            this.botaosalvar.Size = new System.Drawing.Size(105, 50);
            this.botaosalvar.TabIndex = 1;
            this.botaosalvar.Text = "Salvar";
            this.botaosalvar.UseVisualStyleBackColor = false;
            this.botaosalvar.Click += new System.EventHandler(this.botaosalvar_Click);
            // 
            // botaonovo
            // 
            this.botaonovo.BackColor = System.Drawing.Color.SteelBlue;
            this.botaonovo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botaonovo.ForeColor = System.Drawing.Color.White;
            this.botaonovo.Location = new System.Drawing.Point(171, 10);
            this.botaonovo.Margin = new System.Windows.Forms.Padding(4);
            this.botaonovo.Name = "botaonovo";
            this.botaonovo.Size = new System.Drawing.Size(105, 50);
            this.botaonovo.TabIndex = 0;
            this.botaonovo.Text = "Novo";
            this.botaonovo.UseVisualStyleBackColor = false;
            this.botaonovo.Click += new System.EventHandler(this.botaonovo_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 63);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(4);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1262, 543);
            this.tabControl1.TabIndex = 2;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.txtrg);
            this.tabPage1.Controls.Add(this.txtnumero);
            this.tabPage1.Controls.Add(this.label13);
            this.tabPage1.Controls.Add(this.txtuf);
            this.tabPage1.Controls.Add(this.label12);
            this.tabPage1.Controls.Add(this.txtcidade);
            this.tabPage1.Controls.Add(this.label11);
            this.tabPage1.Controls.Add(this.txtbairro);
            this.tabPage1.Controls.Add(this.label10);
            this.tabPage1.Controls.Add(this.label9);
            this.tabPage1.Controls.Add(this.txtendereco);
            this.tabPage1.Controls.Add(this.txtcep);
            this.tabPage1.Controls.Add(this.label8);
            this.tabPage1.Controls.Add(this.txtcelular);
            this.tabPage1.Controls.Add(this.label7);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.txtemail);
            this.tabPage1.Controls.Add(this.txtcpf);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.txtnome);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.txtid);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(4);
            this.tabPage1.Size = new System.Drawing.Size(1254, 514);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Dados do Aluno";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // txtrg
            // 
            this.txtrg.Location = new System.Drawing.Point(396, 67);
            this.txtrg.Margin = new System.Windows.Forms.Padding(4);
            this.txtrg.Mask = "#.###.###";
            this.txtrg.Name = "txtrg";
            this.txtrg.Size = new System.Drawing.Size(74, 22);
            this.txtrg.TabIndex = 2;
            // 
            // txtnumero
            // 
            this.txtnumero.Location = new System.Drawing.Point(447, 203);
            this.txtnumero.Margin = new System.Windows.Forms.Padding(4);
            this.txtnumero.Mask = "00000";
            this.txtnumero.Name = "txtnumero";
            this.txtnumero.Size = new System.Drawing.Size(43, 22);
            this.txtnumero.TabIndex = 8;
            this.txtnumero.ValidatingType = typeof(int);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(417, 286);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(28, 16);
            this.label13.TabIndex = 23;
            this.label13.Text = "UF:";
            // 
            // txtuf
            // 
            this.txtuf.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.txtuf.FormattingEnabled = true;
            this.txtuf.Items.AddRange(new object[] {
            "AC",
            "AL",
            "AP",
            "AM",
            "BA",
            "CE",
            "DF",
            "ES",
            "GO",
            "MA",
            "MT",
            "MS",
            "MG",
            "PA",
            "PB",
            "PR",
            "PE",
            "PI",
            "RJ",
            "RN",
            "RS",
            "RO",
            "RR",
            "SC",
            "SP",
            "SE",
            "TO"});
            this.txtuf.Location = new System.Drawing.Point(447, 283);
            this.txtuf.Margin = new System.Windows.Forms.Padding(4);
            this.txtuf.Name = "txtuf";
            this.txtuf.Size = new System.Drawing.Size(73, 24);
            this.txtuf.TabIndex = 11;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(14, 287);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(54, 16);
            this.label12.TabIndex = 21;
            this.label12.Text = "Cidade:";
            // 
            // txtcidade
            // 
            this.txtcidade.Location = new System.Drawing.Point(70, 285);
            this.txtcidade.Margin = new System.Windows.Forms.Padding(4);
            this.txtcidade.Name = "txtcidade";
            this.txtcidade.Size = new System.Drawing.Size(265, 22);
            this.txtcidade.TabIndex = 10;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(14, 245);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(46, 16);
            this.label11.TabIndex = 19;
            this.label11.Text = "Bairro:";
            // 
            // txtbairro
            // 
            this.txtbairro.Location = new System.Drawing.Point(58, 242);
            this.txtbairro.Margin = new System.Windows.Forms.Padding(4);
            this.txtbairro.Name = "txtbairro";
            this.txtbairro.Size = new System.Drawing.Size(265, 22);
            this.txtbairro.TabIndex = 9;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(387, 205);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(58, 16);
            this.label10.TabIndex = 17;
            this.label10.Text = "Numero:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(14, 204);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(69, 16);
            this.label9.TabIndex = 15;
            this.label9.Text = "Endereço:";
            // 
            // txtendereco
            // 
            this.txtendereco.Location = new System.Drawing.Point(84, 202);
            this.txtendereco.Margin = new System.Windows.Forms.Padding(4);
            this.txtendereco.Name = "txtendereco";
            this.txtendereco.Size = new System.Drawing.Size(265, 22);
            this.txtendereco.TabIndex = 7;
            // 
            // txtcep
            // 
            this.txtcep.Location = new System.Drawing.Point(255, 157);
            this.txtcep.Margin = new System.Windows.Forms.Padding(4);
            this.txtcep.Mask = "##.###-###";
            this.txtcep.Name = "txtcep";
            this.txtcep.Size = new System.Drawing.Size(94, 22);
            this.txtcep.TabIndex = 6;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(216, 159);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(37, 16);
            this.label8.TabIndex = 12;
            this.label8.Text = "CEP:";
            // 
            // txtcelular
            // 
            this.txtcelular.Location = new System.Drawing.Point(68, 157);
            this.txtcelular.Margin = new System.Windows.Forms.Padding(4);
            this.txtcelular.Mask = "(##) # ####-####";
            this.txtcelular.Name = "txtcelular";
            this.txtcelular.Size = new System.Drawing.Size(120, 22);
            this.txtcelular.TabIndex = 5;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(14, 159);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(52, 16);
            this.label7.TabIndex = 10;
            this.label7.Text = "Celular:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(205, 111);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(48, 16);
            this.label6.TabIndex = 9;
            this.label6.Text = "E-mail:";
            // 
            // txtemail
            // 
            this.txtemail.Location = new System.Drawing.Point(255, 109);
            this.txtemail.Margin = new System.Windows.Forms.Padding(4);
            this.txtemail.Name = "txtemail";
            this.txtemail.Size = new System.Drawing.Size(265, 22);
            this.txtemail.TabIndex = 4;
            // 
            // txtcpf
            // 
            this.txtcpf.Location = new System.Drawing.Point(52, 111);
            this.txtcpf.Margin = new System.Windows.Forms.Padding(4);
            this.txtcpf.Mask = "###.###.###-##";
            this.txtcpf.Name = "txtcpf";
            this.txtcpf.Size = new System.Drawing.Size(111, 22);
            this.txtcpf.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(14, 113);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(36, 16);
            this.label5.TabIndex = 6;
            this.label5.Text = "CPF:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(364, 69);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(30, 16);
            this.label4.TabIndex = 5;
            this.label4.Text = "RG:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 68);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "Nome:";
            // 
            // txtnome
            // 
            this.txtnome.Location = new System.Drawing.Point(63, 66);
            this.txtnome.Margin = new System.Windows.Forms.Padding(4);
            this.txtnome.Name = "txtnome";
            this.txtnome.Size = new System.Drawing.Size(265, 22);
            this.txtnome.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 25);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(23, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "ID:";
            // 
            // txtid
            // 
            this.txtid.BackColor = System.Drawing.SystemColors.Window;
            this.txtid.Location = new System.Drawing.Point(39, 23);
            this.txtid.Margin = new System.Windows.Forms.Padding(4);
            this.txtid.Name = "txtid";
            this.txtid.Size = new System.Drawing.Size(124, 22);
            this.txtid.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.tabelaAluno);
            this.tabPage2.Controls.Add(this.bPesquisar);
            this.tabPage2.Controls.Add(this.txtPesquisar);
            this.tabPage2.Controls.Add(this.LabelNomePesquisa);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(4);
            this.tabPage2.Size = new System.Drawing.Size(1254, 514);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Consultar";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabelaAluno
            // 
            this.tabelaAluno.AllowUserToAddRows = false;
            this.tabelaAluno.AllowUserToDeleteRows = false;
            this.tabelaAluno.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tabelaAluno.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tabelaAluno.Location = new System.Drawing.Point(4, 63);
            this.tabelaAluno.Name = "tabelaAluno";
            this.tabelaAluno.ReadOnly = true;
            this.tabelaAluno.RowHeadersWidth = 51;
            this.tabelaAluno.RowTemplate.Height = 24;
            this.tabelaAluno.Size = new System.Drawing.Size(1246, 447);
            this.tabelaAluno.TabIndex = 3;
            this.tabelaAluno.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tabelaAluno_CellDoubleClick);
            // 
            // bPesquisar
            // 
            this.bPesquisar.BackColor = System.Drawing.Color.SteelBlue;
            this.bPesquisar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bPesquisar.ForeColor = System.Drawing.Color.White;
            this.bPesquisar.Location = new System.Drawing.Point(254, 8);
            this.bPesquisar.Margin = new System.Windows.Forms.Padding(4);
            this.bPesquisar.Name = "bPesquisar";
            this.bPesquisar.Size = new System.Drawing.Size(108, 48);
            this.bPesquisar.TabIndex = 2;
            this.bPesquisar.Text = "Pesquisar";
            this.bPesquisar.UseVisualStyleBackColor = false;
            this.bPesquisar.Click += new System.EventHandler(this.bPesquisar_Click);
            // 
            // txtPesquisar
            // 
            this.txtPesquisar.Location = new System.Drawing.Point(66, 20);
            this.txtPesquisar.Name = "txtPesquisar";
            this.txtPesquisar.Size = new System.Drawing.Size(182, 22);
            this.txtPesquisar.TabIndex = 1;
            // 
            // LabelNomePesquisa
            // 
            this.LabelNomePesquisa.AutoSize = true;
            this.LabelNomePesquisa.Location = new System.Drawing.Point(17, 21);
            this.LabelNomePesquisa.Name = "LabelNomePesquisa";
            this.LabelNomePesquisa.Size = new System.Drawing.Size(47, 16);
            this.LabelNomePesquisa.TabIndex = 0;
            this.LabelNomePesquisa.Text = "Nome:";
            // 
            // FAluno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1262, 673);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FAluno";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de alunos";
            this.Load += new System.EventHandler(this.FAluno_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tabelaAluno)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button botaoeditar;
        private System.Windows.Forms.Button botaoexcluir;
        private System.Windows.Forms.Button botaosalvar;
        private System.Windows.Forms.Button botaonovo;
        private System.Windows.Forms.MaskedTextBox txtcep;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.MaskedTextBox txtcelular;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtemail;
        private System.Windows.Forms.MaskedTextBox txtcpf;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtnome;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtid;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtcidade;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtbairro;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtendereco;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ComboBox txtuf;
        private System.Windows.Forms.DataGridView tabelaAluno;
        private System.Windows.Forms.Button bPesquisar;
        private System.Windows.Forms.TextBox txtPesquisar;
        private System.Windows.Forms.Label LabelNomePesquisa;
        private System.Windows.Forms.MaskedTextBox txtnumero;
        private System.Windows.Forms.MaskedTextBox txtrg;
    }
}