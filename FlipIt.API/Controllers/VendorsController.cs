using FlipIt.API.Interfaces;
using FlipIt.API.Models;
using Microsoft.AspNetCore.Mvc;

namespace FlipIt.API.Controllers
{
    [ApiController]
    [Route("api/[Controller]")]
    public class VendorsController : GenericCrudController<Vendor>
    {
        public VendorsController(IAsyncRepository<Vendor> repository) : base(repository) { }
    }
}
