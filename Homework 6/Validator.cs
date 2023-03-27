using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace Homework_6
{
    /// <summary>
    /// Class for validating and reserving(if applicable) a validatable or reservable class.
    /// </summary>
    public class Validator
    {
        public bool Validate(IValidatable validatable)
        {
            bool isValid = validatable.Validate();
            if(validatable is IReservable && isValid)
            {
                IReservable reservable = (IReservable)validatable;
                reservable.MakeReserved();
                return isValid;
            }
            return isValid;
            
        }
    }
}
