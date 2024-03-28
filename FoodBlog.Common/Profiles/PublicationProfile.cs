using AutoMapper;
using FoodBlog.Common.DTO;
using FoodBlog.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodBlog.Common.Profiles;

public class PublicationProfile:Profile
{
    public PublicationProfile()
    {
        CreateMap<CreatePublicationDTO, Publication>();
        CreateMap<Publication, PublicationDTO>();
    }
}
