﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MigrationTest.Entities
{
    public class Blog
    {
        public int BlogId { get; set; }
        public string Url { get; set; }
        public string Name { get; set; }
        public string Author { get; set; }
    }
}
