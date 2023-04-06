using BlazorApp.Models;

namespace BlazorApp.Services.Interfaces
{
    public interface ICustomerService
    {
        Task<List<Customer>> GetCustomersAsync();
        Task SaveCustomers(List<Customer> customers);
    }
}
