using System;

public class PayPalPayment : Payment
{
    public override void ProcessPayment()
    {
        Console.WriteLine("PayPal payment processed.");
    }
}