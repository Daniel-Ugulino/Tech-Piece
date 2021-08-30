using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;
using Data_Access;
using Banco_de_Dados;
namespace Fecip_0._4
{
    public partial class Cadastro_peça : Form
    {
        string marca, tipo, modelo, espec1, espec2, espec3, data, qtdAdd, qtd, id_del, qtd_tab, preço;
        int Forne;
        DataTable grid2 = new DataTable();

        private void Price_TextChanged(object sender, EventArgs e)
        {
            preço = price.Text;
        }

        private void Especc3_TextChanged(object sender, EventArgs e)
        {
            espec3 = especc3.Text;
        }

        private void Especc2_TextChanged(object sender, EventArgs e)
        {
            espec2 = especc2.Text;
        }

        private void Qtdd_TextChanged(object sender, EventArgs e)
        {
            qtd = qtdd.Text;
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            if (marcaa.Text == "" || modeloo.Text == "" || tipo == "" || especc1.Text == "" || especc2.Text == "" || especc3.Text == "" || qtdd.Text == "" || price.Text == "" || maskedTextBox1.Text == "" || Forne == 0)
            {
                MessageBox.Show("Erro ao salvar dados");
            }
            else
            {
                Comandos.conn.Open();
                SqlCommand confim = new SqlCommand("select * from produto where marca = '" + marcaa.Text + "' and modelo = '" + modeloo.Text + "' and Tipo = '" + comboBox3.Text + "' and especificação1 = '" + especc1.Text + "' and especificação2 = '" + especc2.Text + "' and especificação3 = '" + especc3.Text + "' and id_F = " + Forne + ";", Comandos.conn);
                confim.CommandType = System.Data.CommandType.Text;
                SqlDataReader reader = confim.ExecuteReader();
                if (reader.HasRows)
                {
                    MessageBox.Show("Peça já existente no sistema");
                    Comandos.conn.Close();
                }
                else
                {
                    Comandos.conn.Close();
                    SqlCommand cad = new SqlCommand("Insert into produto values('" + marca + "','" + tipo + "','" + modelo + "','" + espec1 + "','" + espec2 + "','" + espec3 + "','" + qtd + "','" + preço + "','" + maskedTextBox1.Text + "','" + Forne + "');", Comandos.conn);
                    Comandos.conn.Open();
                    try
                    {
                        cad.ExecuteNonQuery();
                        MessageBox.Show("Peça Cadastrada com sucesso");
                        grid2.Clear();
                        SqlDataAdapter grid = new SqlDataAdapter("Select id_p,Marca,Tipo,modelo,especificação1,especificação2,especificação3,qtd,valor,Data_Cadastro, Fornecedor.Nome_Fornecedor from produto inner join Fornecedor on produto.id_F = Fornecedor.Id_For", Comandos.conn);
                        grid.Fill(grid2);
                        DATAGRID2.DataSource = grid2;
                        Comandos.conn.Close();
                    }
                    catch
                    {
                        MessageBox.Show("Error to save on database");
                        Comandos.conn.Close();
                    }
                }
            }
        }


        private void Button2_Click(object sender, EventArgs e)
        {
            comboBox1.Text = "Selecione um Fornecedor:";
            marcaa.Text = "";
            modeloo.Text = "";
            tipo = "";
            comboBox3.Text = "";
            especc1.Text = "";
            especc2.Text = "";
            especc3.Text = "";
            qtdd.Text = "";
            price.Text = "";
            Forne = 0;
            maskedTextBox1.Text = "";
        }

