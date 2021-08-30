using System;
using System.Windows.Forms;
using Data_Access;
using System.Data.SqlClient;
using Banco_de_Dados;
namespace Fecip_0._4
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }
        private void Button2_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
            Close();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Dados user = new Dados();
            var validLogin = user.Login(textBox1.Text, textBox2.Text);
            if (validLogin == true)
            {
                this.Hide();
                Menu frm = new Menu();
                frm.Show();
                Comandos.conn.Close();
            }
            else
            {
                MessageBox.Show("Login Invalido");
                Comandos.conn.Close();
            }
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            CadFunci frm = new CadFunci();
            frm.Show();
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            Comandos.conn.Close();
            this.Hide();
            Senha_Rec frm = new Senha_Rec();
            frm.Show();
        }

        private void Login_Load(object sender, EventArgs e)
        {

            Comandos table = new Comandos();
            table.Banco();

            Dados.id = 0;
            Dados.Nome = "";
            Dados.Senha = "";
            Dados.Cargo = "";
            Dados.Email = "";
            Dados.condicao = "";
        }
    }
}
