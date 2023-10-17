using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.ComponentModel.Design.Serialization;

namespace FolhaDePagamento
{
    public partial class CadFunc : Form
    {
        public string matricula = "";
        public string nome = "";
        public string cpf = "";
        public string dtnasc = "";
        public string telef = "";
        public string endereco = "";
        public string cep = "";
        public string num = "";
        public string bairro = "";
        public string cargo = "";
        public string email = "";
        public string nomeempresa = "";
        public string cnpj = "";
        public string sexo = "";

        public CadFunc()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            matricula = textBox1.Text;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            nome = textBox2.Text;
        }
        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            cpf = maskedTextBox1.Text;
        }

        private void maskedTextBox2_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            dtnasc = maskedTextBox2.Text;
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void maskedTextBox3_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            telef = maskedTextBox3.Text;
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            endereco = textBox3.Text;
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            bairro = textBox5.Text;
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            num = textBox4.Text;
        }

        private void maskedTextBox4_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            cep = maskedTextBox4.Text;
        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {
        }

        private void CadFunc_Load(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {
            cargo = textBox6.Text;
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {
        }

        private void label8_Click(object sender, EventArgs e)
        {
        }

        private void label9_Click(object sender, EventArgs e)
        {
        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {
            nomeempresa = textBox8.Text;
        }

        private void textBox7_TextChanged_1(object sender, EventArgs e)
        {
            email = textBox7.Text;
        }

        private void label12_Click(object sender, EventArgs e)
        {
        }

        private void maskedTextBox5_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            cnpj = textBox5.Text;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked)
            {
                sexo = "Feminino";
            }
            else
            {
                sexo = "";
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                sexo = "Masculino";
            }
            else
            {
                sexo = "";

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = @"Data Source=DESKTOP-3D2GOF3\SQLEXPRESS; Initial catalog= DB_PIM;" + "Integrated Security = true";
            con.Open();                       
            SqlCommand cdm = new SqlCommand();
            cdm.Connection = con;
            cdm.CommandText = "INSERT INTO TB_Funcionario " +
                "(nome_func, matricula, cpf, cargo, email_func, dtNasc_func, sexo_func, nome_empresa, cnpj_empresa, endereco, numero, cep, bairro, telefone)"
                +
                "VALUES('" + nome + "','" + matricula + "','" + cpf + "','" + cargo + "','" + email + "','" + dtnasc + "','" + sexo + "','" + nomeempresa + "','" + cnpj + "','" + endereco + "','" + num + "','" + cep + "','" + bairro + "','" + telef + "');";
               cdm.ExecuteNonQuery();
            con.Close();
        }
    }
}
