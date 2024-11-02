﻿using System;
using System.Collections.Generic;

namespace EEcomercEE.entities;

public partial class ProdCategory
{
    public int ProdId { get; set; }

    public int CategoryId { get; set; }

    public virtual ICollection<SuppCategory> SuppCategories { get; set; } = new List<SuppCategory>();
}