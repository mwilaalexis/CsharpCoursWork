
using System;
using System.Windows.Forms;

using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Xml.Linq;
using System.Net.Cache;
using System.Security.Cryptography;
using System.Reflection;
using System.Runtime.ConstrainedExecution;

namespace Carlib
{
    public class ORM
    {
        private static string cnnString = ConfigurationManager.ConnectionStrings["BestSale.Properties.Settings.SaleCarDBConnectionString"].ToString();
        private SqlConnection cnn = new SqlConnection(cnnString);
      

        public List<Brand> GetBrands()
        {
            List<Brand> Brands = new List<Brand>();
            cnn.Open();
            string Request = "select * from dbo.Brand";
            SqlCommand cmd = new SqlCommand(Request, cnn);
            SqlDataReader Reader = cmd.ExecuteReader();
            if (Reader.HasRows)
            {
                while (Reader.Read())
                {
                    Brand Brand = new Brand(Reader.GetInt32(0), Reader.GetString(1));
                    Brands.Add(Brand);
                }
            }
            cnn.Close();
            return Brands;
        }
        public List<BodyType> GetBodies()
        {
            List<BodyType> Bodies = new List<BodyType>();
            cnn.Open();
            string Request = "select * from dbo.BodyType_ ";
            SqlCommand cmd = new SqlCommand(Request, cnn);
            SqlDataReader Reader = cmd.ExecuteReader();
            if (Reader.HasRows)
            {
                while (Reader.Read())
                {
                    BodyType body = new BodyType(Reader.GetInt32(0), Reader.GetString(1));
                    Bodies.Add(body);
                }
            }
            cnn.Close();
            return Bodies;

        }
        public List<CarInfo> GetCarInfos(string OrderBy)
        {
            List<CarInfo> Cars = new List<CarInfo>();
            cnn.Open();
            string Request = "select c.Id,bd.ID,bd.name,cl.id,cl.name,m.Id,m.name,b.name,b.ID,c.mileage,c.FabYear,g.name" +
                ",g.Id,c.Cost from dbo.CarInfo c\r\ninner join BodyType_ bd " +
                "on c.BodyID = bd.ID\r\ninner join Color cl on c.ColorID = cl.ID\r\n" +
                "inner join Model m on c.ModelID = m.Id\r\ninner join [Gear Box] g on c.GearBoxID =g.Id\r\n" +
                "inner join Brand b on m.BrandID= b.ID\r\n ORDER BY @order ";
           
            SqlCommand cmd = new SqlCommand(Request, cnn);
            cmd.Parameters.AddWithValue("order", OrderBy);
            SqlDataReader Reader = cmd.ExecuteReader();
            if (Reader.HasRows)
            {
                while (Reader.Read())
                {
                    CarInfo Car = new CarInfo(Reader.GetInt32(0),
                    new Model(Reader.GetInt32(5), Reader.GetString(6), new Brand(Reader.GetInt32(8), Reader.GetString(7))),
                    new Color(Reader.GetInt32(3), Reader.GetString(4)),
                    new BodyType(Reader.GetInt32(1), Reader.GetString(2)),
                    Reader.GetDouble(9), Reader.GetDateTime(10), Reader.GetDecimal(13),
                    new GearBox(Reader.GetInt32(12), Reader.GetString(11)));
                    Cars.Add(Car);

                }
            }
            cnn.Close();
            return Cars;
        }
        public List<Color> GetColors()
        {
            List<Color> Colors = new List<Color>();
            cnn.Open();
            string Request = "select * from dbo.Color";
            SqlCommand cmd = new SqlCommand(Request, cnn);
            SqlDataReader Reader = cmd.ExecuteReader();
            if (Reader.HasRows)
            {
                while (Reader.Read())
                {
                    Color Color = new Color(Reader.GetInt32(0), Reader.GetString(1));
                    Colors.Add(Color);
                }
            }
            cnn.Close();
            return Colors;
        }
        public List<GearBox> GetGearBoxes()
        {
            List<GearBox> gearBoxes = new List<GearBox>();
            cnn.Open();
            string Request = "select * from [Gear box]";
            SqlCommand cmd = new SqlCommand(Request, cnn);
            SqlDataReader Reader = cmd.ExecuteReader();
            if (Reader.HasRows)
            {
                while (Reader.Read())
                {
                    GearBox gearBox = new GearBox(Reader.GetInt32(0), Reader.GetString(1));
                    gearBoxes.Add(gearBox);
                }
            }
            cnn.Close();
            return gearBoxes;
        }
        public List<Customer> GetCustomer()
        {
            List<Customer> Customers = new List<Customer>();
            cnn.Open();
            string Request = "select * from dbo.Customer_";
            SqlCommand cmd = new SqlCommand(Request, cnn);
            SqlDataReader Reader = cmd.ExecuteReader();
            if (Reader.HasRows)
            {
                while (Reader.Read())
                {
                    Customer customer = new Customer(Reader.GetInt32(0), Reader.GetString(1), Reader.GetString(2));
                    Customers.Add(customer);
                }
            }
            cnn.Close();
            
            return Customers;
        }
        public List<Model> GetModels()
        {
            List<Model> Models = new List<Model>();
            cnn.Open();
            string Request = "select m.Id,m.name,b.id,b.Name from dbo.Brand b\r\ninner join Model m on m.BrandID=b.id";
            SqlCommand cmd = new SqlCommand(Request, cnn);
            SqlDataReader Reader = cmd.ExecuteReader();
            if (Reader.HasRows)
            {
                while (Reader.Read())
                {
                    Model model = new Model(Reader.GetInt32(0), Reader.GetString(1),
                        new Brand(Reader.GetInt32(2), Reader.GetString(3)));
                    Models.Add(model);
                }
            }
            cnn.Close();
            return Models;
        }
        public List<Sales> GetSales()
        {
            List<Sales> Sales = new List<Sales>();
            cnn.Open();
            string Request = "select clt.ID,clt.last_name,clt.frist_name, c.Id,bd.ID,bd.name,cl.id,cl.name,m.Id,m.name,b.name" +
                ",b.ID,c.mileage,c.FabYear,g.name,g.Id,c.Cost,s.Price,s.Id from dbo.Sale_ s" +
                "\r\ninner join Customer clt on s.CustomerID=clt.ID\r\ninner join CarInfo c on s.CarID=c.Id" +
                "\r\ninner join BodyType_ bd on c.BodyID = bd.ID\r\ninner join Color cl on c.ColorID = cl.ID" +
                "\r\ninner join Model m on c.ModelID = m.Id\r\ninner join [Gear Box] g on c.GearBoxID =g.Id" +
                "\r\ninner join Brand b on m.BrandID= b.ID\r\n";
            SqlCommand cmd = new SqlCommand(Request, cnn);
            SqlDataReader Reader = cmd.ExecuteReader();
            if (Reader.HasRows)
            {
                while (Reader.Read())
                {
                    Sales sales = new Sales(Reader.GetInt32(20),
                        new CarInfo(Reader.GetInt32(0),
                        new Model(Reader.GetInt32(5), Reader.GetString(6), new Brand(Reader.GetInt32(8), Reader.GetString(7))),
                        new Color(Reader.GetInt32(3), Reader.GetString(4)),
                        new BodyType(Reader.GetInt32(1), Reader.GetString(2)),
                        Reader.GetFloat(9), Reader.GetDateTime(10), Reader.GetDecimal(13),
                        new GearBox(Reader.GetInt32(12), Reader.GetString(11))),
                        Reader.GetDecimal(19), Reader.GetDateTime(20),
                        new Customer(Reader.GetInt32(1), Reader.GetString(2), Reader.GetString(3)));
                    Sales.Add(sales);
                }
            }
            cnn.Close();
            return Sales;
        }




