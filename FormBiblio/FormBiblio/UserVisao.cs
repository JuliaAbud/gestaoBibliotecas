using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.IO;

namespace FormBiblio
{
    public partial class UserVisao : Form
    {

        Livro[] livros;
        Usuario user;
        LivroDigital selectedLivroDigital;
        Emprestimo[] auxEmp = new Emprestimo[10000];
        int countEmp = 0;


        private bool podeConsultar;
        public UserVisao(Usuario u, Livro[] l)
        {
            podeConsultar = false;
            livros = l;
            user = u;
            InitializeComponent();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void listUser_SelectedIndexChanged(object sender, EventArgs e)
        {

            try
            {
                if (livros[listUser.SelectedIndex].GetType().Name == "LivroDigital")
                {
                    podeConsultar = true;
                    selectedLivroDigital = (LivroDigital)livros[listUser.SelectedIndex];
                }
                else
                {
                    podeConsultar = false;
                    selectedLivroDigital = null;
                }
            }
            catch (IndexOutOfRangeException)
            {
                MessageBox.Show("Selecione um livro.");
            }


        }

        private void meusEmprestimosToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Perfil pessoa = new Perfil(user, "Emprestimos");
            pessoa.Show();
        }

        private void minhaListaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Perfil pessoa = new Perfil(user, "Consultas");
            pessoa.Show();
        }



        private void UserVisao_Load(object sender, EventArgs e)
        {

            string line;
            string[] emp;

            StreamReader fileUser = new StreamReader(@Globals.PATH + "emprestimos.txt");

            int q = 0;

            while ((line = fileUser.ReadLine()) != null)
            {
                emp = line.Split(';');
                if (emp[2] == "1") {
                    for (int p = 0; p < Livro.qntLivros; p++) {
                        if (livros[p].codigo == int.Parse(emp[1])) {
                            auxEmp[q] = new Emprestimo(livros[p], user,1);
                            countEmp++;
                            if (int.Parse(emp[0]) == user.nMatricula) {
                                user.emprestimo[user.countEmprestimos] = new Emprestimo(livros[p], user, 1,emp[3]);
                                user.countEmprestimos++;
                                //user.nAtualLivros++;
                            }
                        }
                    }

                    q++;
                }
            }
            fileUser.Close();
            
            for (int i = 0; i < Livro.qntLivros; i++)
            {
                string tipo = livros[i].GetType().Name;
                listUser.Items.Add("Código: " + livros[i].codigo + "   Nome: " + livros[i].nome + "   Tipo: " + tipo);
            }
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }



        private void ButEmprestimo_Click(object sender, EventArgs e)
        {
            user.SituacaoDoUsuario();
            if (user.situação)
            {
                
                try
                {
                    auxEmp[countEmp] = new Emprestimo(livros[listUser.SelectedIndex], user, 1);
                    user.emprestimo[user.countEmprestimos] = new Emprestimo(livros[listUser.SelectedIndex], user, 1);

                    countEmp++;
                    user.PegarLivroEmprestado(livros[listUser.SelectedIndex]);
                    MessageBox.Show("Empréstimo realizado com sucesso.");
                }
                catch (Exception)
                {
                    MessageBox.Show("Selecione um livro.");
                }

            }
            else
            {
                MessageBox.Show("Usuário não pode efetuar um empréstimo.");
            }

        }

        private void VerMais_Click(object sender, EventArgs e) { 
            int max = 0;
            int indexLivro = 0;
            Emprestimo[] aux2Emp = new Emprestimo[countEmp];
            int num = 0;
            for (int i = 0; i < countEmp; i++) {
                aux2Emp[i] = auxEmp[i];
            }
            for (int i = 0; i < Livro.qntLivros; i++)
            {
                num = aux2Emp.Count(emprestimo => emprestimo.livro.codigo == livros[i].codigo);
                if (num > max)
                {
                    max = num;
                    indexLivro = i;
                }
            }
            MessageBox.Show("Livro: " + livros[indexLivro].nome + "\nTipo: " + livros[indexLivro].GetType().Name + "  \nVezes empestadas: " + max);
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }
}