        private void Cadastro_peça_Load(object sender, EventArgs e)
        {
            maskedTextBox1.Text = DateTime.Now.ToShortDateString();
            try
            {
                Comandos.conn.Open();
                SqlCommand sc = new SqlCommand("Select Nome_Fornecedor,Id_For from Fornecedor", Comandos.conn);
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(sc);
                dt.Columns.Add("Nome_Fornecedor", typeof(string));
                dt.Columns.Add("Id_For", typeof(decimal));
                da.Fill(dt);
                Comandos.conn.Close();

                DataRow nada = dt.NewRow();
                nada["Nome_Fornecedor"] = "Selecione um Fornecedor:";
                dt.Rows.InsertAt(nada, 0);

                comboBox1.ValueMember = "Id_For";
                comboBox1.DisplayMember = "Nome_Fornecedor";
                comboBox1.DataSource = dt;

                Comandos.conn.Close();
            }
            catch (Exception)
            {

            }

            SqlDataAdapter grid = new SqlDataAdapter("Select id_p,Marca,Tipo,modelo,especificação1,especificação2,especificação3,qtd,valor,Data_Cadastro, Fornecedor.Nome_Fornecedor from produto inner join Fornecedor on produto.id_F = Fornecedor.Id_For", Comandos.conn);
            grid.Fill(grid2);
            DATAGRID2.DataSource = grid2;
        }

