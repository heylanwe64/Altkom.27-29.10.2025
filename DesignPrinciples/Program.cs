using DesignPrinciples;

var service = new PaymentService();
var customerService = new CustomersService();

var customerId = 1;
var customer = customerService.FindById(customerId);


service.AddIncome(customer, 500);
if (service.Charge(customer, 100))
{
    Console.WriteLine($"Customer {customerId} charged. Actual balance: {customer.Account.Balance}");
}
else
{
    Console.WriteLine($"Customer {customerId} cannot be charged. Actual balance: {customer.Account.Balance}");
}