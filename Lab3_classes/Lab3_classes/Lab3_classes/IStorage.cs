using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3_classes
{
    internal interface IStorage<T>
    {

        public bool ReserveStock(float capacity);
        public void FreeUpStock();
    }
}
