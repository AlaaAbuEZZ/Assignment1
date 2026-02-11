Console.WriteLine("Please enter the invoice amount:");
//aa
double price = Convert.ToDouble(Console.ReadLine());
double PriceAfterDiscount;

if (price >= 500)
{
    // 20% discount
    PriceAfterDiscount = price - (price * 0.20);
}
else if (price >= 300 && price <= 499)
{
    // 10% discount
    PriceAfterDiscount = price - (price * 0.10);
}
else
{
    // No discount
    PriceAfterDiscount = price;
}

Console.WriteLine("Final price after discount: " + PriceAfterDiscount);


