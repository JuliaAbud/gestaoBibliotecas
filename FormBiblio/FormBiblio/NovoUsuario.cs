using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormBiblio
{
    public partial class NovoUsuario : Form
    {
        Admin admin;
        public NovoUsuario(Admin a)
        {
            admin = a;
            InitializeComponent();
        }

        private void butCadastrar_Click(object sender, EventArgs e)
        {
            try
            {
                int arry1, arry2;
                string nome = textNome.Text;
                arry1 = textNome.Text.Length;
                string senha = textSenha.Text;
                arry2 = textSenha.Text.Length;
                int mat = int.Parse(textMatricula.Text);
                if (arry1 !=0 && arry2 != 0)
                {
                    if (radioProfessor.Checked == true)
                    {
                        admin.AdcUsuario(mat, nome, "3", senha);
                        textNome.Clear();
                        textSenha.Clear();
                        textMatricula.Clear();
                        radioProfessor.Checked = false;
                        MessageBox.Show("Usuário criado com sucesso.");
                    }
                    else if (radioAlunoGrad.Checked == true)
                    {
                        admin.AdcUsuario(mat, nome, "1", senha);
                        textNome.Clear();
                        textSenha.Clear();
                        textMatricula.Clear();
                        radioAlunoGrad.Checked = false;
                        MessageBox.Show("Usuário criado com sucesso.");
                    }
                    else if (radioPosGrad.Checked == true)
                    {
                        admin.AdcUsuario(mat, nome, "2", senha);
                        textNome.Clear();
                        textSenha.Clear();
                        textMatricula.Clear();
                        radioPosGrad.Checked = false;
                        MessageBox.Show("Usuário criado com sucesso.");
                    }
                    else
                    {
                        MessageBox.Show("Escolha um tipo de usuário!");
                    }
                }
                else
                {
                    MessageBox.Show("Preencha todos os campos.");
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Preencha todos os campos.");
            }
        }

        private void NovoUsuario_Load(object sender, EventArgs e)
        {

        }

        private void textMatricula_TextChanged(object sender, EventArgs e)
        {

        }

        private void textMatricula_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && !(e.KeyChar == (char)Keys.Back))
            {
                e.Handled = true;
            }
        }
    }
}
