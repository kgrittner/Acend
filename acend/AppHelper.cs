using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace acend
{
    public static class AppHelper
    {
        public static void DisplayOptions()
        {
            Console.WriteLine($"[{AppConst.SALES}] Enter sale, [{AppConst.REPORT}] Output Sales, [{AppConst.QUIT}]  Quit");
        }

        public static decimal ValidateCurrency(string number)
        {
            decimal num;
            bool isValid = decimal.TryParse(number,
            NumberStyles.Currency,
            CultureInfo.GetCultureInfo("en-US"), // cached
            out num);

            return num;
        }


    }
}
