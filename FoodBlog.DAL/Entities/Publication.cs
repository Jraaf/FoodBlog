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
        public int MyProperty { get; set; }
        public string Text { get; set; }=string.Empty;
    }
}
