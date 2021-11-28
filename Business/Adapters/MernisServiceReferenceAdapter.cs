using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Business.Abstract;
using Entities.Concrete;
using MernisServiceReference;

namespace Business.Adapters
{
    public class MernisServiceReferenceAdapter: ICustomerVerifyService
    {
        public bool IsVerified(Customer customer)
        {
            using (KPSPublicSoapClient client = new KPSPublicSoapClient(KPSPublicSoapClient.EndpointConfiguration.KPSPublicSoap))
            {
                return client.TCKimlikNoDogrulaAsync(
                    Convert.ToInt64(customer.NationalityId),
                    customer.FirstName.ToUpper(),
                    customer.LastName.ToUpper(),
                    customer.DateOfBirth.Year).Result.Body.TCKimlikNoDogrulaResult;
            }
            
            
        }
    }
}
