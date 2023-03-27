using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_6
{
    /// <summary>
    /// This class is for showing not only reservations but also other classes in
    /// an application can be validatable as well.
    /// </summary>
    public class ProductSell : IValidatable
    {
        public Product DesiredProduct { get; set; }
        public int Quantity { get; set; }
        public DateTime SellDate { get; set; }

        public bool Validate()
        {
            return DesiredProduct.Stock >= Quantity ? true : false;
        }
    }
}
