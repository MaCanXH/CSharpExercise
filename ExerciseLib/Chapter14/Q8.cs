class Q8
{
    static void ans()
    {
        MobilePhone.GSM s = new MobilePhone.GSM("Apple");
        Console.WriteLine(s);
    }
}
class MobilePhone
{
    private static GSM nokiaN95 = new GSM("Nokia N95");
    public class GSM
    {
        private string model;
        private string manufacturer;
        private double price;
        private string owner;
        public GSM():this(null)
        {
        }
        public GSM(string model):this(model, null)
        {
        }
        public GSM(string model, string manufacturer): this(model, manufacturer, 0)
        {
        }
        public GSM(string model, string manufacturer, double price):this(model, manufacturer, price, null)
        {
        }
        public GSM(String model, string manufacturer, double price, string owner)
        {
            this.model = model;
            this.manufacturer = manufacturer;
            this.price = price;
            this.owner = owner;
        }
        public static void NokiaInfo()
        {
            Console.WriteLine("model: " + nokiaN95.model);
            Console.WriteLine("manufacturer: " + nokiaN95.manufacturer);
            Console.WriteLine("price: " + nokiaN95.price);
            Console.WriteLine("owner: "+ nokiaN95.owner);
        }
        public override string ToString()
        {
            return "the model is " + this.model;
        }

    }
        
    class Battery
    {
        public enum BatteryType
        {
            Li_Ion, NiMH, NiCd
        }
        private string model;
        private int idle;
        private int hoursTalk;
        public Battery():this(null)
        {
        }
        public Battery(string model):this(model, 0)
        {
        }
        public Battery(string model, int idle):this(model, idle, 0)
        {
        }
        public Battery(string model, int idle, int hoursTalk)
        {
            this.model = model;
            this.idle = idle;
            this.hoursTalk = hoursTalk;
        }
    }
    class Display
    {
        private string size;
        private string color;
        public Display():this(null)
        {
        }
        public Display(string size):this(size, null)
        {
        }
        public Display(string size, string color)
        {
            this.size = size;
            this.color = color;
        }
    }
    class Call
    {
        private string date;
        private string time;
        private string duration;

        public Call(string date, string time, string duration)
        {
            this.date = date;
            this.time = time;
            this.duration = duration;
        }
    }
}
