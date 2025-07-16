// See //https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
using System;
using System.Collections.Concurrent;
using cafeteria.DAO;
using cafeteria.Mapeamento;
using cafeteria.Utilidades;
using ZstdSharp.Unsafe;
using System.Linq;

class program
{
    static void Main(string[] args)
    {
        Conexao.Conectar();

        int op = 0;

        do
        {
            Console.WriteLine("Qual ação deseja realizar?\n ");
            Console.WriteLine("1 - Cadastrar Funcionário");
            Console.WriteLine("2 - Atualizar Funcionário");
            Console.WriteLine("3 - Deletar Funcionário");
            Console.WriteLine("4 - Listar Todos os Funcionário");
            Console.WriteLine("5 - SAIR");
            op = Convert.ToInt32(Console.ReadLine());

            switch (op)
            {
                case 1:
                    {
                        try
                        {
                            Funcionario f = new Funcionario();
                            Console.WriteLine("CPF: ");
                            f.CPF = Console.ReadLine();

                            Console.WriteLine("Nome: ");
                            f.nome = Console.ReadLine();

                            Console.WriteLine("Data de Contratação: (yyyy-MM-dd HH:mm:ss)");
                            f.dataContratacao = DateTime.Parse(Console.ReadLine());

                            Console.WriteLine("Salário: ");
                            f.salario = Convert.ToDouble(Console.ReadLine());

                            Console.WriteLine("Telefone: ");
                            f.telefone = Console.ReadLine();

                            Console.WriteLine("Email: ");
                            f.email = Console.ReadLine();

                            Console.WriteLine("Sexo: ");
                            f.sexo = Console.ReadLine();

                            FuncionarioDAO fDao = new FuncionarioDAO();
                            fDao.Cadastrar(f);
                            Console.WriteLine("Funcionário Cadastrado com Sucesso!");
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine("Erro ao cadastrar: " + ex.Message);
                        }
                    }
                    break;
                case 2:
                    {
                        try
                        {
                            Funcionario f = new Funcionario();

                            Console.WriteLine("Informe o ID do funcionário que deseja atualizar");
                            f.idFuncionario = Convert.ToInt32(Console.ReadLine());

                            FuncionarioDAO fDao = new FuncionarioDAO();
                            string continuar;

                            do
                            {
                                    Console.WriteLine("Qual campo deseja atualizar? ");
                                    Console.WriteLine("Selecione uma das opções abaixo:  ");
                                    Console.WriteLine("1 - CPF");
                                    Console.WriteLine("2 - Nome");
                                    Console.WriteLine("3 - Data de Contratação");
                                    Console.WriteLine("4 - Salário");
                                    Console.WriteLine("5 - Telefone");
                                    Console.WriteLine("6 - Email");
                                    Console.WriteLine("7 - Sexo");
                                     string input = Console.ReadLine();
                                    int opc = Convert.ToInt32(Console.ReadLine());
                                
                                if (!int.TryParse(input, out opc) || opc <1|| opc> 7){
                                    Console.WriteLine( "opcao invalida");
                                }
 
                                Console.WriteLine("Digite o novo valor para o campo: ");
                                string novoValor = Console.ReadLine();

                                fDao.Atualizar(f, opc, novoValor);

                                Console.WriteLine("Deseja atualizar outro campo? (S/N):");
                                continuar = Console.ReadLine().Trim().ToUpper();
                            } while (continuar == "S");
                            Console.WriteLine("Atualização Finalizada!");
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine("Erro ao cadastrar: " + ex.Message);
                        }

                    }
                    break;
                case 3:
                    {
                        try
                        {
                            Funcionario f = new Funcionario();

                            Console.WriteLine("Diigte o ID do funciónário que deseja deletar: ");
                            f.idFuncionario = Convert.ToInt32(Console.ReadLine());

                            FuncionarioDAO fDao = new FuncionarioDAO();
                            fDao.Deletar(f);

                            Console.WriteLine("Funcionário deletado com sucesso!");
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine("Erro ao deletar: " + ex.Message);
                        }

                    }break;
                case 4:
                    {
                        try
                        {
                            //Funcionario f = new Funcionario();
                            FuncionarioDAO fDao = new FuncionarioDAO();
                            List<Funcionario> funcionarios = fDao.BuscarTodos();

                            var funcionarioOrder = funcionarios.OrderBy(f => f.idFuncionario).ToList();

                            foreach (Funcionario f in funcionarioOrder)
                            {
                                Console.WriteLine("ID: " + f.idFuncionario);
                                Console.WriteLine("CPF: " + f.CPF);
                                Console.WriteLine("Nome: " + f.nome);
                                Console.WriteLine("Data de Contratação: " + f.dataContratacao);
                                Console.WriteLine("Salário :" + f.salario);
                                Console.WriteLine("Telefone :" + f.telefone);
                                Console.WriteLine("Email :" + f.email);
                                Console.WriteLine("Sexo :" + f.sexo);
                                Console.WriteLine("--------------------");

                            }
                            Console.WriteLine("Listagem concluída com sucesso!");
                        }
                        catch ( Exception ex)
                        {
                            Console.WriteLine("Erro na busca: " + ex.Message);
                        }
                        
                    }break;
                case 5:
                    {
                        Console.WriteLine("Até mais!");
                    }break;
                default:
                    {
                        Console.WriteLine("Opção inválida."); 
                    }break;
            }
        } while (op != 5);
    }
}


