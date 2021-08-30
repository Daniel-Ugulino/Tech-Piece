using System;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using Data_Access;
using Banco_de_Dados;
namespace Fecip_0._4
{
    public partial class Venda : Form
    {
        public Venda()
        {
            InitializeComponent();
        }
        DataTable grid1 = new DataTable();
        DataTable grid70 = new DataTable();
        int cliente,funci, qtdCall;
        decimal valorU, valorT;
        string id, qtd,pagamento;

        private void Venda_Load(object sender, EventArgs e)
        {
            try
            {
                Comandos.conn.Open();
                SqlCommand sc = new SqlCommand("Select Id_cliente,Nome_Cliente from Cliente", Comandos.conn);
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(sc);
                dt.Columns.Add("Nome_Cliente", typeof(string));
                dt.Columns.Add("Id_cliente", typeof(decimal));
                da.Fill(dt);

                DataRow nada = dt.NewRow();
                nada["Nome_Cliente"] = "Selecione o Cliente:";
                dt.Rows.InsertAt(nada, 0);

                comboBox1.ValueMember = "Id_cliente";
                comboBox1.DisplayMember = "Nome_Cliente";
                comboBox1.DataSource = dt;
                Comandos.conn.Close();
            }
            catch (Exception)
            {

            }

            maskedTextDATA.Text = DateTime.Now.ToShortDateString();

            SqlDataAdapter grid = new SqlDataAdapter("Select id_p, Marca, Tipo, modelo, especificação1, especificação2, especificação3, qtd, valor, Data_Cadastro, Fornecedor.Nome_Fornecedor from produto inner join Fornecedor on produto.id_F = Fornecedor.Id_For", Comandos.conn);
            grid.Fill(grid1);
            DATAGRID.DataSource = grid1;
        }

        private void DataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            int i;
            i = e.RowIndex;
            DataGridViewRow row = DATAGRID.Rows[i];
            text_id.Text = row.Cells[0].Value.ToString();
            text_tipo.Text = row.Cells[2].Value.ToString();
            text_modelo.Text = row.Cells[3].Value.ToString();
            text_valorU.Text = row.Cells[8].Value.ToString();
            valorU = Convert.ToDecimal(text_valorU.Text);
            id = row.Cells[0].Value.ToString();

        }

