using System;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data;
using Data_Access;
using Banco_de_Dados;

namespace Fecip_0._4
{
    public partial class Fornecedor : Form
    {
        public Fornecedor()
        {
            InitializeComponent();
        }

        string nome, email;

        private void TextBoxEmailFor_TextChanged(object sender, EventArgs e)
        {
            email = textBoxEmailFor.Text;
        }

        private void Button2_Click(object sender, EventArgs e)
        {

            if (textBoxForN.Text == "" || maskedTextCEP.Text == "" || maskedTextCNPJ.Text == "" || textBoxEmailFor.Text == "")
            {
                MessageBox.Show("Erro ao salvar dados");
            }
            else if (maskedTextCEP.MaskCompleted && maskedTextCNPJ.MaskCompleted)
            {
                Comandos.conn.Open();
                SqlCommand comfim = new SqlCommand("Select * from Fornecedor where Nome_Fornecedor = '" + nome + "' and CNPJ = '" + maskedTextCNPJ.Text + "' and CEP = '" + maskedTextCEP.Text + "' and email = '" + email + "';", Comandos.conn);
                comfim.CommandType = System.Data.CommandType.Text;
                SqlDataReader reader = comfim.ExecuteReader();
                if (reader.HasRows)
                {
                    MessageBox.Show("Fornecedora já existente no sistema");
                    Comandos.conn.Close();
                }
                else
                {
                    Comandos.conn.Close();
                    SqlCommand cad = new SqlCommand("Insert into Fornecedor values('" + nome + "','" + maskedTextCNPJ.Text + "','" + maskedTextCEP.Text + "','" + email + "');", Comandos.conn);
                    Comandos.conn.Open();
                    try
                    {
                        cad.ExecuteNonQuery();
                        MessageBox.Show("Fornecedor Cadastradado com sucesso");
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

        private void Button1_Click(object sender, EventArgs e)
        {
            Comandos.conn.Close();
            Close();
            Menu frm = new Menu();
            frm.Show();
        }
        private void Button4_Click(object sender, EventArgs e)
        {
            maskedTextCNPJ.Text = "";
            textBoxForN.Text = "";
            maskedTextCEP.Text = "";
            textBoxEmailFor.Text = "";
        }
        private void TextBoxForN_TextChanged(object sender, EventArgs e)
        {
            nome = textBoxForN.Text;
        }
    }
}
