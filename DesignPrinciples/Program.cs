using DesignPrinciples;

var service = new Class2();

var custmerId = 1;

service.Func2(custmerId, 500);
if (service.Func1(custmerId, 100))
{
    Console.WriteLine($"Customer {custmerId} charged. Actual balace: {service.GetBalance(custmerId)}");
}
else
{
    Console.WriteLine($"Customer {custmerId} cannot be charged. Actual balace: {service.GetBalance(custmerId)}");
}