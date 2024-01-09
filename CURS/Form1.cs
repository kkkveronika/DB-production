using MySql.Data.MySqlClient;
using System.Data;
using System.Text;
using System.Web;

namespace CURS
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        



        private void Form1_Load(object sender, EventArgs e)
        {
            string connect = "server=localhost; uid=root; pwd=1q2w3e4r5t; database=curs";
            using (MySqlConnection con = new MySqlConnection(connect))
            {
                con.Open();
                //string query = "select * from Á‡Ô‡Ò";
                //using (MySqlCommand cmd = new MySqlCommand(query, con))
                //{
                //    MySqlDataReader reader = cmd.ExecuteReader();
                //    StringBuilder sb = new StringBuilder();
                //    while (reader.Read())
                //    {
                //        sb.Append(reader.GetString(1));

                //    }
                //    label1.Text = sb.ToString();
                //}
            }
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void ÎÓ„ËÒÚToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 f = new Form2();
            f.ShowDialog();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 f = new Form2();
            f.ShowDialog();
        }
    }
}