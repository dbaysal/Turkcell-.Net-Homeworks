using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_4
{
    /// <summary>
    /// IActLike Interface gives an output in type T which indicates the acting behavior as class,
    /// A generic interface with covariant parameter
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public interface IActLike< out T> where T : Parent
    {
        T Act();
    }

   
}
