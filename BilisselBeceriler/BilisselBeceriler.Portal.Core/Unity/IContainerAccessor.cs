﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Practices.Unity;

namespace BilisselBeceriler.Portal.Core
{
    public interface IContainerAccessor
    {
        IUnityContainer Container { get;  }
    }
}
