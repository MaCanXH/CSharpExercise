// A big chain of supermarkets sell millions of products. Each of them 
// has a unique number (barcode), producer, name and price. What data 
// structure could we use in order to quickly find all products, which 
// cost between 5 and 10 dollars?

class Q5
{
    static void ans()
    {
        Products batch = new Products();
        batch.Add(2.5f, "12345", "MaxGood", "PopCorn");
        batch.Add(4.8f, "12345U", "PeterGood", "Iphone Case");
        batch.Add(5.8f, "1234K5", "JohnGood", "flash light");
        batch.Add(1.0f, "12D345", "PGGood", "glue");
        batch.Add(6.9f, "123Q45", "KDGood", "Pen");
        batch.Add(7.2f, "12W345", "MaxGood", "Gundam Figure");
        batch.Add(9.2f, "T12345", "FMDGood", "Lotion");
        batch.Add(8.2f, "123U45", "GOODBIY", "Sun Glasses");
        batch.Add(11.7f, "12J345", "KKLand", "Hot Dog");

        batch.GetPriceRange(5, 10);
    }
}

class Products
{
    private SortedDictionary<float, Good> OrderByPrice;
    public Products()
    {
        this.OrderByPrice = new SortedDictionary<float, Good>();
    }
    public void Add(float price, string barcode, string producer, string productName)
    {
        Good newGood = new Good(barcode, producer, productName);
        this.OrderByPrice[price] = newGood;
    }
    public void GetPriceRange(float lowerbound, float upperbound)
    {
        foreach(float price in this.OrderByPrice.Keys)
        {
            if(price >= lowerbound && price <= upperbound)
            {
                this.OrderByPrice[price].GetGood();
                Console.WriteLine("Product Price: " + price);
                Console.WriteLine("-------------------------");
            }
        }
    }
    class Good
    {
        private string barcode;
        private string producer;
        private string productName;

        public Good(string barcode, string producer, string productName)
        {
            this.barcode = barcode;
            this.producer = producer;
            this.productName = productName;
        }
        public void GetGood()
        {
            Console.WriteLine("Barcode: " + this.barcode);
            Console.WriteLine("Product Name: " + this.productName);
            Console.WriteLine("Producer: " + this.producer);
        }
    }

}
