using FlipIt.API.Interfaces;
using FlipIt.API.Models;
using Microsoft.AspNetCore.Mvc;

namespace FlipIt.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class GenericCrudController<TEntity>(IAsyncRepository<TEntity> repository) : ControllerBase
        where TEntity : EntityBase
    {
        [HttpGet("{id}")]
        public async Task<IActionResult> GetAsync([FromRoute] Guid id, CancellationToken cancellationToken)
        {
            var entity = await repository.GetAsync(id, cancellationToken);

            return Ok(entity);
        }

        [HttpPost]
        public async Task<IActionResult> PostAsync([FromBody] TEntity entity, CancellationToken cancellationToken)
        {
            var createdEntity = await repository.AddAsync(entity, cancellationToken);

            return Ok(createdEntity);
        }

        [HttpPut]
        public async Task<IActionResult> UpdateAsync([FromBody] TEntity entity,
            CancellationToken cancellationToken)
        {
            var updatedEntity = await repository.UpdateAsync(entity, cancellationToken);
            return Ok(updatedEntity);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteAsync(
            [FromRoute] Guid id,
            CancellationToken cancellationToken)
        {
            await repository.DeleteAsync(id, cancellationToken);
            return NoContent();
        }
    }
}
