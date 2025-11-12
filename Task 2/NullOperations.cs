using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2
{
    internal class NullOperations
    {
        public void PerformNullChecks()
        {
            // Declare a string variable and assign null
            string username = null;

            // 1. Using the Ternary Operator (? :)
            string ternaryCheck = (username == null) ? "Username is not available" : username;
            Console.WriteLine(ternaryCheck);

            // 2. Using the Null-Coalescing Operator (??)
            Console.WriteLine(username ?? "Username is not available (using ??)");

            // 3. Using the Null-Coalescing Assignment Operator (??=)
            username ??= "DefaultUser";
            Console.WriteLine("Updated username after ??=: " + username);
        }
    }
}
