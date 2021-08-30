using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Banco_de_Dados;

namespace Data_Access
{
    public class Dados
    {   
        public static int id { get; set; }
        public static string Nome { get; set; }
        public static string Cargo { get; set; }
        public static string Email { get; set; }
        public static string Senha { get; set; }
        public static string condicao { get; set; }
        public bool Login(string nome, string senha)
        {
            Comandos.conn.Open();
            using (var comando = new SqlCommand())
            {
                comando.Connection = Comandos.conn;
                comando.CommandText = "Select * from Funcionario where Nome_Funcionario = @nome and senha_login = @senha";
                comando.Parameters.AddWithValue("@Nome", nome);
                comando.Parameters.AddWithValue("@senha", senha);
                comando.CommandType = System.Data.CommandType.Text;
                SqlDataReader reader = comando.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        id = reader.GetInt32(0);
                        Nome = reader.GetString(1);
                        Cargo = reader.GetString(2);
                        Email = reader.GetString(6);
                        Senha = reader.GetString(10);
                        condicao = reader.GetString(9);
                    }
                    if (condicao == "Ativo")
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
                else
                {
                    return false;
                }
            }
        }
    }
}







