using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using business;

namespace acend
{
    class Program
    {
        static void Main(string[] args)
        {
            bool mainLoop = true;

            while (mainLoop)
            {
                try
                {
                    AppHelper.DisplayOptions();

                    switch (Console.ReadLine())
                    {
                        case AppConst.SALES:
                            SaleHelper.AskForInfo();
                            break;
                        case AppConst.REPORT:
                            SaleHelper.Report();
                            break;
                        case AppConst.QUIT:
                            mainLoop = false;
                            break;
                        default:
                            Console.WriteLine("That is not an option");
                            break;
                    }
                }
                catch (Exception e)
                {
                    throw;
                }
                




            }


        }
    }
}
