using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeneralskiiPracticeMAUI
{
    public partial class Products
    {
        public int Product_Code { get; set; }
        public string Product_Name { get; set; }
        public int Quantity_In_Stock { get; set; }
        public string Unit_of_Measurement { get; set; }
        public decimal Unit_Price { get; set;}
        public string Description { get; set; }
    }
}
