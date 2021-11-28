using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Business.Abstract;
using Business.Adapters;
using Business.Results;
using DataAccess.Abstract;
using Entities.Concrete;

namespace Business.Concrete
{
    public class StarbucksCustomerManager:CustomerManagerBase, IStarbucksCustomerService
    {
        private readonly IEnumerable<ICustomerVerifyService> _customerVerifiers;

        public StarbucksCustomerManager(ICustomerDal customerDal, IEnumerable<ICustomerVerifyService> customerVerifiers) : base(customerDal)
        {
            _customerVerifiers = customerVerifiers;
        }

        
        public override async Task<IResult> AddAsync(Customer customer)
        {
            var _customerVerifyService = _customerVerifiers.SingleOrDefault(v=> v.GetType()==typeof(MernisServiceReferenceAdapter));
            ;
            if (_customerVerifyService.IsVerified(customer))
            {
                return await base.AddAsync(customer);
            }

            return new ErrorResult("Customer is not  verified");
        }
    }
}
