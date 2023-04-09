using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_6
{
    /// <summary>
    /// Reservation parent object only keeps common details of reservation types
    /// Rather than defining Validate method in here I will use an interface because;
    /// 1. Eventhough both car and hotel reservation validation seminar reservation is a special case.
    /// 2. To be more flexible about the validate method (Another classes can be validatable as well).
    /// </summary>
    public abstract class Reservation
    {
        public DateTime ReservationDate { get; set; }
        public int NumberOfDays { get; set; }
        public bool IsReserved { get; set; }
        
    }
}