        public void Delete(CarInfo car)
        {
            using (SqlConnection cnn = new SqlConnection(cnnString))
            {
                cnn.Open();
                string sql = "Delete from dbo.CarInfo where CarInfo.Id=@id";
                ;
                SqlCommand cmd = new SqlCommand(sql, cnn);

                SqlParameter idParameter = new SqlParameter("@id", car.id);

                cmd.Parameters.Add(idParameter);

                cmd.ExecuteNonQuery();
                //cnn.Close();

            }
        }
        public void Delete(Brand brand)
        {
            
            cnn.Open();
            string sql = "Delete from dbo.Brand b where b.name=@name ";
            SqlCommand cmd = new SqlCommand(sql, cnn);
            SqlParameter nameParametr = new SqlParameter("@name", brand.Name);


            cmd.Parameters.Add(nameParametr);
            cmd.ExecuteNonQuery();
            cnn.Close();
            
        }
        public void Delete(Sales sales)
        {
            cnn.Open();
            string request = "Delete from dbo.Sale_ where id=@id";
            SqlCommand cmd = new SqlCommand(request, cnn);
            SqlParameter idParametr = new SqlParameter("@id", sales.Id);
            cmd.Parameters.Add(idParametr);
            cnn.Close();
        }
        public void Delete(Customer customer)
        {
            cnn.Open();
            string sql = "Delete from dbo.Customer_  where firstName=@Firstname and LastName= @Lastname";
            SqlCommand cmd = new SqlCommand(sql, cnn);
            SqlParameter nameParametr = new SqlParameter("@Firstname", customer.FirstName);
            SqlParameter LastNameParametr = new SqlParameter("@Lastname", customer.LastName);
      

            cmd.Parameters.Add(nameParametr);
            cmd.Parameters.Add(LastNameParametr);
    
            cmd.ExecuteNonQuery();
            cnn.Close();

        }
        public void Delete(Model model)
        {
            using (SqlConnection cnn = new SqlConnection(cnnString))
            {
                cnn.Open();
                string sql = "Delete from dbo.Model where id=@id";
                SqlCommand cmd = new SqlCommand(sql, cnn);
                SqlParameter nameParametr = new SqlParameter("@name", model.Name);
                SqlParameter BrandParametr = new SqlParameter("@BrandId", model.Brand.ID);
                SqlParameter idParametr = new SqlParameter("@id", model.ID);

                cmd.Parameters.Add(nameParametr);
                cmd.Parameters.Add(BrandParametr);
                cmd.Parameters.Add(idParametr);
                cmd.ExecuteNonQuery();

            }
        }
        public void Delete(BodyType body)
        {
            cnn.Open();
            string sql = "Delete from dbo.Brand where name=name) ";
            SqlCommand cmd = new SqlCommand(sql, cnn);
            SqlParameter nameParametr = new SqlParameter("@name", body.Name);


            cmd.Parameters.Add(nameParametr);
            cmd.ExecuteNonQuery();
            cnn.Close();
        }


