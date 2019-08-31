using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;

namespace FormBiblio
{
    /* GRUPO: Julia Abud; Gabriel Atene; Hudson Martins; Pedro Augusto Melo
     * Para fazer login: Usuario -> número de matricula presente no arquivo de usuarios
     *                   Senha - > 123456   
     */
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Livro[] livros = new Livro[1000];

            string line;
            string[] books;

            StreamReader fileUser = new StreamReader(@Globals.PATH + "livros.txt");

            int i = 0;

            while ((line = fileUser.ReadLine()) != null) {
                books = line.Split(';');
                if (books[2] == "1") {
                    livros[i] = new LivroFisico(books[1], 10, Convert.ToInt32(books[0]));
                }
                if (books[2] == "2") {
                    livros[i] = new LivroDigital(books[1], 10, Convert.ToInt32(books[0]), Double.Parse(books[3]));
                }
                i++;
            }
            fileUser.Close();


            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Entrada(livros));
        }
    }
}
