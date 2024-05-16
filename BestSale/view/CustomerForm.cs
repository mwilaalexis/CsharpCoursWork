using Carlib;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BestSale.view
{
    public partial class CustomerForm : Form
    {
        private static ORM DB = new ORM();
        private static Customer _CustomerChoosen;
        public static Customer CustomerChoosen
        {
            get { return _CustomerChoosen; }
            set { if(  DB.GetCustomer().Contains(CustomerChoosen))
                { _CustomerChoosen = CustomerChoosen; } }
        }
        public CustomerForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Messages.Text = "";
            if (textBox1.Text =="" || textBox2.Text == "")
            {
                 Messages.Text = "fill the form"; 
                
            }
            else
            {
                Customer customer = new Customer(textBox1.Text, textBox2.Text);
                if (DB.GetCustomer().Contains(customer))
                { DB.Insert(customer); }
                _CustomerChoosen = customer;
                ConfirmationForm form=new ConfirmationForm();
                form.ShowDialog();
                textBox1.Clear();
                textBox2.Clear();
                this.Close();
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CustomerForm_Load(object sender, EventArgs e)
        {

        }

        private void Deletebut_Click(object sender, EventArgs e)
        {
            Customer customer = new Customer(textBox1.Text, textBox2.Text);
            DB.Delete(customer);
            textBox1.Clear();
            textBox2.Clear();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            customerTable customerTable = new customerTable();
            customerTable.ShowDialog();
        }
    }
}
