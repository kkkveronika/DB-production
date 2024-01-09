namespace CURS
{
    partial class Заказ_перемещения
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonDelete = new System.Windows.Forms.Button();
            this.buttonEdit = new System.Windows.Forms.Button();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.label_syr = new System.Windows.Forms.Label();
            this.label_proisv = new System.Windows.Forms.Label();
            this.label_tranz = new System.Windows.Forms.Label();
            this.textBox_id = new System.Windows.Forms.TextBox();
            this.label_ID_склада = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.textBox_get = new System.Windows.Forms.TextBox();
            this.textBox_send = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox_mat = new System.Windows.Forms.TextBox();
            this.textBox_count = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_way = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonDelete
            // 
            this.buttonDelete.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonDelete.Location = new System.Drawing.Point(751, 219);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(94, 40);
            this.buttonDelete.TabIndex = 27;
            this.buttonDelete.Text = "Удалить";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // buttonEdit
            // 
            this.buttonEdit.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonEdit.Location = new System.Drawing.Point(721, 151);
            this.buttonEdit.Name = "buttonEdit";
            this.buttonEdit.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.buttonEdit.Size = new System.Drawing.Size(150, 40);
            this.buttonEdit.TabIndex = 26;
            this.buttonEdit.Text = "Редактировать";
            this.buttonEdit.UseVisualStyleBackColor = true;
            this.buttonEdit.Click += new System.EventHandler(this.buttonEdit_Click);
            // 
            // buttonAdd
            // 
            this.buttonAdd.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonAdd.Location = new System.Drawing.Point(736, 83);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(120, 40);
            this.buttonAdd.TabIndex = 25;
            this.buttonAdd.Text = "Добавить";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // label_syr
            // 
            this.label_syr.AutoSize = true;
            this.label_syr.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_syr.Location = new System.Drawing.Point(131, 154);
            this.label_syr.Name = "label_syr";
            this.label_syr.Size = new System.Drawing.Size(123, 25);
            this.label_syr.TabIndex = 20;
            this.label_syr.Text = "ID_материала";
            this.label_syr.Click += new System.EventHandler(this.label_syr_Click);
            // 
            // label_proisv
            // 
            this.label_proisv.AutoSize = true;
            this.label_proisv.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_proisv.Location = new System.Drawing.Point(131, 110);
            this.label_proisv.Name = "label_proisv";
            this.label_proisv.Size = new System.Drawing.Size(49, 25);
            this.label_proisv.TabIndex = 19;
            this.label_proisv.Text = "Дата";
            this.label_proisv.Click += new System.EventHandler(this.label_proisv_Click);
            // 
            // label_tranz
            // 
            this.label_tranz.AutoSize = true;
            this.label_tranz.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_tranz.Location = new System.Drawing.Point(131, 63);
            this.label_tranz.Name = "label_tranz";
            this.label_tranz.Size = new System.Drawing.Size(107, 25);
            this.label_tranz.TabIndex = 18;
            this.label_tranz.Text = "Количество";
            this.label_tranz.Click += new System.EventHandler(this.label_tranz_Click);
            // 
            // textBox_id
            // 
            this.textBox_id.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBox_id.Location = new System.Drawing.Point(452, 14);
            this.textBox_id.Name = "textBox_id";
            this.textBox_id.ReadOnly = true;
            this.textBox_id.Size = new System.Drawing.Size(125, 31);
            this.textBox_id.TabIndex = 17;
            this.textBox_id.TextChanged += new System.EventHandler(this.textBoxId_склада_TextChanged);
            // 
            // label_ID_склада
            // 
            this.label_ID_склада.AutoSize = true;
            this.label_ID_склада.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_ID_склада.Location = new System.Drawing.Point(131, 20);
            this.label_ID_склада.Name = "label_ID_склада";
            this.label_ID_склада.Size = new System.Drawing.Size(210, 25);
            this.label_ID_склада.TabIndex = 15;
            this.label_ID_склада.Text = "ID_заказа_перемещения";
            this.label_ID_склада.Click += new System.EventHandler(this.label_ID_склада_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 348);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 29;
            this.dataGridView1.Size = new System.Drawing.Size(958, 152);
            this.dataGridView1.TabIndex = 14;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // textBox_get
            // 
            this.textBox_get.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBox_get.Location = new System.Drawing.Point(452, 249);
            this.textBox_get.Name = "textBox_get";
            this.textBox_get.Size = new System.Drawing.Size(125, 31);
            this.textBox_get.TabIndex = 32;
            // 
            // textBox_send
            // 
            this.textBox_send.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBox_send.Location = new System.Drawing.Point(452, 202);
            this.textBox_send.Name = "textBox_send";
            this.textBox_send.Size = new System.Drawing.Size(125, 31);
            this.textBox_send.TabIndex = 31;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(132, 252);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(190, 25);
            this.label4.TabIndex = 30;
            this.label4.Text = "ID_склада_получателя";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(132, 204);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(200, 25);
            this.label3.TabIndex = 29;
            this.label3.Text = "ID_склада_отправителя";
            // 
            // textBox_mat
            // 
            this.textBox_mat.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBox_mat.Location = new System.Drawing.Point(452, 154);
            this.textBox_mat.Name = "textBox_mat";
            this.textBox_mat.Size = new System.Drawing.Size(125, 31);
            this.textBox_mat.TabIndex = 34;
            // 
            // textBox_count
            // 
            this.textBox_count.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBox_count.Location = new System.Drawing.Point(452, 63);
            this.textBox_count.Name = "textBox_count";
            this.textBox_count.Size = new System.Drawing.Size(125, 31);
            this.textBox_count.TabIndex = 35;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(131, 295);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 25);
            this.label1.TabIndex = 36;
            this.label1.Text = "ID_маршрута";
            // 
            // textBox_way
            // 
            this.textBox_way.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBox_way.Location = new System.Drawing.Point(452, 292);
            this.textBox_way.Name = "textBox_way";
            this.textBox_way.Size = new System.Drawing.Size(125, 31);
            this.textBox_way.TabIndex = 37;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(452, 110);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(172, 27);
            this.dateTimePicker1.TabIndex = 38;
            // 
            // Заказ_перемещения
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(982, 512);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.textBox_way);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox_count);
            this.Controls.Add(this.textBox_mat);
            this.Controls.Add(this.textBox_get);
            this.Controls.Add(this.textBox_send);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.buttonEdit);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.label_syr);
            this.Controls.Add(this.label_proisv);
            this.Controls.Add(this.label_tranz);
            this.Controls.Add(this.textBox_id);
            this.Controls.Add(this.label_ID_склада);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Заказ_перемещения";
            this.Text = "Заказ на перемещение";
            this.Load += new System.EventHandler(this.Заказ_перемещения_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button buttonDelete;
        private Button buttonEdit;
        private Button buttonAdd;
        private Label label_syr;
        private Label label_proisv;
        private Label label_tranz;
        private TextBox textBox_id;
        private Label label_ID_склада;
        private DataGridView dataGridView1;
        private TextBox textBox_get;
        private TextBox textBox_send;
        private Label label4;
        private Label label3;
        private TextBox textBox_mat;
        private TextBox textBox_count;
        private Label label1;
        private TextBox textBox_way;
        private DateTimePicker dateTimePicker1;
    }
}