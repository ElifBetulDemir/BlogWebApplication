﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog.Entities.Abstract;

public abstract class BaseEntity
{
    public int Id { get; set; }
    public bool Status { get; set; }
}
