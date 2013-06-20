﻿using System.Collections.Generic;

namespace Books.Core.Services
{
    public class RootObject
    {
        public string kind { get; set; }
        public int totalItems { get; set; }
        public List<Item> items { get; set; }
    }
}