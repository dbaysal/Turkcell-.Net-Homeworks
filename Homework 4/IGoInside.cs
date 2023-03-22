using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_4
{
    /// <summary>
    /// IGoInside interface represents going into a themed place
    /// and the theme is decided by the generic parameter
    /// A generic interface with contravariant type parameter
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public interface IGoInside<in T> where T : Parent
    {
        void GoInside(T place);
    }
}
