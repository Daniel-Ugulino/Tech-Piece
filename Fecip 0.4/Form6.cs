using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;
using Data_Access;
using Banco_de_Dados;
namespace Fecip_0._4
{
    public partial class CadFunci : Form
    {
        string nome, sexo, email, senha, salario, cargo;

        public CadFunci()
        {
            InitializeComponent();
        }

        private void EmailText_TextChanged(object sender, EventArgs e)
        {
            email = emailText.Text;
        }

        private void SenhaText_TextChanged(object sender, EventArgs e)
        {
            senha = SenhaText.Text;
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Comandos.conn.Close();
            Close();
            if (Dados.id == 0)
            {
                Login frm = new Login();
                frm.Show();
            }
            else
            {
                Menu frm = new Menu();
                frm.Show();
            }
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            comboBox3.Text = "";
            maskedTextBox2.Text = "";
            nomeText.Text = "";
            maskedTextBox3.Text = "";
            emailText.Text = "";
            maskedTextBox1.Text = "";
            comboBox2.Text = "";
            salario = "";
            SenhaText.Text = "";
        }

        private void ComboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox2.SelectedIndex == 0)
            {
                cargo = "Vendedor";
                salario = "1000";
            }
            if (comboBox2.SelectedIndex == 1)
            {
                cargo = "Estoquista";
                salario = "1100";
            }
            if (comboBox2.SelectedIndex == 2)
            {
                cargo = "Gerente";
                salario = "5000";
            }
            if (comboBox2.SelectedIndex == 3)
            {
                cargo = "Estagiario";
                salario = "500";
            }
            if (comboBox2.SelectedIndex == 4)
            {
                cargo = "Surpervisor";
                salario = "1700";
            }
        }

        private void ComboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox3.SelectedIndex == 0)
            {
                sexo = "Masculino";
            }
            if (comboBox3.SelectedIndex == 1)
            {
                sexo = "Feminino";
            }
        }



        private void Button2_Click(object sender, EventArgs e)
        {
            if (Convert.ToDateTime(maskedTextBox3.Text).Subtract(DateTime.Now).Days < 0)
            {
                if (comboBox3.Text == "" || maskedTextBox2.Text == "" || nomeText.Text == "" || maskedTextBox3.Text == "" || emailText.Text == "" || maskedTextBox1.Text == "" || comboBox2.Text == "" || salario == "" || SenhaText.Text == "")
                {
                    MessageBox.Show("Erro ao Cadastrar Funcionario");
                }
                else if (maskedTextBox2.MaskCompleted && maskedTextBox1.MaskCompleted && maskedTextBox3.MaskCompleted)
                {
                    Comandos.conn.Open();
                    SqlCommand comfim = new SqlCommand("Select * from Funcionario where Nome_Funcionario = '" + nome + "' and CPF = '" + maskedTextBox2.Text + "' and CEP = '" + maskedTextBox1.Text + "' and Sexo = '" + sexo + "' and email = '" + email + "' and Data_Nascimento = '" + maskedTextBox3.Text + "';", Comandos.conn);
                    comfim.CommandType = System.Data.CommandType.Text;
                    SqlDataReader reader = comfim.ExecuteReader();
                    if (reader.HasRows)
                    {
                        MessageBox.Show("Funcionario já existente no sistema");
                        Comandos.conn.Close();
                    }
                    else
                    {
                        Comandos.conn.Close();
                        SqlCommand adF = new SqlCommand("Insert into funcionario values('" + nome + "','" + cargo + "','" + maskedTextBox2.Text + "','" + maskedTextBox1.Text + "','" + sexo + "','" + email + "','" + maskedTextBox3.Text + "','" + salario + "',default,'" + senha + "');", Comandos.conn);
                        Comandos.conn.Open();
                        try
                        {
                            adF.ExecuteNonQuery();
                            MessageBox.Show("Funcionario Cadastrado com sucesso");
                            Comandos.conn.Close();
                            comboBox3.Text = "";
                            maskedTextBox2.Text = "";
                            nomeText.Text = "";
                            maskedTextBox3.Text = "";
                            emailText.Text = "";
                            maskedTextBox1.Text = "";
                            comboBox2.Text = "";
                            salario = "";
                            SenhaText.Text = "";
                        }
                        catch
                        {
                            MessageBox.Show("Error to save on database");
                            Comandos.conn.Close();
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Erro ao salvar dados");

                }
            }
            else
            {
                MessageBox.Show("Erro ao cadastrar Funcionario Data Inválida");
            }
        }
        private void TextBox1_TextChanged(object sender, EventArgs e)
        {
            nome = nomeText.Text;
        }
    }
}
