namespace FormBiblio
{
    partial class Perfil
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Perfil));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.labelNome = new System.Windows.Forms.Label();
            this.labelVinculo = new System.Windows.Forms.Label();
            this.labelMatricula = new System.Windows.Forms.Label();
            this.listLivrosUser = new System.Windows.Forms.ListBox();
            this.labelTipo = new System.Windows.Forms.Label();
            this.butDevolver = new System.Windows.Forms.Button();
            this.textNome = new System.Windows.Forms.TextBox();
            this.textMatricula = new System.Windows.Forms.TextBox();
            this.textVinculo = new System.Windows.Forms.TextBox();
            this.textLista = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.endPage = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.butImprimir = new System.Windows.Forms.Button();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.endPage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::FormBiblio.Properties.Resources._84c1e40ea0e759e3f1505eb1788ddf3c_default_photo;
            this.pictureBox1.Location = new System.Drawing.Point(12, 21);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(136, 117);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // labelNome
            // 
            this.labelNome.AutoSize = true;
            this.labelNome.Location = new System.Drawing.Point(166, 18);
            this.labelNome.Name = "labelNome";
            this.labelNome.Size = new System.Drawing.Size(57, 18);
            this.labelNome.TabIndex = 1;
            this.labelNome.Text = "Nome:";
            // 
            // labelVinculo
            // 
            this.labelVinculo.AutoSize = true;
            this.labelVinculo.Location = new System.Drawing.Point(167, 110);
            this.labelVinculo.Name = "labelVinculo";
            this.labelVinculo.Size = new System.Drawing.Size(67, 18);
            this.labelVinculo.TabIndex = 2;
            this.labelVinculo.Text = "Vínculo:";
            // 
            // labelMatricula
            // 
            this.labelMatricula.AutoSize = true;
            this.labelMatricula.Location = new System.Drawing.Point(166, 64);
            this.labelMatricula.Name = "labelMatricula";
            this.labelMatricula.Size = new System.Drawing.Size(79, 18);
            this.labelMatricula.TabIndex = 3;
            this.labelMatricula.Text = "Matrícula:";
            // 
            // listLivrosUser
            // 
            this.listLivrosUser.FormattingEnabled = true;
            this.listLivrosUser.ItemHeight = 18;
            this.listLivrosUser.Location = new System.Drawing.Point(147, 220);
            this.listLivrosUser.Name = "listLivrosUser";
            this.listLivrosUser.Size = new System.Drawing.Size(1022, 328);
            this.listLivrosUser.TabIndex = 4;
            this.listLivrosUser.SelectedIndexChanged += new System.EventHandler(this.ListLivrosUser_SelectedIndexChanged);
            // 
            // labelTipo
            // 
            this.labelTipo.AutoSize = true;
            this.labelTipo.Location = new System.Drawing.Point(103, 174);
            this.labelTipo.Name = "labelTipo";
            this.labelTipo.Size = new System.Drawing.Size(142, 18);
            this.labelTipo.TabIndex = 5;
            this.labelTipo.Text = "Lista em exibição:";
            // 
            // butDevolver
            // 
            this.butDevolver.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.butDevolver.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butDevolver.Location = new System.Drawing.Point(12, 351);
            this.butDevolver.Name = "butDevolver";
            this.butDevolver.Size = new System.Drawing.Size(120, 53);
            this.butDevolver.TabIndex = 10;
            this.butDevolver.Text = "Devolver";
            this.butDevolver.UseVisualStyleBackColor = false;
            this.butDevolver.Click += new System.EventHandler(this.butDevolver_Click);
            // 
            // textNome
            // 
            this.textNome.Location = new System.Drawing.Point(251, 15);
            this.textNome.Name = "textNome";
            this.textNome.ReadOnly = true;
            this.textNome.Size = new System.Drawing.Size(620, 31);
            this.textNome.TabIndex = 11;
            this.textNome.TextChanged += new System.EventHandler(this.textNome_TextChanged);
            // 
            // textMatricula
            // 
            this.textMatricula.Location = new System.Drawing.Point(251, 61);
            this.textMatricula.Name = "textMatricula";
            this.textMatricula.ReadOnly = true;
            this.textMatricula.Size = new System.Drawing.Size(620, 31);
            this.textMatricula.TabIndex = 12;
            // 
            // textVinculo
            // 
            this.textVinculo.Location = new System.Drawing.Point(251, 107);
            this.textVinculo.Name = "textVinculo";
            this.textVinculo.ReadOnly = true;
            this.textVinculo.Size = new System.Drawing.Size(620, 31);
            this.textVinculo.TabIndex = 13;
            // 
            // textLista
            // 
            this.textLista.Location = new System.Drawing.Point(251, 171);
            this.textLista.Name = "textLista";
            this.textLista.ReadOnly = true;
            this.textLista.Size = new System.Drawing.Size(620, 31);
            this.textLista.TabIndex = 14;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(752, 581);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 18);
            this.label2.TabIndex = 19;
            this.label2.Text = "Até: ";
            // 
            // endPage
            // 
            this.endPage.Location = new System.Drawing.Point(801, 579);
            this.endPage.Name = "endPage";
            this.endPage.Size = new System.Drawing.Size(70, 31);
            this.endPage.TabIndex = 18;
            this.endPage.ValueChanged += new System.EventHandler(this.EndPage_ValueChanged_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(572, 581);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 18);
            this.label1.TabIndex = 17;
            this.label1.Text = "Da Página:";
            // 
            // butImprimir
            // 
            this.butImprimir.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.butImprimir.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butImprimir.Location = new System.Drawing.Point(338, 568);
            this.butImprimir.Name = "butImprimir";
            this.butImprimir.Size = new System.Drawing.Size(228, 45);
            this.butImprimir.TabIndex = 15;
            this.butImprimir.Text = "Imprimir";
            this.butImprimir.UseVisualStyleBackColor = false;
            this.butImprimir.Click += new System.EventHandler(this.ButImprimir_Click_1);
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(663, 579);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(70, 31);
            this.numericUpDown1.TabIndex = 20;
            this.numericUpDown1.ValueChanged += new System.EventHandler(this.NumericUpDown1_ValueChanged);
            // 
            // Perfil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.ClientSize = new System.Drawing.Size(1181, 636);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.endPage);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.butImprimir);
            this.Controls.Add(this.textLista);
            this.Controls.Add(this.textVinculo);
            this.Controls.Add(this.textMatricula);
            this.Controls.Add(this.textNome);
            this.Controls.Add(this.butDevolver);
            this.Controls.Add(this.labelTipo);
            this.Controls.Add(this.listLivrosUser);
            this.Controls.Add(this.labelMatricula);
            this.Controls.Add(this.labelVinculo);
            this.Controls.Add(this.labelNome);
            this.Controls.Add(this.pictureBox1);
            this.Font = new System.Drawing.Font("Lucida Sans Unicode", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Perfil";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Meu Perfil";
            this.Load += new System.EventHandler(this.Perfil_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.endPage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label labelNome;
        private System.Windows.Forms.Label labelVinculo;
        private System.Windows.Forms.Label labelMatricula;
        private System.Windows.Forms.ListBox listLivrosUser;
        private System.Windows.Forms.Label labelTipo;
        private System.Windows.Forms.Button butDevolver;
        private System.Windows.Forms.TextBox textNome;
        private System.Windows.Forms.TextBox textMatricula;
        private System.Windows.Forms.TextBox textVinculo;
        private System.Windows.Forms.TextBox textLista;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown endPage;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button butImprimir;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
    }
}