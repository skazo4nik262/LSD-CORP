﻿using System;
using System.Collections.Generic;

namespace WebApplication1;

public partial class User
{
    public int Id { get; set; }

    public string Login { get; set; } = null!;

    public string Password { get; set; } = null!;
}
