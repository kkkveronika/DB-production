﻿using System;
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
    public partial class Form_материал : Form
    {
        public Form_материал()
        {
            InitializeComponent();
        }

        private void Form_материал_Load(object sender, EventArgs e)
        {
            string connectionString = "server=localhost; uid=root; pwd=1q2w3e4r5t; database=curs";
            MySqlConnection connection = new MySqlConnection(connectionString);
            connection.Open();

            string selectQuery = "SELECT * FROM Материал";
            MySqlDataAdapter adapter = new MySqlDataAdapter(selectQuery, connection);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);

            dataGridView1.DataSource = dataTable;
        }   

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int row_index = dataGridView1.CurrentCell.RowIndex;
            textBox_id.Text = dataGridView1.Rows[row_index].Cells[0].Value.ToString();
            textBox_name.Text = dataGridView1.Rows[row_index].Cells[1].Value.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string id = textBox_id.Text;
            string name = textBox_name.Text;

            string connectionString = "server=localhost; uid=root; pwd=1q2w3e4r5t; database=curs";
            MySqlConnection connection = new MySqlConnection(connectionString);
            connection.Open();

            string query = "INSERT INTO `Материал`(`ID_материала`, `Название`) VALUES (@Id, @Name)";
            MySqlCommand command = new MySqlCommand(query, connection);
            command.Parameters.AddWithValue("@Id", id);
            command.Parameters.AddWithValue("@Name", name);
            command.ExecuteNonQuery();

            DataTable dataTable = new DataTable();
            string selectQuery = "SELECT `ID_материала`, `Название` FROM `Материал`";
            MySqlCommand selectCommand = new MySqlCommand(selectQuery, connection);
            MySqlDataAdapter adapter = new MySqlDataAdapter(selectCommand);
            adapter.Fill(dataTable);

            dataGridView1.DataSource = dataTable;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string id = textBox_id.Text;
            string name = textBox_name.Text;

            string connectionString = "server=localhost; uid=root; pwd=1q2w3e4r5t; database=curs";
            MySqlConnection connection = new MySqlConnection(connectionString);
            connection.Open();

            string deleteQuery = "DELETE FROM `Материал` WHERE `ID_материала` = @Id AND `Название` = @Name";
            MySqlCommand command = new MySqlCommand(deleteQuery, connection);
            command.Parameters.AddWithValue("@Id", id);
            command.Parameters.AddWithValue("@Name", name);
            command.ExecuteNonQuery();

            DataTable dataTable = new DataTable();
            string selectQuery = "SELECT `ID_материала`, `Название` FROM `Материал`";
            MySqlCommand selectCommand = new MySqlCommand(selectQuery, connection);
            MySqlDataAdapter adapter = new MySqlDataAdapter(selectCommand);
            adapter.Fill(dataTable);

            dataGridView1.DataSource = dataTable;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string id = textBox_id.Text;
            string name = textBox_name.Text;

            string connectionString = "server=localhost; uid=root; pwd=1q2w3e4r5t; database=curs";
            MySqlConnection connection = new MySqlConnection(connectionString);
            connection.Open();

            string updateQuery = "UPDATE `Материал` SET `Название` = @Name WHERE `ID_материала` = @Id";
            MySqlCommand command = new MySqlCommand(updateQuery, connection);
            command.Parameters.AddWithValue("@Name", name);
            command.Parameters.AddWithValue("@Id", id);
            command.ExecuteNonQuery();

            DataTable dataTable = new DataTable();
            string selectQuery = "SELECT `ID_материала`, `Название` FROM `Материал`";
            MySqlCommand selectCommand = new MySqlCommand(selectQuery, connection);
            MySqlDataAdapter adapter = new MySqlDataAdapter(selectCommand);
            adapter.Fill(dataTable);

            dataGridView1.DataSource = dataTable;
        }
    }
}
