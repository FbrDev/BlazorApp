using BlazorApp.Data;
using BlazorApp.Models;
using BlazorApp.Services.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace BlazorApp.Services
{
    public class CompanyService : ICompanyService
    {
        private readonly AppDbContext _context;

        public CompanyService(AppDbContext context)
        {
            _context = context;
        }

        public async Task AddAsync(Company company)
        {
            await _context.AddAsync(company);
            await _context.SaveChangesAsync();
        }

        public async Task UpdateAsync(Company company)
        {
            _context.Update(company);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteAsync(Company company)
        {
            _context.Remove(company);
            await _context.SaveChangesAsync();
        }

        public async Task<Company> GetByIdAsync(Guid id)
        {
            var company = await _context.Companies.FirstOrDefaultAsync(c => c.Id == id);

            return company;
        }

        public async Task<List<Company>> FindAll()
        {
            var companies = await _context.Companies.ToListAsync();

            return companies;
        }
    }
}
