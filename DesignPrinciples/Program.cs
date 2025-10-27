using DesignPrinciples;

var service = new PaymentService();

var customerId = 1;

service.AddIncome(customerId, 500);
if (service.Charge(customerId, 100))
{
    Console.WriteLine($"Customer {customerId} charged. Actual balance: {service.GetBalance(customerId)}");
}
else
{
    Console.WriteLine($"Customer {customerId} cannot be charged. Actual balance: {service.GetBalance(customerId)}");
}