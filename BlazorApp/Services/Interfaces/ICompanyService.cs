using BlazorApp.Models;

namespace BlazorApp.Services.Interfaces
{
    public interface ICompanyService
    {
        Task AddAsync(Company company);
        Task UpdateAsync(Company company);
        Task DeleteAsync(Company company);
        Task<Company> GetByIdAsync(Guid id);
        Task<List<Company>> FindAll();
    }
}