        private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex > 0)
            {
                Forne = Convert.ToInt32(comboBox1.SelectedValue);
            }

        }

        private void Button5_Click(object sender, EventArgs e)
        {
            Comandos.conn.Close();
            Close();
            Menu frm = new Menu();
            frm.Show();
        }

        private void ComboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox3.SelectedIndex == 0)
            {
                tipo = "Placa-Mãe";
            }
            if (comboBox3.SelectedIndex == 1)
            {
                tipo = "Processador";
            }
            if (comboBox3.SelectedIndex == 2)
            {
                tipo = "Memoria-Ram";
            }
            if (comboBox3.SelectedIndex == 3)
            {
                tipo = "Fonte";
            }
            if (comboBox3.SelectedIndex == 4)
            {
                tipo = "Hd";
            }
            if (comboBox3.SelectedIndex == 5)
            {
                tipo = "SSD";
            }
            if (comboBox3.SelectedIndex == 6)
            {
                tipo = "SSD-NVME";
            }
            if (comboBox3.SelectedIndex == 7)
            {
                tipo = "Gabinete";
            }
            if (comboBox3.SelectedIndex == 8)
            {
                tipo = "Cooler";
            }
            if (comboBox3.SelectedIndex == 9)
            {
                tipo = "WaterCooler";
            }
            if (comboBox3.SelectedIndex == 10)
            {
                tipo = "Placa-de-Video";
            }

        }

        private void Button4_Click(object sender, EventArgs e)
        {
            if (IdAlter.Text != "")
            {
                id_del = id_dell.Text;
                SqlCommand dell = new SqlCommand("Update Produto set qtd = (qtd -" + id_del + ") where id_p = " + IdAlter.Text + ";", Comandos.conn);
                Comandos.conn.Open();
                try
                {
                    dell.ExecuteNonQuery();
                    MessageBox.Show("Peça Deletada com sucesso");

                    grid2.Clear();

                    SqlDataAdapter grid = new SqlDataAdapter("Select id_p,Marca,Tipo,modelo,especificação1,especificação2,especificação3,qtd,valor,Data_Cadastro, Fornecedor.Nome_Fornecedor from produto inner join Fornecedor on produto.id_F = Fornecedor.Id_For", Comandos.conn);
                    grid.Fill(grid2);
                    DATAGRID2.DataSource = grid2;

                    Comandos.conn.Close();
                }
                catch
                {
                    MessageBox.Show("Erro deletar peça");
                    Comandos.conn.Close();
                }
            }

            else
            {
                MessageBox.Show("Não há nada selecionado");
            }

        }


        private void FiltratextBox1_TextChanged_1(object sender, EventArgs e)
        {
            if (comboBox2.Text == "ID")
            {
                SqlDataAdapter grid = new SqlDataAdapter("Select id_p,Marca,Tipo,modelo,especificação1,especificação2,especificação3,qtd,valor,Data_Cadastro, Fornecedor.Nome_Fornecedor from produto inner join Fornecedor on produto.id_F = Fornecedor.Id_For where id_p like '" + FiltratextBox1.Text + "%'", Comandos.conn);
                DataTable grid2 = new DataTable();
                grid.Fill(grid2);
                DATAGRID2.DataSource = grid2;
            }
            if (comboBox2.Text == "Marca")
            {
                SqlDataAdapter grid = new SqlDataAdapter("Select id_p,Marca,Tipo,modelo,especificação1,especificação2,especificação3,qtd,valor,Data_Cadastro, Fornecedor.Nome_Fornecedor from produto inner join Fornecedor on produto.id_F = Fornecedor.Id_For where marca like '" + FiltratextBox1.Text + "%'", Comandos.conn);
                DataTable grid2 = new DataTable();
                grid.Fill(grid2);
                DATAGRID2.DataSource = grid2;
            }
            if (comboBox2.Text == "Tipo")
            {
                SqlDataAdapter grid = new SqlDataAdapter("Select id_p,Marca,Tipo,modelo,especificação1,especificação2,especificação3,qtd,valor,Data_Cadastro, Fornecedor.Nome_Fornecedor from produto inner join Fornecedor on produto.id_F = Fornecedor.Id_For where tipo like '" + FiltratextBox1.Text + "%'", Comandos.conn);
                DataTable grid2 = new DataTable();
                grid.Fill(grid2);
                DATAGRID2.DataSource = grid2;
            }
            if (comboBox2.Text == "Modelo")
            {
                SqlDataAdapter grid = new SqlDataAdapter("Select id_p,Marca,Tipo,modelo,especificação1,especificação2,especificação3,qtd,valor,Data_Cadastro, Fornecedor.Nome_Fornecedor from produto inner join Fornecedor on produto.id_F = Fornecedor.Id_For where modelo like '" + FiltratextBox1.Text + "%'", Comandos.conn);
                DataTable grid2 = new DataTable();
                grid.Fill(grid2);
                DATAGRID2.DataSource = grid2;
            }
            if (comboBox2.Text == "Especificação 1")
            {
                SqlDataAdapter grid = new SqlDataAdapter("Select id_p,Marca,Tipo,modelo,especificação1,especificação2,especificação3,qtd,valor,Data_Cadastro, Fornecedor.Nome_Fornecedor from produto inner join Fornecedor on produto.id_F = Fornecedor.Id_For where especificação1 like '" + FiltratextBox1.Text + "%'", Comandos.conn);
                DataTable grid2 = new DataTable();
                grid.Fill(grid2);
                DATAGRID2.DataSource = grid2;
            }
            if (comboBox2.Text == "Especificação 2")
            {
                SqlDataAdapter grid = new SqlDataAdapter("Select id_p,Marca,Tipo,modelo,especificação1,especificação2,especificação3,qtd,valor,Data_Cadastro, Fornecedor.Nome_Fornecedor from produto inner join Fornecedor on produto.id_F = Fornecedor.Id_For where especificação2 like '" + FiltratextBox1.Text + "%'", Comandos.conn);
                DataTable grid2 = new DataTable();
                grid.Fill(grid2);
                DATAGRID2.DataSource = grid2;
            }
            if (comboBox2.Text == "Especificação 3")
            {
                SqlDataAdapter grid = new SqlDataAdapter("Select id_p,Marca,Tipo,modelo,especificação1,especificação2,especificação3,qtd,valor,Data_Cadastro, Fornecedor.Nome_Fornecedor from produto inner join Fornecedor on produto.id_F = Fornecedor.Id_For where especificação3 like '" + FiltratextBox1.Text + "%'", Comandos.conn);
                DataTable grid2 = new DataTable();
                grid.Fill(grid2);
                DATAGRID2.DataSource = grid2;
            }
            if (comboBox2.Text == "Qtd")
            {
                SqlDataAdapter grid = new SqlDataAdapter("Select id_p,Marca,Tipo,modelo,especificação1,especificação2,especificação3,qtd,valor,Data_Cadastro, Fornecedor.Nome_Fornecedor from produto inner join Fornecedor on produto.id_F = Fornecedor.Id_For where qtd like '" + FiltratextBox1.Text + "%'", Comandos.conn);
                DataTable grid2 = new DataTable();
                grid.Fill(grid2);
                DATAGRID2.DataSource = grid2;
            }
            if (comboBox2.Text == "Valor")
            {
                SqlDataAdapter grid = new SqlDataAdapter("Select id_p,Marca,Tipo,modelo,especificação1,especificação2,especificação3,qtd,valor,Data_Cadastro, Fornecedor.Nome_Fornecedor from produto inner join Fornecedor on produto.id_F = Fornecedor.Id_For where valor like '" + FiltratextBox1.Text + "%' order by valor", Comandos.conn);
                DataTable grid2 = new DataTable();
                grid.Fill(grid2);
                DATAGRID2.DataSource = grid2;
            }
            if (comboBox2.Text == "Data de Cadastro")
            {
                SqlDataAdapter grid = new SqlDataAdapter("Select id_p,Marca,Tipo,modelo,especificação1,especificação2,especificação3,qtd,valor,Data_Cadastro, Fornecedor.Nome_Fornecedor from produto inner join Fornecedor on produto.id_F = Fornecedor.Id_For where Data_Cadastro like '" + FiltratextBox1.Text + "%'", Comandos.conn);
                DataTable grid2 = new DataTable();
                grid.Fill(grid2);
                DATAGRID2.DataSource = grid2;
            }
            if (comboBox2.Text == "Fornecedor")
            {
                SqlDataAdapter grid = new SqlDataAdapter("Select id_p,Marca,Tipo,modelo,especificação1,especificação2,especificação3,qtd,valor,Data_Cadastro, Fornecedor.Nome_Fornecedor from produto inner join Fornecedor on produto.id_F = Fornecedor.Id_For where Fornecedor.Nome_Fornecedor like '" + FiltratextBox1.Text + "%'", Comandos.conn);
                DataTable grid2 = new DataTable();
                grid.Fill(grid2);
                DATAGRID2.DataSource = grid2;
            }
        }

        private void TextBox2_TextChanged(object sender, EventArgs e)
        {
            qtdAdd = textBox2.Text;
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            if (IdAlter.Text != "")
            {
                SqlCommand add = new SqlCommand("Update Produto set qtd = (qtd +" + qtdAdd + ") where id_p = " + Convert.ToInt32(IdAlter.Text), Comandos.conn);
                Comandos.conn.Open();
                try
                {
                    add.ExecuteNonQuery();
                    MessageBox.Show("Peça Adicionada com sucesso");

                    grid2.Clear();

                    SqlDataAdapter grid = new SqlDataAdapter("Select id_p,Marca,Tipo,modelo,especificação1,especificação2,especificação3,qtd,valor,Data_Cadastro, Fornecedor.Nome_Fornecedor from produto inner join Fornecedor on produto.id_F = Fornecedor.Id_For", Comandos.conn);
                    grid.Fill(grid2);
                    DATAGRID2.DataSource = grid2;

                    Comandos.conn.Close();
                }
                catch
                {
                    MessageBox.Show("Error ao adicionar peça");
                    Comandos.conn.Close();
                }
            }
            else
            {
                MessageBox.Show("Não há nada selecionado");
            }

        }

        private void DATAGRID2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int i;
            i = e.RowIndex;
            DataGridViewRow row = DATAGRID2.Rows[i];
            IdAlter.Text = row.Cells[0].Value.ToString();
            qtd_tab = row.Cells[7].Value.ToString(); ;
        }

        private void Especc1_TextChanged(object sender, EventArgs e)
        {
            espec1 = especc1.Text;
        }

        private void Modeloo_TextChanged(object sender, EventArgs e)
        {
            modelo = modeloo.Text;
        }

        private void Marcaa_TextChanged(object sender, EventArgs e)
        {
            marca = marcaa.Text;
        }

        public Cadastro_peça()
        {
            InitializeComponent();
        }

    }
}
