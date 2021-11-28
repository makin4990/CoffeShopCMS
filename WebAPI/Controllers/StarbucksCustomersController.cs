using System;
using System.Threading.Tasks;
using Business.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StarbucksCustomersController : ControllerBase
    {
        private readonly IStarbucksCustomerService _customerService;

        public StarbucksCustomersController(IStarbucksCustomerService customerService)
        {
            _customerService = customerService ?? throw new ArgumentNullException(nameof(customerService));
        }

        [HttpPost("Add")]
        public async Task<IActionResult> Add(Customer customer)
        {
           var result = await _customerService.AddAsync(customer);
           return result.IsSuccess ? Ok(result) : BadRequest(result);
        }
    }
}
