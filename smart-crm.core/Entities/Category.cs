﻿using smart_crm.core.SharedKernel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace smart_crm.core.Entities
{
    public class Category: Entity
    {
        public string Name { get; set; }
        public string Slug { get; set; }
    }
}