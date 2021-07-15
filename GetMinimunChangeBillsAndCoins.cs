using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeChallenge
{
    public class GetMinimunChangeBillsAndCoins
    {
        /// <summary>
        /// Keep the Current Currency to get the denominations. 
        /// </summary>
        public string currentCurrency { get; set; }


        public GetMinimunChangeBillsAndCoins(string curency)
        {
            currentCurrency = curency;
        }
        /// <summary>
        /// Calculates the minimun bills and coins to return to the client.
        /// </summary>
        /// <param name="currency"></param>
        /// <returns></returns>
        public string MinimunChangeToReturn(float changeToReturn)
        {
            string messageToReturn = string.Empty;
            float[] currentCurrencyDenominations;
            int totalChangeToReturn = 0;

            //Get the currency denominations by the curren currency given.
            CurrencyDenominationsData.currenciesDenominations.TryGetValue(currentCurrency, out currentCurrencyDenominations);


            if (currentCurrencyDenominations != null)
            {
                Console.WriteLine("Total Bills and/or coins to return: " + Environment.NewLine);
                //Loop the currencyDenominations array.
                for (int i = 0; i < currentCurrencyDenominations.Length; i++)
                {
                    totalChangeToReturn = 0;
                    //Validates that the change to return is greater than the current currency denomination.
                    if (changeToReturn >= currentCurrencyDenominations[i])
                    {
                        //Get the quantity of bills or coins that will be returned.
                        totalChangeToReturn = Convert.ToInt32(Math.Round(changeToReturn / currentCurrencyDenominations[i]));
                        //Discount the amount from the change to return.
                        changeToReturn = float.Parse(Math.Round(changeToReturn % currentCurrencyDenominations[i], 2).ToString());
                        //If the currency is US should validate the current currency denomination is greather or equal than 1 to count bills, or 
                        //If the currency is MX should validate the current currency denomination is greather or equal than 20 to count bills.
                        if ((currentCurrencyDenominations[i] >= 1 && currentCurrency == "US") || (currentCurrencyDenominations[i] >= 20 && currentCurrency == "MX"))
                        {
                            messageToReturn += $"Bill of {currentCurrencyDenominations[i]}: {totalChangeToReturn}";
                        }
                        else
                        {
                            messageToReturn += $"Coins of {Math.Round(currentCurrencyDenominations[i], 2)}: {totalChangeToReturn}";
                        }
                    }
                }
            }
            else
            {
                messageToReturn = "The currency denominations are not set for this currency";
            }

            return messageToReturn;

        }

    }
}
