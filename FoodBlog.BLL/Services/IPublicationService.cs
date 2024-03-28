using FoodBlog.Common.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodBlog.BLL.Services
{
    public interface IPublicationService
    {
        Task<List<PublicationDTO>> GetAllAsync();
        Task<PublicationDTO> GetByIdAsync(int id);
        Task<bool> CreateAsync(CreatePublicationDTO publicationDTO);
        Task<bool> DeleteAsync(int id);
        Task<bool> UpdateAsync(CreatePublicationDTO publicationDTO, int Id);
    }
}
