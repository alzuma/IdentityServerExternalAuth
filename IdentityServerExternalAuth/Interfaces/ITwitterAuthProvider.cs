﻿using IdentityServerExternalAuth.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IdentityServerExternalAuth.Interfaces
{
    public interface ITwitterAuthProvider : IExternalAuthProvider
    {
        Provider Provider { get; }
    }
}
