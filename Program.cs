using System;
using System.Collections.Generic;
using System.Configuration;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeChallenge
{
    class Program
    {
        static void Main(string[] args)
        {
            //Get the current currency from the appsettings, It could be "US" or "MX"
            string currentCurrency = ConfigurationManager.AppSettings.Get("CurrentCurrency");

            //Create an instance of the GetMinimunChangeBillsAndCoins class an give the currentCurrency.
            GetMinimunChangeBillsAndCoins getMinimunChange = new GetMinimunChangeBillsAndCoins(currentCurrency);
            bool exit = false;
            try
            {
                //Loop the process untill the user press Escape key.
                while (!exit)
                {
                    
                    //Get the change to return value.
                    float changeToReturn = CommonMethods.GetPriceItemAndCashReceived();
                    //Call the MinimunChangeToReturn method.
                    Console.WriteLine(getMinimunChange.MinimunChangeToReturn(changeToReturn));
                    Console.ReadLine();
                    CommonMethods.ClearConsole();
                }
            }
            catch (Exception ex)
            {
                CommonMethods.ClearConsole();
                Console.WriteLine("Please Enter a valid inputs. Press any key to continue. ");                
            }
            
        }
    }
}
