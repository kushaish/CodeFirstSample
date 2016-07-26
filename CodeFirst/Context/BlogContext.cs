﻿using CodeFirst.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace CodeFirst.Context
{
    public class BlogContext:DbContext
    {
        public DbSet<Blog> Blog { get; set; }
        public DbSet <Post> Post{ get; set; }
    }
}