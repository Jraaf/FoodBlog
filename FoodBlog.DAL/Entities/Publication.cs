﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodBlog.DAL.Entities
{
    public class Publication
    {
        public int Id { get; set; }
        public string Message { get; set; }=string.Empty;
    }
}
