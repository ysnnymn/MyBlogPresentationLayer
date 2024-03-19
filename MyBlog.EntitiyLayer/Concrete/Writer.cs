﻿using System;
using MyBlog.EntitiyLayer.Abstract;

namespace MyBlog.EntitiyLayer.Concrete
{
	public class Writer: IEntity
    {
        public int WriterId { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string ImageUrl { get; set; }
    }
}

