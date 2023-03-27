using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_6
{
    public class HotelRoomReservation : Reservation, IValidatable, IReservable
    {
        public string RoomNumber { get; set; }
        public string Size { get; set; }

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
