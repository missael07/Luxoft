using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeChallenge
{
    public static class CommonMethods
    {
        /// <summary>
        /// Clear the console once the minimun change was calculated.
        /// </summary>
        public static void ClearConsole()
        {
            Console.Clear();
        }

        /// <summary>
        /// Get the Price Item and Cash Received values and return the substract of those.
        /// </summary>
        /// <returns></returns>
        public static float GetPriceItemAndCashReceived()
        {
            Console.WriteLine("Enter the price item: ");
            float priceItem = float.Parse(Console.ReadLine());
            Console.WriteLine("Enter the cash received: ");
            float cashReceived = float.Parse(Console.ReadLine());

            while (cashReceived <= priceItem)
            {
                Console.WriteLine("The Money received must be greather than price item, Money Received: ");
                cashReceived = float.Parse(Console.ReadLine());
            }

            float changeToReturn = (cashReceived - priceItem);

            return changeToReturn;

        }
    }
}
