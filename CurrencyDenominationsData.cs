using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeChallenge
{
    public static class CurrencyDenominationsData
    {
        /// <summary>
        /// Dictionary used to keep the currecy denominatios of each country.
        /// </summary>
        public static Dictionary<string, float[]> currenciesDenominations = new Dictionary<string, float[]>
        {
            {"US", new float[] { 100,50,20,10,5,1,.25f,.10f,.05f,.01f } },
            {"MX", new float[] { 100,50,20,10,5,2,1,.50f,.20f,.10f,.05f } }
        };
    }
}