        public void Insert(CarInfo car)
        {
            using (SqlConnection cnn = new SqlConnection(cnnString))
            {
                cnn.Open();
                string sql = "insert into dbo.CarInfo(ModelID, mileage,FabYear,BodyID,ColorID,Cost,GearBoxID)" +
                    " values(@ModelID,@mileage,@FabYear,@BodyID,@ColorID,@Cost,@GearBoxID)";
                SqlCommand cmd = new SqlCommand(sql, cnn);
                SqlParameter ModelParameter = new SqlParameter("@ModelID", car.Model.ID);
                SqlParameter ColorParameter = new SqlParameter("@ColorID", car.Color.ID);
                SqlParameter FabYearParameter = new SqlParameter("@FabYear", car.FabDate);
                SqlParameter BodyParameter = new SqlParameter("@BodyID", car.Body.ID);
                SqlParameter CostParameter = new SqlParameter("@Cost", car.Cost);
                SqlParameter mileageParameter = new SqlParameter("@mileage", car.mileage);
                SqlParameter GearParameter = new SqlParameter("@GearBoxID", car.GearBox.ID);
                //   SqlParameter idParameter = new SqlParameter("@id", car.id);

                cmd.Parameters.Add(ModelParameter);
                cmd.Parameters.Add(ColorParameter);
                cmd.Parameters.Add(FabYearParameter);
                cmd.Parameters.Add(BodyParameter);
                cmd.Parameters.Add(CostParameter);
                cmd.Parameters.Add(mileageParameter);
                cmd.Parameters.Add(GearParameter);
                //   cmd.Parameters.Add(idParameter);

                cmd.ExecuteNonQuery();
                cnn.Close();

            }
        }
        public void Insert(Sales sale)
        {
            
            cnn.Open();
            string sql = "insert into dbo.Sale_(CarID,CustomeID,Price,Date_Sale)  values(@car,@customer,@Price,@Date) ";
            SqlCommand cmd = new SqlCommand(sql, cnn);
            SqlParameter CarParametr = new SqlParameter("@car", sale.Car.id);
            SqlParameter CustomerParametr = new SqlParameter("@customer", sale.Customer.Id);
            SqlParameter PriceParametr = new SqlParameter("@Price", sale.Price);
            //SqlParameter idParametr = new SqlParameter("@id", sale.Id);
            SqlParameter DateParametr = new SqlParameter("@Date", sale.Date);

            cmd.Parameters.Add(CarParametr);
            cmd.Parameters.Add(CustomerParametr);
           // cmd.Parameters.Add(idParametr);
            cmd.Parameters.Add(PriceParametr);
            cmd.Parameters.Add(DateParametr);
            cmd.ExecuteNonQuery();
            cnn.Close();
            
        }
        public void Insert(Model model)
        {
            cnn.Open();
            string sql = "";
            SqlCommand cmd = new SqlCommand(sql, cnn);
            SqlParameter nameParametr = new SqlParameter("@name", model.Name);
            SqlParameter BrandParametr = new SqlParameter("@BrandId", model.Brand.ID);
            SqlParameter idParametr = new SqlParameter("@id", model.ID);

            cmd.Parameters.Add(nameParametr);
            cmd.Parameters.Add(BrandParametr);
            cmd.Parameters.Add(idParametr);
            cnn.Close();
            
        }
        public void Insert(Brand brand)
        {
            cnn.Open();
            string sql = "insert into dbo.Brand(name) values (@name) ";
            SqlCommand cmd = new SqlCommand(sql, cnn);
            SqlParameter nameParametr = new SqlParameter("@name", brand.Name);
            cmd.Parameters.Add(nameParametr);
            cmd.ExecuteNonQuery();
            cnn.Close();

        }
        public void Insert(Customer customer)
        {
             cnn.Open();
            string sql = "insert into dbo.Customer_ values(@Firstname,@Lastname)";
            SqlCommand cmd = new SqlCommand(sql, cnn);
            SqlParameter nameParametr = new SqlParameter("@Firstname", customer.FirstName);
            SqlParameter LastNameParametr = new SqlParameter("@Lastname", customer.LastName);

            cmd.Parameters.Add(nameParametr);
            cmd.Parameters.Add(LastNameParametr);
            cmd.ExecuteNonQuery();
            cnn.Close();
            
        }


