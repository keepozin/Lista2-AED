using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Lista_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region LISTA 2

            #region DADOS INICIAIS
            int opcao = 1;
            while (opcao != 0)
            {
                Console.WriteLine("1 - Exercício 1");
                Console.WriteLine("2 - Exercício 2");
                Console.WriteLine("3 - Exercício 3");
                Console.WriteLine("4 - Exercício 4");
                Console.WriteLine("5 - Exercício 5");
                Console.WriteLine("6 - Exercício 6");
                Console.WriteLine("7 - Exercício 7");
                Console.WriteLine("8 - Exercício 8");
                Console.WriteLine("0 - Sair");

                opcao = Convert.ToInt32(Console.ReadLine());
                Console.Clear();
                Console.WriteLine("Exercício: " + opcao);
                Console.WriteLine();
                #endregion

                switch (opcao)
                {
                    #region Exercício 1
                    case 1:
                        {
                            Retangulo retangulo = new Retangulo();
                            Console.WriteLine("Digite um valor para altura e um para o lado");
                            retangulo.Altura = Console.ReadLine();

                            Console.WriteLine(retangulo.CalcularArea());
                            Console.WriteLine(retangulo.CalcularPerimetro());
                            break;
                        }
                    #endregion

                    #region  Exercício 2
                    case 2:
                        {
                            ContaBancaria contaBancaria = new ContaBancaria();
                            double valor;
                            int escolha = 1;
                            while (escolha != 0)
                            {
                                Console.WriteLine("1 - Depositar dinheiro");
                                Console.WriteLine("2 - Sacar dinheiro");
                                Console.WriteLine("3 - Exibir saldo atual");
                                Console.WriteLine("0 - Voltar");

                                switch (escolha)
                                {
                                    case 0:
                                        {
                                            break;
                                        }
                                    case 1:
                                        {
                                            valor = 0;
                                            Console.WriteLine("Digite um valor para depositar: ");
                                            valor = Convert.ToDouble(Console.ReadLine());
                                            contaBancaria.Depositar(valor);
                                            break;
                                        }
                                    case 2:
                                        {
                                            valor = 0;
                                            Console.WriteLine("Digite quanto deseja sacar: ");
                                            valor = Convert.ToDouble(Console.ReadLine());
                                            contaBancaria.Sacar(valor);
                                            break;
                                        }
                                    case 3:
                                        Console.Write($"O saldo de {contaBancaria.Titular} é de {contaBancaria.ExibirSaldo()}");
                                        break;
                                }
                            }
                            Console.Clear();
                            break;
                        }
                    #endregion

                    #region Exercício 3
                    case 3:
                        {
                            Livro livro = new Livro("1", "2", "3", 1000);
                            int opcaoEscolha = 1;
                            while (opcaoEscolha != 0)
                            {

                                Console.WriteLine("1 - Preencha os dados do livro.");
                                Console.WriteLine("2 - Exibir informações do livro.");
                                Console.WriteLine("3 - Verificar se o livro é do gênero de ficção.");

                                opcaoEscolha = Convert.ToInt32(Console.ReadLine());
                                Console.Clear();
                                Console.WriteLine();
                                switch (opcaoEscolha)
                                {

                                    case 1:
                                        {
                                            Console.WriteLine("Insira o título do livro");
                                            livro.Titulo = Console.ReadLine();
                                            Console.WriteLine("Insira o título do livro");
                                            livro.Autor = Console.ReadLine();
                                            Console.WriteLine("Insira o gênero do livro");
                                            livro.Genero = Console.ReadLine();
                                            Console.WriteLine("Insira o ano de lançamento do livro");
                                            livro.AnoLancamento = Convert.ToInt32(Console.ReadLine());
                                            break;
                                        }
                                    case 2:
                                        {
                                            //Validacao para conferir se os dados estão preenchidos
                                            Console.WriteLine("Título: " + livro.Titulo);
                                            Console.WriteLine("Autor: " + livro.Autor);
                                            Console.WriteLine("Gênero: " + livro.Genero);
                                            Console.WriteLine("Ano de Lançamento: " + livro.AnoLancamento);
                                            break;
                                        }
                                    case 3:
                                        {
                                            bool GeneroFiccao()
                                            {
                                                bool eFiccao = false;

                                                List<string> generoFiccao = new List<string> { "ficção", "ficcao", "ficçao", "ficcão" };
                                                livro.Titulo.ToLower();

                                                if (generoFiccao.Contains(livro.Genero))
                                                    eFiccao = true;

                                                return eFiccao;
                                            }
                                            Console.WriteLine("O gênero é ficção?" + GeneroFiccao());
                                            break;
                                        }

                                    default:
                                        {
                                            Console.WriteLine("Digite uma opção válida!");
                                            break;
                                        }
                                }

                            }
                            break;
                        }

                    default:
                        {
                            Console.WriteLine("Digite uma opção válida!");
                            break;
                        }
                        #endregion
                }
            }
            #endregion
        }
    }
}