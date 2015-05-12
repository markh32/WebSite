﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ninject;
using Ninject.Extensions.Factory;
using OCC.Data;
using OCC.Service.Webhost.DependencyInjection;
using OCC.Service.Webhost.Services;

namespace OCC.Service.Webhost.Tests.Helpers
{
    public static class TestHelper
    {
        public static CodeCampService GetTestService(OCCDB dbContext)
        {
            var kernel = new StandardKernel();
            Bootstrapper.Configure(kernel);
            kernel.Rebind<OCCDB>().ToConstant(dbContext);
            return kernel.Get<CodeCampService>();
        }
    }
}
