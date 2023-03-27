using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_6
{
    public interface IValidatable
    {
        bool Validate();
        //void Reserved();   This method is not included in the interface because
        //                   ProductSell class is also a validatable class but
        //                   Reserved is not applicable. A new interface is needed (Interface Segregation)
    }
}
