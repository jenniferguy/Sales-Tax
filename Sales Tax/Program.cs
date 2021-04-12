using System;

namespace Sales_Tax
{
    class Program
    {
        static void Main(string[] args)
        {

            //DECLARE THE VARIABLES

            double purchaseAmt      = 0.0;
            double stateTax         = 0.04;
            double countyTax        = 0.02;
            double total_State_Tax  = 0.0;
            double total_County_Tax = 0.0;
            double total_Taxes_Due  = 0.0;
            double total_Amt_Due    = 0.0;
            

            //INPUT-WHAT I NEED TO KNOW

            Console.Write(" Please enter the amount of the purchase:  ");
            purchaseAmt = double.Parse (Console.ReadLine());
            Console.WriteLine();

            //CALCULATE THE TOTAL SALES TAX AMOUNTS

            total_State_Tax  = purchaseAmt * stateTax;

            total_County_Tax = purchaseAmt * countyTax;

            total_Taxes_Due = total_State_Tax + total_County_Tax;

            //CALCULATE THE TOTAL AMOUNT DUE

            total_Amt_Due = purchaseAmt + total_State_Tax + total_County_Tax;
            Console.WriteLine();


            //OUTPUT-WHAT I WANT THE CUSTOMER TO SEE

            Console.Write(" The amount of your purchase is {0:C}", purchaseAmt);
            Console.WriteLine();
            Console.WriteLine();
            Console.Write(" The total state tax due is   {0:C}",  total_State_Tax);
            Console.WriteLine();
            Console.WriteLine();
            Console.Write(" The total county tax due is {0:C}" ,total_County_Tax);
            Console.WriteLine();
            Console.WriteLine();
            Console.Write(" Total amount of taxes paid is {0:C} ", total_Taxes_Due);
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("-----------------------------------------------");
            Console.WriteLine();
            Console.Write(" The total amount due is  {0:C} ", total_Amt_Due);

            //KEEPS THE WINDOW OPEN UNTIL A KEY IS PRESSED
            Console.ReadKey();








        }
    }
}
