using Grpc.Net.Client;
using client.Protos;

namespace client.Services;

public class CustomerServiceClient
{
    private readonly CustomerService.CustomerServiceClient _customerServiceClient;

    public CustomerServiceClient(string address)
    {
        var channel = GrpcChannel.ForAddress(address);
        
        _customerServiceClient = new CustomerService.CustomerServiceClient(channel);
    }

    public async Task<Customer> CreateCustomerAsync(Customer customer)
    {
        var response = await _customerServiceClient.CreateCustomerAsync(customer);

        return response;
    }

    public async Task<Customer> UpdateCustomerAsync(Customer customer)
    {
        var response = await _customerServiceClient.UpdateCustomerAsync(customer);

        return response;
    }

    public async Task<CustomerSuccessResponse> DeleteCustomerAsync(Customer customer)
    {
        var response = await _customerServiceClient.DeleteCustomerAsync(customer);

        return response;
    }

    public async Task<Customer> GetCustomerByIdAsync(CustomerByIdRequest customerByIdRequest)
    {
        var response = await _customerServiceClient.GetCustomerByIdAsync(customerByIdRequest);
        
        return response;
    }

    public async Task<IEnumerable<Customer>> GetAllCustomersAsync()
    {
        var response = await _customerServiceClient.GetAllCustomersAsync(new());
        
        return [.. response.Customers];
    }
}
