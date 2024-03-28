using AutoMapper;
using FoodBlog.Common.DTO;
using FoodBlog.Common.Exceptions;
using FoodBlog.DAL.Entities;
using FoodBlog.DAL.Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodBlog.BLL.Services
{
    public class PublicationService : IPublicationService
    {
        private readonly IPublicationRepository _repository;
        private readonly IMapper _mapper;
        public PublicationService(IPublicationRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }
        public async Task<bool> CreateAsync(CreatePublicationDTO publicationDTO)
        {
            var data=_mapper.Map<Publication>(publicationDTO);
            return await _repository.AddAsync(data);
        }

        public async Task<bool> DeleteAsync(int id)
        {
            var data= await _repository.GetAsync(id) 
                ?? throw new NotFoundException(id);

            return await _repository.DeleteAsync(data);
        }

        public async Task<List<PublicationDTO>> GetAllAsync()
        {
            var data = await _repository.GetAllAsync();
            return _mapper.Map<List<PublicationDTO>>(data);
        }

        public async Task<PublicationDTO> GetByIdAsync(int id)
        {
            var data = await _repository.GetAsync(id);

            return _mapper.Map<PublicationDTO>(data);
        }

        public async Task<bool> UpdateAsync(CreatePublicationDTO publicationDTO, int Id)
        {
            var data = await _repository.GetAsync(Id) 
                ?? throw new NotFoundException(Id);

            _mapper.Map(publicationDTO, data);  


            return await _repository.UpdateAsync(data);
        }
    }
}
