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
    public partial class Raport_de_vente : Form
    {
        ORM db = new ORM();

        public Raport_de_vente()
        {
            InitializeComponent();
          
            dataGridView1.DataSource = db.GetReport( date1.Value, date2.Value);
            AVG.Text = $" Average {db.AVG(date1.Value, date2.Value).AVG} $ by car  , Total Price: {db.AVG(date1.Value, date2.Value).SUM}$ nomber of item:{db.AVG(date1.Value, date2.Value).COUNT} car";



        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {
            // string v=groupeBy.Text;
            dataGridView1.DataSource = db.GetReport( date1.Value, date2.Value);
            AVG.Text = $" Average {db.AVG(date1.Value, date2.Value).AVG} $ by car  , Total Price: {db.AVG(date1.Value, date2.Value).SUM}$ nomber of item:{db.AVG(date1.Value, date2.Value).COUNT} car";

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void date2_ValueChanged(object sender, EventArgs e)
        {
            dataGridView1.DataSource = db.GetReport( date1.Value, date2.Value);
            AVG.Text = $" Average {db.AVG(date1.Value, date2.Value).AVG} $ by car  , Total Price: {db.AVG(date1.Value, date2.Value).SUM}$ nomber of item:{db.AVG(date1.Value, date2.Value).COUNT} car";

        }

    
        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Document d = new Document();
            d.Save(db.GetReport( date1.Value, date2.Value));

            MessageBox.Show("successful");
        }
    }
}
