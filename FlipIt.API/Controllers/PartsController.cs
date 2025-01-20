using FlipIt.API.Interfaces;
using FlipIt.API.Models;
using Microsoft.AspNetCore.Mvc;

namespace FlipIt.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class PartsController : GenericCrudController<Part>
    {
        public PartsController(IAsyncRepository<Part> repository) : base(repository) { }
    }
}
