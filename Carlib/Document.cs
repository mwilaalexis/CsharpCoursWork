using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;
using Newtonsoft.Json;

namespace Carlib
{
    public class Document
    {
        //read and write from or to a file
        public string pathFile { get; set; } = @"C:\Users\HP\Documents\c# all resolt\rentCar\DataFile\";

        public Document(string Namefile)
        {
            this.pathFile = Namefile;
        }

        public Document()
        {
            this.pathFile += "saveFile.txt";
        }

        public void Save(List<Sales> objectToSave)
        {
            try
            {
                using (StreamWriter sw = new StreamWriter(this.pathFile))
                {
                    sw.Write(JsonConvert.SerializeObject(objectToSave, Newtonsoft.Json.Formatting.Indented));
                }
            }
            catch (Exception err)
            {
                Console.WriteLine(err.Message);
            }
        }


        //public void archive(Sales sales) 
        //{
        //    throw new NotImplementedException();
        //}
        //public void PrintReceipt(Sales sales)
        //{
        //    archive(sales);
        //    throw new NotImplementedException();
        //}
    }
}
