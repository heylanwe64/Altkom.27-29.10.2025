namespace DesignPatterns.Behavioral.ChainOfResponsibility.I
{
    internal class Client
    {
        public static void Execute()
        {
            //IDiscountHandler handler4 = new DiscountHandler("Kierownik sklepu", 1000, 7500);
            IDiscountHandler handler3 = new DiscountHandler("Kierownik sali", 500, 7500);
            //IDiscountHandler handler2 = new DiscountHandler("Kierownik kas", 250, 10000, handler3);
            IDiscountHandler handler1 = new DiscountHandler("Kasjer", 100, 10000, handler3);


            var result = handler1.Discount(150, 12000);
            if (!result)
                Console.WriteLine("Nie można udzielić rabatu");


            result = handler3.Discount(600, 8000);
            if (!result)
                Console.WriteLine("Nie można udzielić rabatu");
        }
    }
}
