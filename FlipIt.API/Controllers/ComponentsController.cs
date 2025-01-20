using FlipIt.API.Interfaces;
using FlipIt.API.Models;
using Microsoft.AspNetCore.Mvc;

namespace FlipIt.API.Controllers
{
    [ApiController]
    [Route("api/[Controller]")]
    public class ComponentsController : GenericCrudController<Component>
    {
        public ComponentsController(IAsyncRepository<Component> repository) : base(repository) { }
    }
}
