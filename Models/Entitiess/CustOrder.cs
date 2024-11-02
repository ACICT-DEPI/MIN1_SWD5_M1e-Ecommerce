﻿using System;
using System.Collections.Generic;

namespace EEcomercEE.Models.Entitiess;

public partial class CustOrder
{
    public double OId { get; set; }

    public int CustId { get; set; }

    public virtual Customer Cust { get; set; } = null!;

    public virtual Orderr OIdNavigation { get; set; } = null!;
}
