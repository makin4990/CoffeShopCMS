using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Business.Results;
using Entities.Concrete;

namespace Business.Abstract
{
    public interface IStarbucksCustomerService
    {
        Task<IResult> AddAsync(Customer customer);
        Task<IResult> UpdateAsync(Customer customer);
        Task<IResult> DeleteAsync(Customer customer);
        Task<IDataResult<List<Customer>>> GetAllAsync();
        Task<IDataResult<Customer>> GetByIdAsync(int id);
    }
}
