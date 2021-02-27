using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto_de_organização
{
    public partial class Pessoas : Form
    {
        public Pessoas()
        {
            InitializeComponent();
        }

        private void Pessoas_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'databaseDataSet.Pessoa'. Você pode movê-la ou removê-la conforme necessário.
            this.pessoaTableAdapter.Fill(this.databaseDataSet.Pessoa);

        }

        private void label1_Click(object sender, EventArgs e)
        {
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            //Armazenar dados nas variaveis

            string nome = txtNome.Text;
            string sobrenome = txtSobrenome.Text;

            //Conexão com banco de dados

            string connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\55479\\Desktop\\Projeto\\Projeto de organização\\DataBase\\Database.mdf;Integrated Security=True";
            SqlConnection con = new SqlConnection(connectionString);

            //Comando para inserir na tabela 

            string query = $@"
            INSERT INTO Pessoa (Nome, Sobrenome)
            VALUES ('{nome}', '{sobrenome}');
            ";

            SqlCommand cmd = new SqlCommand(query, con);
            con.Open();

            //Exectuar comando no banco de dados 

            cmd.ExecuteNonQuery();

            //Fecha a conexão com o banco de dados
            con.Close();


        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
