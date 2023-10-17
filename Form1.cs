using System;
using System.Windows.Forms;
using System.Data.SqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace FolhaDePagamento
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e) //neste m�todo tem a fun��o de mostrar a senha.
        {
            textBoxSenha1.UseSystemPasswordChar = checkBox1.Checked;
        }

        private void fecharLinkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) //Aqui ir� fechar a aplica��o.
        {
            Application.Exit();
        }

        private void esqueciSenhaLinkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) //vai abrir o Forms2 
        {
            new Form2().Show();
            this.Hide();
        }

        //Aqui irei fazer a conex�o com o banco de dados
        //Por�m deixo avisado que pode haver altera��es 
        //Pois no momento � s� um teste
        private void loginButton1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = @"Data Source=DESKTOP-3D2GOF3\SQLEXPRESS; Initial catalog= DB_PIM;" + "Integrated Security = true";
            con.Open();

            SqlCommand cdm = new SqlCommand();
            cdm.Connection = con;

            string entrar = "select * from TB_Usuario where email_user = '" + textBoxEmail1.Text + "' and senha_user = '" + textBoxSenha1.Text + "'";

            cdm = new SqlCommand(entrar, con);
            SqlDataReader dr = cdm.ExecuteReader();
            if (dr.Read() == true)
            {
                new Form5().Show();
                this.Hide();
                con.Close();
            }
            else
            {
                MessageBox.Show("Usu�rio ou senha inv�lida", "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBoxEmail1.Text = "";
                textBoxSenha1.Text = "";
                textBoxEmail1.Focus();
            }
        }

        private void tituloLabel1_Click(object sender, EventArgs e)
        {

        }

        private void textBoxEmail1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}