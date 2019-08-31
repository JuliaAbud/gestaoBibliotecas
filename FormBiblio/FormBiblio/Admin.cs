using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace FormBiblio
{
    public class Admin : Usuario
    {
        Livro[] livros;

        /// <summary>
        /// Metódo construtor de ADMIN
        /// </summary>
        public Admin(Livro [] l)
        {
            livros = l;
            nome = "Admin";
            senha = "123456";

        }

        /// <summary>
        /// Metodo para adicionar um Livro no arquivo.txt
        /// </summary>
        /// <param name="c">Código do livro</param>
        /// <param name="n">Nome do livro</param>
        /// <param name="t">Tipo do Livro</param>
        /// <param name="qnt">Preço por página do livro</param>
        public void AdcLivro(int c, string n, int t, string qnt)
        {
            if (t == 1) {
                livros[Livro.qntLivros] = new LivroFisico(n, 100, c);
            }
            if (t == 2) {
                livros[Livro.qntLivros] = new LivroDigital(n, 100, c, Double.Parse(qnt));
            }
            
            using (StreamWriter fileUWriter = new StreamWriter(@Globals.PATH + "livros.txt", true)){
                fileUWriter.WriteLine(c + ";" + n + ";" + t + ";" + qnt);
            };

        }

        /// <summary>
        /// Metodo para adicionar um Usuario no arquivo.txt
        /// </summary>
        /// <param name="mat">Numero de matricula do usuario(codigo)</param>
        /// <param name="nom">Nome do usuario</param>
        /// <param name="tipo">Tipo de usuario</param>
        /// <param name="senh">Senha do Usuario</param>
        public void AdcUsuario(int mat, string nom, string tipo, string senh) {
            using (StreamWriter fileUWriter = new StreamWriter(@Globals.PATH + "usuarios.txt", true)) {
                fileUWriter.WriteLine(mat + ";" + nom + ";" + tipo + ";" + senh);
            };
        }

        /// <summary>
        /// Metodo que vai ver se o usúario pode ou nao pegar um novo livro ou se esta penalizado
        /// </summary>
        /// <returns></returns>
        public override void SituacaoDoUsuario()
        {

        }
    }
}