        public List<CarInfo> Search(string keyWord)
        {
            List<CarInfo> Cars = new List<CarInfo>();
            cnn.Open();
            string Request = "select c.Id,bd.ID,bd.name,cl.id,cl.name,m.Id,m.name,b.name,b.ID,c.mileage,c.FabYear,g.name" +
            ",g.Id,c.Cost from dbo.CarInfo c\r\ninner join BodyType_ bd " +
            "on c.BodyID = bd.ID\r\ninner join Color cl on c.ColorID = cl.ID\r\n" +
            "inner join Model m on c.ModelID = m.Id\r\ninner join [Gear Box] g on c.GearBoxID =g.Id\r\n" +
            "inner join Brand b on m.BrandID= b.ID\r\n" +
            $"where b.name=@brand or m.name=@brand ";
         
            SqlCommand cmd = new SqlCommand(Request, cnn);
            SqlParameter nameParameter = new SqlParameter("@brand", keyWord);
            cmd.Parameters.Add(nameParameter);
            SqlDataReader Reader = cmd.ExecuteReader();
            CarInfo Car = null;

            if (Reader.HasRows)
            {
                while (Reader.Read())
                {
                    Car = new CarInfo(Reader.GetInt32(0),
                    new Model(Reader.GetInt32(5), Reader.GetString(6), new Brand(Reader.GetInt32(8), Reader.GetString(7))),
                    new Color(Reader.GetInt32(3), Reader.GetString(4)),
                    new BodyType(Reader.GetInt32(1), Reader.GetString(2)),
                    Reader.GetDouble(9), Reader.GetDateTime(10), Reader.GetDecimal(13),
                    new GearBox(Reader.GetInt32(12), Reader.GetString(11))
                    );
                    Cars.Add(Car);

                }


            }
            cnn.Close();
            return Cars;
            

        }

