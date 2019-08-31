using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace FormBiblio {
    public partial class AdmVisao : Form {
        Admin adm;
        Livro[] livros;
        public AdmVisao(Livro[] l, Admin a) {
            livros = l;
            adm = a;
            InitializeComponent();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e) {
            this.Close();
        }

        private void adicionarToolStripMenuItem1_Click(object sender, EventArgs e) {
            NovoLivro novo = new NovoLivro(adm);
            novo.Show();
        }

        private void adicionarToolStripMenuItem_Click(object sender, EventArgs e) {
            NovoUsuario novo = new NovoUsuario(adm);
            novo.Show();
        }

        private void AdmVisao_Load(object sender, EventArgs e) {

        }

        private void ListarToolStripMenuItem1_Click(object sender, EventArgs e) {
            listAdm.Items.Clear();
            for (int i = 0; i < Livro.qntLivros; i++) {
                string tipo = livros[i].GetType().Name;
               
                listAdm.Items.Add("Código: " + livros[i].codigo + "   Nome: " + livros[i].nome + "   Tipo: " + tipo);
            }
     
        }

        private void ListAdm_SelectedIndexChanged(object sender, EventArgs e) {

        }

        private void ListarToolStripMenuItem_Click(object sender, EventArgs e) {
            try {
                string line;
                string[] users;
                listAdm.Items.Clear();
                StreamReader fileUser = new StreamReader(@Globals.PATH + "/usuarios.txt");

                while ((line = fileUser.ReadLine()) != null) {
                    users = line.Split(';');
                    listAdm.Items.Add("Nome: " + users[1] + "," + "Nº Matricula: " + users[0] + "," + "Tipo: " + users[2]);

                }
                fileUser.Close();
            } catch (FileNotFoundException) {
                MessageBox.Show("Lista de usuários não encontrada.");
            }
       
        }

        private void usuárioToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}