using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atm_Withdraw
{
    class atm
    {
       static int fifty_bills(int val){
         int remainder=0;
         int bill_count=0;
         while(val>= 50){
                remainder = val / 50;
                 bill_count++;
                 val = val - 50;
                //Console.WriteLine(remainder + "< " + val);

            } // end of loop
            Console.WriteLine("you have " + bill_count + " $50.00 bills");
            return val;
         }// end of 50 function

       static int twenty_bills(int val)
       {
           int remainder = 0;
           int bill_count = 0;
           while (val >= 20)
           {
               remainder = val / 20;
               bill_count++;
               val = val -20;
               //Console.WriteLine(remainder + "< " + val);

           } // end of loop
           Console.WriteLine("you have " + bill_count + " $20.00 bills");
           return val;
       }// end of 20 function
       static int ten_bills(int val)
       {
           int remainder = 0;
           int bill_count = 0;
           while (val >= 10)
           {
               remainder = val / 10;
               bill_count++;
               val = val - 10;
               //Console.WriteLine(remainder + "< " + val);

           } // end of loop
           Console.WriteLine("you have " + bill_count + " $10.00 bills");
           return val;
       }// end of ten function
       static int five_bills(int val)
       {
           int remainder = 0;
           int bill_count = 0;
           while (val >= 5)
           {
               remainder = val / 5;
               bill_count++;
               val = val - 5;

           } // end of loop
           Console.WriteLine("you have " + bill_count + " $5.00 bills");
           return val;
       }// end of 5 function

       static int one_bills(int val)
       {
           int remainder = 0;
           int bill_count = 0;
           while (val >= 1)
           {
               remainder = val / 1;
               bill_count++;
               val = val - 1;

           } // end of loop

           Console.WriteLine("you have " + bill_count + " $1.00 bills");
           return val;
       }// end of function
        static void Main(string[] args)
        {
            string input;
            string opt = "y";
            // int bill_count=0 , remainder=0;
            atm obj= new atm();
            do{
                int amount;
                Console.WriteLine("Please Enter the valid Amount ");
                amount=int.Parse(Console.ReadLine());
                if (amount > 0 && amount <= 300)
                {
                    Console.WriteLine(amount);
                    if (amount >= 50  ) {
                        amount=fifty_bills(amount);// calling function
                        
                    }
                    if (amount >= 20)
                    {
                        amount = twenty_bills(amount);// calling function

                    }
                    if (amount >= 10)
                    {
                        amount = ten_bills(amount);// calling function
                    }
                     if (amount >= 5)
                    {
                        amount = five_bills(amount);// calling function
                    }

                     if (amount >=1 )
                     {
                         amount = one_bills(amount);// calling function
                     }
                 
                }
                else // validate the withdraw amount.....
                {
                    if(amount > 300)
                    Console.WriteLine("It is not a valid amount, Enter amount less than 300 ");
                    else if (amount == 0)
                    Console.WriteLine("It is not a valid amount, Enter amount greater than zero ");
                    else
                    Console.WriteLine("It is not a valid amount, Enter valid amount ");
                }
              

            Console.WriteLine("Another Withdrawal? Enter y to continue ");
            input= Console.ReadLine();
           } while (string.Compare(opt,input)==0);
            Console.ReadKey();
        }
    }
}
