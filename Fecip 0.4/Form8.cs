using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;
using Data_Access;
using Banco_de_Dados;
namespace Fecip_0._4
{
    public partial class Relatorio : Form
    {
        string id, coluna;
        public Relatorio()
        {
            InitializeComponent();
        }

        private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == 0)
            {
                dataGridRe.DataSource = null;
                SqlDataAdapter grid = new SqlDataAdapter("Select id_p,Marca,Tipo,modelo,especificação1,especificação2,especificação3,qtd,valor,Data_Cadastro, Fornecedor.Nome_Fornecedor from produto inner join Fornecedor on produto.id_F = Fornecedor.Id_For", Comandos.conn);
                DataTable grid2 = new DataTable();
                grid.Fill(grid2);
                dataGridRe.DataSource = grid2;
                comboBox2.Items.Clear();
                comboBox2.Items.Insert(0, "Id_p");
                comboBox2.Items.Insert(1, "Marca");
                comboBox2.Items.Insert(2, "Tipo");
                comboBox2.Items.Insert(3, "Modelo");
                comboBox2.Items.Insert(4, "Especificação1");
                comboBox2.Items.Insert(5, "Especificação2");
                comboBox2.Items.Insert(6, "Especificação3");
                comboBox2.Items.Insert(7, "Qtd");
                comboBox2.Items.Insert(8, "Valor");
                comboBox2.Items.Insert(9, "Data_Cadastro");
                comboBox2.Items.Insert(10, "Nome_Fornecedor");

            }
            if (comboBox1.SelectedIndex == 1)
            {
                dataGridRe.DataSource = null;
                SqlDataAdapter grid = new SqlDataAdapter("select Cod_Venda,peça_venda,venda.qtd,Data_Venda,cliente.nome_cliente,funcionario.nome_funcionario,forma_de_pagamento,(venda.qtd * produto.valor) as Valor_Total from venda inner join produto on venda.peça_venda = produto.id_p inner join cliente on venda.id_cliente = cliente.id_cliente inner join funcionario on venda.id_funcionario = funcionario.Id_funci;", Comandos.conn);
                DataTable grid2 = new DataTable();
                grid.Fill(grid2);
                dataGridRe.DataSource = grid2;
                comboBox2.Items.Clear();
                comboBox2.Items.Insert(0, "Cod_Venda");
                comboBox2.Items.Insert(1, "peça_venda");
                comboBox2.Items.Insert(2, "qtd");
                comboBox2.Items.Insert(3, "Data_Venda");
                comboBox2.Items.Insert(4, "nome_cliente");
                comboBox2.Items.Insert(5, "nome_funcionario");
                comboBox2.Items.Insert(6, "forma_de_pagamento");
                comboBox2.Items.Insert(7, "Valor_Total");
            }
            if (comboBox1.SelectedIndex == 2)
            {
                dataGridRe.DataSource = null;
                SqlDataAdapter grid = new SqlDataAdapter("Select * from Cliente", Comandos.conn);
                DataTable grid2 = new DataTable();
                grid.Fill(grid2);
                dataGridRe.DataSource = grid2;
                comboBox2.Items.Clear();
                comboBox2.Items.Insert(0, "Id_cliente");
                comboBox2.Items.Insert(1, "Nome_Cliente");
                comboBox2.Items.Insert(2, "CPF");
                comboBox2.Items.Insert(3, "CEP");
                comboBox2.Items.Insert(4, "Sexo");
                comboBox2.Items.Insert(5, "Data_Nascimento");
                comboBox2.Items.Insert(6, "Email");
            }
            if (comboBox1.SelectedIndex == 3)
            {
                if (Dados.Cargo == "Surpervisor")
                {
                    dataGridRe.DataSource = null;
                    MessageBox.Show("Você não tem acesso a esse relátorio");
                }
                else
                {
                    dataGridRe.DataSource = null;
                    SqlDataAdapter grid = new SqlDataAdapter("Select Id_Funci,Nome_Funcionario,Cargo,CPF,CEP,Sexo,Data_Nascimento,Email,Salario,Condição from Funcionario", Comandos.conn);
                    DataTable grid2 = new DataTable();
                    grid.Fill(grid2);
                    dataGridRe.DataSource = grid2;
                    comboBox2.Items.Clear();
                    comboBox2.Items.Insert(0, "Id_Funci");
                    comboBox2.Items.Insert(1, "Nome_Funcionario");
                    comboBox2.Items.Insert(2, "Cargo");
                    comboBox2.Items.Insert(3, "CPF");
                    comboBox2.Items.Insert(4, "CEP");
                    comboBox2.Items.Insert(5, "Sexo");
                    comboBox2.Items.Insert(6, "Data_Nascimento");
                    comboBox2.Items.Insert(7, "Email");
                    comboBox2.Items.Insert(8, "Salario");
                    comboBox2.Items.Insert(9, "Condição");
                }
            }
            if (comboBox1.SelectedIndex == 4)
            {
                dataGridRe.DataSource = null;
                SqlDataAdapter grid = new SqlDataAdapter("Select * from Fornecedor;", Comandos.conn);
                DataTable grid2 = new DataTable();
                grid.Fill(grid2);
                dataGridRe.DataSource = grid2;
                comboBox2.Items.Clear();
                comboBox2.Items.Insert(0, "Id_For ");
                comboBox2.Items.Insert(1, "Nome_Fornecedor");
                comboBox2.Items.Insert(2, "CNPJ");
                comboBox2.Items.Insert(3, "CEP");
                comboBox2.Items.Insert(4, "Email");
            }
        }
        private void DataGridRe_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int i;
            i = e.RowIndex;
            DataGridViewRow row = dataGridRe.Rows[i];
            textBox1.Text = row.Cells[0].Value.ToString();
            id = dataGridRe.Columns[0].HeaderText;
            coluna = dataGridRe.Columns[e.ColumnIndex].HeaderText;
            textBox3.Text = coluna;
        }

        private void ComboBox2_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == 0)
            {
                dataGridRe.DataSource = null;
                SqlDataAdapter grid = new SqlDataAdapter("Select id_p,Marca,Tipo,modelo,especificação1,especificação2,especificação3,qtd,valor,Data_Cadastro, Fornecedor.Nome_Fornecedor from produto inner join Fornecedor on produto.id_F = Fornecedor.Id_For order by " + comboBox2.Text, Comandos.conn);
                DataTable grid2 = new DataTable();
                grid.Fill(grid2);
                dataGridRe.DataSource = grid2;
            }
            if (comboBox1.SelectedIndex == 1)
            {
                dataGridRe.DataSource = null;
                SqlDataAdapter grid = new SqlDataAdapter("select Cod_Venda, peça_venda, venda.qtd, Data_Venda, cliente.nome_cliente, funcionario.nome_funcionario,forma_de_pagamento,(venda.qtd * produto.valor) as Valor_Total from venda inner join produto on venda.peça_venda = produto.id_p inner join cliente on venda.id_cliente = cliente.id_cliente inner join funcionario on venda.id_funcionario = funcionario.Id_funci order by " + comboBox2.Text, Comandos.conn);
                DataTable grid2 = new DataTable();
                grid.Fill(grid2);
                dataGridRe.DataSource = grid2;
            }
            if (comboBox1.SelectedIndex == 2)
            {
                dataGridRe.DataSource = null;
                SqlDataAdapter grid = new SqlDataAdapter("Select * from Cliente order by " + comboBox2.Text, Comandos.conn);
                DataTable grid2 = new DataTable();
                grid.Fill(grid2);
                dataGridRe.DataSource = grid2;
            }
            if (comboBox1.SelectedIndex == 3)
            {
                dataGridRe.DataSource = null;
                SqlDataAdapter grid = new SqlDataAdapter("Select Id_Funci,Nome_Funcionario,Cargo,CPF,CEP,Sexo,Data_Nascimento,Email,Salario,Condição from Funcionario order by " + comboBox2.Text, Comandos.conn);
                DataTable grid2 = new DataTable();
                grid.Fill(grid2);
                dataGridRe.DataSource = grid2;
            }
            if (comboBox1.SelectedIndex == 4)
            {
                dataGridRe.DataSource = null;
                SqlDataAdapter grid = new SqlDataAdapter("Select * from Fornecedor order by " + comboBox2.Text, Comandos.conn);
                DataTable grid2 = new DataTable();
                grid.Fill(grid2);
                dataGridRe.DataSource = grid2;
            }
        }

        private void Relatorio_Load(object sender, EventArgs e)
        {
            if (Dados.Cargo == "Vendedor")
            {
                if (comboBox1.SelectedIndex == 0)
                {
                    dataGridRe.DataSource = null;
                    button1.Enabled = false;
                    MessageBox.Show("Você não tem acesso a esse relatorio");
                }


            }
            if (Dados.Cargo == "Gerente")
            {
                if (comboBox1.SelectedIndex == 0)
                {
                    dataGridRe.DataSource = null;
                    button1.Enabled = false;
                    MessageBox.Show("Você não tem acesso a esse relatorio");
                }

            }
            if (Dados.Cargo == "Estoquista")
            {
                button1.Enabled = false;

            }
        }

        private void Button5_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == 3)
            {
                SqlCommand dell = new SqlCommand("Update Funcionario set Condição = 'Desativado' where Id_Funci = " + textBox1.Text, Comandos.conn);
                Comandos.conn.Open();
                try
                {
                    dell.ExecuteNonQuery();
                    MessageBox.Show("Funcionario Deletado com sucesso");
                    if (Dados.id.ToString() == textBox1.Text)
                    {
                        this.Close();
                        Login frm = new Login();
                        frm.Show();
                    }
                }
                catch
                {
                    MessageBox.Show("Error to save on database");
                    Comandos.conn.Close();

                }
            }
            else if (textBox1.Text != "")
            {
                SqlCommand dell = new SqlCommand("delete from " + comboBox1.Text + " where " + id + " = " + textBox1.Text + ";", Comandos.conn);
                Comandos.conn.Open();
                try
                {
                    dell.ExecuteNonQuery();
                    MessageBox.Show(comboBox1.Text+" Deletado(a) com sucesso");
                    Comandos.conn.Close();
                }
                catch
                {
                    MessageBox.Show("Error to save on database");
                    Comandos.conn.Close();

                }
            }
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            Comandos.conn.Close();
            Close();
            Menu frm = new Menu();
            frm.Show();
        }

        private void Relatorio_Load_1(object sender, EventArgs e)
        {
            if (Dados.Cargo == "Surpervisor")
            {
                button1.Enabled = false;
                button5.Enabled = false;
            }
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            if (textBox2.Text != "")
            {
                SqlCommand alter = new SqlCommand("Update " + comboBox1.Text + " set " + coluna + " = '" + textBox2.Text + "' where " + id + " = " + textBox1.Text, Comandos.conn);
                Comandos.conn.Open();
                try
                {
                    alter.ExecuteNonQuery();
                    MessageBox.Show(textBox3.Text + " Alterado com sucesso");
                    Comandos.conn.Close();
                }
                catch
                {
                    MessageBox.Show("Erro ao alterar " + comboBox1.Text);
                    Comandos.conn.Close();
                }
            }
        }
    }
}
