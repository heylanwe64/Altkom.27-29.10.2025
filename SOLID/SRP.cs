namespace SOLID.S
{

    public class Invoice
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public decimal Amount { get; set; }
        // Other invoice-related properties and methods

        // Odpowiedzialność: logika biznesowa faktury
        public decimal CalculateTax()
        {
            return Amount * 0.23m;
        }
    }

    public class InvoiceRepository
    {
        // Odpowiedzialność: zapis do pliku
        public void SaveToFile(Invoice invoice, string path)
        {
            File.WriteAllText(path, $"Invoice {invoice.Id}, Amount: {invoice.Amount}");
        }
    }

    public class EmailService
    {
        // Odpowiedzialność: wysyłanie e-maila
        public void SendEmail(Invoice invoice, string email)
        {
            Console.WriteLine($"Sending invoice {invoice.Id} to {email}");
        }
    }


    /*internal class Invoice
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public decimal Amount { get; set; }
        // Other invoice-related properties and methods

        // Odpowiedzialność: logika biznesowa faktury
        public decimal CalculateTax()
        {
            return Amount * 0.23m;
        }

        // Odpowiedzialność: zapis do pliku
        public void SaveToFile(string path)
        {
            File.WriteAllText(path, $"Invoice {Id}, Amount: {Amount}");
        }

        // Odpowiedzialność: wysyłanie e-maila
        public void SendEmail(string email)
        {
            Console.WriteLine($"Sending invoice {Id} to {email}");
        }
    }*/
}
