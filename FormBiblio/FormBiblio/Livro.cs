using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormBiblio
{
    public abstract class Livro
    {
        public static int qntLivros;
        public Livro()
        {
             qntLivros++;
        }

        protected string _nome;
        public string nome
        {
            get { return _nome; }
            set { _nome = value; }
        }

        protected int _codigo;
        public int codigo
        {
            get { return _codigo; }
            set { _codigo = value; }
        }

        protected int _qtnPaginas;
        public int qtnPaginas
        {
            get { return _qtnPaginas; }
            set
            {
                if (value > 0)
                    _qtnPaginas = value;
                else
                    _qtnPaginas = 1;
            }
        }

        /// <summary>
        /// Construtor
        /// </summary>
        /// <param name="n"> Nome do Livro</param>
        /// <param name="tip">V: virtual F: físico</param>
        /// <param name="qtnP">Quantidade de páginas</param>
        /// <param name="a"> Nome do autor</param>
        public Livro(string n, int qtnP, int cod)
        {
            qntLivros++;
            nome = n;
            qtnPaginas = qtnP;
            codigo = cod;
        }


        public abstract void emprestar(Usuario u);

    }
}
