using FlipIt.API.Interfaces;
using FlipIt.API.Models;
using Microsoft.AspNetCore.Mvc;

namespace FlipIt.API.Controllers
{
    [ApiController]
    [Route("api/[Controller]")]
    public class BuildsController : GenericCrudController<Build>
    {
        public BuildsController(IAsyncRepository<Build> repository) : base(repository) { }
    }
}
