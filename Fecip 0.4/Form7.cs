using System;
using System.Windows.Forms;
using System.Data.SqlClient;
using Data_Access;
using Banco_de_Dados;
namespace Fecip_0._4
{
    public partial class Cad_Cliente : Form
    {
        string nome, sexo, email;
        private void Button1_Click(object sender, EventArgs e)
        {
            if (Convert.ToDateTime(maskedTextDATA.Text).Subtract(DateTime.Now).Days < 0)
            {
                if (maskedTextCEP.Text == "" || maskedTextCPF.Text == "" || textBoxEmail.Text == "" || maskedTextDATA.Text == "" || sexo == "" || textBox1.Text == "")
                {
                    MessageBox.Show("Erro ao salvar dados");
                }
                else if (maskedTextCEP.MaskCompleted && maskedTextCPF.MaskCompleted && maskedTextDATA.MaskCompleted)
                {
                    Comandos.conn.Open();
                    SqlCommand comfim = new SqlCommand("Select * from Cliente where Nome_Cliente = '" + textBox1.Text + "' and CPF = '" + maskedTextCPF.Text + "' and CEP = '" + maskedTextCEP.Text + "' and Sexo = '" + sexo + "' and email = '" + textBoxEmail.Text + "' and Data_Nascimento = '" + maskedTextDATA.Text + "';", Comandos.conn);
                    comfim.CommandType = System.Data.CommandType.Text;
                    SqlDataReader reader = comfim.ExecuteReader();
                    if (reader.HasRows)
                    {
                        MessageBox.Show("Cliente já existente no sistema");
                        Comandos.conn.Close();
                    }
                    else
                    {
                        Comandos.conn.Close();
                        SqlCommand adC = new SqlCommand("Insert into cliente values ('" + textBox1.Text + "','" + maskedTextCPF.Text + "','" + maskedTextCEP.Text + "','" + sexo + "','" + maskedTextDATA.Text + "','" + textBoxEmail.Text + "');", Comandos.conn);
                        Comandos.conn.Open();
                        try
                        {
                            adC.ExecuteNonQuery();
                            MessageBox.Show("Cliente cadastrado com sucesso");
                            Comandos.conn.Close();
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

        private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == 0)
            {
                sexo = "Masculino";
            }
            if (comboBox1.SelectedIndex == 1)
            {
                sexo = "Feminino";
            }
        }

        private void TextBoxEmail_TextChanged(object sender, EventArgs e)
        {
            email = textBoxEmail.Text;
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            textBoxEmail.Text = "";
            textBox1.Text = "";
            comboBox1.Text = "";
            maskedTextCEP.Text = "";
            maskedTextCPF.Text = "";
            maskedTextDATA.Text = "";
        }

        public Cad_Cliente()
        {
            InitializeComponent();
        }

        private void MaskedTextCPF_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            if (maskedTextCPF.MaskCompleted)
            {

            }
        }

        private void MaskedTextDATA_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            if (maskedTextDATA.Text.ToString() == DateTime.Now.ToShortDateString())
            {

            }
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            Comandos.conn.Close();
            Close();
            Menu frm = new Menu();
            frm.Show();
        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {
            nome = textBox1.Text;
        }
    }
}
