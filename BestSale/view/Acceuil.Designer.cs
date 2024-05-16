namespace BestSale
{
    partial class Acceuil
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
            this.components = new System.ComponentModel.Container();
            this.Menu = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.Previewbut = new System.Windows.Forms.Button();
            this.ExitBut = new System.Windows.Forms.Button();
            this.Nextbut = new System.Windows.Forms.Button();
            this.Buybut = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.button2 = new System.Windows.Forms.Button();
            this.slider = new System.Windows.Forms.PictureBox();
            this.Menu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.slider)).BeginInit();
            this.SuspendLayout();
            // 
            // Menu
            // 
            this.Menu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.Menu.Controls.Add(this.button2);
            this.Menu.Controls.Add(this.button1);
            this.Menu.Controls.Add(this.Previewbut);
            this.Menu.Controls.Add(this.ExitBut);
            this.Menu.Controls.Add(this.Nextbut);
            this.Menu.Controls.Add(this.Buybut);
            this.Menu.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Menu.Location = new System.Drawing.Point(0, 443);
            this.Menu.Name = "Menu";
            this.Menu.Size = new System.Drawing.Size(981, 107);
            this.Menu.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.Aqua;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(748, 40);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 27);
            this.button1.TabIndex = 4;
            this.button1.Text = " Data Base ";
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Visible = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Previewbut
            // 
            this.Previewbut.FlatAppearance.BorderColor = System.Drawing.Color.Aqua;
            this.Previewbut.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.Previewbut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Previewbut.Location = new System.Drawing.Point(324, 40);
            this.Previewbut.Name = "Previewbut";
            this.Previewbut.Size = new System.Drawing.Size(100, 27);
            this.Previewbut.TabIndex = 3;
            this.Previewbut.Text = "Preview";
            this.Previewbut.UseVisualStyleBackColor = true;
            this.Previewbut.Click += new System.EventHandler(this.Previewbut_Click);
            // 
            // ExitBut
            // 
            this.ExitBut.FlatAppearance.BorderColor = System.Drawing.Color.Aqua;
            this.ExitBut.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.ExitBut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ExitBut.Location = new System.Drawing.Point(854, 40);
            this.ExitBut.Name = "ExitBut";
            this.ExitBut.Size = new System.Drawing.Size(100, 27);
            this.ExitBut.TabIndex = 2;
            this.ExitBut.Text = "Exit";
            this.ExitBut.UseVisualStyleBackColor = true;
            this.ExitBut.Click += new System.EventHandler(this.ExitBut_Click);
            // 
            // Nextbut
            // 
            this.Nextbut.FlatAppearance.BorderColor = System.Drawing.Color.Aqua;
            this.Nextbut.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.Nextbut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Nextbut.Location = new System.Drawing.Point(536, 40);
            this.Nextbut.Name = "Nextbut";
            this.Nextbut.Size = new System.Drawing.Size(100, 27);
            this.Nextbut.TabIndex = 1;
            this.Nextbut.Text = "Next";
            this.Nextbut.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.Nextbut.UseVisualStyleBackColor = true;
            this.Nextbut.Click += new System.EventHandler(this.Nextbut_Click);
            // 
            // Buybut
            // 
            this.Buybut.FlatAppearance.BorderColor = System.Drawing.Color.Aqua;
            this.Buybut.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.Buybut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Buybut.Location = new System.Drawing.Point(642, 40);
            this.Buybut.Name = "Buybut";
            this.Buybut.Size = new System.Drawing.Size(100, 27);
            this.Buybut.TabIndex = 0;
            this.Buybut.Text = "Connect";
            this.Buybut.UseVisualStyleBackColor = true;
            this.Buybut.Click += new System.EventHandler(this.Buybut_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 20;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // button2
            // 
            this.button2.FlatAppearance.BorderColor = System.Drawing.Color.Aqua;
            this.button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Location = new System.Drawing.Point(430, 40);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(100, 27);
            this.button2.TabIndex = 5;
            this.button2.Text = "start";
            this.button2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Visible = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // slider
            // 
            this.slider.Dock = System.Windows.Forms.DockStyle.Fill;
            this.slider.Image = global::BestSale.Properties.Resources._9082703;
            this.slider.Location = new System.Drawing.Point(0, 0);
            this.slider.Name = "slider";
            this.slider.Size = new System.Drawing.Size(981, 550);
            this.slider.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.slider.TabIndex = 0;
            this.slider.TabStop = false;
            // 
            // Acceuil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Aqua;
            this.ClientSize = new System.Drawing.Size(981, 550);
            this.Controls.Add(this.Menu);
            this.Controls.Add(this.slider);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Acceuil";
            this.Text = "SaleForm";
            this.Menu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.slider)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox slider;
        private System.Windows.Forms.Panel Menu;
        private System.Windows.Forms.Button Buybut;
        private System.Windows.Forms.Button Nextbut;
        private System.Windows.Forms.Button Previewbut;
        private System.Windows.Forms.Button ExitBut;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button button2;
    }
}