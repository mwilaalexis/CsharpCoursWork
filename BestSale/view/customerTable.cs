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

namespace BestSale.view
{
    public partial class customerTable : Form
    {
        ORM DB=new ORM();
        public customerTable()
        {
            InitializeComponent();
            initialiseCustomer();
        }

        private void initialiseCustomer()
        {
            richTextBox1.Clear();
            comboBox1.Items.Clear();
            comboBox2.Items.Clear();
            foreach (Customer customer in DB.GetCustomer()) {
                comboBox1.Items.Add(customer.FirstName);
                comboBox2.Items.Add(customer.LastName);
                richTextBox1.Text+=customer.ToString();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Deletebut_Click(object sender, EventArgs e)
        {
            Customer customer = new Customer(comboBox1.Text, comboBox2.Text);
            List<Customer> list = DB.searchCst(SearchBox.Text);
            int i = Convert.ToInt32(index.Value);
                DB.Delete(DB.searchCst(SearchBox.Text)[i]);
            initialiseCustomer();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
            List<Customer> list = DB.searchCst(SearchBox.Text);
            if (list.Count() != 0)
            {
                Customer customer = new Customer(comboBox1.Text, comboBox2.Text);
                customer.Id = Select(list).Id;
                DB.Update(customer);
            }
            initialiseCustomer();

        }

        private void index_ValueChanged(object sender, EventArgs e)
        {
            Select(DB.searchCst(SearchBox.Text));
        }

        private  Customer Select(List<Customer>list)
        {
            index.Maximum=list.Count();
            int i = Convert.ToInt32(index.Value);
            comboBox1.Text = list[i].FirstName;
            comboBox2.Text = list[i].LastName;
            richTextBox1.Clear();
            foreach (Customer customer in list)
            {
                richTextBox1.Text += customer.ToString();
            }
            return list[i];
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Customer customer =new  Customer(comboBox1.Text,comboBox2.Text);
            DB.Insert(customer);
            initialiseCustomer();
            
        }

        private void butSeach_Click(object sender, EventArgs e)
        {
            Select(DB.searchCst(SearchBox.Text));
        }
    }
}
