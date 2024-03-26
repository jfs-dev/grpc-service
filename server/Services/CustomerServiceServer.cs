using Grpc.Core;
using server.Data;
using server.Protos;

namespace server.Services;

public class CustomerServiceServer(AppDbContext dbContext) : CustomerService.CustomerServiceBase
{
    private readonly AppDbContext _dbContext = dbContext;

    public override Task<Customer> CreateCustomer(Customer request, ServerCallContext context)
    {
        _dbContext.Add(request);
        _dbContext.SaveChanges();        
        
        return Task.FromResult(request);
    }

    public override Task<Customer> UpdateCustomer(Customer request, ServerCallContext context)
    {
        var existingCustomer = _dbContext.Customers.FirstOrDefault(x => x.Id == request.Id);

        if (existingCustomer is not null)
        {
            existingCustomer.Name = request.Name;
            existingCustomer.Email = request.Email;

            _dbContext.SaveChanges();
        }
        
        return Task.FromResult(existingCustomer ?? new());
    }

    public override Task<CustomerSuccessResponse> DeleteCustomer(Customer request, ServerCallContext context)
    {
        var response = new CustomerSuccessResponse { Success = false };
        
        var customerToRemove = _dbContext.Customers.FirstOrDefault(x => x.Id == request.Id);
        
        if (customerToRemove is not null)
        {
            _dbContext.Customers.Remove(customerToRemove);
            _dbContext.SaveChanges();

            response.Success = true;
        }
        
        return Task.FromResult(response);
    }

    public override Task<Customer> GetCustomerById(CustomerByIdRequest request, ServerCallContext context)
    {
        var customer = _dbContext.Customers.FirstOrDefault(c => c.Id == request.Id);
        
        return Task.FromResult(customer ?? new());
    }

    public override Task<CustomersResponse> GetAllCustomers(CustomerEmptyRequest request, ServerCallContext context)
    {
        var response = new CustomersResponse();
        
        response.Customers.AddRange([.. _dbContext.Customers]);

        return Task.FromResult(response);
    }
}
