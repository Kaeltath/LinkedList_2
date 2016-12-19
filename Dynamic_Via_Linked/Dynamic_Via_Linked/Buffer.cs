using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dynamic_Via_Linked
{
    abstract class Buffer<T>
    {
        
        protected int counter = 0;        
                
        

        public bool IsEmpty()
        {
            if (counter == 0)
            {
                return true;
            }

            return false;
        }        
    }
}
