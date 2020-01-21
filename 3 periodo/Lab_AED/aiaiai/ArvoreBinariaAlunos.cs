using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exerc_arvore
{
    class ArvoreBinariaAlunos
    {
        private Aluno raiz; // referência à raiz da árvore.
        /// <summary>
        /// Construtor da classe.
        /// Esse construtor cria uma nova árvore binária de alunos vazia. Para isso, esse método atribui null à raiz da árvore.
        /// </summary>
        public ArvoreBinariaAlunos()
        {
            raiz = null;
        }
        /// <summary>
        /// Método booleano que indica se a árvore está vazia ou não.
        /// </summary>
        /// <returns>
        /// verdadeiro: se a raiz da árvore for null, o que significa que a árvore está vazia.
        /// falso: se a raiz da árvore não for null, o que significa que a árvore não está vazia.
        /// </returns>
        public Boolean arvoreVazia()
        {
            /// Se a raiz da árvore for null, a árvore está vazia.
            if (this.raiz == null) return true;
            /// Caso contrário, a árvore não está vazia.
            else return false;
            /// <summary>
            /// Método recursivo responsável por adicionar um aluno à árvore.
            /// </summary>
            /// <param name="raizArvore"> raiz da árvore ou sub--árvore em que o aluno será adicionado. </ param >
            /// <param name="alunoNovo"> aluno que deverá ser adicionado à árvore. </ param >
            /// <returns> a raiz atualizada da árvore ou sub--árvore em que o aluno foi adicionado. </ returns >
        }
        private Aluno adicionar(Aluno raizArvore, Aluno alunoNovo)
        {
            /// Se a raiz da árvore ou sub--árvore for null, a árvore está vazia e então um novo aluno é inserido.
            if (raizArvore == null) raizArvore = alunoNovo;
            else
            {
                /// Se o número de matrícula do aluno armazenado na raiz da árvore for maior do que o número de matrícula do aluno que deverá ser inserido na árvore:
                /// adicione esse aluno à sub--árvore esquerda; e atualize a referência para a sub--árvore esquerda modificada.
                if (raizArvore.numMatricula > alunoNovo.numMatricula) raizArvore.esquerda = adicionar(raizArvore.esquerda, alunoNovo);
                else
                {
                    /// Se o número de matrícula do aluno armazenado na raiz da árvore for menor do que o número de matrícula do aluno que deverá ser inserido na árvore:
                    /// adicione esse aluno à sub--árvore direita; e atualize a referência para a sub--árvore direita modificada.
                    if (raizArvore.numMatricula < alunoNovo.numMatricula) raizArvore.direita = adicionar(raizArvore.direita, alunoNovo);
                    else
                        /// O número de matrícula do aluno armazenado na raiz da árvore é igual ao número de matrícula do aluno que deveria ser inserido na árvore.
                        Console.WriteLine("O aluno {0}, cuja matrícula é {1}, já foi inserido anteriormente.", alunoNovo.nome, alunoNovo.numMatricula);
                }
            }
            /// Retorna a raiz atualizada da árvore ou sub--árvore em que o aluno foi adicionado.
            return raizArvore;
        }

        /// <summary>
        /// Metodo que encapsula a adição recursiva de alunos à árvore.
        /// </summary>
        /// <param name="alunoNovo"> aluno que deverá ser inserido na árvore.</ param >
        public void inserir(Aluno alunoNovo)
        {
            /// Chama o método recursivo "adicionar", que será responsável por adicionar, o aluno passado como parâmetro, à árvore.
            /// O método "adicionar" receberá, como primeiro parâmetro, a raiz atual da árvore; e, como segundo parâmetro, o aluno que deverá ser adicionado à árvore.
            /// Por fim, a raiz atual da árvore é atualizada, com a raiz retornada pelo método "adicionar".
            this.raiz = adicionar(this.raiz, alunoNovo);
        }
        /// <summary>
        /// Método recursivo responsável por localizar na árvore ou sub--árvore o antecessor do nó que deverá ser retirado.
        /// O antecessor do nó que deverá ser retirado da árvore corresponde
        /// ao nó que armazena o aluno cujo número de matrícula é o maior,
        /// dentre os números de matrícula menores do que o número de matrícula do nó que deverá ser retirado.
        /// Depois de ser localizado na árvore ou sub--árvore,
        /// o antecessor do nó que deverá ser retirado da árvore o substitui.
        /// Adicionalmente, a árvore ou sub--árvore é atualizada com a remoção do antecessor.
        /// </summary>
        /// <param name="alunoRetirar"> referência ao nó que armazena o aluno que deverá ser retirado da árvore. </param>
        /// <param name="raizArvore"> raiz da árvore ou sub--árvore em que o antecessor do nó que deverá ser retirado deverá ser localizado. </param>
        /// <returns> raiz atualizada da árvore ou sub--árvore após a remoção do antecessor do nó que foi retirado da árvore. </returns>
        private Aluno antecessor(Aluno alunoRetirar, Aluno raizArvore)
        {
            /// Se o antecessor do nó que deverá ser retirado da árvore ainda não foi encontrado...
            if (raizArvore.direita != null)
            {
                /// Pesquise o antecessor na sub--árvore direita.
                raizArvore.direita = antecessor(alunoRetirar, raizArvore.direita);
                return raizArvore;
            }
            /// O antecessor do nó que deverá ser retirado da árvore foi
            else
            {
                /// O antecessor do nó que deverá ser retirado da árvore o
                alunoRetirar.numMatricula = raizArvore.numMatricula;
                alunoRetirar.nome = raizArvore.nome; alunoRetirar.nota = raizArvore.nota;
                /// A raiz da árvore é atualizada com os descendentes à esquerda do antecessor.
                /// Ou seja, retira--se o antecessor da árvore. 
                return raizArvore.esquerda;
            }
        }
        /// <summary>
        /// Método recursivo responsável por localizar um aluno na árvore e retirá--lo da árvore.
        /// </summary>
        /// <param name="raizArvore"> raiz da árvore ou sub--árvore da qual o aluno será retirado. </param>
        /// <param name="matricula"> número de matrícula do aluno que deverá ser localizado e removido da árvore. </param>
        /// <returns> a raiz atualizada da árvore ou sub--árvore da qual o aluno foi retirado. </returns>
        private Aluno retirar(Aluno raizArvore, int matricula)
        {
            /// Se a raiz da árvore ou sub--árvore for null, a árvore está vazia e o aluno, que deveria ser retirado dessa árvore, não foi encontrado.
            /// Nesse caso, deve--se retornar null.
            if (raizArvore == null)
            {
                Console.WriteLine("O aluno, cuja matrícula é {0}, não foi encontrado.", matricula);
                return raizArvore;
            }
            else
            {
                /// O número de matrícula do aluno armazenado na raiz da árvore é igual ao número de matrícula do aluno que deve ser retirado dessa árvore.
                /// Ou seja, o aluno que deve ser retirado da árvore foi encontrado. 
                if (raizArvore.numMatricula == matricula)
                {
                    /// O nó da árvore que será retirado não possui descendentes à direita.
                    /// Nesse caso, os descendentes à esquerda do nó que está sendo retirado da árvore passarão a ser descendentes do nó--pai do nó que está sendo retirado.
                    if (raizArvore.direita == null) return (raizArvore.esquerda);
                    else
                        /// O nó da árvore que será retirado não possui descendentes à esquerda.
                        /// Nesse caso, os descendentes à direita do nó que está sendo retirado da árvore passarão a ser descendentes do nó--pai do nó que está sendo retirado.
                        if (raizArvore.esquerda == null) return (raizArvore.direita);
                    else
                    {
                        /// O nó que está sendo retirado da árvore possui descendentes à esquerda e à direita.
                        /// Nesse caso, o antecessor do nó que está sendo retirado é localizado na sub--árvore esquerda desse nó.
                        /// O antecessor do nó que está sendo retirado da árvore corresponde matrícula é o maior,
                        /// ao nó que armazena o aluno cujo número de
                        /// dentre os números de matrícula menores do que o número de matrícula do nó que está sendo retirado.
                        /// Depois de ser localizado na sub--árvore esquerda do nó que está sendo retirado,
                        /// o antecessor desse nó o substitui.
                        /// A sub--árvore esquerda do nó que foi retirado é atualizada com a remoção do antecessor.
                        raizArvore.esquerda = antecessor(raizArvore, raizArvore.esquerda);
                        /// Retorna a raiz atualizada da árvore ou subárvore da qual o aluno foi retirado.
                        return (raizArvore);
                    }
                }
                else
                {
                    /// Se o número de matrícula do aluno armazenado na raiz da árvore for maior do que o número de matrícula do aluno que deverá ser localizadoe retirado da árvore:
                    /// pesquise e retire esse aluno da sub--árvore esquerda. 

                    if (raizArvore.numMatricula > matricula) raizArvore.esquerda = retirar(raizArvore.esquerda, matricula);
                    else
                        /// Se o número de matrícula do aluno armazenado na raiz da árvore for menor do que o número de matrícula do aluno que deverá ser localizado e retirado da árvore:
                        /// pesquise e retire esse aluno da sub--árvore direita.
                        raizArvore.direita = retirar(raizArvore.direita, matricula);
                    /// Retorna a raiz atualizada da árvore ou sub--árvore da qual o aluno foi retirado.
                    return raizArvore;
                }
            }
        }
        /// <summary>
        /// Método que encapsula a retirada recursiva de um aluno da árvore.
        /// </summary>
        /// <param name="matriculaRemover"> número de matrícula do aluno que deverá ser localizado e removido da árvore. </param>
        public void remover(int matriculaRemover)
        {
            /// Chama o método recursivo "retirar", que será responsável por pesquisar o aluno, passado como parâmetro, na árvore e retirá--lo da árvore.
            /// O método "retirar" receberá, como primeiro parâmetro, a raiz atual da árvore; e, como segundo parâmetro, o aluno que deverá ser localizado e retirado dessa árvore.
            this.raiz = retirar(this.raiz, matriculaRemover);
        }

        private Aluno pesquisar(Aluno raizArvore, int matricula)
        {
            if (raizArvore == null) return null;

            if (raizArvore.numMatricula == matricula) return raizArvore;
            else
            {
                if (matricula > raiz.numMatricula)
                {
                    return pesquisar(raizArvore.direita, matricula);
                }
                else if (matricula < raiz.numMatricula)
                {
                    return pesquisar(raizArvore.esquerda, matricula);
                }
                return raizArvore;
            }
        }

        private void imprimirEmOrdem(Aluno raizArvore)
        {
            if(raizArvore != null)
            {
                imprimirEmOrdem(raizArvore.esquerda);
                Console.WriteLine(raizArvore.nome);
                imprimirEmOrdem(raizArvore.direita);
            }
        }

        public Aluno menorNumeroMatricula()
        {
            while(raiz.esquerda != null)
            {
                raiz = raiz.esquerda;
            }
            return raiz;
        }

        public int contarNumAlunos(Aluno raizArvore)
        {
            int i = 0;
            if (raizArvore != null)
            {
                 i = 1 + contarNumAlunos(raizArvore.esquerda);

                 i = 1 + contarNumAlunos(raizArvore.direita);
            }
            return i;
        }

        /*private int obterAltura(Aluno raizArvore)
        {

        }*/

        /*private void imprimirMaiorMenor(Aluno raizArvore)
        {

        }*/

        /*private Aluno obterMaiorNota(Aluno raizArvore)
        {

        }*/
    }
}

