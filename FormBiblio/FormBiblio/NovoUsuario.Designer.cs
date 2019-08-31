namespace FormBiblio
{
    partial class NovoUsuario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NovoUsuario));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textMatricula = new System.Windows.Forms.TextBox();
            this.textNome = new System.Windows.Forms.TextBox();
            this.textSenha = new System.Windows.Forms.TextBox();
            this.gbTipo = new System.Windows.Forms.GroupBox();
            this.radioPosGrad = new System.Windows.Forms.RadioButton();
            this.radioProfessor = new System.Windows.Forms.RadioButton();
            this.radioAlunoGrad = new System.Windows.Forms.RadioButton();
            this.butCadastrar = new System.Windows.Forms.Button();
            this.gbTipo.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Matrícula:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 130);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 18);
            this.label3.TabIndex = 2;
            this.label3.Text = "Senha:";
            // 
            // textMatricula
            // 
            this.textMatricula.Location = new System.Drawing.Point(123, 80);
            this.textMatricula.Name = "textMatricula";
            this.textMatricula.Size = new System.Drawing.Size(136, 31);
            this.textMatricula.TabIndex = 3;
            this.textMatricula.TextChanged += new System.EventHandler(this.textMatricula_TextChanged);
            this.textMatricula.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textMatricula_KeyPress);
            // 
            // textNome
            // 
            this.textNome.Location = new System.Drawing.Point(123, 30);
            this.textNome.Name = "textNome";
            this.textNome.Size = new System.Drawing.Size(357, 31);
            this.textNome.TabIndex = 4;
            // 
            // textSenha
            // 
            this.textSenha.Location = new System.Drawing.Point(123, 127);
            this.textSenha.Name = "textSenha";
            this.textSenha.Size = new System.Drawing.Size(136, 31);
            this.textSenha.TabIndex = 5;
            // 
            // gbTipo
            // 
            this.gbTipo.Controls.Add(this.radioPosGrad);
            this.gbTipo.Controls.Add(this.radioProfessor);
            this.gbTipo.Controls.Add(this.radioAlunoGrad);
            this.gbTipo.Location = new System.Drawing.Point(265, 67);
            this.gbTipo.Name = "gbTipo";
            this.gbTipo.Size = new System.Drawing.Size(215, 106);
            this.gbTipo.TabIndex = 6;
            this.gbTipo.TabStop = false;
            this.gbTipo.Text = "Tipo";
            // 
            // radioPosGrad
            // 
            this.radioPosGrad.AutoSize = true;
            this.radioPosGrad.Location = new System.Drawing.Point(22, 50);
            this.radioPosGrad.Name = "radioPosGrad";
            this.radioPosGrad.Size = new System.Drawing.Size(182, 22);
            this.radioPosGrad.TabIndex = 7;
            this.radioPosGrad.TabStop = true;
            this.radioPosGrad.Text = "Aluno Pós Graduação";
            this.radioPosGrad.UseVisualStyleBackColor = true;
            // 
            // radioProfessor
            // 
            this.radioProfessor.AutoSize = true;
            this.radioProfessor.Location = new System.Drawing.Point(22, 78);
            this.radioProfessor.Name = "radioProfessor";
            this.radioProfessor.Size = new System.Drawing.Size(96, 22);
            this.radioProfessor.TabIndex = 8;
            this.radioProfessor.TabStop = true;
            this.radioProfessor.Text = "Professor";
            this.radioProfessor.UseVisualStyleBackColor = true;
            // 
            // radioAlunoGrad
            // 
            this.radioAlunoGrad.AutoSize = true;
            this.radioAlunoGrad.Location = new System.Drawing.Point(22, 22);
            this.radioAlunoGrad.Name = "radioAlunoGrad";
            this.radioAlunoGrad.Size = new System.Drawing.Size(151, 22);
            this.radioAlunoGrad.TabIndex = 0;
            this.radioAlunoGrad.TabStop = true;
            this.radioAlunoGrad.Text = "Aluno Graduação";
            this.radioAlunoGrad.UseVisualStyleBackColor = true;
            // 
            // butCadastrar
            // 
            this.butCadastrar.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.butCadastrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butCadastrar.Location = new System.Drawing.Point(180, 182);
            this.butCadastrar.Name = "butCadastrar";
            this.butCadastrar.Size = new System.Drawing.Size(120, 53);
            this.butCadastrar.TabIndex = 11;
            this.butCadastrar.Text = "Cadastrar";
            this.butCadastrar.UseVisualStyleBackColor = false;
            this.butCadastrar.Click += new System.EventHandler(this.butCadastrar_Click);
            // 
            // NovoUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.ClientSize = new System.Drawing.Size(492, 247);
            this.Controls.Add(this.butCadastrar);
            this.Controls.Add(this.gbTipo);
            this.Controls.Add(this.textSenha);
            this.Controls.Add(this.textNome);
            this.Controls.Add(this.textMatricula);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Lucida Sans Unicode", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "NovoUsuario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Adicionar Usuário";
            this.Load += new System.EventHandler(this.NovoUsuario_Load);
            this.gbTipo.ResumeLayout(false);
            this.gbTipo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textMatricula;
        private System.Windows.Forms.TextBox textNome;
        private System.Windows.Forms.TextBox textSenha;
        private System.Windows.Forms.GroupBox gbTipo;
        private System.Windows.Forms.RadioButton radioPosGrad;
        private System.Windows.Forms.RadioButton radioProfessor;
        private System.Windows.Forms.RadioButton radioAlunoGrad;
        private System.Windows.Forms.Button butCadastrar;
    }
}