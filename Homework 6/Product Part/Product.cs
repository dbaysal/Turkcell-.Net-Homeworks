using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_6
{
    /// <summary>
    /// To extend the cases I assumed that the application both allows reservations
    /// and product buying operations
    /// </summary>
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public int Stock { get; set; }
    }
}