        public void Update(CarInfo car)
        {
        
            cnn.Open();
            string sql = "Update dbo.CarInfo set ModelID = @ModelID, mileage = @mileage ,FabYear = @FabYear, BodyID = @BodyID, ColorID = @ColorID, Cost = @Cost, GearBoxID = @GearBoxID where Id = @id";
            SqlCommand cmd = new SqlCommand(sql, cnn);
            SqlParameter ModelParameter = new SqlParameter("@ModelID", car.Model.ID);
            SqlParameter ColorParameter = new SqlParameter("@ColorID", car.Color.ID);
            SqlParameter FabYearParameter = new SqlParameter("@FabYear", car.FabDate);
            SqlParameter BodyParameter = new SqlParameter("@BodyID", car.Body.ID);
            SqlParameter CostParameter = new SqlParameter("@Cost", car.Cost);
            SqlParameter mileageParameter = new SqlParameter("@mileage", car.mileage);
            SqlParameter GearParameter = new SqlParameter("@GearBoxID", car.GearBox.ID);
            SqlParameter idParameter = new SqlParameter("@id", car.id);

            cmd.Parameters.Add(ModelParameter);
            cmd.Parameters.Add(ColorParameter);
            cmd.Parameters.Add(FabYearParameter);
            cmd.Parameters.Add(BodyParameter);
            cmd.Parameters.Add(CostParameter);
            cmd.Parameters.Add(mileageParameter);
            cmd.Parameters.Add(GearParameter);
            cmd.Parameters.Add(idParameter);

            cmd.ExecuteNonQuery();
            cnn.Close();

            
        }     
        public void Update(Sales sale)
        {

            cnn.Open();
            string sql = " update ";
            SqlCommand cmd = new SqlCommand(sql, cnn);
            SqlParameter CarParametr = new SqlParameter("@Car", sale.Car.id);
            SqlParameter CustomerParametr = new SqlParameter("@Customer", sale.Customer.Id);
            SqlParameter PriceParametr = new SqlParameter("@Price", sale.Price);
            SqlParameter idParametr = new SqlParameter("@id", sale.Id);
            SqlParameter DateParametr = new SqlParameter("@Date", sale.Date);

            cmd.Parameters.Add(CarParametr);
            cmd.Parameters.Add(CustomerParametr);
            cmd.Parameters.Add(idParametr);
            cmd.Parameters.Add(PriceParametr);
            cmd.Parameters.Add(DateParametr);
            cmd.ExecuteNonQuery();
            cnn.Close();

        }
        public void Update(Model model)
        {
            cnn.Open();
            string sql = "update dbo.Model set name=@name where id=@id";
            SqlCommand cmd = new SqlCommand(sql, cnn);
            SqlParameter nameParametr = new SqlParameter("@name", model.Name);
            SqlParameter BrandParametr = new SqlParameter("@Brand", model.Brand.ID);
            SqlParameter idParametr = new SqlParameter("@id", model.ID);

            cmd.Parameters.Add(nameParametr);
            cmd.Parameters.Add(BrandParametr);
            cmd.Parameters.Add(idParametr);
            cnn.Close();

        }
        public void Update(Brand brand)
        {
            cnn.Open();
            string sql = "update dbo.Brand set name= @name where id=@id ";
            SqlCommand cmd = new SqlCommand(sql, cnn);
            SqlParameter nameParametr = new SqlParameter("@name", brand.Name);
            SqlParameter idParametr = new SqlParameter("@id", brand.ID);
            cmd.Parameters.Add(nameParametr);
            cmd.Parameters.Add(idParametr);
            cmd.ExecuteNonQuery();
            cnn.Close();

        }
        public void Update(Customer customer)
        {
            cnn.Open();
            string sql = "update dbo.Customer_  set firstName=@Firstname,Lastname=@Lastname where ID=@id ";
            SqlCommand cmd = new SqlCommand(sql, cnn);
            SqlParameter nameParametr = new SqlParameter("@Firstname", customer.FirstName);
            SqlParameter LastNameParametr = new SqlParameter("@Lastname", customer.LastName);
            SqlParameter idParametr = new SqlParameter("@id", customer.Id);

            cmd.Parameters.Add(nameParametr);
            cmd.Parameters.Add(LastNameParametr);
            cmd.Parameters.Add(idParametr);
            cmd.ExecuteNonQuery();
            cnn.Close();

        }

     
        public Exception GetException()
        {
            try
            {
                cnn.Open();
                cnn.Close();
                Exception exception = new Exception("All rigth");
                return exception;
            }
            catch(Exception ex)
            {
                return ex;
            }
        }

