using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uebung_1
{
    class Program
    {
        #region methods
        /// <summary>
        /// Print message to console
        /// </summary>
        /// <param name="msg">Message to be printed</param>
        /// <param name="upperCase">Print in upper or lower case letters</param>
        private static void PrintMessage(String msg, bool upperCase)
        {
            if (upperCase)
            {
                msg = msg.ToUpper();
            }
            else
            {
                msg = msg.ToLower();
            }

            Console.WriteLine(msg);
        }
        #endregion

        static void Main(string[] args)
        {
            PrintMessage("Huhu", true);
            PrintMessage("Huhu", false);
            Console.Read();
        }
    }
}
