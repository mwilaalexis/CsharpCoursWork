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
    public partial class ModelForm : Form
    {
        private  ORM DB = new ORM();
     
        public ModelForm()
        {
            InitializeComponent();
            InitializeModel();
        }
        public void InitializeModel()
        {
            foreach(Model model in DB.GetModels())
            {
                combModel.Items.Add(model);
                combBrandM.Items.Add(model.Brand);
            }
            foreach (Brand brand in DB.GetBrands())
            {
                combBrandM.Items.Add(brand);
            }
        }
        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DB.Insert(new Brand(combBrandM.Text));
            InitializeModel();
        }

        private void DeleteBrandbut_Click(object sender, EventArgs e)
        {
            Brand brand = new Brand(combBrandM.SelectedItem.ToString());
            DB.Delete(brand);
            InitializeModel();
        }

        private void Insertbut_Click(object sender, EventArgs e)
        {
            Model model = new Model(combModel.Text, (Brand)combBrandM.SelectedItem);
            DB.Insert(model);
            InitializeModel();
        }

        private void Deletebut_Click(object sender, EventArgs e)
        {
            if (DB.GetModels().Contains((Model)combModel.SelectedItem))
            {
                DB.Delete((Model)combModel.SelectedItem);
                InitializeModel();
            }
        }

        private void Updatebut_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            brandStat.Text = combBrandM.Text;
            Modelstat.Text = combModel.Text;

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void ModelForm_Load(object sender, EventArgs e)
        {
            combModel.SelectedItem = CarForm.Model;
            
        }
    }

}
