using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Diagnostics;

namespace FormBiblio
{
    public class Emprestimo
    {
        private Data _dataDoEmprestimo;
        public Data dataDoEmprestimo
        {
            get { return _dataDoEmprestimo; }
            set { _dataDoEmprestimo = value; }
        }

        private Data _dataDaDevolucao;
        public Data dataDaDevolucao
        {
            get { return _dataDaDevolucao; }
            set { _dataDaDevolucao = value; }
        }

        private int _tipo;
        public int tipo {
            get { return _tipo; }
            set { _tipo = value; }
        }

        private Livro _livro;
        public Livro livro {
            get { return _livro; }
            set { _livro = value; }
        }

        private Usuario _usuario;
        public Usuario usuario
        {
            get { return _usuario; }
            set { _usuario = value; }
        }

        /// <summary>
        /// Construtor de emprestimo
        /// </summary>
        /// <param name="l">Livro do emprestimo</param>
        /// <param name="u">Usuario do emprestimo</param>
        /// <param name="t">tipo</param>
        public Emprestimo (Livro l, Usuario u, int t)
        {
            livro = l;
            tipo = t;
            usuario = u;
            dataDoEmprestimo = new Data(DateTime.Today.Day, DateTime.Today.Month, DateTime.Today.Year);
            dataDaDevolucao = new Data(DateTime.Today.Day, DateTime.Today.Month, DateTime.Today.Year);
            dataDaDevolucao.AdicionarDias(7);

        }
        public Emprestimo(Livro l, Usuario u, int t,string dat)
        {
            livro = l;
            tipo = t;
            usuario = u;
            string[] vetdat = dat.Split('/');
            dataDoEmprestimo = new Data(int.Parse(vetdat[0]), int.Parse(vetdat[1]), int.Parse(vetdat[2]));
            dataDaDevolucao = new Data(int.Parse(vetdat[0]), int.Parse(vetdat[1]), int.Parse(vetdat[2]));
            dataDaDevolucao.AdicionarDias(7);
        }

        /// <summary>
        /// Metodo para solicitar um emprestimo
        /// </summary>
        /// <param name="l">Livro a qual deseja solicitar um emprestimo</param>
        /// <param name="u">Usuario que está efetuando esse emprestimo</param>
        public void Emprestar(Livro l, Usuario u)
        {
            dataDoEmprestimo = new Data(DateTime.Today.Day, DateTime.Today.Month, DateTime.Today.Year);
            dataDaDevolucao = new Data(DateTime.Today.Day, DateTime.Today.Month, DateTime.Today.Year);
            dataDaDevolucao.AdicionarDias(7);

            using (StreamWriter fileUWriter = new StreamWriter(@Globals.PATH + "emprestimos.txt", true))
            {
                fileUWriter.WriteLine(u.nMatricula + ";" + l.codigo + ";" + 1 + ";" + dataDoEmprestimo.ImprimirData());
            };
        }

        /// <summary>
        /// Metodo para devolver um emprestimo
        /// </summary>
        /// <param name="l">Livro a qual deseja devolver</param>
        /// <param name="u">Usuario que está efetuando essa devolução desse emprestimo</param>
        public void Devolver(Livro l, Usuario u)
        {
            Data dataDevolvida = new Data(DateTime.Today.Day, DateTime.Today.Month, DateTime.Today.Year);
            int a = dataDoEmprestimo.VerDuasDatas(dataDoEmprestimo, dataDevolvida);
            
            dataDevolvida = new Data(DateTime.Today.Day, DateTime.Today.Month, DateTime.Today.Year);
            using (StreamWriter fileUWriter = new StreamWriter(@Globals.PATH + "emprestimos.txt", true)) {
                fileUWriter.WriteLine(u.nMatricula + ";" + l.codigo + ";" + 2 + ";" + dataDevolvida.ImprimirData());
            };
            u.penalidade.AdicionarDias(a*2);
          
        }

    }
}
