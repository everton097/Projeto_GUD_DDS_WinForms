namespace Escola
{
    partial class FMenu
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FMenu));
            this.BarraDeTitulo = new System.Windows.Forms.Panel();
            this.BotaoMinimizar = new System.Windows.Forms.Button();
            this.BotaoFechar = new System.Windows.Forms.Button();
            this.BotaoMaximizar = new System.Windows.Forms.Button();
            this.BotaoRestaurar = new System.Windows.Forms.Button();
            this.BarraMenuLataral = new System.Windows.Forms.Panel();
            this.sair = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.button4 = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.optAluno = new System.Windows.Forms.Button();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.panelSubTela = new System.Windows.Forms.Panel();
            this.BarraDeTitulo.SuspendLayout();
            this.BarraMenuLataral.SuspendLayout();
            this.SuspendLayout();
            // 
            // BarraDeTitulo
            // 
            this.BarraDeTitulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.BarraDeTitulo.Controls.Add(this.BotaoMinimizar);
            this.BarraDeTitulo.Controls.Add(this.BotaoFechar);
            this.BarraDeTitulo.Controls.Add(this.BotaoMaximizar);
            this.BarraDeTitulo.Controls.Add(this.BotaoRestaurar);
            this.BarraDeTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.BarraDeTitulo.Location = new System.Drawing.Point(0, 0);
            this.BarraDeTitulo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.BarraDeTitulo.Name = "BarraDeTitulo";
            this.BarraDeTitulo.Size = new System.Drawing.Size(946, 24);
            this.BarraDeTitulo.TabIndex = 2;
            this.BarraDeTitulo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.BarraDeTitulo_MouseDown);
            // 
            // BotaoMinimizar
            // 
            this.BotaoMinimizar.AccessibleDescription = "BotaoMinimizar";
            this.BotaoMinimizar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BotaoMinimizar.BackColor = System.Drawing.Color.Transparent;
            this.BotaoMinimizar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BotaoMinimizar.BackgroundImage")));
            this.BotaoMinimizar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BotaoMinimizar.FlatAppearance.BorderSize = 0;
            this.BotaoMinimizar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(100)))), ((int)(((byte)(200)))));
            this.BotaoMinimizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BotaoMinimizar.Location = new System.Drawing.Point(820, 3);
            this.BotaoMinimizar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.BotaoMinimizar.Name = "BotaoMinimizar";
            this.BotaoMinimizar.Size = new System.Drawing.Size(34, 19);
            this.BotaoMinimizar.TabIndex = 6;
            this.BotaoMinimizar.UseVisualStyleBackColor = false;
            this.BotaoMinimizar.Click += new System.EventHandler(this.BotaoMinimizar_Click);
            // 
            // BotaoFechar
            // 
            this.BotaoFechar.AccessibleDescription = "BotaoFechar";
            this.BotaoFechar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BotaoFechar.BackColor = System.Drawing.Color.Transparent;
            this.BotaoFechar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BotaoFechar.BackgroundImage")));
            this.BotaoFechar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BotaoFechar.FlatAppearance.BorderSize = 0;
            this.BotaoFechar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(100)))), ((int)(((byte)(200)))));
            this.BotaoFechar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BotaoFechar.Location = new System.Drawing.Point(904, 3);
            this.BotaoFechar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.BotaoFechar.Name = "BotaoFechar";
            this.BotaoFechar.Size = new System.Drawing.Size(34, 19);
            this.BotaoFechar.TabIndex = 4;
            this.BotaoFechar.UseVisualStyleBackColor = false;
            this.BotaoFechar.Click += new System.EventHandler(this.BotaoFechar_Click);
            // 
            // BotaoMaximizar
            // 
            this.BotaoMaximizar.AccessibleDescription = "BotaoMaximizar";
            this.BotaoMaximizar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BotaoMaximizar.BackColor = System.Drawing.Color.Transparent;
            this.BotaoMaximizar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BotaoMaximizar.BackgroundImage")));
            this.BotaoMaximizar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BotaoMaximizar.FlatAppearance.BorderSize = 0;
            this.BotaoMaximizar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(100)))), ((int)(((byte)(200)))));
            this.BotaoMaximizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BotaoMaximizar.Location = new System.Drawing.Point(859, 3);
            this.BotaoMaximizar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.BotaoMaximizar.Name = "BotaoMaximizar";
            this.BotaoMaximizar.Size = new System.Drawing.Size(34, 19);
            this.BotaoMaximizar.TabIndex = 5;
            this.BotaoMaximizar.UseVisualStyleBackColor = false;
            this.BotaoMaximizar.Click += new System.EventHandler(this.BotaoMaximizar_Click);
            // 
            // BotaoRestaurar
            // 
            this.BotaoRestaurar.AccessibleDescription = "BotaoRestaurar";
            this.BotaoRestaurar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BotaoRestaurar.BackColor = System.Drawing.Color.Transparent;
            this.BotaoRestaurar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BotaoRestaurar.BackgroundImage")));
            this.BotaoRestaurar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BotaoRestaurar.FlatAppearance.BorderSize = 0;
            this.BotaoRestaurar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(100)))), ((int)(((byte)(200)))));
            this.BotaoRestaurar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BotaoRestaurar.Location = new System.Drawing.Point(859, 3);
            this.BotaoRestaurar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.BotaoRestaurar.Name = "BotaoRestaurar";
            this.BotaoRestaurar.Size = new System.Drawing.Size(34, 19);
            this.BotaoRestaurar.TabIndex = 7;
            this.BotaoRestaurar.UseVisualStyleBackColor = false;
            this.BotaoRestaurar.Visible = false;
            this.BotaoRestaurar.Click += new System.EventHandler(this.BotaoRestaurar_Click);
            // 
            // BarraMenuLataral
            // 
            this.BarraMenuLataral.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.BarraMenuLataral.Controls.Add(this.sair);
            this.BarraMenuLataral.Controls.Add(this.panel3);
            this.BarraMenuLataral.Controls.Add(this.button4);
            this.BarraMenuLataral.Controls.Add(this.panel2);
            this.BarraMenuLataral.Controls.Add(this.optAluno);
            this.BarraMenuLataral.Dock = System.Windows.Forms.DockStyle.Left;
            this.BarraMenuLataral.Location = new System.Drawing.Point(0, 24);
            this.BarraMenuLataral.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.BarraMenuLataral.Name = "BarraMenuLataral";
            this.BarraMenuLataral.Size = new System.Drawing.Size(128, 523);
            this.BarraMenuLataral.TabIndex = 3;
            // 
            // sair
            // 
            this.sair.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.sair.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.sair.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.sair.FlatAppearance.BorderSize = 0;
            this.sair.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.sair.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sair.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sair.ForeColor = System.Drawing.Color.White;
            this.sair.Image = ((System.Drawing.Image)(resources.GetObject("sair.Image")));
            this.sair.Location = new System.Drawing.Point(8, 477);
            this.sair.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.sair.Name = "sair";
            this.sair.Size = new System.Drawing.Size(41, 37);
            this.sair.TabIndex = 10;
            this.sair.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.sair.UseVisualStyleBackColor = false;
            this.sair.Click += new System.EventHandler(this.sair_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.panel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panel3.Location = new System.Drawing.Point(5, 38);
            this.panel3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(4, 28);
            this.panel3.TabIndex = 9;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.button4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.Color.White;
            this.button4.Image = ((System.Drawing.Image)(resources.GetObject("button4.Image")));
            this.button4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button4.Location = new System.Drawing.Point(9, 38);
            this.button4.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button4.Name = "button4";
            this.button4.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.button4.Size = new System.Drawing.Size(134, 28);
            this.button4.TabIndex = 8;
            this.button4.Text = " Cursos";
            this.button4.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button4.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panel2.Location = new System.Drawing.Point(5, 5);
            this.panel2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(4, 28);
            this.panel2.TabIndex = 7;
            // 
            // optAluno
            // 
            this.optAluno.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.optAluno.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.optAluno.FlatAppearance.BorderSize = 0;
            this.optAluno.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.optAluno.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.optAluno.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.optAluno.ForeColor = System.Drawing.Color.White;
            this.optAluno.Image = ((System.Drawing.Image)(resources.GetObject("optAluno.Image")));
            this.optAluno.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.optAluno.Location = new System.Drawing.Point(9, 5);
            this.optAluno.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.optAluno.Name = "optAluno";
            this.optAluno.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.optAluno.Size = new System.Drawing.Size(134, 28);
            this.optAluno.TabIndex = 6;
            this.optAluno.Text = " Alunos";
            this.optAluno.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.optAluno.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.optAluno.UseVisualStyleBackColor = false;
            this.optAluno.Click += new System.EventHandler(this.optAluno_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // panelSubTela
            // 
            this.panelSubTela.BackColor = System.Drawing.Color.Transparent;
            this.panelSubTela.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panelSubTela.BackgroundImage")));
            this.panelSubTela.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelSubTela.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelSubTela.Location = new System.Drawing.Point(128, 24);
            this.panelSubTela.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panelSubTela.Name = "panelSubTela";
            this.panelSubTela.Size = new System.Drawing.Size(818, 523);
            this.panelSubTela.TabIndex = 4;
            // 
            // FMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(946, 547);
            this.Controls.Add(this.panelSubTela);
            this.Controls.Add(this.BarraMenuLataral);
            this.Controls.Add(this.BarraDeTitulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sistema Escola";
            this.BarraDeTitulo.ResumeLayout(false);
            this.BarraMenuLataral.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel BarraDeTitulo;
        private System.Windows.Forms.Panel BarraMenuLataral;
        private System.Windows.Forms.Button BotaoFechar;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button optAluno;
        private System.Windows.Forms.Button BotaoRestaurar;
        private System.Windows.Forms.Button BotaoMinimizar;
        private System.Windows.Forms.Button BotaoMaximizar;
        private System.Windows.Forms.Button sair;
        private System.Windows.Forms.Panel panelSubTela;
    }
}

