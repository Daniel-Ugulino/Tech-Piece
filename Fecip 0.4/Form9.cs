using System;
using System.Windows.Forms;
using System.Data.SqlClient;
using Data_Access;
using Banco_de_Dados;
namespace Fecip_0._4
{
    public partial class Senha_Rec : Form
    {

        string senha,condicao;
        public Senha_Rec()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            var validsenha = SenhaFunci(textBox2.Text, textBox3.Text);
            if (validsenha == true)
            {
                if(condicao == "Ativo")
                {
                    textBox1.Text = senha;
                    Comandos.conn.Close();
                }
                else
                {
                    MessageBox.Show("Usuario Inexistente");
                    Comandos.conn.Close();
                }
            }
            else if (validsenha == false) 
            {
                MessageBox.Show("Usuario Inexistente");
                Comandos.conn.Close();
            }
        }
        public bool SenhaFunci(string nome, string cpf)
        {
            Comandos.conn.Open();
            SqlCommand comando = new SqlCommand("Select senha_login,condição from Funcionario where Nome_Funcionario = @nome and CPF = @CPF", Comandos.conn);
            comando.Parameters.AddWithValue("@Nome", nome);
            comando.Parameters.AddWithValue("@CPF", cpf);
            comando.CommandType = System.Data.CommandType.Text;
            SqlDataReader reader = comando.ExecuteReader();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    condicao = reader.GetString(1);
                    senha = reader.GetString(0);
                }
                return true;
            }
            else
            {
                return false;
            }
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            this.Close();
            Login frm = new Login();
            frm.Show();
        }
    }
}
        

