using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Windows.Forms;


namespace FormBiblio
{
    public partial class NovoLivro : Form
    {
        Admin admin;
        int tipo, cod;
        string pag;
        string nome = "";
        public NovoLivro(Admin adm)
        {
            admin = adm;
            InitializeComponent();
        }

        private void butCadastrar_Click(object sender, EventArgs e)
        {
            try {
                nome = textNome.Text;
                pag = textPaginas.Text;
                cod = int.Parse(textCodigo.Text);

                if (textPaginas.Text.Contains(','))
                {
                    if (nome.Length != 0 && (tipo == 1 || tipo == 2))
                    {
                        admin.AdcLivro(cod, nome, tipo, pag);
                        MessageBox.Show("Livro Cadastrado com sucesso.");
                        textNome.Text = "";
                        textPaginas.Text = "";
                        textCodigo.Text = "";
                        radioDigital.Checked = false;
                    }
                    else
                    {
                        MessageBox.Show("Preencha todos os campos.");
                    }
                }
                else
                {
                    pag = pag + ",0";
                    if (nome.Length != 0 && (tipo == 1 || tipo == 2))
                    {
                        admin.AdcLivro(cod, nome, tipo, pag);
                        MessageBox.Show("Livro Cadastrado com sucesso.");
                        textNome.Text = "";
                        textPaginas.Text = "";
                        textCodigo.Text = "";
                        radioDigital.Checked = false;
                    }
                    else
                    {
                        MessageBox.Show("Preencha todos os campos.");
                    }
                }
                
            }
            catch (FormatException) {
                MessageBox.Show("Preencha todos os campos.");
            }
            
        }

        private void NovoLivro_Load(object sender, EventArgs e) {

        }

        private void Label4_Click(object sender, EventArgs e) {

        }

        private void RadioFisico_CheckedChanged(object sender, EventArgs e) {
            tipo = 1;
        }

        private void textPaginas_TextChanged(object sender, EventArgs e)
        {

        }

        private void textPaginas_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar == '.'))
            {
                e.KeyChar = ',';
            }

            if (!char.IsNumber(e.KeyChar) && !(e.KeyChar == (char)Keys.Back) && !(e.KeyChar == ','))
            {
                e.Handled = true;
            }
        }

        private void textCodigo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && !(e.KeyChar == (char)Keys.Back))
            {
                e.Handled = true;
            }
        }

        private void RadioDigital_CheckedChanged(object sender, EventArgs e)
        {
            tipo = 2;
        }
    }
}
