namespace FormBiblio
{
    partial class UserVisao
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserVisao));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.verToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.meusEmprestimosToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.minhaListaToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.sairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.meusEmprestimosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.minhaListaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pendênciasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listUser = new System.Windows.Forms.ListBox();
            this.butEmprestimo = new System.Windows.Forms.Button();
            this.verMais = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.verToolStripMenuItem,
            this.sairToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1279, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // verToolStripMenuItem
            // 
            this.verToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.meusEmprestimosToolStripMenuItem1,
            this.minhaListaToolStripMenuItem1});
            this.verToolStripMenuItem.Name = "verToolStripMenuItem";
            this.verToolStripMenuItem.Size = new System.Drawing.Size(73, 20);
            this.verToolStripMenuItem.Text = "Meu Perfil";
            // 
            // meusEmprestimosToolStripMenuItem1
            // 
            this.meusEmprestimosToolStripMenuItem1.Name = "meusEmprestimosToolStripMenuItem1";
            this.meusEmprestimosToolStripMenuItem1.Size = new System.Drawing.Size(175, 22);
            this.meusEmprestimosToolStripMenuItem1.Text = "Meus Emprestimos";
            this.meusEmprestimosToolStripMenuItem1.Click += new System.EventHandler(this.meusEmprestimosToolStripMenuItem1_Click);
            // 
            // minhaListaToolStripMenuItem1
            // 
            this.minhaListaToolStripMenuItem1.Name = "minhaListaToolStripMenuItem1";
            this.minhaListaToolStripMenuItem1.Size = new System.Drawing.Size(175, 22);
            this.minhaListaToolStripMenuItem1.Text = "Minhas Consultas";
            this.minhaListaToolStripMenuItem1.Click += new System.EventHandler(this.minhaListaToolStripMenuItem1_Click);
            // 
            // sairToolStripMenuItem
            // 
            this.sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            this.sairToolStripMenuItem.Size = new System.Drawing.Size(38, 20);
            this.sairToolStripMenuItem.Text = "Sair";
            this.sairToolStripMenuItem.Click += new System.EventHandler(this.sairToolStripMenuItem_Click);
            // 
            // meusEmprestimosToolStripMenuItem
            // 
            this.meusEmprestimosToolStripMenuItem.Name = "meusEmprestimosToolStripMenuItem";
            this.meusEmprestimosToolStripMenuItem.Size = new System.Drawing.Size(175, 22);
            this.meusEmprestimosToolStripMenuItem.Text = "Meus emprestimos";
            // 
            // minhaListaToolStripMenuItem
            // 
            this.minhaListaToolStripMenuItem.Name = "minhaListaToolStripMenuItem";
            this.minhaListaToolStripMenuItem.Size = new System.Drawing.Size(175, 22);
            this.minhaListaToolStripMenuItem.Text = "Minha Lista";
            // 
            // pendênciasToolStripMenuItem
            // 
            this.pendênciasToolStripMenuItem.Name = "pendênciasToolStripMenuItem";
            this.pendênciasToolStripMenuItem.Size = new System.Drawing.Size(175, 22);
            this.pendênciasToolStripMenuItem.Text = "Pendências";
            // 
            // listUser
            // 
            this.listUser.FormattingEnabled = true;
            this.listUser.ItemHeight = 18;
            this.listUser.Location = new System.Drawing.Point(15, 45);
            this.listUser.Name = "listUser";
            this.listUser.Size = new System.Drawing.Size(913, 508);
            this.listUser.TabIndex = 5;
            this.listUser.SelectedIndexChanged += new System.EventHandler(this.listUser_SelectedIndexChanged);
            // 
            // butEmprestimo
            // 
            this.butEmprestimo.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.butEmprestimo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butEmprestimo.Location = new System.Drawing.Point(1015, 167);
            this.butEmprestimo.Name = "butEmprestimo";
            this.butEmprestimo.Size = new System.Drawing.Size(228, 82);
            this.butEmprestimo.TabIndex = 8;
            this.butEmprestimo.Text = "Solicitar Emprestimo ou Consulta";
            this.butEmprestimo.UseVisualStyleBackColor = false;
            this.butEmprestimo.Click += new System.EventHandler(this.ButEmprestimo_Click);
            // 
            // verMais
            // 
            this.verMais.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.verMais.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.verMais.Location = new System.Drawing.Point(1015, 298);
            this.verMais.Name = "verMais";
            this.verMais.Size = new System.Drawing.Size(228, 82);
            this.verMais.TabIndex = 9;
            this.verMais.Text = "Ver os Mais Emprestados";
            this.verMais.UseVisualStyleBackColor = false;
            this.verMais.Click += new System.EventHandler(this.VerMais_Click);
            // 
            // UserVisao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.ClientSize = new System.Drawing.Size(1279, 585);
            this.ControlBox = false;
            this.Controls.Add(this.verMais);
            this.Controls.Add(this.butEmprestimo);
            this.Controls.Add(this.listUser);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "UserVisao";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Serviço de Emprestimo";
            this.Load += new System.EventHandler(this.UserVisao_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem verToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem meusEmprestimosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem minhaListaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pendênciasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sairToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem meusEmprestimosToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem minhaListaToolStripMenuItem1;
        private System.Windows.Forms.ListBox listUser;
        private System.Windows.Forms.Button butEmprestimo;
        private System.Windows.Forms.Button verMais;
    }
}