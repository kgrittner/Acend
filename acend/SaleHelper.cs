using business;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace acend
{
    public static class SaleHelper
    {

        public static void AskForInfo()
        {
            var sale = new Sale();
            Console.WriteLine("Enter the sale amount");
            sale.SaleAmount = AppHelper.ValidateCurrency(Console.ReadLine());
            sale.EntryDate = DateTime.Now;

            Console.WriteLine("Enter the state code");
            State state = State.RetrieveByCode(Console.ReadLine());

            sale.TaxRate = state == default(State) ? SaleConst.DEFAULT_TAX_RATE : state.TaxRate;
            sale.StateCode = state == default(State) ? "WI" : state.StateCode;


            sale.TotalAmount = (sale.SaleAmount * sale.TaxRate) + sale.SaleAmount;

            sale.AddOrUpdate();

        }


        public static void Report()
        {
            foreach (Sale s in Sale.RetrieveAll().OrderBy(x=> x.EntryDate).ToList())
            {
                Console.WriteLine($"EntryDate: {s.EntryDate:dd/MM/yyyy hh:mm}, Sale Amount: {s.SaleAmount:C}, Total: {s.TotalAmount:C}, Tax: {s.TaxRate:C}, State: {s.StateCode}");
            }
        }








    }
}
