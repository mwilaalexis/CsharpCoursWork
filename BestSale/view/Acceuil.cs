using BestSale.view;
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

namespace BestSale
{
    public partial class Acceuil : Form
    {
        ORM DB=new ORM();
        public Acceuil()
        {
            InitializeComponent();
        }
        int ImageNumber = 1;
        private void Nextbut_Click(object sender, EventArgs e)
        {
            if (ImageNumber == 14)
            {
                slider.ImageLocation = string.Format(@"img\{0}.jpg", ImageNumber);
                ImageNumber = 1;
            }
            else
            {
                ImageNumber++;
                slider.ImageLocation = string.Format(@"img\{0}.jpg", ImageNumber);
                
            }
        }

        private void Previewbut_Click(object sender, EventArgs e)
        {
            if (ImageNumber == 1)
            {
                slider.ImageLocation = string.Format(@"img\{0}.jpg", ImageNumber);
                ImageNumber = 14;
            }
            else
            {
                ImageNumber--;
                slider.ImageLocation =string.Format(@"img\{0}.jpg", ImageNumber);
            }
        }

        private void ExitBut_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CarForm form = new CarForm();
            //timer1.Enabled = false;
            form.ShowDialog();
        }

        private void Buybut_Click(object sender, EventArgs e) { 
        //{ if ()
        //    {
        //        button1.Visible = true;
        //        button2.Visible = true;
               

        //    }
        //    else
        //    {
        //        MessageBox.Show(DB.GetException().Message);
        //    }
        ////    CustomerForm form = new CustomerForm();
        ////    form.ShowDialog();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //if (ImageNumber == 14)
            //{
            //    slider.ImageLocation = string.Format(@"img\{0}.jpg", ImageNumber);
            //    ImageNumber = 1;
            //}
            //else
            //{
            //    ImageNumber++;
            ////    slider.ImageLocation = string.Format(@"img\{0}.jpg", ImageNumber);
            //}
        }

        private void button2_Click(object sender, EventArgs e)
        {
            CarForm form = new CarForm();
            form.ShowDialog();
        }
    }
}
