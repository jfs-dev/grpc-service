using client.Protos;
using client.Services;

string address = "http://localhost:5046";

var customerServiceClient = new CustomerServiceClient(address);

Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine("Create Customer");
Console.WriteLine("---------------");

var createCustomerPeterParker = new Customer { Name = "Peter Parker", Email = "peter.parker@marvel.com" };
var createCustomerBenParker = new Customer { Name = "Ben Parker", Email = "ben.parker@marvel.com" };
var createCustomerMaryJane = new Customer { Name = "Mary Jane", Email = "mary.jane@marvel.com" };

var createdCustomerPeterParker = await customerServiceClient.CreateCustomerAsync(createCustomerPeterParker);
var createdCustomerBenParker = await customerServiceClient.CreateCustomerAsync(createCustomerBenParker);
var createdCustomerMaryJane = await customerServiceClient.CreateCustomerAsync(createCustomerMaryJane);

Console.ForegroundColor = ConsoleColor.Magenta;
Console.WriteLine($"Customer created - { createdCustomerPeterParker.Id } - { createdCustomerPeterParker.Name } - { createdCustomerPeterParker.Email }");
Console.WriteLine($"Customer created - { createdCustomerBenParker.Id } - { createdCustomerBenParker.Name } - { createdCustomerBenParker.Email }");
Console.WriteLine($"Customer created - { createdCustomerMaryJane.Id } - { createdCustomerMaryJane.Name } - { createdCustomerMaryJane.Email }");
Console.WriteLine("");

Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine("Update Customer");
Console.WriteLine("---------------");

var updateCustomerMaryJane = new Customer { Id = createdCustomerMaryJane.Id, Name = "Mary Jane Watson", Email = createdCustomerMaryJane.Email };
var updatedCustomerMaryJane = await customerServiceClient.UpdateCustomerAsync(updateCustomerMaryJane);

Console.ForegroundColor = ConsoleColor.Magenta;
Console.WriteLine($"Customer updated - { updatedCustomerMaryJane.Id } - { updatedCustomerMaryJane.Name } - { updatedCustomerMaryJane.Email }");
Console.WriteLine("");

Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine("Delete Customer");
Console.WriteLine("---------------");

var deletedCustomerBenParker = await customerServiceClient.DeleteCustomerAsync(createdCustomerBenParker);
if (deletedCustomerBenParker.Success)
{
    Console.ForegroundColor = ConsoleColor.Magenta;
    Console.WriteLine($"Customer deleted - { createdCustomerBenParker.Id } - { createdCustomerBenParker.Name } - { createdCustomerBenParker.Email }");
    Console.WriteLine("");
}

Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine("Get Customer");
Console.WriteLine("------------");
Console.ForegroundColor = ConsoleColor.Magenta;

var customerByIdReturned = await customerServiceClient.GetCustomerByIdAsync(new CustomerByIdRequest { Id = createdCustomerPeterParker.Id });
Console.WriteLine($"Returned customer - { customerByIdReturned.Id } - { customerByIdReturned.Name } - { customerByIdReturned.Email }");
Console.WriteLine("");

Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine("Get All Customers");
Console.WriteLine("-----------------");
Console.ForegroundColor = ConsoleColor.Magenta;

var allReturnedCustomers  = await customerServiceClient.GetAllCustomersAsync();

foreach (var currentCustomer in allReturnedCustomers)
    Console.WriteLine($"{ currentCustomer.Id } - { currentCustomer.Name } - { currentCustomer.Email }");