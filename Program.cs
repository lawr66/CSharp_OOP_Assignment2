using System;
using System.Collections.Generic;

namespace OOP_CSharp_Assignment2;

    class Program
    {
        static void Main(string[] args)
        {
            Cart cart = new Cart();
            cart.AddItem("Milk",6.7,2);
            cart.AddItem("Eggs",0.8,20);
            cart.AddItem("Bread",9,1);
            cart.DisplayCartContent();
            cart.DisplayTotalCost();
            cart.DeleteItem(1);
            cart.DisplayCartContent();
            cart.DisplayTotalCost();
            cart.UpdateItem(0);
            cart.DisplayCartContent();
            cart.DisplayTotalCost();
            List<Payment> payments = new List<Payment> {new CreditCardPayment(), new PayPalPayment()};
            cart.payment = payments[0];
            cart.payment.ProcessPayment();
            cart.payment = payments[1];
            cart.payment.ProcessPayment();
        }
    }
