using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary.Core.Models
{
    public class car
    {
        public string Carname { get; set; }
        public string Carmodel { get; set; }
        public string Cartype { get; set; }
        public string Carcolor { get; set; }

        public car(string carname, string carmodel, string cartype, string carcolor)
        {
            Carname = carname;
            Carmodel = carmodel;
            Cartype = cartype;
            Carcolor = carcolor;
        }
    }

}
