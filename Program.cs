using System;
using Herança.Classes;

namespace Herança
{
    class Program
    {
        static void Main(string[] args)
        {
                Console.Clear();

                int escolha;
                int opcoes;
                do
                {
                 Console.WriteLine("Escolha entre as opções permitidas");
                 Console.WriteLine("------------------------------------");
                 Console.WriteLine("1 - Entrar no sistema");
                 Console.WriteLine("0 - Sair");
                 escolha = int.Parse(Console.ReadLine());
                   
                            switch (escolha)
                            {
                                case 1:
                                  Console.WriteLine("Continue a Operação");
                                    break;

                                case 0:
                                    Console.WriteLine("Sistema Encerrado!");
                                break;

                                default:
                                    Console.WriteLine("Opção Inválida");
                                    break;
                            }
                            

       
                        do
                        {
                         Console.WriteLine("Bem Vindo ao nosso sistema. Agora digite a opção desejada: ");
                         Console.WriteLine("------------------------------------------------------------");
                         Console.WriteLine("1 - Pessoa Fisica");
                         Console.WriteLine("2 - Pessoa Juridica");
                         opcoes = int.Parse(Console.ReadLine());


                                        switch (opcoes)
                                        {
                                            case 1:

                                              //Pessoa Fisica
                                                PessoaFisica pf = new PessoaFisica();
                                                pf.nome = "Maiara";
                                                pf.cpf = "000.000.000-00";
                                                Console.WriteLine("Bem Vindo " + pf.DarBoasVindas(pf.nome));

                                                Console.WriteLine("---------------------------------");
                                                Console.WriteLine("Digite seu CPF:");
                                                int cpf = int.Parse(Console.ReadLine());
                                                Console.WriteLine("---------------------------------");
                                              
                                                 //Validar CPF
                                                 Console.WriteLine(pf.ValidarCPF(pf.cpf));

                                                break;


                                            case 2:
                                                 //Pessoa Juridica
                                                PessoaJuridica pj = new PessoaJuridica();
                                                pj.nome = "Maiara";
                                                pj.cnpj = "00.000.000/0000-00";
                                                Console.WriteLine(pj.DarBoasVindas(pj.nome));

                                                Console.WriteLine("---------------------------------");
                                                Console.WriteLine("Digite seu CNPJ:");
                                                int cnpj = int.Parse(Console.ReadLine());
                                                Console.WriteLine("---------------------------------");
                                              

                                            break;
                                            default:
                                                Console.WriteLine("Opção Inválida");
                                                break;
                                        }
                                        
                                
                        } while (opcoes !=2);
  
                        
                } while ( escolha != 0);
                  
        }
           


    }
}
