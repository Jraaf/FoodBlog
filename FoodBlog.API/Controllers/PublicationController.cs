using FoodBlog.BLL.Services;
using FoodBlog.Common.DTO;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FoodBlog.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PublicationController : ControllerBase
    {
        private readonly IPublicationService _service;
        public PublicationController(IPublicationService service)
        {
            _service = service;
        }
        [HttpGet("{id}")]
        public async Task<PublicationDTO> Get(int id)
        {
            return await _service.GetByIdAsync(id);
        }
        [HttpGet]
        public async IAsyncEnumerable<List<PublicationDTO>> GetAll()
        {
            yield return await _service.GetAllAsync();
        }
        [HttpPost]
        public async Task<bool> Post(CreatePublicationDTO obj)
        {
            return await _service.CreateAsync(obj);
        }
        [HttpDelete("{id}")]
        public async Task<bool> Delete(int id)
        {
            return await _service.DeleteAsync(id);
        }
        [HttpPut]
        public async Task<bool> Update(CreatePublicationDTO obj,int id)
        {
            return await _service.UpdateAsync(obj, id);
        }
    }
}
