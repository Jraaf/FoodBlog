using FoodBlog.DAL.Entities;
using FoodBlog.DAL.Repository.Base;
using FoodBlog.DAL.Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodBlog.DAL.Repository
{
    public class PublicationRepository: Repo<Publication, int>, IPublicationRepository
    {
        public PublicationRepository(ApplicationDBContext context):base(context)
        {
            
        }
    }
}
