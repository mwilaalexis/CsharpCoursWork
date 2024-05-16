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
    public partial class ConfirmationForm : Form
    {
        private ORM DB = new ORM();
        //Document document = new Document();
        private static Sales sales { get; set; }
        public ConfirmationForm()
        {
            InitializeComponent();
        }

        private void Canselbut_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ConfirmationForm_Load(object sender, EventArgs e)
        {
            CustomerName1.Text += CustomerForm.CustomerChoosen.FirstName;
            CustomerName2.Text += CustomerForm.CustomerChoosen.LastName;
            CarDetail.Text += CarForm.CarChoosen.ToString();
            CarPrice.Text += CarForm.CarChoosen.Cost;
            sales = new Sales(CarForm.CarChoosen, CarForm.CarChoosen.Cost, DateTime.Now, CustomerForm.CustomerChoosen);

        }

        private void Insertbut_Click(object sender, EventArgs e)
        {
           
            DB.Insert(sales);
            this.Close();
        }

        private void Printbut_Click(object sender, EventArgs e)
        {
            DB.Insert(sales);
       //     document.PrintReceipt(sales);
        }
    }
}
