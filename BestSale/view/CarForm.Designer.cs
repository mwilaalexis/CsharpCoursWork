namespace BestSale
{
    partial class CarForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CarForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.butSearch = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.filter = new System.Windows.Forms.ComboBox();
            this.inputSeachIndice = new System.Windows.Forms.NumericUpDown();
            this.Updatebut = new System.Windows.Forms.Button();
            this.Refreshbut = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.butBuy = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.AddColor = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SearchBox = new System.Windows.Forms.TextBox();
            this.AddCar = new System.Windows.Forms.Button();
            this.CloseBub = new System.Windows.Forms.Button();
            this.DelBut = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.inputCost = new System.Windows.Forms.TextBox();
            this.inputMil = new System.Windows.Forms.TextBox();
            this.CombModel = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.combGear = new System.Windows.Forms.ComboBox();
            this.combColor = new System.Windows.Forms.ComboBox();
            this.comboBody = new System.Windows.Forms.ComboBox();
            this.inputDate = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inputSeachIndice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Controls.Add(this.butSearch);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.filter);
            this.panel1.Controls.Add(this.inputSeachIndice);
            this.panel1.Controls.Add(this.Updatebut);
            this.panel1.Controls.Add(this.Refreshbut);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.butBuy);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.AddColor);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.SearchBox);
            this.panel1.Controls.Add(this.AddCar);
            this.panel1.Controls.Add(this.CloseBub);
            this.panel1.Controls.Add(this.DelBut);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.ForeColor = System.Drawing.Color.White;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1063, 529);
            this.panel1.TabIndex = 0;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.Black;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.Location = new System.Drawing.Point(0, 308);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(1060, 218);
            this.dataGridView1.TabIndex = 27;
            // 
            // butSearch
            // 
            this.butSearch.ForeColor = System.Drawing.Color.Black;
            this.butSearch.Location = new System.Drawing.Point(367, 275);
            this.butSearch.Name = "butSearch";
            this.butSearch.Size = new System.Drawing.Size(58, 19);
            this.butSearch.TabIndex = 25;
            this.butSearch.Text = "Search";
            this.butSearch.UseVisualStyleBackColor = true;
            this.butSearch.Click += new System.EventHandler(this.butSearch_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(-1, 274);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(54, 19);
            this.label8.TabIndex = 19;
            this.label8.Text = "Sort by";
            // 
            // filter
            // 
            this.filter.FormattingEnabled = true;
            this.filter.Location = new System.Drawing.Point(62, 273);
            this.filter.Name = "filter";
            this.filter.Size = new System.Drawing.Size(53, 21);
            this.filter.TabIndex = 19;
            this.filter.Text = "ALL";
            this.filter.SelectedIndexChanged += new System.EventHandler(this.filter_SelectedIndexChanged);
            // 
            // inputSeachIndice
            // 
            this.inputSeachIndice.Location = new System.Drawing.Point(121, 273);
            this.inputSeachIndice.Name = "inputSeachIndice";
            this.inputSeachIndice.Size = new System.Drawing.Size(39, 20);
            this.inputSeachIndice.TabIndex = 19;
            this.inputSeachIndice.Visible = false;
            this.inputSeachIndice.ValueChanged += new System.EventHandler(this.inputSeachIndice_ValueChanged);
            // 
            // Updatebut
            // 
            this.Updatebut.BackColor = System.Drawing.Color.Black;
            this.Updatebut.FlatAppearance.BorderColor = System.Drawing.Color.Aqua;
            this.Updatebut.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.Updatebut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Updatebut.Location = new System.Drawing.Point(559, 116);
            this.Updatebut.Name = "Updatebut";
            this.Updatebut.Size = new System.Drawing.Size(92, 27);
            this.Updatebut.TabIndex = 23;
            this.Updatebut.Text = "update";
            this.Updatebut.UseVisualStyleBackColor = false;
            this.Updatebut.Click += new System.EventHandler(this.Updatebut_Click_1);
            // 
            // Refreshbut
            // 
            this.Refreshbut.BackColor = System.Drawing.Color.Black;
            this.Refreshbut.FlatAppearance.BorderColor = System.Drawing.Color.Aqua;
            this.Refreshbut.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.Refreshbut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Refreshbut.Location = new System.Drawing.Point(559, 50);
            this.Refreshbut.Name = "Refreshbut";
            this.Refreshbut.Size = new System.Drawing.Size(92, 27);
            this.Refreshbut.TabIndex = 22;
            this.Refreshbut.Text = "Refresh";
            this.Refreshbut.UseVisualStyleBackColor = false;
            this.Refreshbut.Click += new System.EventHandler(this.button4_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(3, 9);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(529, 260);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 20;
            this.pictureBox1.TabStop = false;
            // 
            // butBuy
            // 
            this.butBuy.BackColor = System.Drawing.Color.Black;
            this.butBuy.FlatAppearance.BorderColor = System.Drawing.Color.Aqua;
            this.butBuy.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.butBuy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.butBuy.Location = new System.Drawing.Point(559, 184);
            this.butBuy.Name = "butBuy";
            this.butBuy.Size = new System.Drawing.Size(92, 27);
            this.butBuy.TabIndex = 19;
            this.butBuy.Text = "Buy";
            this.butBuy.UseVisualStyleBackColor = false;
            this.butBuy.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Black;
            this.button2.FlatAppearance.BorderColor = System.Drawing.Color.Aqua;
            this.button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Location = new System.Drawing.Point(657, 275);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(95, 27);
            this.button2.TabIndex = 18;
            this.button2.Text = "Body type";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // AddColor
            // 
            this.AddColor.BackColor = System.Drawing.Color.Black;
            this.AddColor.FlatAppearance.BorderColor = System.Drawing.Color.Aqua;
            this.AddColor.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.AddColor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddColor.Location = new System.Drawing.Point(860, 275);
            this.AddColor.Name = "AddColor";
            this.AddColor.Size = new System.Drawing.Size(95, 27);
            this.AddColor.TabIndex = 15;
            this.AddColor.Text = "manage user";
            this.AddColor.UseVisualStyleBackColor = false;
            this.AddColor.Click += new System.EventHandler(this.AddColor_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Black;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.Aqua;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(758, 275);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(95, 27);
            this.button1.TabIndex = 13;
            this.button1.Text = "Model";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // SearchBox
            // 
            this.SearchBox.Location = new System.Drawing.Point(166, 274);
            this.SearchBox.Name = "SearchBox";
            this.SearchBox.Size = new System.Drawing.Size(195, 20);
            this.SearchBox.TabIndex = 17;
            // 
            // AddCar
            // 
            this.AddCar.BackColor = System.Drawing.Color.Black;
            this.AddCar.FlatAppearance.BorderColor = System.Drawing.Color.Aqua;
            this.AddCar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.AddCar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddCar.Location = new System.Drawing.Point(559, 83);
            this.AddCar.Name = "AddCar";
            this.AddCar.Size = new System.Drawing.Size(92, 27);
            this.AddCar.TabIndex = 14;
            this.AddCar.Text = "Add Car";
            this.AddCar.UseVisualStyleBackColor = false;
            this.AddCar.Click += new System.EventHandler(this.button2_Click);
            // 
            // CloseBub
            // 
            this.CloseBub.BackColor = System.Drawing.Color.Black;
            this.CloseBub.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CloseBub.FlatAppearance.BorderColor = System.Drawing.Color.Aqua;
            this.CloseBub.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.CloseBub.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CloseBub.Location = new System.Drawing.Point(961, 275);
            this.CloseBub.Name = "CloseBub";
            this.CloseBub.Size = new System.Drawing.Size(94, 27);
            this.CloseBub.TabIndex = 2;
            this.CloseBub.Text = "Close";
            this.CloseBub.UseVisualStyleBackColor = false;
            this.CloseBub.Click += new System.EventHandler(this.CloseBub_Click);
            // 
            // DelBut
            // 
            this.DelBut.BackColor = System.Drawing.Color.Black;
            this.DelBut.FlatAppearance.BorderColor = System.Drawing.Color.Aqua;
            this.DelBut.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.DelBut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DelBut.Location = new System.Drawing.Point(559, 151);
            this.DelBut.Name = "DelBut";
            this.DelBut.Size = new System.Drawing.Size(92, 27);
            this.DelBut.TabIndex = 1;
            this.DelBut.Text = "Delete";
            this.DelBut.UseVisualStyleBackColor = false;
            this.DelBut.Click += new System.EventHandler(this.DelBut_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.inputCost);
            this.panel2.Controls.Add(this.inputMil);
            this.panel2.Controls.Add(this.CombModel);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.combGear);
            this.panel2.Controls.Add(this.combColor);
            this.panel2.Controls.Add(this.comboBody);
            this.panel2.Controls.Add(this.inputDate);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Location = new System.Drawing.Point(670, 9);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(372, 247);
            this.panel2.TabIndex = 16;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(4, 121);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(125, 19);
            this.label5.TabIndex = 18;
            this.label5.Text = "Date of fabrication";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(3, 173);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(37, 19);
            this.label7.TabIndex = 17;
            this.label7.Text = "Cost";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(3, 147);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 19);
            this.label6.TabIndex = 16;
            this.label6.Text = "mileage";
            // 
            // inputCost
            // 
            this.inputCost.Location = new System.Drawing.Point(150, 172);
            this.inputCost.Name = "inputCost";
            this.inputCost.Size = new System.Drawing.Size(219, 20);
            this.inputCost.TabIndex = 15;
            // 
            // inputMil
            // 
            this.inputMil.Location = new System.Drawing.Point(149, 146);
            this.inputMil.Name = "inputMil";
            this.inputMil.Size = new System.Drawing.Size(220, 20);
            this.inputMil.TabIndex = 13;
            // 
            // CombModel
            // 
            this.CombModel.FormattingEnabled = true;
            this.CombModel.Location = new System.Drawing.Point(149, 15);
            this.CombModel.Name = "CombModel";
            this.CombModel.Size = new System.Drawing.Size(220, 21);
            this.CombModel.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 19);
            this.label1.TabIndex = 7;
            this.label1.Text = "Model";
            // 
            // combGear
            // 
            this.combGear.FormattingEnabled = true;
            this.combGear.Location = new System.Drawing.Point(149, 42);
            this.combGear.Name = "combGear";
            this.combGear.Size = new System.Drawing.Size(220, 21);
            this.combGear.TabIndex = 4;
            // 
            // combColor
            // 
            this.combColor.FormattingEnabled = true;
            this.combColor.Location = new System.Drawing.Point(149, 70);
            this.combColor.Name = "combColor";
            this.combColor.Size = new System.Drawing.Size(220, 21);
            this.combColor.TabIndex = 5;
            // 
            // comboBody
            // 
            this.comboBody.FormattingEnabled = true;
            this.comboBody.Location = new System.Drawing.Point(149, 94);
            this.comboBody.Name = "comboBody";
            this.comboBody.Size = new System.Drawing.Size(220, 21);
            this.comboBody.TabIndex = 6;
            // 
            // inputDate
            // 
            this.inputDate.Location = new System.Drawing.Point(149, 119);
            this.inputDate.Name = "inputDate";
            this.inputDate.Size = new System.Drawing.Size(220, 20);
            this.inputDate.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 19);
            this.label2.TabIndex = 8;
            this.label2.Text = "Gear Box";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(3, 96);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 19);
            this.label3.TabIndex = 9;
            this.label3.Text = "Body type";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(3, 72);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 19);
            this.label4.TabIndex = 10;
            this.label4.Text = "Color";
            // 
            // CarForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Aqua;
            this.ClientSize = new System.Drawing.Size(1070, 535);
            this.Controls.Add(this.panel1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CarForm";
            this.Text = "CarForm";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inputSeachIndice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button DelBut;
        private System.Windows.Forms.Button CloseBub;
        private System.Windows.Forms.Button AddCar;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button AddColor;
        private System.Windows.Forms.TextBox SearchBox;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox combGear;
        private System.Windows.Forms.ComboBox combColor;
        private System.Windows.Forms.ComboBox comboBody;
        private System.Windows.Forms.DateTimePicker inputDate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button butBuy;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox inputCost;
        private System.Windows.Forms.TextBox inputMil;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.NumericUpDown inputSeachIndice;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button Refreshbut;
        private System.Windows.Forms.Button Updatebut;
        public System.Windows.Forms.ComboBox CombModel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label8;
        public System.Windows.Forms.ComboBox filter;
        private System.Windows.Forms.Button butSearch;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}

