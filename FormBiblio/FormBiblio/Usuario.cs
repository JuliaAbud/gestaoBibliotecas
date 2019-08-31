using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Diagnostics;

namespace FormBiblio
{
    public abstract class Usuario
    {
        protected string _nome;
        public string nome
        {
            get { return _nome; }
            set { _nome = value; }
        }

        protected int _nMatricula;
        public int nMatricula
        {
            get { return _nMatricula; }
            set
            {
                if (value >= 0)
                {
                    _nMatricula = value;
                }
                else
                {
                    _nMatricula = 0;
                }
            }

        }

        protected int _nMaxLivros;
        protected int nMaxLivros
        {
            get { return _nMaxLivros; }
            set { _nMaxLivros = value; }
        }

        protected int _nAtualLivros;
        public int nAtualLivros
        {
            get { return _nAtualLivros; }
            set { _nAtualLivros = value; }
        }

        protected bool _situação;
        public bool situação
        {
            get { return _situação; }
            set { _situação = value; }
        }

        protected string _senha;
        public string senha
        {
            get { return _senha; }
            set { _senha = value; }
        }

        protected Emprestimo[] _emprestimo;
        public Emprestimo[] emprestimo
        {
            get { return _emprestimo; }
            set { _emprestimo = value; }
        }

        protected Data _penalidade;
        public Data penalidade
        {
            get { return _penalidade; }
            set { _penalidade = value; }
        }

        protected int _countEmprestimos;
        public int countEmprestimos {
            get { return _countEmprestimos; }
            set { _countEmprestimos = value; }
        }

        /// <summary>
        /// Metodo que vai ver se o usúario pode ou nao pegar um novo livro ou se esta penalizado
        /// </summary>
        /// <returns></returns>
        public abstract void SituacaoDoUsuario();

        /// <summary>
        /// Metodo para o usúario pegar um livro emprestado
        /// </summary>
        /// <param name="a">Livro no qual o usúario deseja pegar</param>
        public bool PegarLivroEmprestado(Livro a)
        {
            SituacaoDoUsuario();
            if (this.situação)
            {
                countEmprestimos++;
                a.emprestar(this);
                return true;
            } else
            {
                return false;
            }
           
        }
  
        /// <summary>
        /// Metodo para o usúario devolver o emprestimo de um livro
        /// </summary>
        /// <param name="e">Emprestimo a qual o usuario deseja devolver</param>
        /// <returns></returns>
        public void DevolverEmprestimo(Emprestimo e)
        {
            e.Devolver(e.livro, this);
            nAtualLivros--;
        }



    }
}