        public List<Sales> GetReport(DateTime date1,DateTime date2)
        {
            List<Sales> Sales = new List<Sales>();
            cnn.Open();
            string Request = @"
                            select 
	                        s.id,c.Id,m.Id,m.name,b.ID,b.name,
	                        cl.id,cl.name,bd.ID,bd.name,c.mileage,
	                        c.FabYear,c.Cost,g.Id,g.name,
	                        s.Price,s.Date_Sale,
	                        clt.ID,
	                        clt.LastName,
	                        clt.firstName
	                         from dbo.Sale_ s

                        left join Customer_ clt on s.CustomeID=clt.ID
                        left join CarInfo c on s.CarID=c.Id
                        left join BodyType_ bd on c.BodyID = bd.ID
                        left join Color cl on c.ColorID = cl.ID
                        left join Model m on c.ModelID = m.Id
                        left join [Gear Box] g on c.GearBoxID =g.Id
                        left join Brand b on m.BrandID= b.ID
                        where s.Date_Sale between @date1 and @date2";
                        
          
            SqlCommand cmd = new SqlCommand(Request, cnn);
            cmd.Parameters.AddWithValue("date1", date1);
            cmd.Parameters.AddWithValue("date2", date2);
         

            SqlDataReader Reader = cmd.ExecuteReader();
            if (Reader.HasRows)
            {
                while (Reader.Read())
                {
                    Color color =new Color(Reader.GetInt32(6), Reader.GetString(7));
                    Model model = new Model(Reader.GetInt32(2), Reader.GetString(3), new Brand(Reader.GetInt32(4), Reader.GetString(5)));
                    BodyType body = new BodyType(Reader.GetInt32(8), Reader.GetString(9));
                    GearBox gear = new GearBox(Reader.GetInt32(13), Reader.GetString(14));
                    double mileager = Reader.GetDouble(10);

                    CarInfo car = new CarInfo(Reader.GetInt32(1),model,color,body, mileager,
                    Reader.GetDateTime(11), Reader.GetDecimal(12), gear);
                    Customer clt =new Customer(Reader.GetInt32(17), Reader.GetString(18), Reader.GetString(19));

                    Sales sales = new Sales(Reader.GetInt32(0), car,
                    Reader.GetDecimal(15), Reader.GetDateTime(16), clt);
                    Sales.Add(sales);
                }
            }
            cnn.Close();
            return Sales;

        }
        public List<Customer> searchCst(string text)
        {
            List<Customer> Customers = new List<Customer>();
            cnn.Open();
            string Request = "select * from dbo.Customer_ c where c.Firstname=@Firstname or c.Lastname=@Lastname ";
            SqlCommand cmd = new SqlCommand(Request, cnn);
            SqlParameter nameParametr = new SqlParameter("@Firstname", text);
            SqlParameter LastNameParametr = new SqlParameter("@Lastname", text);
            cmd.Parameters.Add(nameParametr);
            cmd.Parameters.Add(LastNameParametr);
            SqlDataReader Reader = cmd.ExecuteReader();
            if (Reader.HasRows)
            {
                while (Reader.Read())
                {
                    Customer customer = new Customer(Reader.GetInt32(0), Reader.GetString(1), Reader.GetString(2));
                    Customers.Add(customer);
                }
            }
            cnn.Close();

            return Customers;
        }

        //public double AVG(DateTime date1, DateTime date2)
        //{
        //    double average;
        //    cnn.Open();
        //    string Request = "select AVG(Price) from dbo.Sale_ s where s.Date_Sale  between @date1 and @date2";
        //    SqlCommand cmd = new SqlCommand(Request, cnn);
        //    cmd.Parameters.AddWithValue("date1", date1);
        //    cmd.Parameters.AddWithValue("date2", date2);
        //    SqlDataReader Reader = cmd.ExecuteReader();

        //    average = Reader.GetDouble(0);
        //    return average;
        //}

        public Report AVG(DateTime date1, DateTime date2)
        {
           
                cnn.Open();
                string query = @"SELECT AVG(Price),SUM(Price),COUNT(*) FROM dbo.Sale_ WHERE Date_Sale BETWEEN @date1 AND @date2";

            using (SqlCommand cmd = new SqlCommand(query, cnn))
            {
                cmd.Parameters.AddWithValue("date1", date1);
                cmd.Parameters.AddWithValue("date2", date2);
       
                object Reader = cmd.ExecuteScalar();

                if (Reader != null)
                {
                    return (Report)Reader;   
                }
                else { return new Report("the table is empty"); }
            }
            
          
           
        }


    }
}