        private void ComboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox2.Text == "ID")
            {
                SqlDataAdapter grid = new SqlDataAdapter("Select id_p,Marca,Tipo,modelo,especificação1,especificação2,especificação3,qtd,valor,Data_Cadastro, Fornecedor.Nome_Fornecedor from produto inner join Fornecedor on produto.id_F = Fornecedor.Id_For order by id_p", Comandos.conn);
                DataTable grid2 = new DataTable();
                grid.Fill(grid2);
                DATAGRID.DataSource = grid2;
            }
            if (comboBox2.Text == "Marca")
            {
                SqlDataAdapter grid = new SqlDataAdapter("Select id_p,Marca,Tipo,modelo,especificação1,especificação2,especificação3,qtd,valor,Data_Cadastro, Fornecedor.Nome_Fornecedor from produto inner join Fornecedor on produto.id_F = Fornecedor.Id_For order by Marca", Comandos.conn);
                DataTable grid2 = new DataTable();
                grid.Fill(grid2);
                DATAGRID.DataSource = grid2;
            }
            if (comboBox2.Text == "Tipo")
            {
                SqlDataAdapter grid = new SqlDataAdapter("Select id_p,Marca,Tipo,modelo,especificação1,especificação2,especificação3,qtd,valor,Data_Cadastro, Fornecedor.Nome_Fornecedor from produto inner join Fornecedor on produto.id_F = Fornecedor.Id_For order by Tipo", Comandos.conn);
                DataTable grid2 = new DataTable();
                grid.Fill(grid2);
                DATAGRID.DataSource = grid2;
            }
            if (comboBox2.Text == "Modelo")
            {
                SqlDataAdapter grid = new SqlDataAdapter("Select id_p,Marca,Tipo,modelo,especificação1,especificação2,especificação3,qtd,valor,Data_Cadastro, Fornecedor.Nome_Fornecedor from produto inner join Fornecedor on produto.id_F = Fornecedor.Id_For order by Modelo", Comandos.conn);
                DataTable grid2 = new DataTable();
                grid.Fill(grid2);
                DATAGRID.DataSource = grid2;
            }
            if (comboBox2.Text == "Especificação 1")
            {
                SqlDataAdapter grid = new SqlDataAdapter("Select id_p,Marca,Tipo,modelo,especificação1,especificação2,especificação3,qtd,valor,Data_Cadastro, Fornecedor.Nome_Fornecedor from produto inner join Fornecedor on produto.id_F = Fornecedor.Id_For order by especificação1", Comandos.conn);
                DataTable grid2 = new DataTable();
                grid.Fill(grid2);
                DATAGRID.DataSource = grid2;
            }
            if (comboBox2.Text == "Especificação 2")
            {
                SqlDataAdapter grid = new SqlDataAdapter("Select id_p,Marca,Tipo,modelo,especificação1,especificação2,especificação3,qtd,valor,Data_Cadastro, Fornecedor.Nome_Fornecedor from produto inner join Fornecedor on produto.id_F = Fornecedor.Id_For order by especificação2", Comandos.conn);
                DataTable grid2 = new DataTable();
                grid.Fill(grid2);
                DATAGRID.DataSource = grid2;
            }
            if (comboBox2.Text == "Especificação 3")
            {
                SqlDataAdapter grid = new SqlDataAdapter("Select id_p,Marca,Tipo,modelo,especificação1,especificação2,especificação3,qtd,valor,Data_Cadastro, Fornecedor.Nome_Fornecedor from produto inner join Fornecedor on produto.id_F = Fornecedor.Id_For order by especificação3", Comandos.conn);
                DataTable grid2 = new DataTable();
                grid.Fill(grid2);
                DATAGRID.DataSource = grid2;
            }
            if (comboBox2.Text == "Qtd")
            {
                SqlDataAdapter grid = new SqlDataAdapter("Select id_p,Marca,Tipo,modelo,especificação1,especificação2,especificação3,qtd,valor,Data_Cadastro, Fornecedor.Nome_Fornecedor from produto inner join Fornecedor on produto.id_F = Fornecedor.Id_For order by Qtd", Comandos.conn);
                DataTable grid2 = new DataTable();
                grid.Fill(grid2);
                DATAGRID.DataSource = grid2;
            }
            if (comboBox2.Text == "Valor")
            {
                SqlDataAdapter grid = new SqlDataAdapter("Select id_p,Marca,Tipo,modelo,especificação1,especificação2,especificação3,qtd,valor,Data_Cadastro, Fornecedor.Nome_Fornecedor from produto inner join Fornecedor on produto.id_F = Fornecedor.Id_For order by Valor", Comandos.conn);
                DataTable grid2 = new DataTable();
                grid.Fill(grid2);
                DATAGRID.DataSource = grid2;
            }
            if (comboBox2.Text == "Data de Cadastro")
            {
                SqlDataAdapter grid = new SqlDataAdapter("Select id_p,Marca,Tipo,modelo,especificação1,especificação2,especificação3,qtd,valor,Data_Cadastro, Fornecedor.Nome_Fornecedor from produto inner join Fornecedor on produto.id_F = Fornecedor.Id_For order by Data_Cadastro", Comandos.conn);
                DataTable grid2 = new DataTable();
                grid.Fill(grid2);
                DATAGRID.DataSource = grid2;
            }
            if (comboBox2.Text == "Fornecedor")
            {
                SqlDataAdapter grid = new SqlDataAdapter("Select id_p,Marca,Tipo,modelo,especificação1,especificação2,especificação3,qtd,valor,Data_Cadastro, Fornecedor.Nome_Fornecedor from produto inner join Fornecedor on produto.id_F = Fornecedor.Id_For order by Fornecedor.Nome_Fornecedor", Comandos.conn);
                DataTable grid2 = new DataTable();
                grid.Fill(grid2);
                DATAGRID.DataSource = grid2;
            }
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            valorT = 0;
            text_qtd.Text = "";
            qtd = "";
            text_valorT.Text = "";
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            this.Close();
            Cad_Cliente frm = new Cad_Cliente();
            frm.Show();
        }

        private void ComboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {
            pagamento = comboBox4.Text;
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            Comandos.conn.Close();
            Close();
            Menu frm = new Menu();
            frm.Show();
        }

        Bitmap memoryImage;
        private void CaptureScreen()
        {
            Graphics myGraphics = this.CreateGraphics();
            Size s = this.Size;
            memoryImage = new Bitmap(s.Width, s.Height, myGraphics);
            Graphics memoryGraphics = Graphics.FromImage(memoryImage);
            memoryGraphics.CopyFromScreen(this.Location.X, this.Location.Y, 0, 0, s);
        }
        private void PrintDocument1_PrintPage(object sender, PrintPageEventArgs e)
        {
            e.Graphics.DrawImage(memoryImage, 0, 0);
        }
        private void Button3_Click(object sender, EventArgs e)
        {
             CaptureScreen();
            printDocument1.Print();           
        }

        private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex > 0)
            {
                cliente = Convert.ToInt32(comboBox1.SelectedValue);
            }

        }

        private void Text_qtd_TextChanged(object sender, EventArgs e)
        {
            qtd = text_qtd.Text;
        }

        private void Button6_Click(object sender, EventArgs e)
        {

            if (text_id.Text == "" || qtd == "" || maskedTextDATA.Text == "" || cliente == 0 || pagamento == "" || valorT == 0)
            {
                MessageBox.Show("Erro ao efetua venda");
            }
            else
            {
                Comandos.conn.Open();
                valorT = qtdCall * valorU;
                SqlCommand venda = new SqlCommand("Update Produto set qtd = (qtd -" + qtd + ") where id_p = " + id + ";", Comandos.conn);
                SqlCommand seel = new SqlCommand("Insert into venda values('" + id.ToString() + "','" + qtd.ToString() + "','" + maskedTextDATA.Text + "','" + cliente.ToString() + "','" + Dados.id + "','" +pagamento + "');", Comandos.conn);
                SqlCommand qtdvenda = new SqlCommand("Update Funcionario set Qtd_Venda = (Qtd_Venda +" + qtd + ") where Id_Funci = " + funci, Comandos.conn);
                try
                {
                    venda.ExecuteNonQuery();
                    seel.ExecuteNonQuery();
                    MessageBox.Show("Peça(s) vendida(s) com sucesso");
                    Comandos.conn.Close();

                    grid1.Clear();
                    SqlDataAdapter grid = new SqlDataAdapter("Select id_p, Marca, Tipo, modelo, especificação1, especificação2, especificação3, qtd, valor, Data_Cadastro, Fornecedor.Nome_Fornecedor from produto inner join Fornecedor on produto.id_F = Fornecedor.Id_For", Comandos.conn);
                    grid.Fill(grid1);
                    DATAGRID.DataSource = grid1;

                    valorT = 0;
                    text_qtd.Text = "";
                    qtd = "";
                    text_valorT.Text = "";

                }
                catch
                {
                    MessageBox.Show("Erro ao efetu venda");
                    Comandos.conn.Close();
                }
            }
        }


        private void Button5_Click(object sender, EventArgs e)
        {
            if (valorU != 0 && qtd != "")
            {
                qtdCall = Convert.ToInt32(qtd);
                valorT = qtdCall * valorU;
                text_valorT.Text = valorT.ToString();
            }
            else
            {
                MessageBox.Show("A quantidade ou produto não foram selecioandos");
            }
        }
    }
}
