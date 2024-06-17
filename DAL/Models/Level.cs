﻿using System;
using System.Collections.Generic;

namespace DAL.Models;

public partial class Level
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public virtual ICollection<Recipe> Recipes { get; set; } = new List<Recipe>();
}