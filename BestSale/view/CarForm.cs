using BestSale.view;
using Carlib;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Lifetime;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BestSale
{
    public partial class CarForm : Form
    {
        private static CarInfo _Car;
        public static CarInfo CarChoosen
        {
            get { return _Car; }
            set { if (value != null) { _Car = CarChoosen; } }
        }
        private static Model _Model;
        public static Model Model
        {
            get { return _Model;  }
            set { if (Model != null) { _Model = Model; } }
        }
        public static BodyType _BodyType { get; set; }
        public static BodyType BodyType
        {
            get { return _BodyType; }
            set { if (BodyType != null) { _BodyType = BodyType; } }
        }

        private ORM DB = new ORM();

        
        public CarForm()
        {
            InitializeComponent();
           InitializeCar();
        }
        public void InitializeCar()
        {
            filter.Items.Clear();
            filter.Items.Add("All");
            filter.Items.Add("Price");
            filter.Items.Add("Date");
            filter.Items.Add("Brand");
            foreach (Model model in DB.GetModels())
            {
                CombModel.Items.Add(model);
            }
            foreach (Carlib.Color color in DB.GetColors())
            {
                combColor.Items.Add(color);
            }
            foreach (GearBox gearbox in DB.GetGearBoxes())
            {
                combGear.Items.Add(gearbox);
            }
            foreach(BodyType body in DB.GetBodies())
            {
                comboBody.Items.Add(body);   
            }
            //CarTable.Text= " id\tBrand\tColor\tModel.\tGearBox\tCost\tmileage\n ";
            //foreach (CarInfo car in DB.GetCarInfos(filter.Text))
            //{
            //    CarTable.Text+=car.ToString();
            //}
            dataGridView1.DataSource = DB.GetCarInfos(filter.Text);
        }
        private void CloseBub_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int n=inputMil.Text.Length;
            CarInfo car = new CarInfo((Model)CombModel.SelectedItem, (Carlib.Color)combColor.SelectedItem, (BodyType)comboBody.SelectedItem,
           double.Parse(inputMil.Text.Substring(0,n-2)),inputDate.Value, Convert.ToDecimal(inputCost.Text),
           (GearBox)combGear.SelectedItem);
    
           
                DB.Insert(car);
                InitializeCar();
                CarChoosen = car;
                butBuy.Visible = true;
            


        }

     

        private void DisplayResult()
        {
            List<CarInfo> Cars = DB.Search(SearchBox.Text);
            int j = Cars.Count();
            inputSeachIndice.Maximum = j - 1;
            if (j != 0)
            {

                dataGridView1.DataSource = DB.Search(SearchBox.Text);

                
             
               selectCar(Cars);

            }
            else
            {

                dataGridView1.Text = "Not Find";
            }
        }
        void selectCar(List<CarInfo> Cars)
        {
            int j = Cars.Count();
            inputSeachIndice.Maximum = j - 1;
            if (j != 0)
            {
                int i = Convert.ToInt32(inputSeachIndice.Value);
                CarInfo car = Cars[i];
                combColor.Text = car.Color.ToString();
                comboBody.Text = car.Body.ToString();
                combGear.Text = car.GearBox.ToString();
                CombModel.Text = car.Model.ToString();
                inputCost.Text = car.Cost.ToString();
                inputDate.Value = car.FabDate;
                inputMil.Text = $"{car.mileage} km";

                _Car = car;
                DelBut.Visible = true;
                Updatebut.Visible = true;
                butBuy.Visible = true;
            }
        
          }
        private void DelBut_Click(object sender, EventArgs e)
        {
            CarInfo car = DB.Search(SearchBox.Text)[Convert.ToInt32(inputSeachIndice.Value)];
            if (DB.GetCarInfos(filter.SelectedItem.ToString()).Contains(car))
            {
                DB.Delete(car);
                InitializeCar();
                DelBut.Visible = false; 
                Updatebut.Visible=false;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            InitializeCar(); 
        }


        private void button3_Click(object sender, EventArgs e)
        {
            CustomerForm form = new CustomerForm();
            form.ShowDialog();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            BodyForm1 form = new BodyForm1();
            form.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ModelForm form = new ModelForm();
            form.ShowDialog();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void butSearch_Click(object sender, EventArgs e)
        { inputSeachIndice.Visible=true;
          
            DisplayResult();
        }

        private void inputSeachIndice_ValueChanged(object sender, EventArgs e)
        {
            selectCar(DB.Search(SearchBox.Text));
        }

        private void Updatebut_Click_1(object sender, EventArgs e)
        {
            int n = inputMil.Text.Length;
            CarInfo car = new CarInfo((Model)CombModel.SelectedItem, (Carlib.Color)combColor.SelectedItem, (BodyType)comboBody.SelectedItem,
                          double.Parse(inputMil.Text.Substring(0, n - 2)), inputDate.Value, Convert.ToDecimal(inputCost.Text),
                          (GearBox)combGear.SelectedItem);
                          car.id= DB.Search(SearchBox.Text)[Convert.ToInt32(inputSeachIndice.Value)].id;
            _Car=car;
            if (DB.Search(SearchBox.Text).Count()!=0)
            {
                DB.Update(car);
                Updatebut.Enabled = true;
                List<CarInfo> cars = DB.Search(SearchBox.Text);

                dataGridView1.DataSource=cars;
                selectCar(cars);
                Updatebut.Visible=false;
            }
        }

        private void filter_SelectedIndexChanged(object sender, EventArgs e)
        {
            InitializeCar(); 
        }

        private void AddColor_Click(object sender, EventArgs e)
        {
            customerTable customerTable = new customerTable();
            customerTable.ShowDialog();
        }
    }
}
 