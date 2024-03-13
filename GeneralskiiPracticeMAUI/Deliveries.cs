using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeneralskiiPracticeMAUI
{
    public partial class Deliveries
    {
        public int Delivery_Number { get; set; }
        public int Supplier_Number { get; set; }
        public int Product_Code { get; set; }
        public DateOnly Delivery_Date { get; set; }
        public int Quantity_Supplied { get; set; }
        public string Invoice_Number { get; set; }
    }
}
