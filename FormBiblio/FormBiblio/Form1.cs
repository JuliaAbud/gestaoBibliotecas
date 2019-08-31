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
using System.Diagnostics;

namespace FormBiblio
{
    public partial class Entrada : Form
    {
        Livro [] livros;
        
        public Entrada(Livro [] l)
        {
            livros = l;
            
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
         
        }

        private void butEntrar_Click(object sender, EventArgs e)
        {
            string line;
            string[] users;

            StreamReader fileUser = new StreamReader(@Globals.PATH + "usuarios.txt");

            while ((line = fileUser.ReadLine()) != null) {
                users = line.Split(';');

                if (textUsuario.Text == "Admin" && textSenha.Text == "123456") {
                    Admin admin = new Admin(livros);
                    AdmVisao adm = new AdmVisao(livros, admin);
                    fileUser.Close();
                    adm.ShowDialog(); //abre outro
                    return;

                } else {
                    if (textUsuario.Text == users[0]&&textSenha.Text == "123456") {
                        Usuario u;
                        if (users[2] == "1") {
                            u = new Aluno_Graduacao(users[1], Convert.ToInt32(textUsuario.Text), "123456");
                        }
                        if (users[2] == "2") {
                            u = new Aluno_Pos_Graduacao(users[1], Convert.ToInt32(textUsuario.Text), "123456");
                        }
                        if (users[2] == "3") {
                            u = new Professor(users[1], Convert.ToInt32(textUsuario.Text), "123456");
                        } else {
                            u = new Aluno_Graduacao(users[1], Convert.ToInt32(textUsuario.Text), "123456");
                        }
                        UserVisao usuario = new UserVisao(u, livros);
                        usuario.ShowDialog(); //abre outro
                        fileUser.Close();
                        return;
                    }
                }
            }
            MessageBox.Show("Usuário não cadastrado.");
            textUsuario.Clear();
            textSenha.Clear();
            fileUser.Close();
            
        }
    }
}
