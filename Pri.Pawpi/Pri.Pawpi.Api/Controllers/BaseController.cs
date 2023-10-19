using Microsoft.AspNetCore.Mvc;
using Pri.Pawpi.Core.Entities;
using Pri.Pawpi.Core.Interfaces.Services;

namespace Pri.Pawpi.Api.Controllers
{
    public abstract class BaseController<T> : ControllerBase where T : BaseEntity
    {
        private readonly IServiceBase<T> _service;

        public BaseController(IServiceBase<T> service) 
        {
            _service = service;
        }

        [HttpDelete("{id}")]
        public virtual async Task<IActionResult> Delete(int id)
        {
            var result = await _service.DeleteAsync(id);

            if (!result.IsSuccess)
                return BadRequest(result.Errors);

            return Ok();
        }
    }
}
