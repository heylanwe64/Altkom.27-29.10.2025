using DesignPrinciples;

var service = new PaymentService();
var customerService = new CustomersService();

var customerId = 1;
var customer = customerService.FindById(customerId);

var account = customer?.Account;

service.AddIncome(account, 500);
if (service.Charge(account, 100))
{
    Console.WriteLine($"Customer {customerId} charged. Actual balance: {account.Balance}");
}
else
{
    Console.WriteLine($"Customer {customerId} cannot be charged. Actual balance: {account.Balance}");
}