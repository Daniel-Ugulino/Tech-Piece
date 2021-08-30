using System;
using System.Windows.Forms;
using Data_Access;
using Tech_Piece;

namespace Fecip_0._4
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();          
        }

        private void Button6_Click(object sender, EventArgs e)
        {
            this.Close();
            Fornecedor frm = new Fornecedor();
            frm.Show();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            this.Close();
            Cadastro_peça frm = new Cadastro_peça();
            frm.Show();
        }

        private void Button7_Click(object sender, EventArgs e)
        {
            Close();
            Login frm = new Login();
            frm.Show();
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            this.Close();
            Cad_Cliente frm = new Cad_Cliente();
            frm.Show();

        }

        private void Button2_Click(object sender, EventArgs e)
        {
            this.Close();
            Venda frm = new Venda();
            frm.Show();

        }

        private void Button8_Click(object sender, EventArgs e)
        {
            this.Close();
            CadFunci frm = new CadFunci();
            frm.Show();
        }

        private void Menu_Load(object sender, EventArgs e)
        {
            if (Dados.Cargo == "Vendedor")
            {
                button8.Enabled = false;
                button1.Enabled = false;
                button6.Enabled = false;
                button3.Enabled = false;
            }

            if (Dados.Cargo == "Estoquista")
            {
                button8.Enabled = false;
                button4.Enabled = false;
                button2.Enabled = false;
                button6.Enabled = false;
                button3.Enabled = false;
            }
            if (Dados.Cargo == "Estagiario")
            {
                button8.Enabled = false;
                button1.Enabled = false;
                button6.Enabled = false;
                button3.Enabled = false;
            }
            if (Dados.Cargo == "Surpervisor")
            {
                button8.Enabled = false;
                button1.Enabled = false;
                button6.Enabled = false;
            }
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            this.Close();
            Relatorio frm = new Relatorio();
            frm.Show();
        }
    }
}
