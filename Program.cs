// See //https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

using cafeteria.DAO;
using cafeteria.Mapeamento;
using cafeteria.Utilidades;
using ZstdSharp.Unsafe;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        Conexao.Conectar();

        int op = 0;
        string menuInput;

        do
        {
            Console.WriteLine("Qual ação deseja realizar?\n ");
            Console.WriteLine("1 - Cadastrar Funcionário");
            Console.WriteLine("2 - Atualizar Funcionário");
            Console.WriteLine("3 - Deletar Funcionário");
            Console.WriteLine("4 - Listar Todos os Funcionário");
            Console.WriteLine("5 - SAIR");
            //op = Convert.ToInt32(Console.ReadLine());
            menuInput = Console.ReadLine();

            if (!int.TryParse(menuInput, out op) || op < 1 || op > 5)
            {
                Console.WriteLine("Opção inválida. Por favor, digite um número de 1 a 5.");
                // Continue to the next iteration of the do-while loop
                continue;
            }

            switch (op)
            {
                case 1:
                    {
                        try
                        {
                            Funcionario f = new Funcionario();

                            
                            do
                            {
                                Console.WriteLine("CPF: ");
                                string entradaCPF = Console.ReadLine();

                                if (!Validacoes.ValidarCPf(entradaCPF))
                                {
                                    Console.WriteLine("CPF inválido. Por favor, digite novamente.");
                                }
                                else
                                {
                                    f.CPF = Validacoes.FormatarCPF(entradaCPF);
                                    break;
                                }
                            }while (true);

                            string nomeDigitado;
                            do
                            {
                                Console.WriteLine("Nome: ");
                                nomeDigitado = Console.ReadLine();
                                if (string.IsNullOrEmpty(nomeDigitado))
                                {
                                    Console.WriteLine("Nome não pode ser vazio. Digite novamente.");
                                }
                            } while (string.IsNullOrWhiteSpace(nomeDigitado));
                            
                            f.nome = Validacoes.CapitalizarNome(nomeDigitado);


                            DateTime dataContratacao;
                            do
                            {
                                Console.WriteLine("Data de Contratação (yyyy-MM-dd HH:mm:ss):");
                                string entradaData = Console.ReadLine();

                                if (!DateTime.TryParse(entradaData, out dataContratacao))
                                {
                                    Console.WriteLine("Data inválida. Digite novamente.");
                                }
                            } while (dataContratacao == default(DateTime));

                            f.dataContratacao = dataContratacao;


                            double salario;
                            do
                            {
                                Console.Write("Salário: ");
                                if (!double.TryParse(Console.ReadLine(), out salario) || salario <= 0)
                                {
                                    Console.WriteLine("Valor inválido. O salário deve ser um número maior que 0.");
                                }
                            } while (salario <= 0);

                            f.salario = salario;


                            do
                            {
                                Console.WriteLine("Telefone: (somente números ou com máscara) adicione o DDD!: ");
                                string telefoneInput = Console.ReadLine();

                                if (!Validacoes.ValidarTelefone(telefoneInput))
                                {
                                    Console.WriteLine("Telefone inválido. Digite novamente.");
                                }
                                else
                                {
                                    f.telefone = Validacoes.FormatarTelefone(telefoneInput);
                                    break;
                                }
                            } while(true);



                            string email;
                            do
                            {
                                Console.WriteLine("Email: ");
                                email = Console.ReadLine();

                                if (string.IsNullOrWhiteSpace(email) || !Validacoes.ValidarEmail(email))
                                {
                                    Console.WriteLine("Email inválido. Digite novamente:");
                                }
                            } while (string.IsNullOrWhiteSpace(email) || !Validacoes.ValidarEmail(email));
                            f.email = email;


                            Console.WriteLine("Sexo (Masculino/Feminino): ");
                            string sexo = Console.ReadLine().Trim();

                            while (!Validacoes.ValidarSexoPorExtenso(sexo))
                            {
                                Console.WriteLine("Sexo inválido. Digite apenas 'Masculino' ou 'Feminino':");
                                sexo = Console.ReadLine().Trim();
                            }
                            f.sexo = char.ToUpper(sexo[0]) + sexo.Substring(1).ToLower();


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

                            Console.WriteLine("Informe o ID do funcionário que deseja atualizar: ");
                            f.idFuncionario = Convert.ToInt32(Console.ReadLine());

                            FuncionarioDAO fDao = new FuncionarioDAO();
                            string continuar = "S";

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
                                    int opc;
                                
                                if (!int.TryParse(input, out opc) || opc <1|| opc> 7){
                                    Console.WriteLine( "opcao invalida. Tente novamente.");
                                    continue;
                                }

                                string novoValor;

                                do
                                {
                                    Console.WriteLine("Digite o novo valor para o campo: ");
                                    novoValor = Console.ReadLine();

                                    if (string.IsNullOrWhiteSpace(novoValor))
                                    {
                                        Console.WriteLine("O valor não pode ser vazio. Tente novamente.");
                                        continue;
                                    }

                                    bool valido = true;

                                    switch (opc)
                                    {
                                        case 1:
                                            {
                                                if (!Validacoes.ValidarCPf(novoValor))
                                                {
                                                    Console.WriteLine("Cpf inválido. Tente novamente.");
                                                    valido = false;
                                                }
                                            } break;
                                        case 2:
                                            {
                                                novoValor = Validacoes.CapitalizarNome(novoValor);
                                            } break;
                                        case 3:
                                            {
                                                DateTime data;

                                                if (!DateTime.TryParse(novoValor, out data))
                                                {
                                                    Console.WriteLine("Data inválida. Tente novamente. ");
                                                    valido = false;
                                                }
                                            } break;
                                        case 4:
                                            {
                                                double salario;
                                                if (!double.TryParse(novoValor, out salario) || salario <= 0){
                                                    Console.WriteLine("Salário inválido. Temte novamente.");
                                                    valido = false;
                                                }
                                            } break;
                                        case 5:
                                            {
                                                if (!Validacoes.ValidarTelefone(novoValor))
                                                {
                                                    Console.WriteLine("Telefone inválido. Tente novamente (somente números ou com máscara) adicione o DDD!");
                                                    valido = false;
                                                }
                                            } break;
                                        case 6:
                                            {
                                                if (!Validacoes.ValidarEmail(novoValor))
                                                {
                                                    Console.WriteLine("Email inválido. Tente novamente.");
                                                    valido = false;
                                                }
                                            } break;
                                        case 7:
                                            {
                                                if (!Validacoes.ValidarSexoPorExtenso(novoValor))
                                                {
                                                    Console.WriteLine("Sexo inválido. Digite apenas Masculino ou Feminino");
                                                    valido = false;
                                                }
                                                else
                                                {
                                                    novoValor = char.ToUpper(novoValor[0]) + novoValor.Substring(1).ToLower();
                                                }
                                            } break;
                                    } if (valido) break;

                                } while (true);

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

                            Console.WriteLine("Digite o ID do funciónário que deseja deletar: ");
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


