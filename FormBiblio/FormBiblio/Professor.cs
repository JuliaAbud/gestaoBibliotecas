using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormBiblio
{
    class Professor : Usuario
    {
        static int maximoLivros = 10;

        /// <summary>
        /// Metódo construtor de Professor
        /// </summary>
        /// <param name="a">Nome do usuário</param>
        /// <param name="b">Numero de Matrícula do usuário</param>
        /// <param name="d">Senha do usuario</param>
        public Professor(string a, int b, string d)
        {
            nome = a;
            nMatricula = b;
            nMaxLivros = maximoLivros;
            emprestimo = new Emprestimo[nMaxLivros];
            nAtualLivros = 0;
            situação = true;
            senha = d;
            penalidade = new Data(DateTime.Today.Day, DateTime.Today.Month, DateTime.Today.Year);
            countEmprestimos = 0;
        }

        /// <summary>
        /// Metodo que vai ver se o usúario pode ou nao pegar um novo livro ou se esta penalizado
        /// </summary>
        /// <returns></returns>
        public override void SituacaoDoUsuario()
        {
            if (this.nAtualLivros < this.nMaxLivros)
            {
                this.situação = true;

            }
            else
            {
                this.situação = false;

            }
        }
    }
}
