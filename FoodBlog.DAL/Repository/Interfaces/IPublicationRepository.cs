using FoodBlog.DAL.Entities;
using FoodBlog.DAL.Repository.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodBlog.DAL.Repository.Interfaces
{
    public interface IPublicationRepository : IRepo<Publication, int>
    {

    }
}
