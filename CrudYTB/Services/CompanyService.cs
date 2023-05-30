using System;
using CrudYTB.Data;
using CrudYTB.models;
using Microsoft.EntityFrameworkCore;

namespace CrudYTB.Services
{
	public class CompanyService: ICompanyServices
    {
		private readonly AppDBContext dbContext;

		public CompanyService(AppDBContext appDBContext)
		{
			dbContext = appDBContext;
		}

		public async Task Add(Company company)
		{
			await dbContext.AddAsync(company);
			await dbContext.SaveChangesAsync();
		}

        public async Task Update(Company company)
        {
            dbContext.Update(company);
            await dbContext.SaveChangesAsync();
        }

        public async Task Delete(Company company)
        {
            dbContext.Remove(company);
            await dbContext.SaveChangesAsync();
        }

		public async Task <Company> GetBy(Guid id)
		{
			var company = await dbContext.Companies.FirstOrDefaultAsync(c => c.Id == id);

            return company;
		}

        public async Task<List<Company>> FindAll()
        {
            var company = await dbContext.Companies.ToListAsync();

            return company;
        }

    }
}

