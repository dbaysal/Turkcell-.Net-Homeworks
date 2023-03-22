using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_4
{
    /// <summary>
    /// A simple class to implement related interfaces
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class Implementer<T> : IActLike<T>, IGoInside<T> where T : Parent, new()
    {
        public T Act()
        {
            return new T();
        }

        public void GoInside(T place)
        {
            
        }
    }
}
