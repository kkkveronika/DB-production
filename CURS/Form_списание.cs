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
    public partial class Form_списание : Form
    {
        public Form_списание()
        {
            InitializeComponent();
        }

        private void Form_списание_Load(object sender, EventArgs e)
        {
            string connectionString = "server=localhost; uid=root; pwd=1q2w3e4r5t; database=curs";
            MySqlConnection connection = new MySqlConnection(connectionString);
            connection.Open();

            string selectQuery = "SELECT * FROM Списание";
            MySqlDataAdapter adapter = new MySqlDataAdapter(selectQuery, connection);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);

            dataGridView1.DataSource = dataTable;
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int row_index = dataGridView1.CurrentCell.RowIndex;
            textBox_id.Text = dataGridView1.Rows[row_index].Cells[0].Value.ToString();
            textBox_numb.Text = dataGridView1.Rows[row_index].Cells[1].Value.ToString();
            textBox_prod.Text = dataGridView1.Rows[row_index].Cells[2].Value.ToString();
            textBox_mat.Text = dataGridView1.Rows[row_index].Cells[3].Value.ToString();
            textBox_store.Text = dataGridView1.Rows[row_index].Cells[4].Value.ToString();
            textBox_count.Text = dataGridView1.Rows[row_index].Cells[5].Value.ToString();
            dateTimePicker1.Text = dataGridView1.Rows[row_index].Cells[6].Value.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string id = textBox_id.Text;
            string step = textBox_numb.Text;
            string id_prod = textBox_prod.Text;
            string id_mat = textBox_mat.Text;
            string id_store= textBox_store.Text;
            string count= textBox_count.Text;
            string date = dateTimePicker1.Value.ToString("yyyy-MM-dd");

            string connectionString = "server=localhost; uid=root; pwd=1q2w3e4r5t; database=curs";
            MySqlConnection connection = new MySqlConnection(connectionString);
            connection.Open();

            string query = "INSERT INTO `Списание`(`ID_списания`, `№этапа`, `ID_заявки_производства`,`ID_материала`, `ID_склада`,`Количество`,`Дата`) VALUES (@Id, @numb, @prod, @mat, @store, @count, @date)";
            MySqlCommand command = new MySqlCommand(query, connection);
            command.Parameters.AddWithValue("@Id", id);
            command.Parameters.AddWithValue("@numb", step);
            command.Parameters.AddWithValue("@prod", id_prod);
            command.Parameters.AddWithValue("@mat", id_mat);
            command.Parameters.AddWithValue("@store", id_store);
            command.Parameters.AddWithValue("@count", count);
            command.Parameters.AddWithValue("@date", date);
            command.ExecuteNonQuery();

            DataTable dataTable = new DataTable();
            string selectQuery = "SELECT `ID_списания`, `№этапа`, `ID_заявки_производства`,`ID_материала`, `ID_склада`,`Количество`,`Дата` FROM `Списание`";
            MySqlCommand selectCommand = new MySqlCommand(selectQuery, connection);
            MySqlDataAdapter adapter = new MySqlDataAdapter(selectCommand);
            adapter.Fill(dataTable);

            dataGridView1.DataSource = dataTable;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string id = textBox_id.Text;
            string step = textBox_numb.Text;
            string id_prod = textBox_prod.Text;
            string id_mat = textBox_mat.Text;
            string id_store = textBox_store.Text;
            string count = textBox_count.Text;
            string date = dateTimePicker1.Value.ToString("yyyy-MM-dd");

            string connectionString = "server=localhost; uid=root; pwd=1q2w3e4r5t; database=curs";
            MySqlConnection connection = new MySqlConnection(connectionString);
            connection.Open();

            string updateQuery = "UPDATE `Списание` SET `№этапа`, `ID_заявки_производства`,`ID_материала`, `ID_склада`,`Количество`,`Дата` WHERE `ID_списания` = @Id";
            MySqlCommand command = new MySqlCommand(updateQuery, connection);
            command.Parameters.AddWithValue("@Id", id);
            command.Parameters.AddWithValue("@numb", step);
            command.Parameters.AddWithValue("@prod", id_prod);
            command.Parameters.AddWithValue("@mat", id_mat);
            command.Parameters.AddWithValue("@store", id_store);
            command.Parameters.AddWithValue("@count", count);
            command.Parameters.AddWithValue("@date", date);
            command.ExecuteNonQuery();

            DataTable dataTable = new DataTable();
            string selectQuery = "SELECT `ID_списания`, `№этапа`, `ID_заявки_производства`,`ID_материала`, `ID_склада`,`Количество`,`Дата` FROM `Списание`";
            MySqlCommand selectCommand = new MySqlCommand(selectQuery, connection);
            MySqlDataAdapter adapter = new MySqlDataAdapter(selectCommand);
            adapter.Fill(dataTable);

            dataGridView1.DataSource = dataTable;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string id = textBox_id.Text;
            string step = textBox_numb.Text;
            string id_prod = textBox_prod.Text;
            string id_mat = textBox_mat.Text;
            string id_store = textBox_store.Text;
            string count = textBox_count.Text;
            string date = dateTimePicker1.Value.ToString("yyyy-MM-dd");

            string connectionString = "server=localhost; uid=root; pwd=1q2w3e4r5t; database=curs";
            MySqlConnection connection = new MySqlConnection(connectionString);
            connection.Open();

            string deleteQuery = "DELETE FROM `Списание` WHERE `ID_списания` = @Id";
            MySqlCommand command = new MySqlCommand(deleteQuery, connection);
            command.Parameters.AddWithValue("@Id", id);
            command.Parameters.AddWithValue("@numb", step);
            command.Parameters.AddWithValue("@prod", id_prod);
            command.Parameters.AddWithValue("@mat", id_mat);
            command.Parameters.AddWithValue("@store", id_store);
            command.Parameters.AddWithValue("@count", count);
            command.Parameters.AddWithValue("@date", date);
            command.ExecuteNonQuery();

            DataTable dataTable = new DataTable();
            string selectQuery = "SELECT `ID_списания`, `№этапа`, `ID_заявки_производства`,`ID_материала`, `ID_склада`,`Количество`,`Дата` FROM `Списание`";
            MySqlCommand selectCommand = new MySqlCommand(selectQuery, connection);
            MySqlDataAdapter adapter = new MySqlDataAdapter(selectCommand);
            adapter.Fill(dataTable);

            dataGridView1.DataSource = dataTable;
        }
    }
}
