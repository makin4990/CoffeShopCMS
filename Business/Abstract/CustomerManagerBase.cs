using System;
using System.Collections.Generic;
using System.Resources;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;
using Business.Results;
using DataAccess.Abstract;
using Entities.Concrete;


namespace Business.Abstract
{
    public abstract class CustomerManagerBase : IPortalCustomerService
    {
        protected readonly ICustomerDal _customerDal;

        protected CustomerManagerBase(ICustomerDal customerDal)
        {
            _customerDal = customerDal;
        }

        public  virtual async Task<IResult> AddAsync(Customer customer)
        {
            await _customerDal.AddAsync(customer);
            return new SuccessResult("Customer Added");
        }

        public async Task<IResult> DeleteAsync(Customer customer)
        {
           await _customerDal.DeleteAsync(customer);
           return new SuccessResult("Customer Deleted");
        }

        public async Task<IDataResult<List<Customer>>> GetAllAsync()
        {
            var result = await _customerDal.GetAllAsync();
            return new SuccessDataResult<List<Customer>>(result,"Customers are listed");
        }

        public async Task<IDataResult<Customer>> GetByIdAsync(int id)
        {
            var result = await _customerDal.GetByIdAsync(id);
            return new SuccessDataResult<Customer>(result, "Customer is listed");
        }

        public async Task<IResult> UpdateAsync(Customer customer)
        {
            await _customerDal.UpdateAsync(customer);
            return new SuccessDataResult<Customer>(customer, "Customer is updated");
        }
    }
}
