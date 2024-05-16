using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Carlib
{
    public class Report
    {
        public  string v;

        public Report(string message)
        {
            this.v = message;
        }

        public Report(double aVG, double sUM,int count)
        {
            AVG = aVG;
            SUM = sUM;
            COUNT = count;
        }

        public double AVG { get; set; }
        public double SUM { get; set; }
        public int COUNT { get; set; }

    }
}
