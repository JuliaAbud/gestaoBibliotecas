namespace FormBiblio
{
    partial class NovoLivro
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NovoLivro));
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.gbTipo = new System.Windows.Forms.GroupBox();
            this.radioDigital = new System.Windows.Forms.RadioButton();
            this.radioFisico = new System.Windows.Forms.RadioButton();
            this.textPaginas = new System.Windows.Forms.TextBox();
            this.textNome = new System.Windows.Forms.TextBox();
            this.textCodigo = new System.Windows.Forms.TextBox();
            this.butCadastrar = new System.Windows.Forms.Button();
            this.gbTipo.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 18);
            this.label3.TabIndex = 2;
            this.label3.Text = "Código:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(22, 122);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 36);
            this.label4.TabIndex = 3;
            this.label4.Text = "Preço por \r\npágina:";
            this.label4.Click += new System.EventHandler(this.Label4_Click);
            // 
            // gbTipo
            // 
            this.gbTipo.Controls.Add(this.radioDigital);
            this.gbTipo.Controls.Add(this.radioFisico);
            this.gbTipo.Location = new System.Drawing.Point(231, 82);
            this.gbTipo.Name = "gbTipo";
            this.gbTipo.Size = new System.Drawing.Size(175, 66);
            this.gbTipo.TabIndex = 4;
            this.gbTipo.TabStop = false;
            this.gbTipo.Text = "Tipo";
            // 
            // radioDigital
            // 
            this.radioDigital.AutoSize = true;
            this.radioDigital.Location = new System.Drawing.Point(92, 30);
            this.radioDigital.Name = "radioDigital";
            this.radioDigital.Size = new System.Drawing.Size(73, 22);
            this.radioDigital.TabIndex = 5;
            this.radioDigital.TabStop = true;
            this.radioDigital.Text = "Digital";
            this.radioDigital.UseVisualStyleBackColor = true;
            this.radioDigital.CheckedChanged += new System.EventHandler(this.RadioDigital_CheckedChanged);
            // 
            // radioFisico
            // 
            this.radioFisico.AutoSize = true;
            this.radioFisico.Location = new System.Drawing.Point(6, 30);
            this.radioFisico.Name = "radioFisico";
            this.radioFisico.Size = new System.Drawing.Size(67, 22);
            this.radioFisico.TabIndex = 0;
            this.radioFisico.TabStop = true;
            this.radioFisico.Text = "Físico";
            this.radioFisico.UseVisualStyleBackColor = true;
            this.radioFisico.CheckedChanged += new System.EventHandler(this.RadioFisico_CheckedChanged);
            // 
            // textPaginas
            // 
            this.textPaginas.Location = new System.Drawing.Point(114, 127);
            this.textPaginas.Name = "textPaginas";
            this.textPaginas.Size = new System.Drawing.Size(100, 31);
            this.textPaginas.TabIndex = 5;
            this.textPaginas.TextChanged += new System.EventHandler(this.textPaginas_TextChanged);
            this.textPaginas.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textPaginas_KeyPress);
            // 
            // textNome
            // 
            this.textNome.Location = new System.Drawing.Point(114, 26);
            this.textNome.Name = "textNome";
            this.textNome.Size = new System.Drawing.Size(292, 31);
            this.textNome.TabIndex = 6;
            // 
            // textCodigo
            // 
            this.textCodigo.Location = new System.Drawing.Point(114, 77);
            this.textCodigo.Name = "textCodigo";
            this.textCodigo.Size = new System.Drawing.Size(100, 31);
            this.textCodigo.TabIndex = 8;
            this.textCodigo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textCodigo_KeyPress);
            // 
            // butCadastrar
            // 
            this.butCadastrar.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.butCadastrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butCadastrar.Location = new System.Drawing.Point(147, 167);
            this.butCadastrar.Name = "butCadastrar";
            this.butCadastrar.Size = new System.Drawing.Size(120, 53);
            this.butCadastrar.TabIndex = 10;
            this.butCadastrar.Text = "Cadastrar";
            this.butCadastrar.UseVisualStyleBackColor = false;
            this.butCadastrar.Click += new System.EventHandler(this.butCadastrar_Click);
            // 
            // NovoLivro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.ClientSize = new System.Drawing.Size(430, 232);
            this.Controls.Add(this.butCadastrar);
            this.Controls.Add(this.textCodigo);
            this.Controls.Add(this.textNome);
            this.Controls.Add(this.textPaginas);
            this.Controls.Add(this.gbTipo);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Lucida Sans Unicode", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "NovoLivro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Adicionar Livro";
            this.Load += new System.EventHandler(this.NovoLivro_Load);
            this.gbTipo.ResumeLayout(false);
            this.gbTipo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox gbTipo;
        private System.Windows.Forms.RadioButton radioFisico;
        private System.Windows.Forms.RadioButton radioDigital;
        private System.Windows.Forms.TextBox textPaginas;
        private System.Windows.Forms.TextBox textNome;
        private System.Windows.Forms.TextBox textCodigo;
        private System.Windows.Forms.Button butCadastrar;
    }
}