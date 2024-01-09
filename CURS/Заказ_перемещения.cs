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
    public partial class Заказ_перемещения : Form
    {
        public Заказ_перемещения()
        {
            InitializeComponent();
        }

        private void label_ID_склада_Click(object sender, EventArgs e)
        {

        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            string id = textBox_id.Text;
            string count = textBox_count.Text;
            string date = dateTimePicker1.Value.ToString("yyyy-MM-dd");
            string mat = textBox_mat.Text;
            string id_send = textBox_send.Text;
            string id_get = textBox_get.Text;
            string way = textBox_way.Text;

            string connectionString = "server=localhost; uid=root; pwd=1q2w3e4r5t; database=curs";
            MySqlConnection connection = new MySqlConnection(connectionString);
            connection.Open();

            string updateQuery = "UPDATE `Заказ_перемещения` SET `Количество`, `Дата`, `ID_материала`, `ID_склада_получ`, `ID_склада_отпр`, `ID_маршрута` WHERE `ID_заказа_перемещения` = @Id";
            MySqlCommand command = new MySqlCommand(updateQuery, connection);
            command.Parameters.AddWithValue("@Id", id);
            command.Parameters.AddWithValue("@count", count);
            command.Parameters.AddWithValue("@date", date);
            command.Parameters.AddWithValue("@id_mat", mat);
            command.Parameters.AddWithValue("@id_send", id_send);
            command.Parameters.AddWithValue("@id_get", id_get);
            command.Parameters.AddWithValue("@id_way", way);
            command.ExecuteNonQuery();

            DataTable dataTable = new DataTable();
            string selectQuery = "SELECT `ID_заказа_перемещения`, `Количество`, `Дата`, `ID_материала`, `ID_склада_получ`, `ID_склада_отпр`, `ID_маршрута` FROM `Заказ_перемещения`";
            MySqlCommand selectCommand = new MySqlCommand(selectQuery, connection);
            MySqlDataAdapter adapter = new MySqlDataAdapter(selectCommand);
            adapter.Fill(dataTable);

            dataGridView1.DataSource = dataTable;
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            string id = textBox_id.Text;
            string count = textBox_count.Text;
            string date = dateTimePicker1.Value.ToString("yyyy-MM-dd");
            string mat = textBox_mat.Text;
            string id_send = textBox_send.Text;
            string id_get = textBox_get.Text;
            string way = textBox_way.Text;

            string connectionString = "server=localhost; uid=root; pwd=1q2w3e4r5t; database=curs";
            MySqlConnection connection = new MySqlConnection(connectionString);
            connection.Open();

            string query = "INSERT INTO `Заказ_перемещения` (`Количество`, `Дата`, `ID_материала`, `ID_склада_получ`, `ID_склада_отпр`, `ID_маршрута`) VALUES (@count, @date, @id_mat, @id_get, @id_send, @id_way)";
            MySqlCommand command = new MySqlCommand(query, connection);
            command.Parameters.AddWithValue("@count", count);
            command.Parameters.AddWithValue("@date", date);
            command.Parameters.AddWithValue("@id_mat", mat);
            command.Parameters.AddWithValue("@id_send", id_send);
            command.Parameters.AddWithValue("@id_get", id_get);
            command.Parameters.AddWithValue("@id_way", way);

            command.ExecuteNonQuery();

            DataTable dataTable = new DataTable();
            string selectQuery = "SELECT `ID_заказа_перемещения`, `Количество`, `Дата`, `ID_материала`, `ID_склада_получ`, `ID_склада_отпр`, `ID_маршрута` FROM `Заказ_перемещения`";
            MySqlCommand selectCommand = new MySqlCommand(selectQuery, connection);
            MySqlDataAdapter adapter = new MySqlDataAdapter(selectCommand);
            adapter.Fill(dataTable);

            dataGridView1.DataSource = dataTable;
        }

        private void checkBox_pfgp_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox_syr_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox_proisv_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label_pfgp_Click(object sender, EventArgs e)
        {

        }

        private void label_syr_Click(object sender, EventArgs e)
        {

        }

        private void label_proisv_Click(object sender, EventArgs e)
        {

        }

        private void label_tranz_Click(object sender, EventArgs e)
        {

        }

        private void textBoxId_склада_TextChanged(object sender, EventArgs e)
        {

        }

        private void checkBox_tranz_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            string id = textBox_id.Text;
            string count = textBox_count.Text;
            string date = dateTimePicker1.Value.ToString("yyyy-MM-dd");
            string mat = textBox_mat.Text;
            string id_send = textBox_send.Text;
            string id_get = textBox_get.Text;
            string way = textBox_way.Text;

            string connectionString = "server=localhost; uid=root; pwd=1q2w3e4r5t; database=curs";
            MySqlConnection connection = new MySqlConnection(connectionString);
            connection.Open();

            string deleteQuery = "DELETE FROM `Заказ_перемещения` WHERE `ID_заказа_перемещения` = @Id";
            MySqlCommand command = new MySqlCommand(deleteQuery, connection);
            command.Parameters.AddWithValue("@Id", id);
            command.Parameters.AddWithValue("@count", count);
            command.Parameters.AddWithValue("@date", date);
            command.Parameters.AddWithValue("@id_mat", mat);
            command.Parameters.AddWithValue("@id_send", id_send);
            command.Parameters.AddWithValue("@id_get", id_get);
            command.Parameters.AddWithValue("@id_way", way);
            command.ExecuteNonQuery();

            DataTable dataTable = new DataTable();
            string selectQuery = "SELECT `ID_заказа_перемещения`, `Количество`, `Дата`, `ID_материала`, `ID_склада_получ`, `ID_склада_отпр`, `ID_маршрута` FROM `Заказ_перемещения`";
            MySqlCommand selectCommand = new MySqlCommand(selectQuery, connection);
            MySqlDataAdapter adapter = new MySqlDataAdapter(selectCommand);
            adapter.Fill(dataTable);

            dataGridView1.DataSource = dataTable;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Заказ_перемещения_Load(object sender, EventArgs e)
        {
            string connectionString = "server=localhost; uid=root; pwd=1q2w3e4r5t; database=curs";
            MySqlConnection connection = new MySqlConnection(connectionString);
            connection.Open();

            string selectQuery = "SELECT * FROM заказ_перемещения";
            MySqlDataAdapter adapter = new MySqlDataAdapter(selectQuery, connection);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);

            dataGridView1.DataSource = dataTable;
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int row_index = dataGridView1.CurrentCell.RowIndex;
            textBox_id.Text = dataGridView1.Rows[row_index].Cells[0].Value.ToString();
            textBox_count.Text = dataGridView1.Rows[row_index].Cells[1].Value.ToString();
            dateTimePicker1.Text = dataGridView1.Rows[row_index].Cells[2].Value.ToString();
            textBox_mat.Text = dataGridView1.Rows[row_index].Cells[3].Value.ToString();
            textBox_send.Text = dataGridView1.Rows[row_index].Cells[4].Value.ToString();
            textBox_get.Text = dataGridView1.Rows[row_index].Cells[5].Value.ToString();
            textBox_way.Text = dataGridView1.Rows[row_index].Cells[6].Value.ToString();
        }
    }
}
