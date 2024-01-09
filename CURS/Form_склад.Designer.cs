namespace CURS
{
    partial class Form_склад
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label_ID_склада = new System.Windows.Forms.Label();
            this.checkBox_tranz = new System.Windows.Forms.CheckBox();
            this.textBoxId_склада = new System.Windows.Forms.TextBox();
            this.label_tranz = new System.Windows.Forms.Label();
            this.label_proisv = new System.Windows.Forms.Label();
            this.label_syr = new System.Windows.Forms.Label();
            this.label_pfgp = new System.Windows.Forms.Label();
            this.checkBox_proisv = new System.Windows.Forms.CheckBox();
            this.checkBox_syr = new System.Windows.Forms.CheckBox();
            this.checkBox_pfgp = new System.Windows.Forms.CheckBox();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonEdit = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5});
            this.dataGridView1.Location = new System.Drawing.Point(12, 250);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 29;
            this.dataGridView1.Size = new System.Drawing.Size(759, 188);
            this.dataGridView1.TabIndex = 0;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "ID_склада";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 125;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Транзитный";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.Width = 125;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Производственный";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.Width = 160;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Сырье";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.Width = 125;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Полуфабрикаты и готовая продукция";
            this.Column5.MinimumWidth = 6;
            this.Column5.Name = "Column5";
            this.Column5.Width = 170;
            // 
            // label_ID_склада
            // 
            this.label_ID_склада.AutoSize = true;
            this.label_ID_склада.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_ID_склада.Location = new System.Drawing.Point(59, 26);
            this.label_ID_склада.Name = "label_ID_склада";
            this.label_ID_склада.Size = new System.Drawing.Size(91, 25);
            this.label_ID_склада.TabIndex = 1;
            this.label_ID_склада.Text = "ID_склада";
            // 
            // checkBox_tranz
            // 
            this.checkBox_tranz.AutoSize = true;
            this.checkBox_tranz.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.checkBox_tranz.Location = new System.Drawing.Point(407, 77);
            this.checkBox_tranz.Name = "checkBox_tranz";
            this.checkBox_tranz.Size = new System.Drawing.Size(18, 17);
            this.checkBox_tranz.TabIndex = 2;
            this.checkBox_tranz.UseVisualStyleBackColor = true;
            // 
            // textBoxId_склада
            // 
            this.textBoxId_склада.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxId_склада.Location = new System.Drawing.Point(355, 20);
            this.textBoxId_склада.Name = "textBoxId_склада";
            this.textBoxId_склада.ReadOnly = true;
            this.textBoxId_склада.Size = new System.Drawing.Size(125, 31);
            this.textBoxId_склада.TabIndex = 3;
            // 
            // label_tranz
            // 
            this.label_tranz.AutoSize = true;
            this.label_tranz.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_tranz.Location = new System.Drawing.Point(59, 69);
            this.label_tranz.Name = "label_tranz";
            this.label_tranz.Size = new System.Drawing.Size(109, 25);
            this.label_tranz.TabIndex = 4;
            this.label_tranz.Text = "Транзитный";
            this.label_tranz.Click += new System.EventHandler(this.label2_Click);
            // 
            // label_proisv
            // 
            this.label_proisv.AutoSize = true;
            this.label_proisv.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_proisv.Location = new System.Drawing.Point(59, 116);
            this.label_proisv.Name = "label_proisv";
            this.label_proisv.Size = new System.Drawing.Size(173, 25);
            this.label_proisv.TabIndex = 5;
            this.label_proisv.Text = "Производственный";
            // 
            // label_syr
            // 
            this.label_syr.AutoSize = true;
            this.label_syr.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_syr.Location = new System.Drawing.Point(59, 160);
            this.label_syr.Name = "label_syr";
            this.label_syr.Size = new System.Drawing.Size(65, 25);
            this.label_syr.TabIndex = 6;
            this.label_syr.Text = "Сырье";
            // 
            // label_pfgp
            // 
            this.label_pfgp.AutoSize = true;
            this.label_pfgp.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_pfgp.Location = new System.Drawing.Point(59, 204);
            this.label_pfgp.Name = "label_pfgp";
            this.label_pfgp.Size = new System.Drawing.Size(323, 25);
            this.label_pfgp.TabIndex = 7;
            this.label_pfgp.Text = "Полуфабрикаты и готовая продукция";
            // 
            // checkBox_proisv
            // 
            this.checkBox_proisv.AutoSize = true;
            this.checkBox_proisv.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.checkBox_proisv.Location = new System.Drawing.Point(407, 121);
            this.checkBox_proisv.Name = "checkBox_proisv";
            this.checkBox_proisv.Size = new System.Drawing.Size(18, 17);
            this.checkBox_proisv.TabIndex = 8;
            this.checkBox_proisv.UseVisualStyleBackColor = true;
            // 
            // checkBox_syr
            // 
            this.checkBox_syr.AutoSize = true;
            this.checkBox_syr.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.checkBox_syr.Location = new System.Drawing.Point(407, 168);
            this.checkBox_syr.Name = "checkBox_syr";
            this.checkBox_syr.Size = new System.Drawing.Size(18, 17);
            this.checkBox_syr.TabIndex = 9;
            this.checkBox_syr.UseVisualStyleBackColor = true;
            // 
            // checkBox_pfgp
            // 
            this.checkBox_pfgp.AutoSize = true;
            this.checkBox_pfgp.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.checkBox_pfgp.Location = new System.Drawing.Point(407, 212);
            this.checkBox_pfgp.Name = "checkBox_pfgp";
            this.checkBox_pfgp.Size = new System.Drawing.Size(18, 17);
            this.checkBox_pfgp.TabIndex = 10;
            this.checkBox_pfgp.UseVisualStyleBackColor = true;
            // 
            // buttonAdd
            // 
            this.buttonAdd.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonAdd.Location = new System.Drawing.Point(619, 44);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(120, 40);
            this.buttonAdd.TabIndex = 11;
            this.buttonAdd.Text = "Добавить";
            this.buttonAdd.UseVisualStyleBackColor = true;
            // 
            // buttonEdit
            // 
            this.buttonEdit.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonEdit.Location = new System.Drawing.Point(604, 112);
            this.buttonEdit.Name = "buttonEdit";
            this.buttonEdit.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.buttonEdit.Size = new System.Drawing.Size(150, 40);
            this.buttonEdit.TabIndex = 12;
            this.buttonEdit.Text = "Редактировать";
            this.buttonEdit.UseVisualStyleBackColor = true;
            // 
            // buttonDelete
            // 
            this.buttonDelete.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonDelete.Location = new System.Drawing.Point(634, 180);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(94, 40);
            this.buttonDelete.TabIndex = 13;
            this.buttonDelete.Text = "Удалить";
            this.buttonDelete.UseVisualStyleBackColor = true;
            // 
            // Form_склад
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.buttonEdit);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.checkBox_pfgp);
            this.Controls.Add(this.checkBox_syr);
            this.Controls.Add(this.checkBox_proisv);
            this.Controls.Add(this.label_pfgp);
            this.Controls.Add(this.label_syr);
            this.Controls.Add(this.label_proisv);
            this.Controls.Add(this.label_tranz);
            this.Controls.Add(this.textBoxId_склада);
            this.Controls.Add(this.checkBox_tranz);
            this.Controls.Add(this.label_ID_склада);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form_склад";
            this.Text = "Склад";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
        private Label label_ID_склада;
        private CheckBox checkBox_tranz;
        private TextBox textBoxId_склада;
        private Label label_tranz;
        private Label label_proisv;
        private Label label_syr;
        private Label label_pfgp;
        private CheckBox checkBox_proisv;
        private CheckBox checkBox_syr;
        private CheckBox checkBox_pfgp;
        private Button buttonAdd;
        private Button buttonEdit;
        private Button buttonDelete;
    }
}