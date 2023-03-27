using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_6
{
    public class ReservationOperation
    {
        private readonly Validator validator;
        public ReservationOperation(Validator validator)
        {
            //ReservationOperation class is dependent to the Validator class.
            //Instead of creating Validator object in the method I decide to get it while
            //the object is created with the constructor. (Dependency Inversion)
            this.validator = validator;
        }
        public void CreateReservation(IValidatable validatable)
        {
            validator.Validate(validatable);
        }
    }
}
