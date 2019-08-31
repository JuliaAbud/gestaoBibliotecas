using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormBiblio
{
    class LivroFisico : Livro
    {
        /// <summary>
        /// Construtor Livro Fisico
        /// </summary>
        /// <param name="n"></param>
        /// <param name="qtn"></param>
        /// <param name="tip"></param>
        /// <param name="qtnP"></param>
        /// <param name="a"></param>
        public LivroFisico(string n, int qtnP, int cod)
        {
            nome = n;
            qtnPaginas = qtnP;
            
            codigo = cod;
        }

        public override void emprestar(Usuario u)
        {
            u.nAtualLivros++;
            u.emprestimo[u.countEmprestimos] = new Emprestimo(this, u, 1);
            u.emprestimo[u.countEmprestimos].Emprestar(this, u);
        }

    }
}
