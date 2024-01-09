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
    public partial class Form_отгрузка : Form
    {
        public Form_отгрузка()
        {
            InitializeComponent();
        }

        private void Form_отгрузка_Load(object sender, EventArgs e)
        {
            string connectionString = "server=localhost; uid=root; pwd=1q2w3e4r5t; database=curs";
            MySqlConnection connection = new MySqlConnection(connectionString);
            connection.Open();

            string selectQuery = "SELECT * FROM Отгрузка";
            MySqlDataAdapter adapter = new MySqlDataAdapter(selectQuery, connection);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);

            dataGridView1.DataSource = dataTable;
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int row_index = dataGridView1.CurrentCell.RowIndex;
            textBox_id.Text = dataGridView1.Rows[row_index].Cells[0].Value.ToString();
            dateTimePicker1.Text = dataGridView1.Rows[row_index].Cells[1].Value.ToString();
            textBox_order.Text = dataGridView1.Rows[row_index].Cells[2].Value.ToString();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string id = textBox_id.Text;
            string id_order = textBox_order.Text;
            string date = dateTimePicker1.Value.ToString("yyyy-MM-dd");

            string connectionString = "server=localhost; uid=root; pwd=1q2w3e4r5t; database=curs";
            MySqlConnection connection = new MySqlConnection(connectionString);
            connection.Open();

            string query = "INSERT INTO `Отгрузка` (`ID_отгрузки`, `Дата`, `ID_заказа_перемещения`) VALUES (@Id, @date, @order)";
            MySqlCommand command = new MySqlCommand(query, connection);
            command.Parameters.AddWithValue("@Id", id);
            command.Parameters.AddWithValue("@order", id_order);
            command.Parameters.AddWithValue("@date", date);
            command.ExecuteNonQuery();

            DataTable dataTable = new DataTable();
            string selectQuery = "SELECT `ID_отгрузки`, `Дата`, `ID_заказа_перемещения` FROM `Отгрузка`";
            MySqlCommand selectCommand = new MySqlCommand(selectQuery, connection);
            MySqlDataAdapter adapter = new MySqlDataAdapter(selectCommand);
            adapter.Fill(dataTable);

            dataGridView1.DataSource = dataTable;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string id = textBox_id.Text;
            string id_order = textBox_order.Text;
            string date = dateTimePicker1.Value.ToString("yyyy-MM-dd");

            string connectionString = "server=localhost; uid=root; pwd=1q2w3e4r5t; database=curs";
            MySqlConnection connection = new MySqlConnection(connectionString);
            connection.Open();

            string updateQuery = "UPDATE `Отгрузка` SET `Дата`, `ID_заказа_перемещения` WHERE `ID_отгрузки` = @Id";
            MySqlCommand command = new MySqlCommand(updateQuery, connection);
            command.Parameters.AddWithValue("@Id", id);
            command.Parameters.AddWithValue("@order", id_order);
            command.Parameters.AddWithValue("@date", date);
            command.ExecuteNonQuery();

            DataTable dataTable = new DataTable();
            string selectQuery = "SELECT `ID_отгрузки`, `Дата`, `ID_заказа_перемещения` FROM `Отгрузка`";
            MySqlCommand selectCommand = new MySqlCommand(selectQuery, connection);
            MySqlDataAdapter adapter = new MySqlDataAdapter(selectCommand);
            adapter.Fill(dataTable);

            dataGridView1.DataSource = dataTable;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string id = textBox_id.Text;
            string id_order = textBox_order.Text;
            string date = dateTimePicker1.Value.ToString("yyyy-MM-dd");

            string connectionString = "server=localhost; uid=root; pwd=1q2w3e4r5t; database=curs";
            MySqlConnection connection = new MySqlConnection(connectionString);
            connection.Open();

            string deleteQuery = "DELETE FROM `Отгрузка` WHERE `ID_отгрузки` = @Id";
            MySqlCommand command = new MySqlCommand(deleteQuery, connection);
            command.Parameters.AddWithValue("@Id", id);
            command.Parameters.AddWithValue("@order", id_order);
            command.Parameters.AddWithValue("@date", date);
            command.ExecuteNonQuery();

            DataTable dataTable = new DataTable();
            string selectQuery = "SELECT `ID_отгрузки`, `Дата`, `ID_заказа_перемещения` FROM `Отгрузка`";
            MySqlCommand selectCommand = new MySqlCommand(selectQuery, connection);
            MySqlDataAdapter adapter = new MySqlDataAdapter(selectCommand);
            adapter.Fill(dataTable);

            dataGridView1.DataSource = dataTable;
        }
    }
}
