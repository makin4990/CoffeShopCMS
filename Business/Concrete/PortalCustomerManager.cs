using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Business.Abstract;
using Business.Results;
using DataAccess.Abstract;
using Entities.Concrete;

namespace Business.Concrete
{
    public class PortalCustomerManager:CustomerManagerBase,IPortalCustomerService
    {
        private readonly IEnumerable<ICustomerVerifyService> _customerVerifyServices;
        public PortalCustomerManager(ICustomerDal customerDal, IEnumerable<ICustomerVerifyService> customerVerifyServices) : base(customerDal)
        {
            _customerVerifyServices = customerVerifyServices;
        }

        public async override Task<IResult> AddAsync(Customer customer)
        {
            var _customerVerifyService =
                _customerVerifyServices.SingleOrDefault(p => p.GetType() == typeof(CustomerVerifyManager));
            if (!_customerVerifyService.IsVerified(customer))
            {
                return new ErrorResult("Customer is not verifid");
            }

            return await base.AddAsync(customer);

        }
    }
}
