using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CURS
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void складToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_склад f = new Form_склад();
            f.ShowDialog();
        }

        private void материалToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_материал f = new Form_материал();
            f.ShowDialog();
        }


        private void запасToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_запас f = new Form_запас();
            f.ShowDialog();
        }

        private void маршрутToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_маршрут f = new Form_маршрут();
            f.ShowDialog();
        }

        private void заказНаПеремещениеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Заказ_перемещения f = new Заказ_перемещения();
            f.ShowDialog();
        }

        private void списаниеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_списание f = new Form_списание();
            f.ShowDialog();
        }

        private void списаниеToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Form_списание f = new Form_списание();
            f.ShowDialog();
        }

        private void отгрузкаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_отгрузка f = new Form_отгрузка();
            f.ShowDialog();
        }

        private void пополнениеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_пополнение f = new Form_пополнение();
            f.ShowDialog();
        }
        private void ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_пополнение f = new Form_пополнение();
            f.ShowDialog();
        }

        private void заявкаНаПродажуToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form3 f = new Form3();
            f.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form_склад f = new Form_склад();
            f.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form_материал f = new Form_материал();
            f.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form_маршрут f = new Form_маршрут();
            f.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form_запас f = new Form_запас();
            f.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form_списание f = new Form_списание();
            f.ShowDialog();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Form_отгрузка f = new Form_отгрузка();
            f.ShowDialog();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Заказ_перемещения f = new Заказ_перемещения();
            f.ShowDialog();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
