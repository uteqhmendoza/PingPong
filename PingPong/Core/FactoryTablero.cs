using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PingPong.Core
{
    public class FactoryTablero
    {
        public T CreateInstance<T>()
        {
            return (T)Activator.CreateInstance(typeof(T));
        }
    }
}
