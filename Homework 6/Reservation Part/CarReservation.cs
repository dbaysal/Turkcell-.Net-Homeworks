using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_6
{
    public class CarReservation : Reservation, IValidatable, IReservable
    {
        public string PlateNumber { get; set; }
        public string Brand { get; set; }
        public long Kilometers { get; set; }
        public bool Validate()
        {
            return ReservationDate > DateTime.Now && IsReserved ? true : false;
            
        }
        public void MakeReserved()
        {
            IsReserved = true;
        }
    }
}
