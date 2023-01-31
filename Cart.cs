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

    public void DeleteItem()
    {
        string itemName;
        bool veryfier = false;
        while(1>0)
        {
            Console.Write("Introduce the name of the item you want to delete. ");
            itemName = Console.ReadLine();
            for(int i = 0; i < this.cart.Count; i++)
                {
                    if(string.Equals(this.cart[i].Name, itemName, StringComparison.OrdinalIgnoreCase))
                    {
                        this.cart.RemoveAt(i);
                        veryfier = true;
                    }
                }
            if(veryfier == true)
            {
                Console.WriteLine("{0} removed succesfully.",itemName);
                break;
            }
            else
            {
                Console.WriteLine("Couldn't remove specified item ({0}), please check spelling and try again.",itemName);
            }
        }
    }

    public void UpdateItem()
    {
       string itemName;
       int q; 
       int index;
       bool isNumber;

       while(1>0)
       {
            index = -1;
            Console.Write("Input the name of the item you want to update.");
            itemName = Console.ReadLine();
            Console.Write("Input the number with which you want to update the quantity of the item (write negative number to decrease).");
            isNumber = int.TryParse(Console.ReadLine(), out q);
            if(isNumber == true)
            {
                for(int i = 0; i < this.cart.Count; i++)
                {
                    if(string.Equals(this.cart[i].Name, itemName, StringComparison.OrdinalIgnoreCase))
                    {
                        index = i;
                        break;
                    }
                }
                if(index != -1)
                {
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
                else
                {
                    Console.WriteLine("Item not found, couldn't update, please try again.");
                }
            }
            else
            {
                Console.WriteLine("Entered value isn't a number, please try again.");
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