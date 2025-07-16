using cafeteria.Mapeamento;
using cafeteria.Utilidades;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cafeteria.DAO
{
    internal class FuncionarioDAO
    {
        public void Cadastrar(Funcionario funcionario)
        {
            try
            {
                string dataContratacao = funcionario.dataContratacao.ToString("yyyy-MM-dd HH:mm:ss");
                string sql = "INSERT INTO funcionario (CPF, nome, dataContratacao, salario, telefone, email, sexo)" +
                    "VALUES (@CPF, @nome, @dataContratacao, @salario, @telefone, @email, @sexo)";
                MySqlCommand comando = new MySqlCommand(sql, Conexao.Conectar());
                comando.Parameters.AddWithValue("@CPF", funcionario.CPF);
                comando.Parameters.AddWithValue("@nome", funcionario.nome);
                comando.Parameters.AddWithValue("@dataContratacao", funcionario.dataContratacao);
                comando.Parameters.AddWithValue("@salario", funcionario.salario);
                comando.Parameters.AddWithValue("@telefone", funcionario.telefone);
                comando.Parameters.AddWithValue("@email", funcionario.email);
                comando.Parameters.AddWithValue("@sexo", funcionario.sexo);
                comando.ExecuteNonQuery();

                Conexao.FecharConexao();

            }catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public void Atualizar(Funcionario funcionario, int campo, string novoValor)
        {
            string campob = "";
            object valorConvertido = novoValor;

            switch (campo)
            {
                case 1:
                    {
                        campob = "CPF";
                    } break;
                case 2:
                    {
                        campob = "nome";
                    } break;
                case 3:
                    {
                        campob = "dataContratacao";
                        valorConvertido = double.Parse(novoValor);
                    } break;
                case 4:
                    {
                        campob = "salario";
                        valorConvertido = double.Parse(novoValor);
                    } break;
                case 5:
                    {
                        campob = "telefone";
                    } break;
                case 6:
                    {
                        campob = "email";
                    } break;
                case 7:
                    {
                        campob = "sexo";
                    } break;
                default:
                    {
                        throw new Exception("Opção de campo inválida. ");
                    } 
            }

            string sql = $"UPDATE funcionario SET {campob} = @valor WHERE idFuncionario = @idFuncionario";
            MySqlCommand comando = new MySqlCommand(sql, Conexao.Conectar());
            comando.Parameters.AddWithValue("@idFuncionario", funcionario.idFuncionario);
            comando.Parameters.AddWithValue("@valor", valorConvertido);
            comando.ExecuteNonQuery();

            Conexao.FecharConexao();

        }


        public void Deletar(Funcionario funcionario)
        {
            string dataContracao = funcionario.dataContratacao.ToString("yyyy-MM-dd HH:mm:ss");
            string sql = "DELETE FROM funcionario WHERE idFuncionario = @idFuncionario";
            MySqlCommand comando = new MySqlCommand(sql, Conexao.Conectar());
            comando.Parameters.AddWithValue("@idFuncionario", funcionario.idFuncionario);
            comando.ExecuteNonQuery();

            Conexao.FecharConexao();
        }

        public List<Funcionario> BuscarTodos()
        {
            List<Funcionario > funcionarioCadastrados = new List<Funcionario>();
            try
            {
                string sql = "SELECT * FROM Funcionario ORDER BY idFuncionario ASC";
                MySqlCommand comando = new MySqlCommand(sql, Conexao.Conectar());
                
                using (MySqlDataReader dr = comando.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        Funcionario f = new Funcionario();
                        f.idFuncionario = dr.GetInt32("idFuncionario");
                        f.CPF = dr.GetString("CPF");
                        f.nome = dr.GetString("nome");
                        f.dataContratacao = dr.GetDateTime("dataContratacao");
                        f.salario = dr.GetDouble("salario");
                        f.telefone = dr.GetString("telefone");
                        f.email = dr.GetString("email");
                        f.sexo = dr.GetString("sexo");

                        funcionarioCadastrados.Add(f);
                    }
                }
                return funcionarioCadastrados;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
