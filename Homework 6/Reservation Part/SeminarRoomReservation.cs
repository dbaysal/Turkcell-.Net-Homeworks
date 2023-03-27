using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_6
{
    public class SeminarRoomReservation : Reservation, IValidatable, IReservable
    {
        public int Capacity { get; set; }
        public int NumberOfPeopleForReservation { get; set; }

        public bool Validate()
        {
            return ReservationDate > DateTime.Now &&
                                                    IsReserved &&
                                                                    NumberOfPeopleForReservation <= Capacity ? true : false;
        }
        public void MakeReserved()
        {
            IsReserved = true;
        }
    }
}
