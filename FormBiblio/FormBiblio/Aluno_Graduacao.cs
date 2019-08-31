using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormBiblio
{
    class Aluno_Graduacao : Usuario
    {
        static int maximoLivros = 5;

        /// <summary>
        /// Metódo construtor de Aluno de Graduação
        /// </summary>
        /// <param name="a">Nome do usuário</param>
        /// <param name="b">Numero de Matrícula do usuário</param>
        /// <param name="d">Senha do usuario</param>
        public Aluno_Graduacao(string a, int b, string d)
        {
            nome = a;
            nMatricula = b;
            nMaxLivros = maximoLivros;
            emprestimo = new Emprestimo[100000];
            nAtualLivros = 0;
            situação = true;
            senha = d;
            penalidade = new Data (DateTime.Today.Day, DateTime.Today.Month, DateTime.Today.Year);
            countEmprestimos = 0;
        }

        /// <summary>
        /// Metodo que vai ver se o usúario pode ou nao pegar um novo livro ou se esta penalizado
        /// </summary>
        /// <returns></returns>
        public override void SituacaoDoUsuario()
        {
            DateTime dataDaPenalidade = new DateTime(penalidade.ano, penalidade.mes, penalidade.dia);
            DateTime dataAtual = DateTime.Now;

            if (this.nAtualLivros < this.nMaxLivros && dataAtual.Date <= dataDaPenalidade.Date)
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
