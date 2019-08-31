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

namespace FormBiblio
{
    public partial class Perfil : Form
    {
        Usuario user;
        private string lista;
        private string _typeControl;
        private int a, b;

        Emprestimo[] emprestimos;
        Emprestimo[] emprestimoAux = new Emprestimo[100000];
        private int emprestimoAuxCounter = 0;

        public Perfil(Usuario u, string l)
        {
            user = u;
            lista = l;
            emprestimos = user.emprestimo;
            InitializeComponent();
        }

        public string typeControl() {
            if (lista == "Consultas") {
                _typeControl = "LivroDigital";
            }
            if (lista == "Emprestimos") {
                _typeControl = "LivroFisico";
            }
            return _typeControl;
        }


        private void textNome_TextChanged(object sender, EventArgs e)
        {
            
            
        }

        private void Perfil_Load(object sender, EventArgs e) {
            if (lista == "Consultas") {
                butDevolver.Visible = false;
            }
            if (lista == "Emprestimos") {
                label1.Visible = false;
                label2.Visible = false;
                butImprimir.Visible = false;
                numericUpDown1.Visible = false;
                endPage.Visible = false;
                
            }
            
            textNome.Text = user.nome;
            textMatricula.Text = user.nMatricula.ToString();
            textVinculo.Text = user.GetType().Name;
            textLista.Text = lista;
            for (int i = 0; i < user.countEmprestimos; i++) {
                Debug.WriteLine(user.countEmprestimos);
                if (user.emprestimo[i].livro.GetType().Name == typeControl()) {
                    string vetdat = user.emprestimo[i].dataDoEmprestimo.ImprimirData();
                    emprestimoAux[emprestimoAuxCounter] = new Emprestimo(user.emprestimo[i].livro, user, 1,vetdat);
                    listLivrosUser.Items.Add("Livro: " + emprestimoAux[emprestimoAuxCounter].livro.nome + "  | Data: " + emprestimoAux[emprestimoAuxCounter].dataDoEmprestimo.ImprimirData() + "  | Dia a devolver: " + emprestimoAux[emprestimoAuxCounter].dataDaDevolucao.ImprimirData());
                    emprestimoAuxCounter++;
                }
           }
           
        }

    

        private void EndPage_ValueChanged_1(object sender, EventArgs e) {
            b = (int)endPage.Value;
        }


        private void ButImprimir_Click_1(object sender, EventArgs e) {
            try {
                if (a > 0 && b > 0 && a <= b) {
                  
                    LivroDigital selectedLivroDigital = (LivroDigital)emprestimoAux[listLivrosUser.SelectedIndex].livro;
                    MessageBox.Show("Preço a pagar: " + selectedLivroDigital.PrecoImpressao(a, b).ToString("c"));
                    selectedLivroDigital.imprimir(a, b);
                    MessageBox.Show("Livro impresso com sucesso.");
                } else {
                    MessageBox.Show("Selecione as páginas corretamente.");
                }
            } catch (NullReferenceException) {
                MessageBox.Show("Selecione um livro digital.");
            } catch (IndexOutOfRangeException) {
                MessageBox.Show("Selecione um livro.");
            }

        }

        private void NumericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            a = (int)numericUpDown1.Value;
        }

        private void butDevolver_Click(object sender, EventArgs e)
        {
            try
            {
                Emprestimo emp = emprestimoAux[listLivrosUser.SelectedIndex];
                Debug.WriteLine(emp.dataDoEmprestimo.ImprimirData());
                user.DevolverEmprestimo(emp);
                DateTime dataDaPenalidade = new DateTime(emp.dataDaDevolucao.ano, emp.dataDaDevolucao.mes, emp.dataDaDevolucao.dia);
                DateTime dataAtual = DateTime.Now;
                if (dataAtual.Date <= dataDaPenalidade.Date)
                {
                    MessageBox.Show("Livro devolvido sem atraso.");
                }
                else
                {
                    MessageBox.Show("Exemplar atrasado.");
                }
                user.DevolverEmprestimo(emp = emprestimoAux[listLivrosUser.SelectedIndex]);
            }
            catch (IndexOutOfRangeException)
            {
                MessageBox.Show("Selecione um empréstimo.");
            }
            
        }


        private void ListLivrosUser_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
    }
}
