using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2
{
    internal class NullOperations
    {
       public void PerformNullCheck()
        {
            string userName = null;

            string nullCheck = (userName == null) ? "Username is null" : userName;
            Console.WriteLine(nullCheck);

            string userName1 = null;

            string nullCoalescing = (userName1 ?== null) ? "UserName is null" : userName1;


        }
    }
}
