using Carlib;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace BestSale
{
    public partial class BodyForm1 : Form
    {
        private ORM DB = new ORM();
        public BodyForm1()
        {
            InitializeComponent();
            InitialiweBody();
        }

        private void InitialiweBody()
        {
            foreach(BodyType bodyType in DB.GetBodies())
            {
                comboBox1.Items.Add(bodyType);
                richTextBox1.Text += bodyType.ToString();
            }
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void CloseBut_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void DeleteBut_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text != null && DB.GetBodies().Contains((BodyType)comboBox1.SelectedItem))
            {
                BodyType Body = (BodyType)comboBox1.SelectedItem;
                DB.Delete(Body);
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void BodyForm1_Load(object sender, EventArgs e)
        {
            comboBox1.SelectedItem = CarForm.BodyType;
        }
    }
}
