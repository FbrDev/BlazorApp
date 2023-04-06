using Blazored.LocalStorage;
using BlazorApp.Models;
using System.Text.Json;
using BlazorApp.Services.Interfaces;

namespace BlazorApp.Services
{
    public class CustomerService : ICustomerService
    {
        private readonly ILocalStorageService localStorageService;

        public CustomerService(ILocalStorageService localStorageService)
        {
            this.localStorageService = localStorageService;
        }

        private string customersLocalStorageKey = "customersKey";

        public async Task<List<Customer>> GetCustomersAsync()
        {
            var customersJson = await localStorageService.GetItemAsync<string>(customersLocalStorageKey);

            if (string.IsNullOrEmpty(customersJson))
                return new List<Customer>();

            return JsonSerializer.Deserialize<List<Customer>>(customersJson);
        }

        public async Task SaveCustomers(List<Customer> customers)
        {
            var customersJson = JsonSerializer.Serialize(customers);
            await localStorageService.SetItemAsync(customersLocalStorageKey, customersJson);
        }
    }
}