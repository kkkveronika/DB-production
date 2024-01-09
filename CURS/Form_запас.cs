using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace CURS
{
    public partial class Form_запас : Form
    {
        public Form_запас()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int row_index = dataGridView1.CurrentCell.RowIndex;
            textBox_id.Text = dataGridView1.Rows[row_index].Cells[0].Value.ToString();
            textBox_mat.Text = dataGridView1.Rows[row_index].Cells[1].Value.ToString();
            textBox_count.Text = dataGridView1.Rows[row_index].Cells[2].Value.ToString();
            textBox_min_count.Text = dataGridView1.Rows[row_index].Cells[3].Value.ToString();
        }

        private void Form_запас_Load(object sender, EventArgs e)
        {
            string connectionString = "server=localhost; uid=root; pwd=1q2w3e4r5t; database=curs";
            MySqlConnection connection = new MySqlConnection(connectionString);
            connection.Open();

            string selectQuery = "SELECT * FROM Запас";
            MySqlDataAdapter adapter = new MySqlDataAdapter(selectQuery, connection);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);

            dataGridView1.DataSource = dataTable;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string id = textBox_id.Text;
            string mat = textBox_mat.Text;
            string count = textBox_count.Text;
            string min_count = textBox_min_count.Text;

            string connectionString = "server=localhost; uid=root; pwd=1q2w3e4r5t; database=curs";
            MySqlConnection connection = new MySqlConnection(connectionString);
            connection.Open();

            string query = "INSERT INTO `Запас`(`ID_запаса`, `ID_материала`, `Количество`,`Мин_количество`) VALUES (@Id, @mat, @count, @min_count)";
            MySqlCommand command = new MySqlCommand(query, connection);
            command.Parameters.AddWithValue("@Id", id);
            command.Parameters.AddWithValue("@mat", mat);
            command.Parameters.AddWithValue("@count", count);
            command.Parameters.AddWithValue("@min_count", min_count);

            command.ExecuteNonQuery();

            DataTable dataTable = new DataTable();
            string selectQuery = "SELECT `ID_запаса`, `ID_материала`, `Количество`,`Мин_количество` FROM `Запас`";
            MySqlCommand selectCommand = new MySqlCommand(selectQuery, connection);
            MySqlDataAdapter adapter = new MySqlDataAdapter(selectCommand);
            adapter.Fill(dataTable);

            dataGridView1.DataSource = dataTable;
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}
