using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Diagnostics;

namespace FormBiblio
{
    class LivroDigital : Livro
    {
        
        private string _custoImpressao;
        public string custoImpressao
        {
            get { return _custoImpressao; }
            set { _custoImpressao = value; }
        }

        /// <summary>
        /// Construtor Livro Digital
        /// </summary>
        /// <param name="n"></param>
        /// <param name="qtnP"></param>
        /// <param name="a"></param>
        /// <param name="l"></param>
        public LivroDigital(string n,int qtnP, int cod, double custoImp)
        {
            custoImpressao = custoImp.ToString();
            
            nome = n;
            qtnPaginas = qtnP;
            codigo = cod;
        }

        /// <summary>
        /// Calcula o preço da impressão
        /// </summary>
        /// <param name="a">1 página a ser imprimida ou única página</param>
        /// <param name="b">última página ou única página</param>
        /// <returns>Preçoo da impressão - double</returns>
        public double PrecoImpressao(int a, int b)
        {
            
            int pg = b - a;
            pg++;

            return Double.Parse(custoImpressao) * pg;
        }

        /// <summary>
        /// Imprime a quantidade de páginas requeridas
        /// </summary>
        /// <param name="a">1 página a ser imprimida ou única página</param>
        /// <param name="b">última página a ser imprimida ou única página</param>
        public void imprimir(int a, int b)
        {
           try {
                using (FileStream fs = File.Create(@Globals.PATH + nome + ".txt")) { }
                using (StreamWriter fileUWriter = new StreamWriter(@Globals.PATH + nome + ".txt", true))
                {
                    for (int i = a; i <= b; i++)
                    {
                        fileUWriter.WriteLine(Globals.BOOK_CONTENT);
                        fileUWriter.WriteLine("Pág " + i);
                    }

                };
            } catch(NotSupportedException)
            {
                for (int i = a; i <= b; i++)
                {
                    Debug.WriteLine(Globals.BOOK_CONTENT);
                    Debug.WriteLine("Pág " + i);
                }
            }
            
        }

        public override void emprestar(Usuario u)
        {
            u.emprestimo[u.countEmprestimos] = new Emprestimo(this,u, 1);
            u.emprestimo[u.countEmprestimos].Emprestar(this, u);
        }


    }
}
