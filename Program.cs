using System;
using System.Collections.Generic;

namespace OOP_CSharp_Assignment2;

    class Program
    {
        static void Main(string[] args)
        {
            int pay;
            string cardType;
            string paymentType;
            Cart cart = new Cart();
            cart.AddItem("Milk",6.7,2);
            cart.AddItem("Eggs",0.8,20);
            cart.AddItem("Bread",9,1);
            cart.DisplayCartContent();
            cart.DisplayTotalCost();
            cart.DeleteItem();
            cart.DisplayCartContent();
            cart.DisplayTotalCost();
            cart.UpdateItem();
            cart.DisplayCartContent();
            cart.DisplayTotalCost();
            Payment payment;
            while(1>0)
            {
                Console.Write("How do you want to pay, cash or card? ");
                paymentType = Console.ReadLine();
                if(string.Equals(paymentType,"Cash",StringComparison.OrdinalIgnoreCase))
                {
                        Console.WriteLine("Payment with cash processed.");
                        break;
                }
                else if(string.Equals(paymentType,"Card",StringComparison.OrdinalIgnoreCase))
                    {
                        Console.Write("What kind of card do you want to use, credit or PayPal? ");
                        cardType = Console.ReadLine();
                        if(string.Equals(cardType,"Credit",StringComparison.OrdinalIgnoreCase))
                        {
                            payment = new CreditCardPayment();
                            payment.ProcessPayment();
                            break;
                        }
                        else if(string.Equals(paymentType,"PayPal",StringComparison.OrdinalIgnoreCase))
                        {
                            payment = new PayPalPayment();
                            payment.ProcessPayment();
                            break;
                        }
                        else
                        {
                            Console.WriteLine("An error has occured when selecting card type, please try paying again.");
                        }
                    }
                else
                {
                    Console.WriteLine("An error has occured when choosin payment type, please try again.");
                }
                }

            }
        }
  //  }
