Console.WriteLine("Please enter the invoice amount:");
//aa
double price = Convert.ToDouble(Console.ReadLine());
double Priceafterdiscount;

if (price >= 500)
{
    // 20% discount
    Priceafterdiscount = price - (price * 0.20);
}
else if (price >= 300 && price <= 499)
{
    // 10% discount
    Priceafterdiscount = price - (price * 0.10);
}
else
{
    // No discount
    Priceafterdiscount = price;
}

Console.WriteLine("Final price after discount: " + Priceafterdiscount);


