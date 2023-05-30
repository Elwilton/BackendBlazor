using System;
using CrudYTB.models;

namespace CrudYTB.Services
{
	public interface ICompanyServices
	{
		Task Add(Company company);

		Task Update(Company company);

        Task Delete(Company company);

		Task<Company> GetBy(Guid id);

		Task<List<Company>> FindAll();
    }
}

