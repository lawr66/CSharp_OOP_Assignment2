using System;
using System.Collections.Generic;

public class Cart
{
    private List<CartItem> cart = new List<CartItem> {};
    public Payment payment;

    private class CartItem
    {
        public string Name{get; set;}
        public double Price{get;set;}
        public int Quantity{get;set;}

        public CartItem(string name, double price, int quantity)
        {
            this.Name = name;
            this.Price = price;
            this.Quantity = quantity;
        }
    }

    public void AddItem(string name, double price, int quantity)
    {
            this.cart.Add(new CartItem(name,price,quantity));
    }

    public void DeleteItem(int index)
    {
            this.cart.RemoveAt(index);
    }

    public void UpdateItem(int index)
    {
        int q;
       Console.WriteLine("Input the number with which you want to update the quantity of the item (write negative number to decrease).");
       while(1>0)
       {
            q = int.Parse(Console.ReadLine());
            if(this.cart[index].Quantity + q <0)
            {
                Console.WriteLine("Quantity can't be negative, please try another value.");
            }
            else if(this.cart[index].Quantity + q == 0)
            {
                this.cart.RemoveAt(index);
                break;
            }
            else
            {
               this.cart[index].Quantity = cart[index].Quantity + q;
                break;
            }
       }
    }

    public void DisplayTotalCost()
    {
        double total = 0;
        for(int i = 0; i < cart.Count; i++)
        {
            total = total + this.cart[i].Price;
        }
        Console.WriteLine("Total cost of items is: {0}", total);
    }

    public void DisplayCartContent()
    {
        for(int i = 0; i < this.cart.Count; i++)
        {
            Console.WriteLine("{0} piece(s) of {1}",this.cart[i].Quantity,this.cart[i].Name);
        }
    }
}